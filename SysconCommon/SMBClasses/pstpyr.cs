using System;

namespace SMB.Tables {
	public class pstpyr : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Posting#                        
		/// </summary>
		[SMBFieldName("pstnum")]
		[SMBFieldDescription("Posting#")]
		public long pstnum;

		/// <summary>
		/// Department                      
		/// </summary>
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Dr Acct                         
		/// </summary>
		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Dr Acct")]
		public long dbtact;

		/// <summary>
		/// Amount                          
		/// </summary>
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

	}
}