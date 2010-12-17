using System;

namespace SMB.Tables {
	public class tmeqln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Equipment Type")]
		public int eqptyp;

		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public int eqpnum;

		[SMBFieldName("oprrte")]
		[SMBFieldDescription("Operated")]
		public decimal oprrte;

		[SMBFieldName("stdrte")]
		[SMBFieldDescription("Standby")]
		public decimal stdrte;

		[SMBFieldName("idlrte")]
		[SMBFieldDescription("Idle")]
		public decimal idlrte;

		[SMBFieldName("minhrs")]
		[SMBFieldDescription("Minimum Hrs")]
		public decimal minhrs;

	}
}