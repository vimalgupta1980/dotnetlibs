using System;

namespace SMB.Tables {
	public class prplin : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Bid Item")]
		public int itmnum;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("matprp")]
		[SMBFieldDescription("Material")]
		public decimal matprp;

		[SMBFieldName("labprp")]
		[SMBFieldDescription("Labor")]
		public decimal labprp;

		[SMBFieldName("eqpprp")]
		[SMBFieldDescription("Equipment")]
		public decimal eqpprp;

		[SMBFieldName("subprp")]
		[SMBFieldDescription("Subcontract")]
		public decimal subprp;

		[SMBFieldName("othprp")]
		[SMBFieldDescription("Other")]
		public decimal othprp;

		[SMBFieldName("usrcs6")]
		[SMBFieldDescription("User Def Type 6")]
		public decimal usrcs6;

		[SMBFieldName("usrcs7")]
		[SMBFieldDescription("User Def Type 7")]
		public decimal usrcs7;

		[SMBFieldName("usrcs8")]
		[SMBFieldDescription("User Def Type 8")]
		public decimal usrcs8;

		[SMBFieldName("usrcs9")]
		[SMBFieldDescription("User Def Type 9")]
		public decimal usrcs9;

		[SMBFieldName("ttlprp")]
		[SMBFieldDescription("Total")]
		public decimal ttlprp;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("matorg")]
		[SMBFieldDescription("Orig Material")]
		public decimal matorg;

		[SMBFieldName("laborg")]
		[SMBFieldDescription("Orig Labor")]
		public decimal laborg;

		[SMBFieldName("eqporg")]
		[SMBFieldDescription("Orig Equipment")]
		public decimal eqporg;

		[SMBFieldName("suborg")]
		[SMBFieldDescription("Orig Subcontract")]
		public decimal suborg;

		[SMBFieldName("othorg")]
		[SMBFieldDescription("Orig Other")]
		public decimal othorg;

		[SMBFieldName("cs6org")]
		[SMBFieldDescription("Orig User Def Type 6")]
		public decimal cs6org;

		[SMBFieldName("cs7org")]
		[SMBFieldDescription("Orig User Def Type 7")]
		public decimal cs7org;

		[SMBFieldName("cs8org")]
		[SMBFieldDescription("Orig User Def Type 8")]
		public decimal cs8org;

		[SMBFieldName("cs9org")]
		[SMBFieldDescription("Orig User Def Type 9")]
		public decimal cs9org;

		[SMBFieldName("ttlorg")]
		[SMBFieldDescription("Orig Total")]
		public decimal ttlorg;

	}
}