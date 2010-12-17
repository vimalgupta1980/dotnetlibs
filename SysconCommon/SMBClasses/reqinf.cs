using System;

namespace SMB.Tables {
	public class reqinf : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public int clnnum;

		[SMBFieldName("attion")]
		[SMBFieldDescription("Attention")]
		public string attion;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public int divnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("subdte")]
		[SMBFieldDescription("Date")]
		public DateTime subdte;

		[SMBFieldName("rfinum")]
		[SMBFieldDescription("RFI #")]
		public string rfinum;

		[SMBFieldName("rfityp")]
		[SMBFieldDescription("RFI Type")]
		public int rfityp;

		[SMBFieldName("reqdte")]
		[SMBFieldDescription("Required")]
		public DateTime reqdte;

		[SMBFieldName("reqsby")]
		[SMBFieldDescription("Request by")]
		public int reqsby;

		[SMBFieldName("ansrby")]
		[SMBFieldDescription("Answered by")]
		public string ansrby;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("retdte")]
		[SMBFieldDescription("Returned")]
		public DateTime retdte;

		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		[SMBFieldName("reqinf")]
		[SMBFieldDescription("Requested")]
		public string _reqinf;

		[SMBFieldName("retinf")]
		[SMBFieldDescription("Supplied")]
		public string retinf;

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

		[SMBFieldName("possch")]
		[SMBFieldDescription("Schedule Change")]
		public int possch;

		[SMBFieldName("poschg")]
		[SMBFieldDescription("Change Order")]
		public int poschg;

		[SMBFieldName("plnchg")]
		[SMBFieldDescription("Plan Change")]
		public int plnchg;

		[SMBFieldName("usrck1")]
		[SMBFieldDescription("User Def Check 1")]
		public int usrck1;

		[SMBFieldName("usrck2")]
		[SMBFieldDescription("User Def Check 2")]
		public int usrck2;

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

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}