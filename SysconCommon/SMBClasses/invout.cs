using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class invout : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Part#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("trnqty")]
		[SMBFieldDescription("Quantity")]
		public decimal trnqty;

		/// <summary>
		/// Transaction Date                
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Transaction Date")]
		public DateTime trndte;

		/// <summary>
		/// Transaction Type                
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("trntyp")]
		[SMBFieldDescription("Transaction Type")]
		public long trntyp;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Link#                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("lgrref")]
		[SMBFieldDescription("Link#")]
		public long lgrref;

	}
}