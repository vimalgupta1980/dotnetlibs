using System;

namespace SMB.Tables {
	public class propsl : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public int lckedt;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public int hotlst;

		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edit Date")]
		public DateTime edtdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		[SMBFieldName("colshw")]
		[SMBFieldDescription("Proposal Basis")]
		public int colshw;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}