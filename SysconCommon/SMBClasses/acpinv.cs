using System;

namespace SMB.Tables {
	public class acpinv : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		[SMBFieldName("pchord")]
		[SMBFieldDescription("Order#")]
		public string pchord;

		[SMBFieldName("ctcnum")]
		[SMBFieldDescription("Contract#")]
		public string ctcnum;

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

		[SMBFieldName("invdte")]
		[SMBFieldDescription("Date")]
		public DateTime invdte;

		[SMBFieldName("duedte")]
		[SMBFieldDescription("Due Date")]
		public DateTime duedte;

		[SMBFieldName("refnum")]
		[SMBFieldDescription("Reference#")]
		public string refnum;

		[SMBFieldName("dscdte")]
		[SMBFieldDescription("Disc Date")]
		public DateTime dscdte;

		[SMBFieldName("invtyp")]
		[SMBFieldDescription("Type")]
		public int invtyp;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("payee2")]
		[SMBFieldDescription("2nd Payee")]
		public string payee2;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Discount")]
		public decimal dscavl;

		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		[SMBFieldName("setpay")]
		[SMBFieldDescription("Set to Pay")]
		public decimal setpay;

		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid")]
		public decimal amtpad;

		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Disc/Credit")]
		public decimal dsctkn;

		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		[SMBFieldName("adjust")]
		[SMBFieldDescription("Variance")]
		public decimal adjust;

		[SMBFieldName("freigh")]
		[SMBFieldDescription("Freight")]
		public decimal freigh;

		[SMBFieldName("ttlpad")]
		[SMBFieldDescription("Total Paid")]
		public decimal ttlpad;

		[SMBFieldName("invbal")]
		[SMBFieldDescription("Invoice Balance")]
		public decimal invbal;

		[SMBFieldName("invnet")]
		[SMBFieldDescription("Invoice Net")]
		public decimal invnet;

		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public int actper;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public int lgrrec;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		[SMBFieldName("btcnum")]
		[SMBFieldDescription("Batch#")]
		public int btcnum;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public int hotlst;

		[SMBFieldName("shpnum")]
		[SMBFieldDescription("Shipping#")]
		public string shpnum;

		[SMBFieldName("cmpamt")]
		[SMBFieldDescription("Work Comp")]
		public decimal cmpamt;

		[SMBFieldName("usetax")]
		[SMBFieldDescription("'Use Tax' Rate")]
		public decimal usetax;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}