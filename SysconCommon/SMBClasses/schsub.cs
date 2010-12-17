using System;

namespace SMB.Tables {
	public class schsub : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public int phsnum;

		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		[SMBFieldName("subnum")]
		[SMBFieldDescription("Subcontractor")]
		public int subnum;

		[SMBFieldName("strtme")]
		[SMBFieldDescription("Start Time")]
		public DateTime strtme;

		[SMBFieldName("endtme")]
		[SMBFieldDescription("End Time")]
		public DateTime endtme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}