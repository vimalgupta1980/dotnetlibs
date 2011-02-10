using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class invbal : smbtable {
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
		/// Quantity Remaining              
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("qtyrmn")]
		[SMBFieldDescription("Quantity Remaining")]
		public decimal qtyrmn;

		/// <summary>
		/// Transaction Date                
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Transaction Date")]
		public DateTime trndte;

		/// <summary>
		/// Transaction Time                
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("trntme")]
		[SMBFieldDescription("Transaction Time")]
		public long trntme;

		/// <summary>
		/// Part Price                      
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Part Price")]
		public decimal prtprc;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Link#                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("lgrref")]
		[SMBFieldDescription("Link#")]
		public long lgrref;

	}
}