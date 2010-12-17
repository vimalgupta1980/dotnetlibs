using System;

namespace SMB.Tables {
	public class wnddft : smbtable {
		[SMBFieldName("wndnme")]
		[SMBFieldDescription("Screen Name")]
		public string wndnme;

		[SMBFieldName("wndste")]
		[SMBFieldDescription("Window State")]
		public int wndste;

		[SMBFieldName("wndhgt")]
		[SMBFieldDescription("Window Height")]
		public int wndhgt;

		[SMBFieldName("wndwdt")]
		[SMBFieldDescription("Window Width")]
		public int wndwdt;

		[SMBFieldName("wndtop")]
		[SMBFieldDescription("Window Top")]
		public int wndtop;

		[SMBFieldName("wndlft")]
		[SMBFieldDescription("Window Left")]
		public int wndlft;

		[SMBFieldName("wnddft")]
		[SMBFieldDescription("Defaults")]
		public string _wnddft;

		[SMBFieldName("grddft")]
		[SMBFieldDescription("Grid Defaults")]
		public string grddft;

		[SMBFieldName("grdsze")]
		[SMBFieldDescription("Grid Column Sizes")]
		public string grdsze;

		[SMBFieldName("grdlft")]
		[SMBFieldDescription("Grid Left Column")]
		public string grdlft;

		[SMBFieldName("optbtn")]
		[SMBFieldDescription("Option Buttons")]
		public string optbtn;

		[SMBFieldName("chkbox")]
		[SMBFieldDescription("Check Box")]
		public string chkbox;

	}
}