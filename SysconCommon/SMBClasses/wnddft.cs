using System;

namespace SMB.Tables {
	public class wnddft : smbtable {
		/// <summary>
		/// Screen Name                     
		/// </summary>
		[SMBFieldName("wndnme")]
		[SMBFieldDescription("Screen Name")]
		public string wndnme;

		/// <summary>
		/// Window State                    
		/// </summary>
		[SMBFieldName("wndste")]
		[SMBFieldDescription("Window State")]
		public long wndste;

		/// <summary>
		/// Window Height                   
		/// </summary>
		[SMBFieldName("wndhgt")]
		[SMBFieldDescription("Window Height")]
		public long wndhgt;

		/// <summary>
		/// Window Width                    
		/// </summary>
		[SMBFieldName("wndwdt")]
		[SMBFieldDescription("Window Width")]
		public long wndwdt;

		/// <summary>
		/// Window Top                      
		/// </summary>
		[SMBFieldName("wndtop")]
		[SMBFieldDescription("Window Top")]
		public long wndtop;

		/// <summary>
		/// Window Left                     
		/// </summary>
		[SMBFieldName("wndlft")]
		[SMBFieldDescription("Window Left")]
		public long wndlft;

		/// <summary>
		/// Defaults                        
		/// </summary>
		[SMBFieldName("wnddft")]
		[SMBFieldDescription("Defaults")]
		public string _wnddft;

		/// <summary>
		/// Grid Defaults                   
		/// </summary>
		[SMBFieldName("grddft")]
		[SMBFieldDescription("Grid Defaults")]
		public string grddft;

		/// <summary>
		/// Grid Column Sizes               
		/// </summary>
		[SMBFieldName("grdsze")]
		[SMBFieldDescription("Grid Column Sizes")]
		public string grdsze;

		/// <summary>
		/// Grid Left Column                
		/// </summary>
		[SMBFieldName("grdlft")]
		[SMBFieldDescription("Grid Left Column")]
		public string grdlft;

		/// <summary>
		/// Option Buttons                  
		/// </summary>
		[SMBFieldName("optbtn")]
		[SMBFieldDescription("Option Buttons")]
		public string optbtn;

		/// <summary>
		/// Check Box                       
		/// </summary>
		[SMBFieldName("chkbox")]
		[SMBFieldDescription("Check Box")]
		public string chkbox;

	}
}