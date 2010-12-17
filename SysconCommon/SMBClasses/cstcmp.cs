using System;

namespace SMB.Tables {
	public class cstcmp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("lbrbur")]
		[SMBFieldDescription("Labor Burden")]
		public decimal lbrbur;

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