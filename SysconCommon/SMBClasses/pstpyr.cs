using System;

namespace SMB.Tables {
	public class pstpyr : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("pstnum")]
		[SMBFieldDescription("Posting#")]
		public int pstnum;

		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public int dptmnt;

		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Dr Acct")]
		public int dbtact;

		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

	}
}