using System;

namespace SMB.Tables {
	public class pchtyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("PO Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}