using System;

namespace SMB.Tables {
	public class loctax : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("District#")]
		public int recnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("District Name")]
		public string dscrpt;

		[SMBFieldName("resrte")]
		[SMBFieldDescription("Resident Rate")]
		public decimal resrte;

		[SMBFieldName("nonrte")]
		[SMBFieldDescription("Non-Res Rate")]
		public decimal nonrte;

		[SMBFieldName("inctax")]
		[SMBFieldDescription("Tax State")]
		public string inctax;

	}
}