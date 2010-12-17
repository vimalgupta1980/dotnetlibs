using System;

namespace SMB.Tables {
	public class chgtyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("CO Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}