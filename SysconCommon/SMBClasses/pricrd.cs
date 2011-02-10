using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class pricrd : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Tran#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Tran#")]
		public string trnnum;

		/// <summary>
		/// Transaction Date                
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Transaction Date")]
		public DateTime trndte;

		/// <summary>
		/// Payee                           
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("paydsc")]
		[SMBFieldDescription("Payee")]
		public string paydsc;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Credit Card Issuer              
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("issuer")]
		[SMBFieldDescription("Credit Card Issuer")]
		public long issuer;

		/// <summary>
		/// Credit Card                     
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("subact")]
		[SMBFieldDescription("Credit Card")]
		public long subact;

		/// <summary>
		/// Debit Amount                    
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("dbtamt")]
		[SMBFieldDescription("Debit Amount")]
		public decimal dbtamt;

		/// <summary>
		/// Credit Amount                   
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("crdamt")]
		[SMBFieldDescription("Credit Amount")]
		public decimal crdamt;

		/// <summary>
		/// Reconciliation In Process       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("active")]
		[SMBFieldDescription("Reconciliation In Process")]
		public long active;

		/// <summary>
		/// Cleared Credit Card Reconcil.   
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("ccrclr")]
		[SMBFieldDescription("Cleared Credit Card Reconcil.")]
		public long ccrclr;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

	}
}