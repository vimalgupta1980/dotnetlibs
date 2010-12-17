using System;

namespace SMB.Tables {
	public class cortyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Correspondence Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}