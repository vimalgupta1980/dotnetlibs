using System;

namespace SMB.Tables {
	public class jobtyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}