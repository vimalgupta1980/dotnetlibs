using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class tmcddd : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Calculation                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("clcnum")]
		[SMBFieldDescription("Calculation")]
		public long clcnum;

		/// <summary>
		/// Amount                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

		/// <summary>
		/// State Wages                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("stewge")]
		[SMBFieldDescription("State Wages")]
		public decimal stewge;

		/// <summary>
		/// State Gross                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("stegrs")]
		[SMBFieldDescription("State Gross")]
		public decimal stegrs;

	}
}