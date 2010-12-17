using System;

namespace SMB.Tables {
	public class reqprp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("reqnum")]
		[SMBFieldDescription("Request#")]
		public string reqnum;

		[SMBFieldName("reqdte")]
		[SMBFieldDescription("Date")]
		public DateTime reqdte;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("attion")]
		[SMBFieldDescription("Attention")]
		public string attion;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Request by")]
		public int empnum;

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

		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		[SMBFieldName("deldte")]
		[SMBFieldDescription("Delivery")]
		public DateTime deldte;

		[SMBFieldName("delvia")]
		[SMBFieldDescription("Via")]
		public string delvia;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("reqtyp")]
		[SMBFieldDescription("Type")]
		public int reqtyp;

		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address1")]
		public string addrs1;

		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
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

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("subttl")]
		[SMBFieldDescription("Subtotal")]
		public decimal subttl;

		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		[SMBFieldName("reqttl")]
		[SMBFieldDescription("Total")]
		public decimal reqttl;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public int hotlst;

		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public int lckedt;

		[SMBFieldName("prcrcv")]
		[SMBFieldDescription("Prices Rec'd")]
		public DateTime prcrcv;

		[SMBFieldName("prcexp")]
		[SMBFieldDescription("Prices Expire")]
		public DateTime prcexp;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}