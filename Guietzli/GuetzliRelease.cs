/* 
 * Guietzli: GuetzliRelease class
 * (c) 2017, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/>
 * 
 */
using System ;
using System.Net ;
using System.IO ;
using Multipetros.Config ;

namespace Guietzli{
	/// <summary>
	/// Version control and latest release downloader for Guetzli encoder
	/// </summary>
	public class GuetzliRelease	{
		
		private readonly string EXE_NAME = "guetzli.exe" ;
		
		/// <summary>
		/// Empty class contructor
		/// </summary>
		public GuetzliRelease(){ }
		
		public string ExeName{
			get{
				return this.EXE_NAME ;
			}
		}
		
		public enum ReleaseInfo{
			DownloadUrl,
			VersionStr
		}
		
		/// <summary>
		/// Find the latest Guetzli's release URL or version tag.
		/// </summary>
		/// <param name="returnDownloadUrl">True to return download url, false to return version tag only</param>
		/// <returns>Download url (without filename), or version tag (x.y.z)</returns>
		public string GetLatestRelease(ReleaseInfo info){
			//the github.com/usr/project/releases/latest redirects always to the latest release page, which contains the
			//version tag and the download url (partial). Capturing the HTTP Header location we can find these info.
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://github.com/google/guetzli/releases/latest");
			request.AllowAutoRedirect = false;
			HttpWebResponse response ;
			string redirUrl ;
			try {				
				response = (HttpWebResponse)request.GetResponse();				
				redirUrl = response.Headers["Location"];								
				response.Close();
			} catch (Exception) {
				return "" ;
			}
			
			if(info == ReleaseInfo.DownloadUrl)
				return redirUrl.Replace("tag", "download") ;
			
			//split the url, get the last part (wich contains the ver. tag), remove the v from the begin & return the version
			string[] redirUrlParts = redirUrl.Split('/') ;
			string latestVer = redirUrlParts[redirUrlParts.Length - 1] ;
			return latestVer.Substring(1) ;		
		}
		
		/// <summary>
		/// Compares the current downloaded version and the latest available version of Guetzli encoder, 
		/// and determines if there is new and update is needed.
		/// </summary>
		/// <param name="currentVer">Current Version string in major.minor.revison form</param>
		/// <param name="latestVer">Latest Available Version string in major.minor.revison form</param>
		/// <returns>True if newer Guetzli release exist, else fale.</returns>
		public bool NeedUpdate(string currentVer, string latestVer){
			string[] latestVerParts = latestVer.Split('.') ;
			int latestMajor = 0 ;
			int latestMinor = 0 ;
			int latestRevision = 0 ;
			int.TryParse(latestVerParts[0], out latestMajor) ;
			if(latestVerParts.Length > 1){
				int.TryParse(latestVerParts[1], out latestMinor) ;
				if(latestVerParts.Length > 2){
					int.TryParse(latestVerParts[2], out latestRevision) ;
				}
			}
			
			string[] currentVerParts = currentVer.Split('.') ;
			int currentMajor = 0 ;
			int currentMinor = 0 ;
			int currentRevision = 0 ;
			int.TryParse(currentVerParts[0], out currentMajor) ;
			if(currentVerParts.Length > 1){
				int.TryParse(currentVerParts[1], out currentMinor) ;
				if(currentVerParts.Length > 2){
					int.TryParse(currentVerParts[2], out currentRevision) ;
				}
			}
			
			if(latestMajor > currentMajor)
				return true ;
			if(latestMinor > currentMinor)
				return true ;
			if(latestRevision > currentRevision)
				return true ;
			return false ;
		}
		
		/// <summary>
		/// Compares the current downloaded version and the latest available version of Guetzli encoder, and determines if there is
		/// new and update is needed. <em>The latest available will automated retrieved from the github.</em>
		/// </summary>
		/// <param name="currentVer">Current Version string in major.minor.revison form</param>
		/// <returns>True if newer Guetzli release exist, else fale.</returns>
		public bool NeedUpdate(string currentVer){
			return this.NeedUpdate(this.GetLatestRelease(ReleaseInfo.VersionStr), currentVer) ;
		}
		
		/// <summary>
		/// Download the latest Guetzli binary for the proper OS installed architecture. 
		/// The downloaded file will be renamed to guetzli.exe.
		/// </summary>
		public bool DownloadLatestRelease(){
			WebClient client = new WebClient() ;
			string downloadUrl = GetLatestRelease(ReleaseInfo.DownloadUrl) ;
			//if %WINDIR%/SysWOW64 exist that discloses x64 OS installation
			string syswow64 = Path.Combine(Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.System)).ToString(), "SysWOW64") ;
			if(Directory.Exists(syswow64)){
				downloadUrl += "/guetzli_windows_x86-64.exe" ;
			}else{
				downloadUrl += "/guetzli_windows_x86.exe" ;
			}
			try {				
				client.DownloadFile(downloadUrl, "guetzli.exe") ;
				return true ;
			} catch (Exception) {
				return false ;
			}
		}
	}
}
