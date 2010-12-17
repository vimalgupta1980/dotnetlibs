using System;

namespace SMB.Tables {
	public class pmcgln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("estamt")]
		[SMBFieldDescription("Estimated")]
		public decimal estamt;

		[SMBFieldName("ovhmrk")]
		[SMBFieldDescription("O/H Rate")]
		public decimal ovhmrk;

		[SMBFieldName("pftmrk")]
		[SMBFieldDescription("Profit Rate")]
		public decimal pftmrk;

		[SMBFieldName("reqprc")]
		[SMBFieldDescription("Requested")]
		public decimal reqprc;

		[SMBFieldName("aprprc")]
		[SMBFieldDescription("Approved")]
		public decimal aprprc;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}