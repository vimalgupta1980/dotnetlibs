using System;

namespace SMB.Tables {
	public class ptotkf : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("matovh")]
		[SMBFieldDescription("Material Overhead")]
		public decimal matovh;

		[SMBFieldName("matpft")]
		[SMBFieldDescription("Material Profit")]
		public decimal matpft;

		[SMBFieldName("labovh")]
		[SMBFieldDescription("Labor Overhead")]
		public decimal labovh;

		[SMBFieldName("labpft")]
		[SMBFieldDescription("Labor Profit")]
		public decimal labpft;

		[SMBFieldName("eqpovh")]
		[SMBFieldDescription("Equipment Overhead")]
		public decimal eqpovh;

		[SMBFieldName("eqppft")]
		[SMBFieldDescription("Equipment Profit")]
		public decimal eqppft;

		[SMBFieldName("subovh")]
		[SMBFieldDescription("Subcontract Overhead")]
		public decimal subovh;

		[SMBFieldName("subpft")]
		[SMBFieldDescription("Subcontract Profit")]
		public decimal subpft;

		[SMBFieldName("otrovh")]
		[SMBFieldDescription("Other Overhead")]
		public decimal otrovh;

		[SMBFieldName("otrpft")]
		[SMBFieldDescription("Other Profit")]
		public decimal otrpft;

		[SMBFieldName("cs6ovh")]
		[SMBFieldDescription("User Def Type 6  Overhead")]
		public decimal cs6ovh;

		[SMBFieldName("cs6pft")]
		[SMBFieldDescription("User Def Type 6  Profit")]
		public decimal cs6pft;

		[SMBFieldName("cs7ovh")]
		[SMBFieldDescription("User Def Type 7  Overhead")]
		public decimal cs7ovh;

		[SMBFieldName("cs7pft")]
		[SMBFieldDescription("User Def Type 7  Profit")]
		public decimal cs7pft;

		[SMBFieldName("cs8ovh")]
		[SMBFieldDescription("User Def Type 8  Overhead")]
		public decimal cs8ovh;

		[SMBFieldName("cs8pft")]
		[SMBFieldDescription("User Def Type 8  Profit")]
		public decimal cs8pft;

		[SMBFieldName("cs9ovh")]
		[SMBFieldDescription("User Def Type 9  Overhead")]
		public decimal cs9ovh;

		[SMBFieldName("cs9pft")]
		[SMBFieldDescription("User Def Type 9  Profit")]
		public decimal cs9pft;

		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Last Edit")]
		public DateTime edtdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Part Price")]
		public int prtprc;

		[SMBFieldName("paysbj")]
		[SMBFieldDescription("Payroll Subject Percent")]
		public decimal paysbj;

		[SMBFieldName("subsbj")]
		[SMBFieldDescription("Subcontract Subject Percent")]
		public decimal subsbj;

		[SMBFieldName("bidsbj")]
		[SMBFieldDescription("Bid Subject Percent")]
		public decimal bidsbj;

		[SMBFieldName("taxsbj")]
		[SMBFieldDescription("Tax Subject Percent")]
		public decimal taxsbj;

		[SMBFieldName("bndlt1")]
		[SMBFieldDescription("Bonding Limit 1")]
		public int bndlt1;

		[SMBFieldName("bndlt2")]
		[SMBFieldDescription("Bonding Limit 2")]
		public int bndlt2;

		[SMBFieldName("bndlt3")]
		[SMBFieldDescription("Bonding Limit 3")]
		public int bndlt3;

		[SMBFieldName("payrte")]
		[SMBFieldDescription("Payroll Rate")]
		public decimal payrte;

		[SMBFieldName("subrte")]
		[SMBFieldDescription("Subcontract Rate")]
		public decimal subrte;

		[SMBFieldName("bidrte")]
		[SMBFieldDescription("Bid Rate")]
		public decimal bidrte;

		[SMBFieldName("taxrte")]
		[SMBFieldDescription("Tax Rate")]
		public decimal taxrte;

		[SMBFieldName("lt1rte")]
		[SMBFieldDescription("Limit 1 Rate")]
		public decimal lt1rte;

		[SMBFieldName("lt2rte")]
		[SMBFieldDescription("Limit 2 Rate")]
		public decimal lt2rte;

		[SMBFieldName("lt3rte")]
		[SMBFieldDescription("Limit 3 Rate")]
		public decimal lt3rte;

		[SMBFieldName("payamt")]
		[SMBFieldDescription("Payroll Summary Amount")]
		public decimal payamt;

		[SMBFieldName("subamt")]
		[SMBFieldDescription("Subcontract Summary Amount")]
		public decimal subamt;

		[SMBFieldName("bidamt")]
		[SMBFieldDescription("Bid Summary Amount")]
		public decimal bidamt;

		[SMBFieldName("taxamt")]
		[SMBFieldDescription("Tax Summary Amount")]
		public decimal taxamt;

		[SMBFieldName("lt1amt")]
		[SMBFieldDescription("Limit 1 Summary Amount")]
		public decimal lt1amt;

		[SMBFieldName("lt2amt")]
		[SMBFieldDescription("Limit 2 Summary Amount")]
		public decimal lt2amt;

		[SMBFieldName("lt3amt")]
		[SMBFieldDescription("Limit 3 Summary Amount")]
		public decimal lt3amt;

		[SMBFieldName("instyp")]
		[SMBFieldDescription("Insurance Cost Type")]
		public int instyp;

		[SMBFieldName("inscde")]
		[SMBFieldDescription("Insurance Cost Code")]
		public decimal inscde;

		[SMBFieldName("taxtyp")]
		[SMBFieldDescription("Tax Cost Type")]
		public int taxtyp;

		[SMBFieldName("taxcde")]
		[SMBFieldDescription("Tax Cost Code")]
		public decimal taxcde;

		[SMBFieldName("bndtyp")]
		[SMBFieldDescription("Bonding Cost Type")]
		public int bndtyp;

		[SMBFieldName("bndcde")]
		[SMBFieldDescription("Bonding Cost Code")]
		public decimal bndcde;

		[SMBFieldName("insinc")]
		[SMBFieldDescription("Insurance Include in Budget")]
		public int insinc;

		[SMBFieldName("taxinc")]
		[SMBFieldDescription("Tax Include in Budget")]
		public int taxinc;

		[SMBFieldName("bndinc")]
		[SMBFieldDescription("Bonding Include in Budget")]
		public int bndinc;

		[SMBFieldName("insitm")]
		[SMBFieldDescription("Insurance Bid Item")]
		public int insitm;

		[SMBFieldName("insphs")]
		[SMBFieldDescription("Insurance Phase")]
		public int insphs;

		[SMBFieldName("taxitm")]
		[SMBFieldDescription("Tax Bid Item")]
		public int taxitm;

		[SMBFieldName("taxphs")]
		[SMBFieldDescription("Tax Phase")]
		public int taxphs;

		[SMBFieldName("bnditm")]
		[SMBFieldDescription("Bonding Bid Item")]
		public int bnditm;

		[SMBFieldName("bndphs")]
		[SMBFieldDescription("Bonding Phase")]
		public int bndphs;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("edtnme")]
		[SMBFieldDescription("Current Editor")]
		public string edtnme;

		[SMBFieldName("mrgmrk")]
		[SMBFieldDescription("Margin/Markup Option")]
		public int mrgmrk;

		[SMBFieldName("mrgovr")]
		[SMBFieldDescription("Gross Margin Override")]
		public decimal mrgovr;

		[SMBFieldName("mrkrte")]
		[SMBFieldDescription("Markup %")]
		public decimal mrkrte;

		[SMBFieldName("mrkdlr")]
		[SMBFieldDescription("Dollar Markup")]
		public decimal mrkdlr;

		[SMBFieldName("bidovr")]
		[SMBFieldDescription("Bid Amount")]
		public decimal bidovr;

		[SMBFieldName("lckbid")]
		[SMBFieldDescription("Lock Bid Amount")]
		public int lckbid;

		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Work Order Exports")]
		public string wrkord;

	}
}