using System;

namespace SMB.Tables {
	public class fdrpun : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Bid Item")]
		public int itmnum;

		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		[SMBFieldName("cmptdy")]
		[SMBFieldDescription("Completed Today")]
		public decimal cmptdy;

	}
}