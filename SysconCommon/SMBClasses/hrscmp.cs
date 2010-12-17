using System;

namespace SMB.Tables {
	public class hrscmp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edit Date")]
		public DateTime edtdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}