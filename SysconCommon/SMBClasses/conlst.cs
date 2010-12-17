using System;

namespace SMB.Tables {
	public class conlst : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Contract#")]
		public int recnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}