using System;

namespace SMB.Tables {
	public class taxdst : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("District#")]
		public int recnum;

		[SMBFieldName("dstnme")]
		[SMBFieldDescription("District Name")]
		public string dstnme;

		[SMBFieldName("entty1")]
		[SMBFieldDescription("Tax Entity 1")]
		public int entty1;

		[SMBFieldName("entty2")]
		[SMBFieldDescription("Tax Entity 2")]
		public int entty2;

		[SMBFieldName("entty3")]
		[SMBFieldDescription("Tax Entity 3")]
		public int entty3;

		[SMBFieldName("entty4")]
		[SMBFieldDescription("Tax Entity 4")]
		public int entty4;

		[SMBFieldName("entty5")]
		[SMBFieldDescription("Tax Entity 5")]
		public int entty5;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}