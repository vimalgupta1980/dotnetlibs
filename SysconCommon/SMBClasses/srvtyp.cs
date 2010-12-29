using System;

namespace SMB.Tables {
	public class srvtyp : smbtable {
		/// <summary>
		/// Invoice Type#                   
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Invoice Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		/// <summary>
		/// Department                      
		/// </summary>
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Cash Acct                       
		/// </summary>
		[SMBFieldName("cshact")]
		[SMBFieldDescription("Cash Acct")]
		public long cshact;

		/// <summary>
		/// Taxable Income Acct             
		/// </summary>
		[SMBFieldName("taxinc")]
		[SMBFieldDescription("Taxable Income Acct")]
		public long taxinc;

		/// <summary>
		/// Non-Tax Income Acct             
		/// </summary>
		[SMBFieldName("ntxinc")]
		[SMBFieldDescription("Non-Tax Income Acct")]
		public long ntxinc;

		/// <summary>
		/// Disc Given Acct                 
		/// </summary>
		[SMBFieldName("dscgvn")]
		[SMBFieldDescription("Disc Given Acct")]
		public long dscgvn;

		/// <summary>
		/// Cost of Goods Acct              
		/// </summary>
		[SMBFieldName("invexp")]
		[SMBFieldDescription("Cost of Goods Acct")]
		public long invexp;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}