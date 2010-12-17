using System;

namespace SMB.Tables {
	public class tkfprt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Part#")]
		public int recnum;

		[SMBFieldName("prtnme")]
		[SMBFieldDescription("Description")]
		public string prtnme;

		[SMBFieldName("prtunt")]
		[SMBFieldDescription("Unit")]
		public string prtunt;

		[SMBFieldName("binnum")]
		[SMBFieldDescription("Bin#")]
		public string binnum;

		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		[SMBFieldName("msdsnm")]
		[SMBFieldDescription("MSDS#")]
		public string msdsnm;

		[SMBFieldName("mannme")]
		[SMBFieldDescription("Manufacturer")]
		public string mannme;

		[SMBFieldName("mannum")]
		[SMBFieldDescription("Man Part#")]
		public string mannum;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("prttsk")]
		[SMBFieldDescription("Task")]
		public decimal prttsk;

		[SMBFieldName("prtcls")]
		[SMBFieldDescription("Part Class")]
		public int prtcls;

		[SMBFieldName("dftloc")]
		[SMBFieldDescription("Default Location")]
		public int dftloc;

		[SMBFieldName("lstupd")]
		[SMBFieldDescription("Last Updated")]
		public DateTime lstupd;

		[SMBFieldName("reordr")]
		[SMBFieldDescription("Reorder Quantity")]
		public decimal reordr;

		[SMBFieldName("minord")]
		[SMBFieldDescription("Minimum Order Qty")]
		public decimal minord;

		[SMBFieldName("pkgqty")]
		[SMBFieldDescription("Package Quantity")]
		public decimal pkgqty;

		[SMBFieldName("prtwgt")]
		[SMBFieldDescription("Unit Weight")]
		public decimal prtwgt;

		[SMBFieldName("avgcst")]
		[SMBFieldDescription("Average Cost")]
		public decimal avgcst;

		[SMBFieldName("prtcst")]
		[SMBFieldDescription("Default Cost")]
		public decimal prtcst;

		[SMBFieldName("labunt")]
		[SMBFieldDescription("Quantity")]
		public decimal labunt;

		[SMBFieldName("prtbil")]
		[SMBFieldDescription("Billing Amount")]
		public decimal prtbil;

		[SMBFieldName("qtyohn")]
		[SMBFieldDescription("Quantity on Hand")]
		public decimal qtyohn;

		[SMBFieldName("stkitm")]
		[SMBFieldDescription("Stock Item")]
		public int stkitm;

		[SMBFieldName("serinv")]
		[SMBFieldDescription("Serialized Item")]
		public int serinv;

		[SMBFieldName("mrkupr")]
		[SMBFieldDescription("Markup %")]
		public decimal mrkupr;

		[SMBFieldName("labnum")]
		[SMBFieldDescription("Labor Part#")]
		public int labnum;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("srvprt")]
		[SMBFieldDescription("Service Equipment Item")]
		public int srvprt;

		[SMBFieldName("oemdur")]
		[SMBFieldDescription("OEM Warranty Duration")]
		public int oemdur;

		[SMBFieldName("reqivt")]
		[SMBFieldDescription("Required from Inv.")]
		public int reqivt;

	}
}