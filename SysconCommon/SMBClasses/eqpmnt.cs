using System;

namespace SMB.Tables {
	public class eqpmnt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Equip#")]
		public int recnum;

		[SMBFieldName("eqpnme")]
		[SMBFieldDescription("Description")]
		public string eqpnme;

		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		[SMBFieldName("srlnum")]
		[SMBFieldDescription("Serial#")]
		public string srlnum;

		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		[SMBFieldName("pucnum")]
		[SMBFieldDescription("PUC#")]
		public string pucnum;

		[SMBFieldName("lonnum")]
		[SMBFieldDescription("Loan#")]
		public string lonnum;

		[SMBFieldName("lender")]
		[SMBFieldDescription("Lender")]
		public int lender;

		[SMBFieldName("pchdte")]
		[SMBFieldDescription("Purchased")]
		public DateTime pchdte;

		[SMBFieldName("nxtpay")]
		[SMBFieldDescription("Pay Date")]
		public DateTime nxtpay;

		[SMBFieldName("lontyp")]
		[SMBFieldDescription("Loan Type")]
		public int lontyp;

		[SMBFieldName("intrte")]
		[SMBFieldDescription("Interest Rate")]
		public decimal intrte;

		[SMBFieldName("paymnt")]
		[SMBFieldDescription("Payment")]
		public decimal paymnt;

		[SMBFieldName("deprte")]
		[SMBFieldDescription("Depreciation")]
		public decimal deprte;

		[SMBFieldName("depact")]
		[SMBFieldDescription("Deprec Acct")]
		public int depact;

		[SMBFieldName("intact")]
		[SMBFieldDescription("Interest Acct")]
		public int intact;

		[SMBFieldName("depmnt")]
		[SMBFieldDescription("Department")]
		public int depmnt;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("lstloc")]
		[SMBFieldDescription("Last Location")]
		public string lstloc;

		[SMBFieldName("oprbll")]
		[SMBFieldDescription("Operated Bill")]
		public decimal oprbll;

		[SMBFieldName("oprcst")]
		[SMBFieldDescription("Operated Cost")]
		public decimal oprcst;

		[SMBFieldName("stbbll")]
		[SMBFieldDescription("Standby Bill")]
		public decimal stbbll;

		[SMBFieldName("stbcst")]
		[SMBFieldDescription("Standby Cost")]
		public decimal stbcst;

		[SMBFieldName("idlbll")]
		[SMBFieldDescription("Idle Bill")]
		public decimal idlbll;

		[SMBFieldName("idlcst")]
		[SMBFieldDescription("Idle Cost")]
		public decimal idlcst;

		[SMBFieldName("ttlhrs")]
		[SMBFieldDescription("Hours")]
		public decimal ttlhrs;

		[SMBFieldName("ttlmls")]
		[SMBFieldDescription("Miles")]
		public decimal ttlmls;

		[SMBFieldName("begcap")]
		[SMBFieldDescription("Begin Capital")]
		public decimal begcap;

		[SMBFieldName("capend")]
		[SMBFieldDescription("End Capital")]
		public decimal capend;

		[SMBFieldName("begdep")]
		[SMBFieldDescription("Begin Deprec")]
		public decimal begdep;

		[SMBFieldName("depend")]
		[SMBFieldDescription("End Deprec")]
		public decimal depend;

		[SMBFieldName("beglon")]
		[SMBFieldDescription("Begin Loan")]
		public decimal beglon;

		[SMBFieldName("lonend")]
		[SMBFieldDescription("End Loan")]
		public decimal lonend;

		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Equip. Type")]
		public int eqptyp;

		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		[SMBFieldName("enddte")]
		[SMBFieldDescription("End Date")]
		public DateTime enddte;

		[SMBFieldName("strval")]
		[SMBFieldDescription("Start Value")]
		public decimal strval;

		[SMBFieldName("endval")]
		[SMBFieldDescription("Ending Value")]
		public decimal endval;

		[SMBFieldName("insrnc")]
		[SMBFieldDescription("Insurance")]
		public decimal insrnc;

		[SMBFieldName("financ")]
		[SMBFieldDescription("Financing")]
		public decimal financ;

		[SMBFieldName("taxlic")]
		[SMBFieldDescription("Tax/License")]
		public decimal taxlic;

		[SMBFieldName("inspct")]
		[SMBFieldDescription("Inspection")]
		public decimal inspct;

		[SMBFieldName("ovrhed")]
		[SMBFieldDescription("Overhaul")]
		public decimal ovrhed;

		[SMBFieldName("storag")]
		[SMBFieldDescription("Storage")]
		public decimal storag;

		[SMBFieldName("cstcap")]
		[SMBFieldDescription("Cost of Capital")]
		public decimal cstcap;

		[SMBFieldName("othcst")]
		[SMBFieldDescription("Other Cost")]
		public decimal othcst;

		[SMBFieldName("unttyp")]
		[SMBFieldDescription("Unit")]
		public int unttyp;

		[SMBFieldName("estuse")]
		[SMBFieldDescription("Estimated Use")]
		public decimal estuse;

		[SMBFieldName("fuloil")]
		[SMBFieldDescription("Fuel and Oil")]
		public decimal fuloil;

		[SMBFieldName("csttir")]
		[SMBFieldDescription("Tires")]
		public decimal csttir;

		[SMBFieldName("mntcst")]
		[SMBFieldDescription("Maintenance")]
		public decimal mntcst;

		[SMBFieldName("othopr")]
		[SMBFieldDescription("Other Cost")]
		public decimal othopr;

		[SMBFieldName("lstpst")]
		[SMBFieldDescription("Last Posted (niu)")]
		public DateTime lstpst;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("fluchg")]
		[SMBFieldDescription("Fluid Change")]
		public decimal fluchg;

		[SMBFieldName("minrpr")]
		[SMBFieldDescription("Minor Repair")]
		public decimal minrpr;

		[SMBFieldName("oilchg")]
		[SMBFieldDescription("Oil Change")]
		public decimal oilchg;

		[SMBFieldName("moblbl")]
		[SMBFieldDescription("Mobilization Billing")]
		public decimal moblbl;

		[SMBFieldName("dyopbl")]
		[SMBFieldDescription("Daily Operated Billing")]
		public decimal dyopbl;

		[SMBFieldName("dystbl")]
		[SMBFieldDescription("Daily Standby Billing")]
		public decimal dystbl;

		[SMBFieldName("dyidbl")]
		[SMBFieldDescription("Daily Idle Billing")]
		public decimal dyidbl;

		[SMBFieldName("wkopbl")]
		[SMBFieldDescription("Weekly Operated Billing")]
		public decimal wkopbl;

		[SMBFieldName("wkstbl")]
		[SMBFieldDescription("Weekly Standby Billing")]
		public decimal wkstbl;

		[SMBFieldName("wkidbl")]
		[SMBFieldDescription("Weekly Idle Billing")]
		public decimal wkidbl;

		[SMBFieldName("mtopbl")]
		[SMBFieldDescription("Monthly Operated Billing")]
		public decimal mtopbl;

		[SMBFieldName("mtstbl")]
		[SMBFieldDescription("Monthly Standby Billing")]
		public decimal mtstbl;

		[SMBFieldName("mtidbl")]
		[SMBFieldDescription("Monthly Idle Billing")]
		public decimal mtidbl;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered Date")]
		public DateTime entdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("lstprd")]
		[SMBFieldDescription("Last Period")]
		public string lstprd;

		[SMBFieldName("orghrs")]
		[SMBFieldDescription("Original Hours")]
		public decimal orghrs;

		[SMBFieldName("orgmls")]
		[SMBFieldDescription("Original Miles")]
		public decimal orgmls;

	}
}