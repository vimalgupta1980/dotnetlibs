using System;

namespace SMB.Tables {
	public class grplst : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Group#")]
		public int recnum;

		[SMBFieldName("grpnme")]
		[SMBFieldDescription("Group Name")]
		public string grpnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}