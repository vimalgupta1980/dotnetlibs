using System;

namespace SMB.Tables {
	public class unprln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("biditm")]
		[SMBFieldDescription("Bid Item")]
		public int biditm;

		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		[SMBFieldName("numunt")]
		[SMBFieldDescription("Quantity")]
		public decimal numunt;

		[SMBFieldName("cstunt")]
		[SMBFieldDescription("Unit Price")]
		public decimal cstunt;

		[SMBFieldName("ttlcst")]
		[SMBFieldDescription("Total Price")]
		public decimal ttlcst;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("untorg")]
		[SMBFieldDescription("Orig Quantity")]
		public decimal untorg;

		[SMBFieldName("cstorg")]
		[SMBFieldDescription("Orig Unit Price")]
		public decimal cstorg;

		[SMBFieldName("ttlorg")]
		[SMBFieldDescription("Orig Total Price")]
		public decimal ttlorg;

	}
}