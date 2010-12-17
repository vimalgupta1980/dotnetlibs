using System;

namespace SMB.Tables {
	public class rccpay : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

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

		[SMBFieldName("nxtdte")]
		[SMBFieldDescription("Next Date")]
		public DateTime nxtdte;

		[SMBFieldName("invtyp")]
		[SMBFieldDescription("Type")]
		public int invtyp;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

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

		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		[SMBFieldName("invnet")]
		[SMBFieldDescription("Invoice Net")]
		public decimal invnet;

		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edited Date")]
		public DateTime edtdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		[SMBFieldName("btcnum")]
		[SMBFieldDescription("Batch#")]
		public int btcnum;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public int hotlst;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}