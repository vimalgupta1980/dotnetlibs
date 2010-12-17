using System;

namespace SMB.Tables {
	public class asmprt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Assembly#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("prtchk")]
		[SMBFieldDescription("")]
		public int prtchk;

		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part")]
		public int prtnum;

		[SMBFieldName("prtnme")]
		[SMBFieldDescription("Part Name")]
		public string prtnme;

		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part #")]
		public string alpnum;

		[SMBFieldName("prtunt")]
		[SMBFieldDescription("Unit")]
		public string prtunt;

		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		[SMBFieldName("prtbil")]
		[SMBFieldDescription("Cost")]
		public decimal prtbil;

		[SMBFieldName("extprc")]
		[SMBFieldDescription("Total")]
		public decimal extprc;

		[SMBFieldName("prtfrm")]
		[SMBFieldDescription("Formula")]
		public string prtfrm;

		[SMBFieldName("prtcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal prtcde;

		[SMBFieldName("prttyp")]
		[SMBFieldDescription("Cost Type")]
		public int prttyp;

		[SMBFieldName("prttsk")]
		[SMBFieldDescription("Task")]
		public decimal prttsk;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}