using System;

namespace SMB.Tables {
	public class assemb : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Assembly#")]
		public int recnum;

		[SMBFieldName("asmnme")]
		[SMBFieldDescription("Description")]
		public string asmnme;

		[SMBFieldName("asmunt")]
		[SMBFieldDescription("Unit")]
		public string asmunt;

		[SMBFieldName("asmfrm")]
		[SMBFieldDescription("Formula")]
		public string asmfrm;

		[SMBFieldName("asmcls")]
		[SMBFieldDescription("Assembly Class")]
		public int asmcls;

		[SMBFieldName("ttlcst")]
		[SMBFieldDescription("Total Cost")]
		public decimal ttlcst;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("lstedt")]
		[SMBFieldDescription("Last Edit")]
		public DateTime lstedt;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("matcst")]
		[SMBFieldDescription("Material Cost")]
		public decimal matcst;

		[SMBFieldName("matmrk")]
		[SMBFieldDescription("Material Markup")]
		public decimal matmrk;

		[SMBFieldName("matsel")]
		[SMBFieldDescription("Material Sell")]
		public decimal matsel;

		[SMBFieldName("labcst")]
		[SMBFieldDescription("Labor Cost")]
		public decimal labcst;

		[SMBFieldName("labmrk")]
		[SMBFieldDescription("Labor Markup")]
		public decimal labmrk;

		[SMBFieldName("labsel")]
		[SMBFieldDescription("Labor Sell")]
		public decimal labsel;

		[SMBFieldName("eqpcst")]
		[SMBFieldDescription("Equipment Cost")]
		public decimal eqpcst;

		[SMBFieldName("eqpmrk")]
		[SMBFieldDescription("Equipment Markup")]
		public decimal eqpmrk;

		[SMBFieldName("eqpsel")]
		[SMBFieldDescription("Equipment Sell")]
		public decimal eqpsel;

		[SMBFieldName("subcst")]
		[SMBFieldDescription("Subcontract Cost")]
		public decimal subcst;

		[SMBFieldName("submrk")]
		[SMBFieldDescription("Subcontract Markup")]
		public decimal submrk;

		[SMBFieldName("subsel")]
		[SMBFieldDescription("Subcontract Sell")]
		public decimal subsel;

		[SMBFieldName("othcst")]
		[SMBFieldDescription("Other Cost")]
		public decimal othcst;

		[SMBFieldName("othmrk")]
		[SMBFieldDescription("Other Markup")]
		public decimal othmrk;

		[SMBFieldName("othsel")]
		[SMBFieldDescription("Other Sell")]
		public decimal othsel;

		[SMBFieldName("tp6cst")]
		[SMBFieldDescription("Cost Type 6 Cost")]
		public decimal tp6cst;

		[SMBFieldName("tp6mrk")]
		[SMBFieldDescription("Cost Type 6 Markup")]
		public decimal tp6mrk;

		[SMBFieldName("tp6sel")]
		[SMBFieldDescription("Cost Type 6 Sell")]
		public decimal tp6sel;

		[SMBFieldName("tp7cst")]
		[SMBFieldDescription("Cost Type 7 Cost")]
		public decimal tp7cst;

		[SMBFieldName("tp7mrk")]
		[SMBFieldDescription("Cost Type 7 Markup")]
		public decimal tp7mrk;

		[SMBFieldName("tp7sel")]
		[SMBFieldDescription("Cost Type 7 Sell")]
		public decimal tp7sel;

		[SMBFieldName("tp8cst")]
		[SMBFieldDescription("Cost Type 8 Cost")]
		public decimal tp8cst;

		[SMBFieldName("tp8mrk")]
		[SMBFieldDescription("Cost Type 8 Markup")]
		public decimal tp8mrk;

		[SMBFieldName("tp8sel")]
		[SMBFieldDescription("Cost Type 8 Sell")]
		public decimal tp8sel;

		[SMBFieldName("tp9cst")]
		[SMBFieldDescription("Cost Type 9 Cost")]
		public decimal tp9cst;

		[SMBFieldName("tp9mrk")]
		[SMBFieldDescription("Cost Type 9 Markup")]
		public decimal tp9mrk;

		[SMBFieldName("tp9sel")]
		[SMBFieldDescription("Cost Type 9 Sell")]
		public decimal tp9sel;

		[SMBFieldName("tvltim")]
		[SMBFieldDescription("Travel Time")]
		public int tvltim;

		[SMBFieldName("tvlcst")]
		[SMBFieldDescription("Travel Cost")]
		public decimal tvlcst;

		[SMBFieldName("tvlmrk")]
		[SMBFieldDescription("Travel Markup")]
		public decimal tvlmrk;

		[SMBFieldName("tvlsel")]
		[SMBFieldDescription("Travel Sell")]
		public decimal tvlsel;

		[SMBFieldName("tchtim")]
		[SMBFieldDescription("Technician Time")]
		public int tchtim;

		[SMBFieldName("tchcst")]
		[SMBFieldDescription("Technician Cost")]
		public decimal tchcst;

		[SMBFieldName("tchmrk")]
		[SMBFieldDescription("Technician Markup")]
		public decimal tchmrk;

		[SMBFieldName("tchsel")]
		[SMBFieldDescription("Technician Sell")]
		public decimal tchsel;

		[SMBFieldName("asttim")]
		[SMBFieldDescription("Assistant Time")]
		public int asttim;

		[SMBFieldName("astcst")]
		[SMBFieldDescription("Assistant Cost")]
		public decimal astcst;

		[SMBFieldName("astmrk")]
		[SMBFieldDescription("Assistant Markup")]
		public decimal astmrk;

		[SMBFieldName("astsel")]
		[SMBFieldDescription("Assistant Sell")]
		public decimal astsel;

		[SMBFieldName("msccst")]
		[SMBFieldDescription("Misc Cost")]
		public decimal msccst;

		[SMBFieldName("mscmrk")]
		[SMBFieldDescription("Misc Markup")]
		public decimal mscmrk;

		[SMBFieldName("mscsel")]
		[SMBFieldDescription("Misc Sell")]
		public decimal mscsel;

		[SMBFieldName("ovhcst")]
		[SMBFieldDescription("Overhead Cost")]
		public decimal ovhcst;

		[SMBFieldName("ovhmrk")]
		[SMBFieldDescription("Overhead Markup")]
		public decimal ovhmrk;

		[SMBFieldName("ovhsel")]
		[SMBFieldDescription("Overhead Sell")]
		public decimal ovhsel;

		[SMBFieldName("prmtim")]
		[SMBFieldDescription("Primary Time")]
		public int prmtim;

		[SMBFieldName("prmcst")]
		[SMBFieldDescription("Primary Cost")]
		public decimal prmcst;

		[SMBFieldName("prmsel")]
		[SMBFieldDescription("Primary Sell")]
		public decimal prmsel;

		[SMBFieldName("addtim")]
		[SMBFieldDescription("Add-on Time")]
		public int addtim;

		[SMBFieldName("addcst")]
		[SMBFieldDescription("Add-on Cost")]
		public decimal addcst;

		[SMBFieldName("addsel")]
		[SMBFieldDescription("Add-on Sell")]
		public decimal addsel;

		[SMBFieldName("cpmsel")]
		[SMBFieldDescription("Primary Contract Sell")]
		public decimal cpmsel;

		[SMBFieldName("cadsel")]
		[SMBFieldDescription("Add on Contract Sell")]
		public decimal cadsel;

		[SMBFieldName("condsc")]
		[SMBFieldDescription("Contract Disc")]
		public decimal condsc;

		[SMBFieldName("pntbok")]
		[SMBFieldDescription("Print in Book")]
		public int pntbok;

		[SMBFieldName("pntprt")]
		[SMBFieldDescription("Print Parts")]
		public int pntprt;

		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable")]
		public int taxabl;

	}
}