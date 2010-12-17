using System;

namespace SMB.Tables {
	public class lonfrm : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("lndnum")]
		[SMBFieldDescription("Lender")]
		public int lndnum;

		[SMBFieldName("lonnum")]
		[SMBFieldDescription("Loan#")]
		public string lonnum;

		[SMBFieldName("crtnum")]
		[SMBFieldDescription("Application#")]
		public int crtnum;

		[SMBFieldName("period")]
		[SMBFieldDescription("Billing Date")]
		public DateTime period;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("subdte")]
		[SMBFieldDescription("Submitted")]
		public DateTime subdte;

		[SMBFieldName("aprdte")]
		[SMBFieldDescription("Approved")]
		public DateTime aprdte;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("schamt")]
		[SMBFieldDescription("Scheduled")]
		public decimal schamt;

		[SMBFieldName("chgdte")]
		[SMBFieldDescription("Changes")]
		public decimal chgdte;

		[SMBFieldName("ctcamt")]
		[SMBFieldDescription("Contract")]
		public decimal ctcamt;

		[SMBFieldName("prvamt")]
		[SMBFieldDescription("Previous")]
		public decimal prvamt;

		[SMBFieldName("curamt")]
		[SMBFieldDescription("Current")]
		public decimal curamt;

		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Complete")]
		public decimal pctcmp;

		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total")]
		public decimal ttlcmp;

		[SMBFieldName("balnce")]
		[SMBFieldDescription("Balance")]
		public decimal balnce;

		[SMBFieldName("tocomp")]
		[SMBFieldDescription("To Complete")]
		public decimal tocomp;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public int hotlst;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("cmbphs")]
		[SMBFieldDescription("Combine Phases")]
		public int cmbphs;

	}
}