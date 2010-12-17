using System;

namespace SMB.Tables {
	public class prdlst : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Product#")]
		public int recnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}