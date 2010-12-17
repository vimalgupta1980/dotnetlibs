using System;

namespace SMB.Tables {
	public class schedl : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("schphs")]
		[SMBFieldDescription("Phase")]
		public int schphs;

		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edit Date")]
		public DateTime edtdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("strdte")]
		[SMBFieldDescription("First Date")]
		public DateTime strdte;

		[SMBFieldName("findte")]
		[SMBFieldDescription("Last Date")]
		public DateTime findte;

		[SMBFieldName("chkbox")]
		[SMBFieldDescription("Check Boxes")]
		public string chkbox;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("wrkdys")]
		[SMBFieldDescription("Work Days")]
		public int wrkdys;

		[SMBFieldName("caldys")]
		[SMBFieldDescription("Calendar Days")]
		public int caldys;

	}
}