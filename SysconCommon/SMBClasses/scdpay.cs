using System;

namespace SMB.Tables {
	public class scdpay : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Second Payee                    
		/// </summary>
		[SMBFieldName("paynme")]
		[SMBFieldDescription("Second Payee")]
		public string paynme;

		/// <summary>
		/// Amount                          
		/// </summary>
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

		/// <summary>
		/// Paid                            
		/// </summary>
		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid")]
		public decimal amtpad;

		/// <summary>
		/// Balance                         
		/// </summary>
		[SMBFieldName("balnce")]
		[SMBFieldDescription("Balance")]
		public decimal balnce;

		/// <summary>
		/// To Pay                          
		/// </summary>
		[SMBFieldName("setpay")]
		[SMBFieldDescription("To Pay")]
		public decimal setpay;

	}
}