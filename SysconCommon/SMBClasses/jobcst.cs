using System;

namespace SMB.Tables {
	public class jobcst : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Work Order#")]
		public string wrkord;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("EntDate")]
		public DateTime entdte;

		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public int actprd;

		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public int srcnum;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("bllsts")]
		[SMBFieldDescription("Billing Status")]
		public int bllsts;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public int eqpnum;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

		[SMBFieldName("payrec")]
		[SMBFieldDescription("Payroll#")]
		public int payrec;

		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public int paytyp;

		[SMBFieldName("csthrs")]
		[SMBFieldDescription("Hours")]
		public decimal csthrs;

		[SMBFieldName("cstamt")]
		[SMBFieldDescription("Cost")]
		public decimal cstamt;

		[SMBFieldName("blgqty")]
		[SMBFieldDescription("Billing Quantity")]
		public decimal blgqty;

		[SMBFieldName("blgamt")]
		[SMBFieldDescription("Billing Amount")]
		public decimal blgamt;

		[SMBFieldName("pieces")]
		[SMBFieldDescription("Pieces")]
		public decimal pieces;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public int lgrrec;

		[SMBFieldName("blgunt")]
		[SMBFieldDescription("Equipment Unit")]
		public int blgunt;

		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Type")]
		public int eqptyp;

		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public int eqpunt;

		[SMBFieldName("eqpqty")]
		[SMBFieldDescription("Quantity")]
		public decimal eqpqty;

		[SMBFieldName("grswge")]
		[SMBFieldDescription("Gross Wage")]
		public decimal grswge;

		[SMBFieldName("ovrrde")]
		[SMBFieldDescription("Override")]
		public int ovrrde;

		[SMBFieldName("blgttl")]
		[SMBFieldDescription("Billing Total")]
		public decimal blgttl;

		[SMBFieldName("active")]
		[SMBFieldDescription("In Process")]
		public int active;

		[SMBFieldName("acrinv")]
		[SMBFieldDescription("Invoice Rec#")]
		public int acrinv;

		[SMBFieldName("shwamt")]
		[SMBFieldDescription("Shown M/U")]
		public decimal shwamt;

		[SMBFieldName("ovhamt")]
		[SMBFieldDescription("O/H Amount")]
		public decimal ovhamt;

		[SMBFieldName("pftamt")]
		[SMBFieldDescription("Profit Amount")]
		public decimal pftamt;

		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Subject to Sales Tax")]
		public int taxabl;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}