using System;

namespace SMB.Tables {
	public class actpay : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor#")]
		public int recnum;

		[SMBFieldName("vndnme")]
		[SMBFieldDescription("Vendor Name")]
		public string vndnme;

		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		[SMBFieldName("ownnme")]
		[SMBFieldDescription("Owner")]
		public string ownnme;

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

		[SMBFieldName("fedidn")]
		[SMBFieldDescription("Federal Id#")]
		public string fedidn;

		[SMBFieldName("steidn")]
		[SMBFieldDescription("State Id#")]
		public string steidn;

		[SMBFieldName("resnum")]
		[SMBFieldDescription("Resale#")]
		public string resnum;

		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account#")]
		public string actnum;

		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		[SMBFieldName("pagnum")]
		[SMBFieldDescription("Pager#")]
		public string pagnum;

		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell#")]
		public string cllphn;

		[SMBFieldName("homphn")]
		[SMBFieldDescription("Home#")]
		public string homphn;

		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		[SMBFieldName("dscrte")]
		[SMBFieldDescription("Disc Rate")]
		public decimal dscrte;

		[SMBFieldName("lgrdft")]
		[SMBFieldDescription("Ledger Acct")]
		public int lgrdft;

		[SMBFieldName("cdedft")]
		[SMBFieldDescription("Cost Code")]
		public decimal cdedft;

		[SMBFieldName("typdft")]
		[SMBFieldDescription("Cost Type")]
		public int typdft;

		[SMBFieldName("stsdft")]
		[SMBFieldDescription("Invoice Status")]
		public int stsdft;

		[SMBFieldName("wrndft")]
		[SMBFieldDescription("PO Warning")]
		public int wrndft;

		[SMBFieldName("bal199")]
		[SMBFieldDescription("1099 Balance")]
		public decimal bal199;

		[SMBFieldName("ytdact")]
		[SMBFieldDescription("YTD Activity")]
		public decimal ytdact;

		[SMBFieldName("lstact")]
		[SMBFieldDescription("LstYr Activity")]
		public decimal lstact;

		[SMBFieldName("begbal")]
		[SMBFieldDescription("Beg Balance")]
		public decimal begbal;

		[SMBFieldName("endbal")]
		[SMBFieldDescription("End Balance")]
		public decimal endbal;

		[SMBFieldName("vndtyp")]
		[SMBFieldDescription("Vendor Type")]
		public int vndtyp;

		[SMBFieldName("prt199")]
		[SMBFieldDescription("1099 Type")]
		public int prt199;

		[SMBFieldName("minsts")]
		[SMBFieldDescription("Minority")]
		public int minsts;

		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public int taxdst;

		[SMBFieldName("intrnl")]
		[SMBFieldDescription("Internal Vendor")]
		public int intrnl;

		[SMBFieldName("cmprte")]
		[SMBFieldDescription("Comp Rate")]
		public decimal cmprte;

		[SMBFieldName("utxrte")]
		[SMBFieldDescription("'Use Tax' Rate")]
		public decimal utxrte;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Default Hot List")]
		public string hotlst;

		[SMBFieldName("ordtyp")]
		[SMBFieldDescription("Purchase Order Type")]
		public int ordtyp;

		[SMBFieldName("orddsc")]
		[SMBFieldDescription("Description")]
		public string orddsc;

		[SMBFieldName("contyp")]
		[SMBFieldDescription("Subcontract Type")]
		public int contyp;

		[SMBFieldName("condsc")]
		[SMBFieldDescription("Description")]
		public string condsc;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Vendor Notes")]
		public string ntetxt;

		[SMBFieldName("dupchk")]
		[SMBFieldDescription("Allow Duplicate Invoice #")]
		public int dupchk;

		[SMBFieldName("rfptyp")]
		[SMBFieldDescription("RFP Type")]
		public int rfptyp;

		[SMBFieldName("rfpdsc")]
		[SMBFieldDescription("Description")]
		public string rfpdsc;

		[SMBFieldName("sepchk")]
		[SMBFieldDescription("Separate Checks")]
		public int sepchk;

		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

	}
}