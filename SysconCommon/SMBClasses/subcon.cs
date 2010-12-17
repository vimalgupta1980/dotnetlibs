using System;

namespace SMB.Tables {
	public class subcon : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("ctcnum")]
		[SMBFieldDescription("Subcontract#")]
		public string ctcnum;

		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public int divnum;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public int taxdst;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("contyp")]
		[SMBFieldDescription("Type")]
		public int contyp;

		[SMBFieldName("rtnrte")]
		[SMBFieldDescription("Retention")]
		public decimal rtnrte;

		[SMBFieldName("pmtbnd")]
		[SMBFieldDescription("Bid Bond")]
		public decimal pmtbnd;

		[SMBFieldName("prfbnd")]
		[SMBFieldDescription("Perf Bond")]
		public decimal prfbnd;

		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		[SMBFieldName("condte")]
		[SMBFieldDescription("Contract Date")]
		public DateTime condte;

		[SMBFieldName("orgstr")]
		[SMBFieldDescription("Original Start")]
		public DateTime orgstr;

		[SMBFieldName("orgfin")]
		[SMBFieldDescription("Original Finish")]
		public DateTime orgfin;

		[SMBFieldName("strdte")]
		[SMBFieldDescription("Actual Start")]
		public DateTime strdte;

		[SMBFieldName("subcmp")]
		[SMBFieldDescription("Subst Complete")]
		public DateTime subcmp;

		[SMBFieldName("findte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime findte;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public int hotlst;

		[SMBFieldName("paysts")]
		[SMBFieldDescription("Hold Pay")]
		public int paysts;

		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public int lckedt;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("cntttl")]
		[SMBFieldDescription("Original Subcontract Total")]
		public decimal cntttl;

		[SMBFieldName("chgttl")]
		[SMBFieldDescription("Changes Total")]
		public decimal chgttl;

		[SMBFieldName("ctcttl")]
		[SMBFieldDescription("New Subcontract Total")]
		public decimal ctcttl;

		[SMBFieldName("taxttl")]
		[SMBFieldDescription("Sales Tax Total")]
		public decimal taxttl;

		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoiced Total")]
		public decimal invttl;

		[SMBFieldName("balttl")]
		[SMBFieldDescription("Remaining Total")]
		public decimal balttl;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}