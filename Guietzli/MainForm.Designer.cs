/* 
 * Guietzli: Main form visual components init
 * (c) 2017, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/>
 * 
 */
namespace Guietzli
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectOutputFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonAddFiles = new System.Windows.Forms.Button();
			this.buttonSelectOutput = new System.Windows.Forms.Button();
			this.buttonStart = new System.Windows.Forms.Button();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.listBoxInput = new System.Windows.Forms.ListBox();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonRemoveFiles = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxOutputFolder = new System.Windows.Forms.TextBox();
			this.buttonOpenFolder = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.labelPercentQ = new System.Windows.Forms.Label();
			this.trackBarQuality = new System.Windows.Forms.TrackBar();
			this.labelQuality = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png";
			this.openFileDialog.Multiselect = true;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(519, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.addFilesToolStripMenuItem,
									this.removeFilesToolStripMenuItem,
									this.selectOutputFolderToolStripMenuItem,
									this.toolStripSeparator1,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// addFilesToolStripMenuItem
			// 
			this.addFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addFilesToolStripMenuItem.Image")));
			this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
			this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.addFilesToolStripMenuItem.Text = "A&dd files";
			this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.AddFilesToolStripMenuItemClick);
			// 
			// removeFilesToolStripMenuItem
			// 
			this.removeFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeFilesToolStripMenuItem.Image")));
			this.removeFilesToolStripMenuItem.Name = "removeFilesToolStripMenuItem";
			this.removeFilesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.removeFilesToolStripMenuItem.Text = "Remo&ve files";
			this.removeFilesToolStripMenuItem.Click += new System.EventHandler(this.RemoveFilesToolStripMenuItemClick);
			// 
			// selectOutputFolderToolStripMenuItem
			// 
			this.selectOutputFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectOutputFolderToolStripMenuItem.Image")));
			this.selectOutputFolderToolStripMenuItem.Name = "selectOutputFolderToolStripMenuItem";
			this.selectOutputFolderToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.selectOutputFolderToolStripMenuItem.Text = "Select outp&ut folder";
			this.selectOutputFolderToolStripMenuItem.Click += new System.EventHandler(this.SelectOutputFolderToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.checkForUpdateToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// checkForUpdateToolStripMenuItem
			// 
			this.checkForUpdateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkForUpdateToolStripMenuItem.Image")));
			this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
			this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.checkForUpdateToolStripMenuItem.Text = "C&heck for update";
			this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdateToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.aboutToolStripMenuItem.Text = "A&bout";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// buttonAddFiles
			// 
			this.buttonAddFiles.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddFiles.Image")));
			this.buttonAddFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAddFiles.Location = new System.Drawing.Point(3, 3);
			this.buttonAddFiles.Name = "buttonAddFiles";
			this.buttonAddFiles.Size = new System.Drawing.Size(120, 23);
			this.buttonAddFiles.TabIndex = 1;
			this.buttonAddFiles.Text = "Add Files";
			this.buttonAddFiles.UseVisualStyleBackColor = true;
			this.buttonAddFiles.Click += new System.EventHandler(this.ButtonAddFilesClick);
			// 
			// buttonSelectOutput
			// 
			this.buttonSelectOutput.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectOutput.Image")));
			this.buttonSelectOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSelectOutput.Location = new System.Drawing.Point(3, 3);
			this.buttonSelectOutput.Name = "buttonSelectOutput";
			this.buttonSelectOutput.Size = new System.Drawing.Size(120, 23);
			this.buttonSelectOutput.TabIndex = 5;
			this.buttonSelectOutput.Text = "Output Folder";
			this.buttonSelectOutput.UseVisualStyleBackColor = true;
			this.buttonSelectOutput.Click += new System.EventHandler(this.ButtonSelectOutputClick);
			// 
			// buttonStart
			// 
			this.buttonStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonStart.Image")));
			this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonStart.Location = new System.Drawing.Point(255, 3);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(120, 23);
			this.buttonStart.TabIndex = 3;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripProgressBar,
									this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 205);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(519, 22);
			this.statusStrip.TabIndex = 5;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripProgressBar
			// 
			this.toolStripProgressBar.Name = "toolStripProgressBar";
			this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel.Text = "Ready";
			// 
			// listBoxInput
			// 
			this.listBoxInput.AllowDrop = true;
			this.listBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxInput.FormattingEnabled = true;
			this.listBoxInput.HorizontalScrollbar = true;
			this.listBoxInput.Location = new System.Drawing.Point(3, 111);
			this.listBoxInput.Name = "listBoxInput";
			this.listBoxInput.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxInput.Size = new System.Drawing.Size(513, 56);
			this.listBoxInput.TabIndex = 0;
			this.listBoxInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBoxInputDragDrop);
			this.listBoxInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBoxInputDragEnter);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerProgressChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.listBoxInput, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 181);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.buttonAddFiles);
			this.flowLayoutPanel1.Controls.Add(this.buttonRemoveFiles);
			this.flowLayoutPanel1.Controls.Add(this.buttonStart);
			this.flowLayoutPanel1.Controls.Add(this.buttonStop);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(513, 30);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// buttonRemoveFiles
			// 
			this.buttonRemoveFiles.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveFiles.Image")));
			this.buttonRemoveFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonRemoveFiles.Location = new System.Drawing.Point(129, 3);
			this.buttonRemoveFiles.Name = "buttonRemoveFiles";
			this.buttonRemoveFiles.Size = new System.Drawing.Size(120, 23);
			this.buttonRemoveFiles.TabIndex = 2;
			this.buttonRemoveFiles.Text = "Remove Files";
			this.buttonRemoveFiles.UseVisualStyleBackColor = true;
			this.buttonRemoveFiles.Click += new System.EventHandler(this.ButtonRemoveFilesClick);
			// 
			// buttonStop
			// 
			this.buttonStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStop.Image")));
			this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonStop.Location = new System.Drawing.Point(381, 3);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(120, 23);
			this.buttonStop.TabIndex = 4;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Visible = false;
			this.buttonStop.Click += new System.EventHandler(this.ButtonStopClick);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel2.Controls.Add(this.textBoxOutputFolder, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.buttonSelectOutput, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.buttonOpenFolder, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 39);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(513, 30);
			this.tableLayoutPanel2.TabIndex = 8;
			// 
			// textBoxOutputFolder
			// 
			this.textBoxOutputFolder.AllowDrop = true;
			this.textBoxOutputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxOutputFolder.Location = new System.Drawing.Point(133, 3);
			this.textBoxOutputFolder.Name = "textBoxOutputFolder";
			this.textBoxOutputFolder.Size = new System.Drawing.Size(337, 20);
			this.textBoxOutputFolder.TabIndex = 6;
			this.textBoxOutputFolder.DoubleClick += new System.EventHandler(this.TextBoxOutputFolderDoubleClick);
			this.textBoxOutputFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxOutputFolderDragDrop);
			this.textBoxOutputFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxOutputFolderDragEnter);
			// 
			// buttonOpenFolder
			// 
			this.buttonOpenFolder.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFolder.Image")));
			this.buttonOpenFolder.Location = new System.Drawing.Point(480, 3);
			this.buttonOpenFolder.Name = "buttonOpenFolder";
			this.buttonOpenFolder.Size = new System.Drawing.Size(30, 24);
			this.buttonOpenFolder.TabIndex = 7;
			this.buttonOpenFolder.UseVisualStyleBackColor = true;
			this.buttonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolderClick);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel4.Controls.Add(this.labelPercentQ, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.trackBarQuality, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.labelQuality, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 75);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(513, 30);
			this.tableLayoutPanel4.TabIndex = 9;
			// 
			// labelPercentQ
			// 
			this.labelPercentQ.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPercentQ.Location = new System.Drawing.Point(476, 0);
			this.labelPercentQ.Name = "labelPercentQ";
			this.labelPercentQ.Size = new System.Drawing.Size(34, 30);
			this.labelPercentQ.TabIndex = 2;
			this.labelPercentQ.Text = "84";
			this.labelPercentQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// trackBarQuality
			// 
			this.trackBarQuality.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trackBarQuality.Location = new System.Drawing.Point(133, 3);
			this.trackBarQuality.Maximum = 110;
			this.trackBarQuality.Minimum = 84;
			this.trackBarQuality.Name = "trackBarQuality";
			this.trackBarQuality.Size = new System.Drawing.Size(337, 24);
			this.trackBarQuality.TabIndex = 8;
			this.trackBarQuality.Value = 84;
			this.trackBarQuality.Scroll += new System.EventHandler(this.TrackBarQualityScroll);
			// 
			// labelQuality
			// 
			this.labelQuality.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelQuality.Image = ((System.Drawing.Image)(resources.GetObject("labelQuality.Image")));
			this.labelQuality.Location = new System.Drawing.Point(3, 0);
			this.labelQuality.Name = "labelQuality";
			this.labelQuality.Size = new System.Drawing.Size(124, 30);
			this.labelQuality.TabIndex = 1;
			this.labelQuality.Text = "Quality";
			this.labelQuality.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel3.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(133, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(24, 20);
			this.textBox1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Output Folder";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonStop;
			this.ClientSize = new System.Drawing.Size(519, 227);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(535, 265);
			this.Name = "MainForm";
			this.Text = "Guietzli";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem selectOutputFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Label labelQuality;
		private System.Windows.Forms.TrackBar trackBarQuality;
		private System.Windows.Forms.Label labelPercentQ;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TextBox textBoxOutputFolder;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.Button buttonAddFiles;
		private System.Windows.Forms.Button buttonOpenFolder;
		private System.Windows.Forms.Button buttonRemoveFiles;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ListBox listBoxInput;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonSelectOutput;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
