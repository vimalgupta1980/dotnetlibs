using System;

namespace SMB.Tables {
	public class fdrpeq : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public int eqpnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public int eqpunt;

		[SMBFieldName("oprtim")]
		[SMBFieldDescription("Operated")]
		public decimal oprtim;

		[SMBFieldName("stdtim")]
		[SMBFieldDescription("Standby")]
		public decimal stdtim;

		[SMBFieldName("idltim")]
		[SMBFieldDescription("Idle")]
		public decimal idltim;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}