using System;

namespace SMB.Tables {
	public class mallst : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Mail List#")]
		public int recnum;

		[SMBFieldName("lstnme")]
		[SMBFieldDescription("List Name")]
		public string lstnme;

	}
}