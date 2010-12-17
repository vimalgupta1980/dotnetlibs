using System;

namespace SMB.Tables {
	public class vndcrt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("dtercv")]
		[SMBFieldDescription("Received")]
		public DateTime dtercv;

		[SMBFieldName("expdte")]
		[SMBFieldDescription("Expires")]
		public DateTime expdte;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}