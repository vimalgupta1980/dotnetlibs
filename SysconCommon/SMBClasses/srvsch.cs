using System;

namespace SMB.Tables {
	public class srvsch : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public int eqpnum;

		[SMBFieldName("priort")]
		[SMBFieldDescription("Priority")]
		public int priort;

		[SMBFieldName("schdte")]
		[SMBFieldDescription("Sched. Date")]
		public DateTime schdte;

		[SMBFieldName("schstr")]
		[SMBFieldDescription("Sched. Start")]
		public DateTime schstr;

		[SMBFieldName("schfin")]
		[SMBFieldDescription("Sched. Finish")]
		public DateTime schfin;

		[SMBFieldName("esthrs")]
		[SMBFieldDescription("Sched. Hours")]
		public decimal esthrs;

		[SMBFieldName("tvltim")]
		[SMBFieldDescription("Travel Time")]
		public string tvltim;

		[SMBFieldName("findte")]
		[SMBFieldDescription("Completed Date")]
		public DateTime findte;

		[SMBFieldName("actstr")]
		[SMBFieldDescription("Actual Start")]
		public DateTime actstr;

		[SMBFieldName("actfin")]
		[SMBFieldDescription("Actual Finish")]
		public DateTime actfin;

		[SMBFieldName("acthrs")]
		[SMBFieldDescription("Actual Hours")]
		public decimal acthrs;

		[SMBFieldName("bildte")]
		[SMBFieldDescription("Billed Date")]
		public DateTime bildte;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

	}
}