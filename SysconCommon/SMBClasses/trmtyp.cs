using System;

namespace SMB.Tables {
	public class trmtyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Transmittal Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}