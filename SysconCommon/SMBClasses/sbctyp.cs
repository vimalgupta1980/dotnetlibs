using System;

namespace SMB.Tables {
	public class sbctyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Subcontract Type#")]
		public int recnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Type Name")]
		public string dscrpt;

	}
}