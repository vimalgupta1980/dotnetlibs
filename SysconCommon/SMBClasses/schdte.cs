using System;

namespace SMB.Tables {
	public class schdte : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public int phsnum;

		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		[SMBFieldName("schdte")]
		[SMBFieldDescription("Date")]
		public DateTime _schdte;

	}
}