using System;

namespace SMB.Tables {
	public class eqptyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Equip Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}