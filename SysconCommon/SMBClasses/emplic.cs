using System;

namespace SMB.Tables {
	public class emplic : smbtable {
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee#")]
		public int empnum;

		[SMBFieldName("typnum")]
		[SMBFieldDescription("License Type")]
		public int typnum;

		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		[SMBFieldName("expdte")]
		[SMBFieldDescription("Exp. Date")]
		public DateTime expdte;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}