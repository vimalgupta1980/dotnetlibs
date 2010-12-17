using System;

namespace SMB.Tables {
	public class tkflin : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Bid Item#")]
		public int itmnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public int phsnum;

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

		[SMBFieldName("prtdsc")]
		[SMBFieldDescription("Description")]
		public string prtdsc;

		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		[SMBFieldName("linqty")]
		[SMBFieldDescription("Quantity")]
		public decimal linqty;

		[SMBFieldName("linprc")]
		[SMBFieldDescription("Cost")]
		public decimal linprc;

		[SMBFieldName("linlck")]
		[SMBFieldDescription("")]
		public bool linlck;

		[SMBFieldName("qtyfrm")]
		[SMBFieldDescription("Formula")]
		public string qtyfrm;

		[SMBFieldName("extqty")]
		[SMBFieldDescription("Ext Quantity")]
		public decimal extqty;

		[SMBFieldName("extttl")]
		[SMBFieldDescription("Ext Cost")]
		public decimal extttl;

		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public int taxdst;

		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		[SMBFieldName("ovhmrk")]
		[SMBFieldDescription("O/H Rate")]
		public decimal ovhmrk;

		[SMBFieldName("ovhamt")]
		[SMBFieldDescription("Overhead")]
		public decimal ovhamt;

		[SMBFieldName("pftmrk")]
		[SMBFieldDescription("Profit Rate")]
		public decimal pftmrk;

		[SMBFieldName("pftamt")]
		[SMBFieldDescription("Profit")]
		public decimal pftamt;

		[SMBFieldName("bidprc")]
		[SMBFieldDescription("Ext Price")]
		public decimal bidprc;

		[SMBFieldName("prmvnd")]
		[SMBFieldDescription("Vendor")]
		public int prmvnd;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task")]
		public decimal tsknum;

		[SMBFieldName("invloc")]
		[SMBFieldDescription("Inventory Location")]
		public int invloc;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("expnte")]
		[SMBFieldDescription("Export Notes")]
		public string expnte;

	}
}