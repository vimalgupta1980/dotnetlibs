using System;

namespace SMB.Tables {
	public class trntyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Training Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

	}
}