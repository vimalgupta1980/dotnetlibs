using System;

namespace SMB.Tables {
	public class invout : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public int prtnum;

		[SMBFieldName("trnqty")]
		[SMBFieldDescription("Quantity")]
		public decimal trnqty;

		[SMBFieldName("trndte")]
		[SMBFieldDescription("Transaction Date")]
		public DateTime trndte;

		[SMBFieldName("trntyp")]
		[SMBFieldDescription("Transaction Type")]
		public int trntyp;

		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public int srcnum;

		[SMBFieldName("lgrref")]
		[SMBFieldDescription("Link#")]
		public int lgrref;

	}
}