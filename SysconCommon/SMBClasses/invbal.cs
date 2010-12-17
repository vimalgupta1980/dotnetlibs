using System;

namespace SMB.Tables {
	public class invbal : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public int prtnum;

		[SMBFieldName("trnqty")]
		[SMBFieldDescription("Quantity")]
		public decimal trnqty;

		[SMBFieldName("qtyrmn")]
		[SMBFieldDescription("Quantity Remaining")]
		public decimal qtyrmn;

		[SMBFieldName("trndte")]
		[SMBFieldDescription("Transaction Date")]
		public DateTime trndte;

		[SMBFieldName("trntme")]
		[SMBFieldDescription("Transaction Time")]
		public int trntme;

		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Part Price")]
		public decimal prtprc;

		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public int srcnum;

		[SMBFieldName("lgrref")]
		[SMBFieldDescription("Link#")]
		public int lgrref;

	}
}