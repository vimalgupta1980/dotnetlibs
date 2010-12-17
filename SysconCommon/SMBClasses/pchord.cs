using System;

namespace SMB.Tables {
	public class pchord : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("ordnum")]
		[SMBFieldDescription("Order#")]
		public string ordnum;

		[SMBFieldName("orddte")]
		[SMBFieldDescription("Order Date")]
		public DateTime orddte;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("attion")]
		[SMBFieldDescription("Attention")]
		public string attion;

		[SMBFieldName("odrdby")]
		[SMBFieldDescription("Ordered by")]
		public int odrdby;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("eqpmnt")]
		[SMBFieldDescription("Equipment")]
		public int eqpmnt;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("docnum")]
		[SMBFieldDescription("Document #")]
		public string docnum;

		[SMBFieldName("docsrc")]
		[SMBFieldDescription("Source")]
		public int docsrc;

		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public int taxdst;

		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		[SMBFieldName("schdte")]
		[SMBFieldDescription("Scheduled")]
		public DateTime schdte;

		[SMBFieldName("deldte")]
		[SMBFieldDescription("Delivery")]
		public DateTime deldte;

		[SMBFieldName("delvia")]
		[SMBFieldDescription("Via")]
		public string delvia;

		[SMBFieldName("ordtyp")]
		[SMBFieldDescription("PO Type")]
		public int ordtyp;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("rcvdte")]
		[SMBFieldDescription("Received")]
		public decimal rcvdte;

		[SMBFieldName("currnt")]
		[SMBFieldDescription("Current")]
		public decimal currnt;

		[SMBFieldName("cancel")]
		[SMBFieldDescription("Canceled")]
		public decimal cancel;

		[SMBFieldName("subttl")]
		[SMBFieldDescription("Subtotal")]
		public decimal subttl;

		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		[SMBFieldName("pchttl")]
		[SMBFieldDescription("Total")]
		public decimal pchttl;

		[SMBFieldName("pchbal")]
		[SMBFieldDescription("Balance")]
		public decimal pchbal;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public int hotlst;

		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public int lckedt;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task")]
		public decimal tsknum;

		[SMBFieldName("issdat")]
		[SMBFieldDescription("Issued Date")]
		public DateTime issdat;

		[SMBFieldName("issbch")]
		[SMBFieldDescription("Issued Batch#")]
		public int issbch;

	}
}