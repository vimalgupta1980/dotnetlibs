using System;

namespace SMB.Tables {
	public class srvpmt : smbtable {
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
		[SMBFieldDescription("Amount")]
		public decimal amount;

		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Discount")]
		public decimal dsctkn;

		[SMBFieldName("aplcrd")]
		[SMBFieldDescription("Credit")]
		public decimal aplcrd;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public int lgrrec;

	}
}