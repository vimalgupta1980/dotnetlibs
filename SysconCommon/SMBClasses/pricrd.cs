using System;

namespace SMB.Tables {
	public class pricrd : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Tran#                           
		/// </summary>
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Tran#")]
		public string trnnum;

		/// <summary>
		/// Transaction Date                
		/// </summary>
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Transaction Date")]
		public DateTime trndte;

		/// <summary>
		/// Payee                           
		/// </summary>
		[SMBFieldName("paydsc")]
		[SMBFieldDescription("Payee")]
		public string paydsc;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Credit Card Issuer              
		/// </summary>
		[SMBFieldName("issuer")]
		[SMBFieldDescription("Credit Card Issuer")]
		public long issuer;

		/// <summary>
		/// Credit Card                     
		/// </summary>
		[SMBFieldName("subact")]
		[SMBFieldDescription("Credit Card")]
		public long subact;

		/// <summary>
		/// Debit Amount                    
		/// </summary>
		[SMBFieldName("dbtamt")]
		[SMBFieldDescription("Debit Amount")]
		public decimal dbtamt;

		/// <summary>
		/// Credit Amount                   
		/// </summary>
		[SMBFieldName("crdamt")]
		[SMBFieldDescription("Credit Amount")]
		public decimal crdamt;

		/// <summary>
		/// Reconciliation In Process       
		/// </summary>
		[SMBFieldName("active")]
		[SMBFieldDescription("Reconciliation In Process")]
		public long active;

		/// <summary>
		/// Cleared Credit Card Reconcil.   
		/// </summary>
		[SMBFieldName("ccrclr")]
		[SMBFieldDescription("Cleared Credit Card Reconcil.")]
		public long ccrclr;

		/// <summary>
		/// Source                          
		/// </summary>
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

	}
}