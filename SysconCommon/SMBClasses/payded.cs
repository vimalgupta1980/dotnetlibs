using System;

namespace SMB.Tables {
	public class payded : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Calculation#")]
		public int recnum;

		[SMBFieldName("clcnme")]
		[SMBFieldDescription("Description")]
		public string clcnme;

		[SMBFieldName("dftrte")]
		[SMBFieldDescription("Default Rate")]
		public decimal dftrte;

		[SMBFieldName("dftmax")]
		[SMBFieldDescription("Default Max")]
		public decimal dftmax;

		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Job Acct")]
		public int dbtact;

		[SMBFieldName("dbtshp")]
		[SMBFieldDescription("Shop Acct")]
		public int dbtshp;

		[SMBFieldName("dbtovh")]
		[SMBFieldDescription("Ovh  Acct")]
		public int dbtovh;

		[SMBFieldName("dbtadm")]
		[SMBFieldDescription("Admin Acct")]
		public int dbtadm;

		[SMBFieldName("crdact")]
		[SMBFieldDescription("Credit Acct")]
		public int crdact;

		[SMBFieldName("crdsub")]
		[SMBFieldDescription("Credit Subaccount")]
		public int crdsub;

		[SMBFieldName("taxste")]
		[SMBFieldDescription("Tax State")]
		public string taxste;

		[SMBFieldName("taxloc")]
		[SMBFieldDescription("Tax Locale")]
		public int taxloc;

		[SMBFieldName("taxtyp")]
		[SMBFieldDescription("Tax Type")]
		public int taxtyp;

		[SMBFieldName("clctyp")]
		[SMBFieldDescription("Calc Type")]
		public int clctyp;

		[SMBFieldName("clcmth")]
		[SMBFieldDescription("Calc Method")]
		public int clcmth;

		[SMBFieldName("bsdded")]
		[SMBFieldDescription("Based On")]
		public int bsdded;

		[SMBFieldName("maxtyp")]
		[SMBFieldDescription("Max Type")]
		public int maxtyp;

		[SMBFieldName("uninum")]
		[SMBFieldDescription("Union")]
		public int uninum;

		[SMBFieldName("bnftyp")]
		[SMBFieldDescription("Benefit")]
		public int bnftyp;

		[SMBFieldName("ssctax")]
		[SMBFieldDescription("SSC Tax")]
		public int ssctax;

		[SMBFieldName("medcre")]
		[SMBFieldDescription("Med Tax")]
		public int medcre;

		[SMBFieldName("fedtax")]
		[SMBFieldDescription("Fed Tax")]
		public int fedtax;

		[SMBFieldName("ftatax")]
		[SMBFieldDescription("FUTA Tax")]
		public int ftatax;

		[SMBFieldName("stetax")]
		[SMBFieldDescription("State Tax")]
		public int stetax;

		[SMBFieldName("steunp")]
		[SMBFieldDescription("SUI Tax")]
		public int steunp;

		[SMBFieldName("stedsb")]
		[SMBFieldDescription("SDI Tax")]
		public int stedsb;

		[SMBFieldName("wkrcmp")]
		[SMBFieldDescription("Wk Comp")]
		public int wkrcmp;

		[SMBFieldName("libins")]
		[SMBFieldDescription("Liability")]
		public int libins;

		[SMBFieldName("loctax")]
		[SMBFieldDescription("Local Tax")]
		public int loctax;

		[SMBFieldName("benovr")]
		[SMBFieldDescription("Paygroup")]
		public int benovr;

		[SMBFieldName("dspchk")]
		[SMBFieldDescription("Display")]
		public int dspchk;

		[SMBFieldName("empsub")]
		[SMBFieldDescription("Emp# for Cr Sub")]
		public int empsub;

		[SMBFieldName("exmdol")]
		[SMBFieldDescription("Exemption Amount")]
		public decimal exmdol;

		[SMBFieldName("addexm")]
		[SMBFieldDescription("Additional Exemp.")]
		public decimal addexm;

		[SMBFieldName("dftact")]
		[SMBFieldDescription("Default Active")]
		public int dftact;

		[SMBFieldName("dspinc")]
		[SMBFieldDescription("Disposable Income")]
		public int dspinc;

		[SMBFieldName("w2_box")]
		[SMBFieldDescription("W-2 Box")]
		public int w2_box;

		[SMBFieldName("w2_cde")]
		[SMBFieldDescription("W-2 Code")]
		public string w2_cde;

		[SMBFieldName("aatrix")]
		[SMBFieldDescription("Aatrix Tax Type")]
		public int aatrix;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}