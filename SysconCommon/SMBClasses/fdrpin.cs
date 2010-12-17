using System;

namespace SMB.Tables {
	public class fdrpin : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("inctyp")]
		[SMBFieldDescription("Incident Type")]
		public int inctyp;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("inctim")]
		[SMBFieldDescription("Time")]
		public DateTime inctim;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}