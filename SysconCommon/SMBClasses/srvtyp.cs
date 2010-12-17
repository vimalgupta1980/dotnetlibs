using System;

namespace SMB.Tables {
	public class srvtyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Invoice Type#")]
		public int recnum;

		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public int dptmnt;

		[SMBFieldName("cshact")]
		[SMBFieldDescription("Cash Acct")]
		public int cshact;

		[SMBFieldName("taxinc")]
		[SMBFieldDescription("Taxable Income Acct")]
		public int taxinc;

		[SMBFieldName("ntxinc")]
		[SMBFieldDescription("Non-Tax Income Acct")]
		public int ntxinc;

		[SMBFieldName("dscgvn")]
		[SMBFieldDescription("Disc Given Acct")]
		public int dscgvn;

		[SMBFieldName("invexp")]
		[SMBFieldDescription("Cost of Goods Acct")]
		public int invexp;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}