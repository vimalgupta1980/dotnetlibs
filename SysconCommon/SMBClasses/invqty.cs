using System;

namespace SMB.Tables {
	public class invqty : smbtable {
		/// <summary>
		/// Part#                           
		/// </summary>
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Location                        
		/// </summary>
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

		/// <summary>
		/// Quantity on Hand                
		/// </summary>
		[SMBFieldName("qtyohn")]
		[SMBFieldDescription("Quantity on Hand")]
		public decimal qtyohn;

		/// <summary>
		/// Quantity Available              
		/// </summary>
		[SMBFieldName("qtyavl")]
		[SMBFieldDescription("Quantity Available")]
		public decimal qtyavl;

		/// <summary>
		/// Last Stocked Date               
		/// </summary>
		[SMBFieldName("lststk")]
		[SMBFieldDescription("Last Stocked Date")]
		public DateTime lststk;

		/// <summary>
		/// Last Picked Date                
		/// </summary>
		[SMBFieldName("lstpck")]
		[SMBFieldDescription("Last Picked Date")]
		public DateTime lstpck;

		/// <summary>
		/// Last Count Date                 
		/// </summary>
		[SMBFieldName("lstinv")]
		[SMBFieldDescription("Last Count Date")]
		public DateTime lstinv;

		/// <summary>
		/// Beginning Quantity              
		/// </summary>
		[SMBFieldName("begqty")]
		[SMBFieldDescription("Beginning Quantity")]
		public decimal begqty;

		/// <summary>
		/// Min Restock Level               
		/// </summary>
		[SMBFieldName("minstk")]
		[SMBFieldDescription("Min Restock Level")]
		public long minstk;

		/// <summary>
		/// Max Restock Level               
		/// </summary>
		[SMBFieldName("maxstk")]
		[SMBFieldDescription("Max Restock Level")]
		public long maxstk;

	}
}