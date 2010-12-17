using System;

namespace SMB.Tables {
	public class plnrcd : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("plnnum")]
		[SMBFieldDescription("Plan#")]
		public string plnnum;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public int divnum;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Architect")]
		public int vndnum;

		[SMBFieldName("orgdte")]
		[SMBFieldDescription("Date")]
		public DateTime orgdte;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public int hotlst;

		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public int lckedt;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered Date")]
		public DateTime entdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}