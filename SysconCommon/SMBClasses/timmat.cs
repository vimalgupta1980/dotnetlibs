using System;

namespace SMB.Tables {
	public class timmat : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("emptbl")]
		[SMBFieldDescription("Wage Rate")]
		public int emptbl;

		[SMBFieldName("eqptbl")]
		[SMBFieldDescription("Equipment Rate")]
		public int eqptbl;

		[SMBFieldName("mtrhdn")]
		[SMBFieldDescription("Material Hidden")]
		public decimal mtrhdn;

		[SMBFieldName("mtrshw")]
		[SMBFieldDescription("Material Shown")]
		public decimal mtrshw;

		[SMBFieldName("mtrovh")]
		[SMBFieldDescription("Material Overhead")]
		public decimal mtrovh;

		[SMBFieldName("mtrpft")]
		[SMBFieldDescription("Material Profit")]
		public decimal mtrpft;

		[SMBFieldName("labhdn")]
		[SMBFieldDescription("Labor Hidden")]
		public decimal labhdn;

		[SMBFieldName("labshw")]
		[SMBFieldDescription("Labor Shown")]
		public decimal labshw;

		[SMBFieldName("labovh")]
		[SMBFieldDescription("Labor Overhead")]
		public decimal labovh;

		[SMBFieldName("labpft")]
		[SMBFieldDescription("Labor Profit")]
		public decimal labpft;

		[SMBFieldName("eqphdn")]
		[SMBFieldDescription("Equipment Hidden")]
		public decimal eqphdn;

		[SMBFieldName("eqpshw")]
		[SMBFieldDescription("Equipment Shown")]
		public decimal eqpshw;

		[SMBFieldName("eqpovh")]
		[SMBFieldDescription("Equipment Overhead")]
		public decimal eqpovh;

		[SMBFieldName("eqppft")]
		[SMBFieldDescription("Equipment Profit")]
		public decimal eqppft;

		[SMBFieldName("subhdn")]
		[SMBFieldDescription("Subcontract Hidden")]
		public decimal subhdn;

		[SMBFieldName("subshw")]
		[SMBFieldDescription("Subcontract Shown")]
		public decimal subshw;

		[SMBFieldName("subovh")]
		[SMBFieldDescription("Subcontract Overhead")]
		public decimal subovh;

		[SMBFieldName("subpft")]
		[SMBFieldDescription("Subcontract Profit")]
		public decimal subpft;

		[SMBFieldName("otrhdn")]
		[SMBFieldDescription("Other Hidden")]
		public decimal otrhdn;

		[SMBFieldName("otrshw")]
		[SMBFieldDescription("Other Shown")]
		public decimal otrshw;

		[SMBFieldName("otrovh")]
		[SMBFieldDescription("Other Overhead")]
		public decimal otrovh;

		[SMBFieldName("otrpft")]
		[SMBFieldDescription("Other Profit")]
		public decimal otrpft;

		[SMBFieldName("cs6hdn")]
		[SMBFieldDescription("User Def Type 6")]
		public decimal cs6hdn;

		[SMBFieldName("cs6shw")]
		[SMBFieldDescription("User Def Type 6 Shown")]
		public decimal cs6shw;

		[SMBFieldName("cs6ovh")]
		[SMBFieldDescription("User Def Type 6 Overhead")]
		public decimal cs6ovh;

		[SMBFieldName("cs6pft")]
		[SMBFieldDescription("User Def Type 6 Profit")]
		public decimal cs6pft;

		[SMBFieldName("cs7hdn")]
		[SMBFieldDescription("User Def Type 7")]
		public decimal cs7hdn;

		[SMBFieldName("cs7shw")]
		[SMBFieldDescription("User Def Type 7 Shown")]
		public decimal cs7shw;

		[SMBFieldName("cs7ovh")]
		[SMBFieldDescription("User Def Type 7 Overhead")]
		public decimal cs7ovh;

		[SMBFieldName("cs7pft")]
		[SMBFieldDescription("User Def Type 7 Profit")]
		public decimal cs7pft;

		[SMBFieldName("cs8hdn")]
		[SMBFieldDescription("User Def Type 8")]
		public decimal cs8hdn;

		[SMBFieldName("cs8shw")]
		[SMBFieldDescription("User Def Type 8 Shown")]
		public decimal cs8shw;

		[SMBFieldName("cs8ovh")]
		[SMBFieldDescription("User Def Type 8 Overhead")]
		public decimal cs8ovh;

		[SMBFieldName("cs8pft")]
		[SMBFieldDescription("User Def Type 8 Profit")]
		public decimal cs8pft;

		[SMBFieldName("cs9hdn")]
		[SMBFieldDescription("User Def Type 9")]
		public decimal cs9hdn;

		[SMBFieldName("cs9shw")]
		[SMBFieldDescription("User Def Type 9 Shown")]
		public decimal cs9shw;

		[SMBFieldName("cs9ovh")]
		[SMBFieldDescription("User Def Type 9 Overhead")]
		public decimal cs9ovh;

		[SMBFieldName("cs9pft")]
		[SMBFieldDescription("User Def Type 9 Profit")]
		public decimal cs9pft;

		[SMBFieldName("clcsts")]
		[SMBFieldDescription("Calculated")]
		public int clcsts;

		[SMBFieldName("invdte")]
		[SMBFieldDescription("Invoice Date")]
		public DateTime invdte;

		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		[SMBFieldName("subjct")]
		[SMBFieldDescription("Taxable Amount")]
		public decimal subjct;

		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax Amount")]
		public decimal slstax;

		[SMBFieldName("taxdtl")]
		[SMBFieldDescription("Tax Details")]
		public string taxdtl;

		[SMBFieldName("jobphs")]
		[SMBFieldDescription("Job Phase")]
		public int jobphs;

		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("incact")]
		[SMBFieldDescription("Income Account")]
		public int incact;

		[SMBFieldName("incsub")]
		[SMBFieldDescription("Subaccount")]
		public int incsub;

	}
}