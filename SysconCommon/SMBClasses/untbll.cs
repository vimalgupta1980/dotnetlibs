using System;

namespace SMB.Tables {
	public class untbll : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("achnum")]
		[SMBFieldDescription("Architect")]
		public int achnum;

		[SMBFieldName("achjob")]
		[SMBFieldDescription("Architect's Job#")]
		public string achjob;

		[SMBFieldName("appnum")]
		[SMBFieldDescription("Application#")]
		public int appnum;

		[SMBFieldName("period")]
		[SMBFieldDescription("Billing Date")]
		public DateTime period;

		[SMBFieldName("subdte")]
		[SMBFieldDescription("Submitted")]
		public DateTime subdte;

		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention Rate")]
		public decimal retain;

		[SMBFieldName("prvbil")]
		[SMBFieldDescription("Net Prev Billings")]
		public decimal prvbil;

		[SMBFieldName("prvret")]
		[SMBFieldDescription("Prev Retention")]
		public decimal prvret;

		[SMBFieldName("incact")]
		[SMBFieldDescription("Income Account")]
		public int incact;

		[SMBFieldName("incsub")]
		[SMBFieldDescription("Subaccount")]
		public int incsub;

		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public int taxdst;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("schttl")]
		[SMBFieldDescription("Scheduled")]
		public decimal schttl;

		[SMBFieldName("chgttl")]
		[SMBFieldDescription("Changes")]
		public decimal chgttl;

		[SMBFieldName("conttl")]
		[SMBFieldDescription("Contract")]
		public decimal conttl;

		[SMBFieldName("prvttl")]
		[SMBFieldDescription("Previous")]
		public decimal prvttl;

		[SMBFieldName("curttl")]
		[SMBFieldDescription("Current")]
		public decimal curttl;

		[SMBFieldName("cmpttl")]
		[SMBFieldDescription("Total")]
		public decimal cmpttl;

		[SMBFieldName("balttl")]
		[SMBFieldDescription("Balance")]
		public decimal balttl;

		[SMBFieldName("retttl")]
		[SMBFieldDescription("Retention")]
		public decimal retttl;

		[SMBFieldName("ttlern")]
		[SMBFieldDescription("Total Earned")]
		public decimal ttlern;

		[SMBFieldName("crtdue")]
		[SMBFieldDescription("Current Due")]
		public decimal crtdue;

		[SMBFieldName("balcon")]
		[SMBFieldDescription("Contract Balance")]
		public decimal balcon;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("erlsrt")]
		[SMBFieldDescription("Earned Less Retention")]
		public decimal erlsrt;

		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable")]
		public decimal taxabl;

		[SMBFieldName("nontax")]
		[SMBFieldDescription("Non-Taxable")]
		public decimal nontax;

		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public decimal lgrrec;

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