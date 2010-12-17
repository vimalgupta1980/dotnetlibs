using System;

namespace SMB.Tables {
	public class eqpcst : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public int eqpnum;

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
		[SMBFieldDescription("Entry Date")]
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

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("opreqp")]
		[SMBFieldDescription("Oper Equip")]
		public int opreqp;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

		[SMBFieldName("payrec")]
		[SMBFieldDescription("Payroll Record")]
		public int payrec;

		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public int paytyp;

		[SMBFieldName("csthrs")]
		[SMBFieldDescription("Labor Hours")]
		public decimal csthrs;

		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Type")]
		public int eqptyp;

		[SMBFieldName("eqpqty")]
		[SMBFieldDescription("Quantity")]
		public decimal eqpqty;

		[SMBFieldName("cstamt")]
		[SMBFieldDescription("Cost")]
		public decimal cstamt;

		[SMBFieldName("grswge")]
		[SMBFieldDescription("Gross Wage")]
		public decimal grswge;

		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public int eqpunt;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("Username")]
		public string usrnme;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public int lgrrec;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}