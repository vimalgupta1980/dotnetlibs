using System;

namespace SMB.Tables {
	public class scdpay : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("paynme")]
		[SMBFieldDescription("Second Payee")]
		public string paynme;

		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid")]
		public decimal amtpad;

		[SMBFieldName("balnce")]
		[SMBFieldDescription("Balance")]
		public decimal balnce;

		[SMBFieldName("setpay")]
		[SMBFieldDescription("To Pay")]
		public decimal setpay;

	}
}