using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class invqty : smbtable {
		/// <summary>
		/// Part#                           
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Location                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

		/// <summary>
		/// Quantity on Hand                
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("qtyohn")]
		[SMBFieldDescription("Quantity on Hand")]
		public decimal qtyohn;

		/// <summary>
		/// Quantity Available              
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("qtyavl")]
		[SMBFieldDescription("Quantity Available")]
		public decimal qtyavl;

		/// <summary>
		/// Last Stocked Date               
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("lststk")]
		[SMBFieldDescription("Last Stocked Date")]
		public DateTime lststk;

		/// <summary>
		/// Last Picked Date                
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("lstpck")]
		[SMBFieldDescription("Last Picked Date")]
		public DateTime lstpck;

		/// <summary>
		/// Last Count Date                 
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("lstinv")]
		[SMBFieldDescription("Last Count Date")]
		public DateTime lstinv;

		/// <summary>
		/// Beginning Quantity              
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("begqty")]
		[SMBFieldDescription("Beginning Quantity")]
		public decimal begqty;

		/// <summary>
		/// Min Restock Level               
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("minstk")]
		[SMBFieldDescription("Min Restock Level")]
		public long minstk;

		/// <summary>
		/// Max Restock Level               
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("maxstk")]
		[SMBFieldDescription("Max Restock Level")]
		public long maxstk;

	}
}