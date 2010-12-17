using System;

namespace SMB.Tables {
	public class vndtyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}