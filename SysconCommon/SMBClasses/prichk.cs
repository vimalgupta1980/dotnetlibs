using System;

namespace SMB.Tables {
	public class prichk : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		[SMBFieldName("paydsc")]
		[SMBFieldDescription("Payee")]
		public string paydsc;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("lgract")]
		[SMBFieldDescription("Account#")]
		public int lgract;

		[SMBFieldName("dbtamt")]
		[SMBFieldDescription("Debit Amount")]
		public decimal dbtamt;

		[SMBFieldName("crdamt")]
		[SMBFieldDescription("Credit Amount")]
		public decimal crdamt;

		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public int srcnum;

		[SMBFieldName("active")]
		[SMBFieldDescription("Reconciliation In Process")]
		public int active;

	}
}