using System;

namespace SMB.Tables {
	public class reqtyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Request Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}