using System;

namespace SMB.Tables {
	public class dptmnt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Department#")]
		public int recnum;

		[SMBFieldName("dptnme")]
		[SMBFieldDescription("Department Name")]
		public string dptnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}