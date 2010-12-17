using System;

namespace SMB.Tables {
	public class pricrd : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Tran#")]
		public string trnnum;

		[SMBFieldName("trndte")]
		[SMBFieldDescription("Transaction Date")]
		public DateTime trndte;

		[SMBFieldName("paydsc")]
		[SMBFieldDescription("Payee")]
		public string paydsc;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("issuer")]
		[SMBFieldDescription("Credit Card Issuer")]
		public int issuer;

		[SMBFieldName("subact")]
		[SMBFieldDescription("Credit Card")]
		public int subact;

		[SMBFieldName("dbtamt")]
		[SMBFieldDescription("Debit Amount")]
		public decimal dbtamt;

		[SMBFieldName("crdamt")]
		[SMBFieldDescription("Credit Amount")]
		public decimal crdamt;

		[SMBFieldName("active")]
		[SMBFieldDescription("Reconciliation In Process")]
		public int active;

		[SMBFieldName("ccrclr")]
		[SMBFieldDescription("Cleared Credit Card Reconcil.")]
		public int ccrclr;

		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public int srcnum;

	}
}