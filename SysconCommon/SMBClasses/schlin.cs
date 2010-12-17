using System;

namespace SMB.Tables {
	public class schlin : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public int phsnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		[SMBFieldName("tsknme")]
		[SMBFieldDescription("Description")]
		public string tsknme;

		[SMBFieldName("tskdur")]
		[SMBFieldDescription("Duration")]
		public int tskdur;

		[SMBFieldName("tsktyp")]
		[SMBFieldDescription("Task Type")]
		public int tsktyp;

		[SMBFieldName("fxddte")]
		[SMBFieldDescription("Fixed Date")]
		public DateTime fxddte;

		[SMBFieldName("notbfr")]
		[SMBFieldDescription("Not Before")]
		public DateTime notbfr;

		[SMBFieldName("notaft")]
		[SMBFieldDescription("Not After")]
		public DateTime notaft;

		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		[SMBFieldName("findte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime findte;

		[SMBFieldName("ltestr")]
		[SMBFieldDescription("Late Start")]
		public DateTime ltestr;

		[SMBFieldName("ltefin")]
		[SMBFieldDescription("Late Finish")]
		public DateTime ltefin;

		[SMBFieldName("tskflt")]
		[SMBFieldDescription("Float")]
		public int tskflt;

		[SMBFieldName("orgdur")]
		[SMBFieldDescription("Original Duration")]
		public int orgdur;

		[SMBFieldName("orgstr")]
		[SMBFieldDescription("Original Start")]
		public DateTime orgstr;

		[SMBFieldName("orgfin")]
		[SMBFieldDescription("Original Finish")]
		public DateTime orgfin;

		[SMBFieldName("orgflt")]
		[SMBFieldDescription("Original Float")]
		public int orgflt;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}