using System;

namespace SMB.Tables {
	public class rccrec : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

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
		[SMBFieldDescription("Tax Dist")]
		public int taxdst;

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
		[SMBFieldDescription("Disc Avail")]
		public decimal dscavl;

		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		[SMBFieldName("invttl")]
		[SMBFieldDescription("Total")]
		public decimal invttl;

		[SMBFieldName("invnet")]
		[SMBFieldDescription("Net Due")]
		public decimal invnet;

		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable Total")]
		public decimal taxabl;

		[SMBFieldName("nontax")]
		[SMBFieldDescription("Non-Tax")]
		public decimal nontax;

		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edited Date")]
		public DateTime edtdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public int hotlst;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}