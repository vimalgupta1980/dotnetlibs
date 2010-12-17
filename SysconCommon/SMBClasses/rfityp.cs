using System;

namespace SMB.Tables {
	public class rfityp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("RFI Type#")]
		public int recnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Type Name")]
		public string dscrpt;

	}
}