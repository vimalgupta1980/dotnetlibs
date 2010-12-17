using System;

namespace SMB.Tables {
	public class eqpmln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Equipment#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("cmpday")]
		[SMBFieldDescription("Comp Date")]
		public DateTime cmpday;

		[SMBFieldName("cycday")]
		[SMBFieldDescription("Cycle Days")]
		public int cycday;

		[SMBFieldName("schdte")]
		[SMBFieldDescription("Sched Date")]
		public DateTime schdte;

		[SMBFieldName("cmphrs")]
		[SMBFieldDescription("Comp Units")]
		public int cmphrs;

		[SMBFieldName("cychrs")]
		[SMBFieldDescription("Cycle Units")]
		public int cychrs;

		[SMBFieldName("schhrs")]
		[SMBFieldDescription("Sched Units")]
		public int schhrs;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}