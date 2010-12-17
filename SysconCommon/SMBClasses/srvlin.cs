using System;

namespace SMB.Tables {
	public class srvlin : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("asmnum")]
		[SMBFieldDescription("Assembly#")]
		public int asmnum;

		[SMBFieldName("asmchk")]
		[SMBFieldDescription("")]
		public int asmchk;

		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public int prtnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Price")]
		public decimal prtprc;

		[SMBFieldName("extqty")]
		[SMBFieldDescription("Ext Qty")]
		public decimal extqty;

		[SMBFieldName("extprc")]
		[SMBFieldDescription("Ext Price")]
		public decimal extprc;

		[SMBFieldName("tktnum")]
		[SMBFieldDescription("Ticket#")]
		public string tktnum;

		[SMBFieldName("blldte")]
		[SMBFieldDescription("Billed to Date")]
		public decimal blldte;

		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current")]
		public decimal curbll;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account")]
		public int actnum;

		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public int subact;

		[SMBFieldName("invloc")]
		[SMBFieldDescription("Inv. Location")]
		public int invloc;

		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial Number")]
		public string sernum;

		[SMBFieldName("sitloc")]
		[SMBFieldDescription("Site Location")]
		public string sitloc;

		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public int eqpnum;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("shpnte")]
		[SMBFieldDescription("Shop Notes")]
		public string shpnte;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Owner Notes")]
		public string ntetxt;

	}
}