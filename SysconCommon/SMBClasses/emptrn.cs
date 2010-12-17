using System;

namespace SMB.Tables {
	public class emptrn : smbtable {
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee#")]
		public int empnum;

		[SMBFieldName("typnum")]
		[SMBFieldDescription("Training Type")]
		public int typnum;

		[SMBFieldName("lstdte")]
		[SMBFieldDescription("Last Date")]
		public DateTime lstdte;

		[SMBFieldName("nxtdte")]
		[SMBFieldDescription("Next Date")]
		public DateTime nxtdte;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}