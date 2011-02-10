using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class prichk : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
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
		/// Account#                        
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("lgract")]
		[SMBFieldDescription("Account#")]
		public long lgract;

		/// <summary>
		/// Debit Amount                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("dbtamt")]
		[SMBFieldDescription("Debit Amount")]
		public decimal dbtamt;

		/// <summary>
		/// Credit Amount                   
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("crdamt")]
		[SMBFieldDescription("Credit Amount")]
		public decimal crdamt;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Reconciliation In Process       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("active")]
		[SMBFieldDescription("Reconciliation In Process")]
		public long active;

	}
}