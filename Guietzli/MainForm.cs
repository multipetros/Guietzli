/* 
 * Guietzli: Main form
 * (c) 2017, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/>
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics ;
using System.Resources;
using System.Globalization;
using System.IO;
using System.Threading;
using Multipetros.Config;
using System.Net;

namespace Guietzli{
	public partial class MainForm : Form{
		//constant string representing registry setting key names
		private readonly string WND_TOP = "top" ;
		private readonly string WND_LEFT = "left" ;
		private readonly string WND_WIDTH = "width" ;
		private readonly string WND_HEIGHT = "height" ;
		private readonly string ENC_VER = "encver" ;
		private readonly string LAST_DIR = "lastdir" ;
		
		private GuetzliRelease encoder = new GuetzliRelease() ;
		private Stopwatch stopwatch = new Stopwatch() ;
		private Process encodeProc ;
		Ini ini = new Ini("settings.ini", false) ;
		
		private bool stopFlag = false ;
		
		public MainForm(){
			InitializeComponent();
		}
		
		private void LoadSettings(){
			int height ;
			int width ;
			int top ;
			int left ;
			
			int.TryParse(ini[WND_HEIGHT], out height) ;
			int.TryParse(ini[WND_WIDTH], out width) ;
			int.TryParse(ini[WND_TOP], out top) ;
			int.TryParse(ini[WND_LEFT], out left) ;
			
			if(height >= this.MinimumSize.Height)
				this.Height = height ;
			if(width >= this.MinimumSize.Width)
				this.Width = width ;
			if(top > 0)
				this.Top = top ;
			if(left > 0)
				this.Left = left ;
			
			string lastDir = ini[LAST_DIR] ;
			if(lastDir == ""){
				lastDir = Path.GetDirectoryName(Application.ExecutablePath) ;
			}
			textBoxOutputFolder.Text = lastDir ;
		}
		
		private void StoreSettings(){
			ini[WND_HEIGHT] = this.Height.ToString() ;
			ini[WND_WIDTH] = this.Width.ToString() ;
			ini[WND_TOP] = this.Top.ToString() ;
			ini[WND_LEFT] = this.Left.ToString() ;
			ini[LAST_DIR] = this.textBoxOutputFolder.Text ;
			try{
				ini.Save() ;
			}catch(Exception) { }
		}
		
		private void LoadTooltips(){
			ToolTip tip = new ToolTip() ;
			tip.SetToolTip(buttonOpenFolder, "Open output folder in Windows Explorer") ;
			tip.SetToolTip(trackBarQuality, "84 is the standard quality, but you can\nincrease it to 110 of libjpeg-turbo score") ;
			tip.SetToolTip(listBoxInput, "Queue list with image files to JPEG encode with guetzli encoder.\nDrag-n-drop files from Desktop or Explorer here to add them to the list ,\nor you can multiple select inserted items to remove them from the list.") ;
			tip.SetToolTip(textBoxOutputFolder, "Enter the output folder path,\ndrag-n-drop output folder from the Desktop,\nor double clik here to open it in Windows Explorer") ;
			tip.SetToolTip(buttonAddFiles, "Open common dialog for selecting files to add them in the queue list") ;
			tip.SetToolTip(buttonRemoveFiles, "Remove selected files from the list") ;
			tip.SetToolTip(buttonSelectOutput, "Open common dialog to select output folder") ;
			tip.SetToolTip(buttonStart, "Start encoding the files in the queue list") ;
			tip.SetToolTip(buttonStop, "Forced stop the encoding process") ;
		}
		
		private void ListBoxInputDragEnter(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop)){
				e.Effect = DragDropEffects.Copy ;
			}
		}
		
		private void ListBoxInputDragDrop(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop)){
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
				foreach(string file in files){
					if(File.Exists(file) && (file.EndsWith(".png") || file.EndsWith(".jpg") || file.EndsWith(".jpeg"))){
						listBoxInput.Items.Add(file) ;
					}
				}
			}
		}
		
		void TextBoxOutputFolderDragEnter(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop)){
				e.Effect = DragDropEffects.Copy ;
			}
		}
		
		void TextBoxOutputFolderDragDrop(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop)){
				string[] folder = (string[])e.Data.GetData(DataFormats.FileDrop);
				if(Directory.Exists(folder[0])){
					textBoxOutputFolder.Text = folder[0] ;
				}
			}
		}
		
		private void ChangeControlsState(bool state){
			buttonAddFiles.Enabled = state ;
			buttonRemoveFiles.Enabled = state ;
			buttonSelectOutput.Enabled = state ;
			buttonStart.Enabled = state ;
			trackBarQuality.Enabled = state ;
			listBoxInput.AllowDrop = state ;
			textBoxOutputFolder.Enabled = state ;
			menuStrip.Enabled = state ;
			buttonStop.Visible = !state ;
		}
		
		private bool AddFiles(){
			DialogResult filesSelection = openFileDialog.ShowDialog() ;
			if(filesSelection == DialogResult.OK){
				string[] files = openFileDialog.FileNames ;
				foreach(string file in files){
					if(File.Exists(file)){
						listBoxInput.Items.Add(file) ;
					}
				}
				if(listBoxInput.Items.Count > 0){
					return true ;
				}
			}
			return false ;
		}
		
		private void Start(){
			if(!File.Exists(encoder.ExeName)){
				DialogResult result = MessageBox.Show("Do you want to download the last release now?", "Guetzli encoder not found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ;
				if(result == DialogResult.Yes){
					bool dl = encoder.DownloadLatestRelease() ;
					if(dl){
						ini[ENC_VER] = encoder.GetLatestRelease(GuetzliRelease.ReleaseInfo.VersionStr) ;
						DialogResult startResult = MessageBox.Show("Download done!\nContinue to encoding?","Success!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ;
						if(startResult == DialogResult.Yes){
							Start() ;
						}
					}else{
						MessageBox.Show("Download failed!","Failure!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
					}
				}
				return ;
			}

			if(listBoxInput.Items.Count == 0){
				DialogResult result = MessageBox.Show("No images selected for encoding!\nDo you want to select some now?", "No images to encode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;
				if(result == DialogResult.Yes){
					bool added = AddFiles() ;
					if(added){
						Start() ;
					}
				}
				return ;
			}
			
			if(!Directory.Exists(textBoxOutputFolder.Text)){
				if(textBoxOutputFolder.Text.Length == 0){
					DialogResult result = MessageBox.Show("No output folder selected!\nDo you want to use the program's folder as output?", "Folder not found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ;
					if(result == DialogResult.Yes){
						bool selected = SelectOutput() ;
						if(selected){
							Start() ;
						}
					}					
				}else{
					DialogResult result = MessageBox.Show("The entered output folder not found!\nDo you want to select an existed output folder now?", "Folder not found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ;
					if(result == DialogResult.Yes){
						bool selected = SelectOutput() ;
						if(selected){
							Start() ;
						}
					}
				}
				return ;
			}
			
			ChangeControlsState(false) ;
			stopFlag = false ;
			toolStripProgressBar.Maximum = listBoxInput.Items.Count ;
			stopwatch.Start() ;
			backgroundWorker.RunWorkerAsync(trackBarQuality.Value.ToString()) ;
			toolStripProgressBar.Style = ProgressBarStyle.Marquee ;
			toolStripStatusLabel.Text = "Working, please wait..." ;
		}
		
		private void Stop(){
			if(encodeProc != null){
				stopFlag = true ;
				encodeProc.Kill() ;
			}
		}
		
		private void RemoveFiles(){
			if(listBoxInput.Items.Count > 0){
				if(listBoxInput.SelectedItems.Count > 0){
					for(int i=listBoxInput.SelectedItems.Count-1; i>=0 ; i--){
						listBoxInput.Items.Remove(listBoxInput.SelectedItems[i]) ;
					}
				}else{
					MessageBox.Show("There is no file selected to remove!\nPlease select some file(s) first.", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
				}
			}else{
				MessageBox.Show("There is no files in the list!", "Nothing to remove", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
			}
		}
		
		private bool SelectOutput(){
			DialogResult folderSelection = folderBrowserDialog.ShowDialog() ;
			if(folderSelection == DialogResult.OK){
				if(Directory.Exists(folderBrowserDialog.SelectedPath)){
					textBoxOutputFolder.Text = folderBrowserDialog.SelectedPath ;
					return true ;
				}
			}
			return false ;
		}
		
		private void OpenOutputFolder(){
			if(textBoxOutputFolder.Text.Length == 0){
				textBoxOutputFolder.Text = Path.GetDirectoryName(Application.ExecutablePath) ;
				Process.Start("explorer.exe", textBoxOutputFolder.Text) ;
			}else{
				if(Directory.Exists(textBoxOutputFolder.Text)){
					Process.Start("explorer.exe", textBoxOutputFolder.Text) ;
				}else{
					DialogResult result = MessageBox.Show("The entered folder not found!\nDo you want to select an existed folder now?", "Folder not found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ;
					if(result == DialogResult.Yes){
						SelectOutput() ;
					}
				}
			}
		}
		
		void ButtonRemoveFilesClick(object sender, EventArgs e)	{
			RemoveFiles() ;
		}
		
		void ButtonAddFilesClick(object sender, EventArgs e){
			AddFiles() ;
		}
		
		void ButtonSelectOutputClick(object sender, EventArgs e){
			SelectOutput() ;
		}
		
		void ButtonOpenFolderClick(object sender, EventArgs e){
			OpenOutputFolder() ;
		}
		
		void TextBoxOutputFolderDoubleClick(object sender, EventArgs e){
			OpenOutputFolder() ;
		}
		
		void ButtonStartClick(object sender, EventArgs e){
			Start() ;
		}
		
		void TrackBarQualityScroll(object sender, System.EventArgs e){
			labelPercentQ.Text = trackBarQuality.Value.ToString() ;
		}
		
		void BackgroundWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs e){
			int itemPercentage = 1 ;
			encodeProc = new Process() ;
			encodeProc.StartInfo.UseShellExecute = false ;
			encodeProc.StartInfo.FileName = encoder.ExeName ;
			while (listBoxInput.Items.Count > 0 && stopFlag == false) {
				string currentFilePath = listBoxInput.Items[0].ToString() ;
				string currentFileName = Path.GetFileNameWithoutExtension(currentFilePath) ;
				string outputFilePath = Path.Combine(textBoxOutputFolder.Text, currentFileName + ".jpg") ;
				string quality = e.Argument.ToString() ;
				encodeProc.StartInfo.Arguments = "--quality " + quality + " \"" + currentFilePath + "\" \"" + outputFilePath + "\"" ;				
				encodeProc.StartInfo.CreateNoWindow = true ;
				encodeProc.Start() ;
				encodeProc.WaitForExit() ;
				backgroundWorker.ReportProgress(itemPercentage++) ;
				Invoke((MethodInvoker) 
					delegate{
				    	listBoxInput.Items.RemoveAt(0) ;
					});
			}
		}
		
		void BackgroundWorkerRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e){
			ChangeControlsState(true) ;
			stopwatch.Stop() ;
			TimeSpan elpasedMs = stopwatch.Elapsed ;
			toolStripProgressBar.Value = toolStripProgressBar.Minimum ;
			toolStripStatusLabel.Text = "Ready" ;
			DialogResult userAnswer = MessageBox.Show("Job done!\nTime needed " + elpasedMs.Hours.ToString("00") + ":" + elpasedMs.Minutes.ToString("00") + ":" + elpasedMs.Seconds.ToString("00") + "\n\nDo you want to show\noutputed files in Windows Explorer?", "Encoding process ended", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ;
			if(userAnswer == DialogResult.Yes){
				OpenOutputFolder() ;
			}
		}
		
		void ButtonStopClick(object sender, EventArgs e){
			Stop() ;
		}
		
		void BackgroundWorkerProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e){
			toolStripProgressBar.Style = ProgressBarStyle.Blocks ;
			toolStripProgressBar.Value = e.ProgressPercentage ;
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e){
			StoreSettings() ;
		}
		
		void MainFormLoad(object sender, EventArgs e){
			LoadTooltips() ;
			LoadSettings() ;
		}
		
		void CheckForUpdateToolStripMenuItemClick(object sender, EventArgs e){
			string curVer = ini[ENC_VER] ;
			string latestVer = encoder.GetLatestRelease(GuetzliRelease.ReleaseInfo.VersionStr) ;
			bool needUpdate = (curVer == "") ;
			if(!needUpdate){
				needUpdate = encoder.NeedUpdate(curVer, latestVer) ;
			}
			if(needUpdate){
				DialogResult result = MessageBox.Show("A new version of Guetzli encoder is available.\nDo you want to download it?","New Guetzli realease available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;
				if(result == DialogResult.Yes){
					bool done = encoder.DownloadLatestRelease() ;
					if(done){
						MessageBox.Show("Download done!","Success!",MessageBoxButtons.OK, MessageBoxIcon.Information) ;
						ini[ENC_VER] = latestVer ;
						ini.Save() ;
					}else{
						MessageBox.Show("Download failed!","Failure!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;						
					}
				}
			}else{
				MessageBox.Show("You got the latest version of Guetzli encoder", "No new Guetzli release available", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
			}
		}
		
		void AddFilesToolStripMenuItemClick(object sender, EventArgs e){
			AddFiles() ;
		}
		
		void RemoveFilesToolStripMenuItemClick(object sender, EventArgs e){
			RemoveFiles() ;
		}
		
		void SelectOutputFolderToolStripMenuItemClick(object sender, EventArgs e){
			SelectOutput() ;
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			MessageBox.Show("Guietzli v1.1\nA Graphic front-end for Guetzli JPEG Encoder\n\nCopyright (c) 2017-2018, Petros Kyladitis\n<http://www.multipetros.gr/>\n\nThis program is free software distributed under the GNU GPL 3, for license details see at 'license.txt' file, distributed with this program, or see at <http://www.gnu.org/licenses/>.", "About this program", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
		}
	}
}
