using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class scdpay : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Second Payee                    
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("paynme")]
		[SMBFieldDescription("Second Payee")]
		public string paynme;

		/// <summary>
		/// Amount                          
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

		/// <summary>
		/// Paid                            
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid")]
		public decimal amtpad;

		/// <summary>
		/// Balance                         
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("balnce")]
		[SMBFieldDescription("Balance")]
		public decimal balnce;

		/// <summary>
		/// To Pay                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("setpay")]
		[SMBFieldDescription("To Pay")]
		public decimal setpay;

	}
}