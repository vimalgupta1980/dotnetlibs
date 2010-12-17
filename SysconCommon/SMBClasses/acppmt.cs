using System;

namespace SMB.Tables {
	public class acppmt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("chknum")]
		[SMBFieldDescription("Trans#")]
		public string chknum;

		[SMBFieldName("chkdte")]
		[SMBFieldDescription("Date")]
		public DateTime chkdte;

		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public int actper;

		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount Paid")]
		public decimal amount;

		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Discount Taken")]
		public decimal dsctkn;

		[SMBFieldName("aplcrd")]
		[SMBFieldDescription("Credit Taken")]
		public decimal aplcrd;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public int lgrrec;

	}
}