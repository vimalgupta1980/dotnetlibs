using System;

namespace SMB.Tables {
	public class prichk : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
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
		/// Account#                        
		/// </summary>
		[SMBFieldName("lgract")]
		[SMBFieldDescription("Account#")]
		public long lgract;

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
		/// Source                          
		/// </summary>
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Reconciliation In Process       
		/// </summary>
		[SMBFieldName("active")]
		[SMBFieldDescription("Reconciliation In Process")]
		public long active;

	}
}