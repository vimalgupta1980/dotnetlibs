using System;

namespace SMB.Tables {
	public class msctbl : smbtable {
		[SMBFieldName("dtanme")]
		[SMBFieldDescription("Data Name")]
		public string dtanme;

		[SMBFieldName("dtalin")]
		[SMBFieldDescription("Line Data")]
		public string dtalin;

	}
}