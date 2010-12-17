using System;

namespace SMB.Tables {
	public class aiafrm : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

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

		[SMBFieldName("retain")]
		[SMBFieldDescription("Primary Ret. Rate")]
		public decimal retain;

		[SMBFieldName("prvbil")]
		[SMBFieldDescription("Net Prev Billings")]
		public decimal prvbil;

		[SMBFieldName("prvret")]
		[SMBFieldDescription("Prev Retention")]
		public decimal prvret;

		[SMBFieldName("maxret")]
		[SMBFieldDescription("Max Retention")]
		public decimal maxret;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("incact")]
		[SMBFieldDescription("Income Account")]
		public int incact;

		[SMBFieldName("incsub")]
		[SMBFieldDescription("Subaccount")]
		public int incsub;

		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public int taxdst;

		[SMBFieldName("schttl")]
		[SMBFieldDescription("Total Scheduled")]
		public decimal schttl;

		[SMBFieldName("chgttl")]
		[SMBFieldDescription("Total Changes")]
		public decimal chgttl;

		[SMBFieldName("conttl")]
		[SMBFieldDescription("Total Contract")]
		public decimal conttl;

		[SMBFieldName("prvttl")]
		[SMBFieldDescription("Total Previous")]
		public decimal prvttl;

		[SMBFieldName("curttl")]
		[SMBFieldDescription("Total Current")]
		public decimal curttl;

		[SMBFieldName("strttl")]
		[SMBFieldDescription("Total Stored")]
		public decimal strttl;

		[SMBFieldName("cmpttl")]
		[SMBFieldDescription("Total Comp")]
		public decimal cmpttl;

		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Complete")]
		public decimal pctcmp;

		[SMBFieldName("balttl")]
		[SMBFieldDescription("Total Balance")]
		public decimal balttl;

		[SMBFieldName("retttl")]
		[SMBFieldDescription("Total Retention")]
		public decimal retttl;

		[SMBFieldName("ttlern")]
		[SMBFieldDescription("Total Earned")]
		public decimal ttlern;

		[SMBFieldName("crtdue")]
		[SMBFieldDescription("Current Due")]
		public decimal crtdue;

		[SMBFieldName("balcon")]
		[SMBFieldDescription("Contract Bal")]
		public decimal balcon;

		[SMBFieldName("subdte")]
		[SMBFieldDescription("Submitted")]
		public DateTime subdte;

		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		[SMBFieldName("matret")]
		[SMBFieldDescription("Material Ret. Rate")]
		public decimal matret;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def 1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def 2")]
		public string usrdf2;

		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Total Taxable")]
		public decimal taxabl;

		[SMBFieldName("nontax")]
		[SMBFieldDescription("Total Non-Tax")]
		public decimal nontax;

		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Amount")]
		public decimal invttl;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("bllbas")]
		[SMBFieldDescription("Billing Basis")]
		public int bllbas;

		[SMBFieldName("erlsrt")]
		[SMBFieldDescription("Earned Less Retention")]
		public decimal erlsrt;

		[SMBFieldName("balfin")]
		[SMBFieldDescription("Balance to Finish")]
		public decimal balfin;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public int lgrrec;

		[SMBFieldName("secrte")]
		[SMBFieldDescription("Secondary Ret. Rate")]
		public decimal secrte;

		[SMBFieldName("prmret")]
		[SMBFieldDescription("Primary Retention")]
		public decimal prmret;

		[SMBFieldName("ttlret")]
		[SMBFieldDescription("Retention Total")]
		public decimal ttlret;

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