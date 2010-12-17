using System;

namespace SMB.Tables {
	public class clntyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}