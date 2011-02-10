using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class wnddft : smbtable {
		/// <summary>
		/// Screen Name                     
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("wndnme")]
		[SMBFieldDescription("Screen Name")]
		public string wndnme;

		/// <summary>
		/// Window State                    
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("wndste")]
		[SMBFieldDescription("Window State")]
		public long wndste;

		/// <summary>
		/// Window Height                   
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("wndhgt")]
		[SMBFieldDescription("Window Height")]
		public long wndhgt;

		/// <summary>
		/// Window Width                    
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("wndwdt")]
		[SMBFieldDescription("Window Width")]
		public long wndwdt;

		/// <summary>
		/// Window Top                      
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("wndtop")]
		[SMBFieldDescription("Window Top")]
		public long wndtop;

		/// <summary>
		/// Window Left                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("wndlft")]
		[SMBFieldDescription("Window Left")]
		public long wndlft;

		/// <summary>
		/// Defaults                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("wnddft")]
		[SMBFieldDescription("Defaults")]
		public string _wnddft;

		/// <summary>
		/// Grid Defaults                   
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("grddft")]
		[SMBFieldDescription("Grid Defaults")]
		public string grddft;

		/// <summary>
		/// Grid Column Sizes               
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("grdsze")]
		[SMBFieldDescription("Grid Column Sizes")]
		public string grdsze;

		/// <summary>
		/// Grid Left Column                
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("grdlft")]
		[SMBFieldDescription("Grid Left Column")]
		public string grdlft;

		/// <summary>
		/// Option Buttons                  
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("optbtn")]
		[SMBFieldDescription("Option Buttons")]
		public string optbtn;

		/// <summary>
		/// Check Box                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("chkbox")]
		[SMBFieldDescription("Check Box")]
		public string chkbox;

	}
}