using System;

namespace SMB.Tables {
	public class biditm : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Item#")]
		public int itmnum;

		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		[SMBFieldName("itmnme")]
		[SMBFieldDescription("Description")]
		public string itmnme;

		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		[SMBFieldName("bidqty")]
		[SMBFieldDescription("Quantity")]
		public decimal bidqty;

		[SMBFieldName("itmtyp")]
		[SMBFieldDescription("Item Type")]
		public int itmtyp;

		[SMBFieldName("ovrhed")]
		[SMBFieldDescription("Overhead")]
		public decimal ovrhed;

		[SMBFieldName("profit")]
		[SMBFieldDescription("Profit")]
		public decimal profit;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}