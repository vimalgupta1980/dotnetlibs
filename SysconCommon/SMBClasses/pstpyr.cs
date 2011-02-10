using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class pstpyr : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Posting#                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("pstnum")]
		[SMBFieldDescription("Posting#")]
		public long pstnum;

		/// <summary>
		/// Department                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Dr Acct                         
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Dr Acct")]
		public long dbtact;

		/// <summary>
		/// Amount                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

	}
}