using System;

namespace SMB.Tables {
	public class actrec : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("jobnme")]
		[SMBFieldDescription("Job Name")]
		public string jobnme;

		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public int clnnum;

		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

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

		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		[SMBFieldName("achtct")]
		[SMBFieldDescription("Architect")]
		public int achtct;

		[SMBFieldName("lender")]
		[SMBFieldDescription("Lender")]
		public int lender;

		[SMBFieldName("sprvsr")]
		[SMBFieldDescription("Supervisor")]
		public int sprvsr;

		[SMBFieldName("slsemp")]
		[SMBFieldDescription("Salesperson")]
		public int slsemp;

		[SMBFieldName("estemp")]
		[SMBFieldDescription("Estimator")]
		public int estemp;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("lcltax")]
		[SMBFieldDescription("Payroll Locale")]
		public int lcltax;

		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax Dist")]
		public int slstax;

		[SMBFieldName("lgract")]
		[SMBFieldDescription("Income Acct")]
		public int lgract;

		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public int dptmnt;

		[SMBFieldName("dsccnt")]
		[SMBFieldDescription("Disc Rate")]
		public decimal dsccnt;

		[SMBFieldName("finchg")]
		[SMBFieldDescription("Finance %")]
		public decimal finchg;

		[SMBFieldName("retain")]
		[SMBFieldDescription("Retain Rate")]
		public decimal retain;

		[SMBFieldName("cntrct")]
		[SMBFieldDescription("Contract")]
		public decimal cntrct;

		[SMBFieldName("begbal")]
		[SMBFieldDescription("Beg Balance")]
		public decimal begbal;

		[SMBFieldName("endbal")]
		[SMBFieldDescription("End Balance")]
		public decimal endbal;

		[SMBFieldName("biddte")]
		[SMBFieldDescription("Bid Open Date")]
		public DateTime biddte;

		[SMBFieldName("plnrcv")]
		[SMBFieldDescription("Plans Received")]
		public DateTime plnrcv;

		[SMBFieldName("actbid")]
		[SMBFieldDescription("Bid Completed")]
		public DateTime actbid;

		[SMBFieldName("ctcdte")]
		[SMBFieldDescription("Contract Date")]
		public DateTime ctcdte;

		[SMBFieldName("prelen")]
		[SMBFieldDescription("Pre-Lien")]
		public DateTime prelen;

		[SMBFieldName("sttdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime sttdte;

		[SMBFieldName("cmpdte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime cmpdte;

		[SMBFieldName("lenfld")]
		[SMBFieldDescription("Lien Filed")]
		public DateTime lenfld;

		[SMBFieldName("lenrls")]
		[SMBFieldDescription("Lien Released")]
		public DateTime lenrls;

		[SMBFieldName("jobtyp")]
		[SMBFieldDescription("Job Type")]
		public int jobtyp;

		[SMBFieldName("status")]
		[SMBFieldDescription("Job Status")]
		public int status;

		[SMBFieldName("pstwip")]
		[SMBFieldDescription("Post to WIP")]
		public int pstwip;

		[SMBFieldName("crtfid")]
		[SMBFieldDescription("Certified Payroll")]
		public int crtfid;

		[SMBFieldName("connum")]
		[SMBFieldDescription("Contract#")]
		public string connum;

		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("export")]
		[SMBFieldDescription("Export Data")]
		public string export;

		[SMBFieldName("lotclr")]
		[SMBFieldDescription("Color Scheme")]
		public string lotclr;

		[SMBFieldName("lotprm")]
		[SMBFieldDescription("Lot Premium")]
		public decimal lotprm;

		[SMBFieldName("plnprc")]
		[SMBFieldDescription("Est. Sales Price")]
		public decimal plnprc;

		[SMBFieldName("actprc")]
		[SMBFieldDescription("Actual Sales Price")]
		public decimal actprc;

		[SMBFieldName("estdte")]
		[SMBFieldDescription("Est. Closing Date")]
		public DateTime estdte;

		[SMBFieldName("actdte")]
		[SMBFieldDescription("Actual Closing Date")]
		public DateTime actdte;

		[SMBFieldName("lotnum")]
		[SMBFieldDescription("Lot Number")]
		public string lotnum;

		[SMBFieldName("modnme")]
		[SMBFieldDescription("Model Name")]
		public string modnme;

		[SMBFieldName("sqarft")]
		[SMBFieldDescription("Square Feet")]
		public int sqarft;

	}
}