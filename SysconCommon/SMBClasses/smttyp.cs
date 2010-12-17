using System;

namespace SMB.Tables {
	public class smttyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Submittal Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}