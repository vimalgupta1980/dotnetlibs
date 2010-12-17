using System;

namespace SMB.Tables {
	public class lictyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("License#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("License Type")]
		public string typnme;

	}
}