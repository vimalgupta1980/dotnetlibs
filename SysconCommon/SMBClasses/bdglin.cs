using System;

namespace SMB.Tables {
	public class bdglin : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("hrsbdg")]
		[SMBFieldDescription("Hours")]
		public decimal hrsbdg;

		[SMBFieldName("matbdg")]
		[SMBFieldDescription("Material")]
		public decimal matbdg;

		[SMBFieldName("labbdg")]
		[SMBFieldDescription("Labor")]
		public decimal labbdg;

		[SMBFieldName("eqpbdg")]
		[SMBFieldDescription("Equipment")]
		public decimal eqpbdg;

		[SMBFieldName("subbdg")]
		[SMBFieldDescription("Subcontract")]
		public decimal subbdg;

		[SMBFieldName("othbdg")]
		[SMBFieldDescription("Other")]
		public decimal othbdg;

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

		[SMBFieldName("ttlbdg")]
		[SMBFieldDescription("Total")]
		public decimal ttlbdg;

		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		[SMBFieldName("estunt")]
		[SMBFieldDescription("Quantity")]
		public decimal estunt;

		[SMBFieldName("untcst")]
		[SMBFieldDescription("Unit Cost")]
		public decimal untcst;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("hrsorg")]
		[SMBFieldDescription("Orig Hours")]
		public decimal hrsorg;

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

		[SMBFieldName("euntor")]
		[SMBFieldDescription("Orig Quantity")]
		public decimal euntor;

		[SMBFieldName("ucstor")]
		[SMBFieldDescription("Org Unit Cost")]
		public decimal ucstor;

	}
}