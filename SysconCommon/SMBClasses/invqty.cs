using System;

namespace SMB.Tables {
	public class invqty : smbtable {
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public int prtnum;

		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public int locnum;

		[SMBFieldName("qtyohn")]
		[SMBFieldDescription("Quantity on Hand")]
		public decimal qtyohn;

		[SMBFieldName("qtyavl")]
		[SMBFieldDescription("Quantity Available")]
		public decimal qtyavl;

		[SMBFieldName("lststk")]
		[SMBFieldDescription("Last Stocked Date")]
		public DateTime lststk;

		[SMBFieldName("lstpck")]
		[SMBFieldDescription("Last Picked Date")]
		public DateTime lstpck;

		[SMBFieldName("lstinv")]
		[SMBFieldDescription("Last Count Date")]
		public DateTime lstinv;

		[SMBFieldName("begqty")]
		[SMBFieldDescription("Beginning Quantity")]
		public decimal begqty;

		[SMBFieldName("minstk")]
		[SMBFieldDescription("Min Restock Level")]
		public int minstk;

		[SMBFieldName("maxstk")]
		[SMBFieldDescription("Max Restock Level")]
		public int maxstk;

	}
}