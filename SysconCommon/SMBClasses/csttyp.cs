using System;

namespace SMB.Tables {
	public class csttyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Cost Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

	}
}