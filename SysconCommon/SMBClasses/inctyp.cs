using System;

namespace SMB.Tables {
	public class inctyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Type#")]
		public int recnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Type Name")]
		public string dscrpt;

	}
}