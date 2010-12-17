using System;

namespace SMB.Tables {
	public class tsktyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Task Type #")]
		public int recnum;

		[SMBFieldName("tsknme")]
		[SMBFieldDescription("Description")]
		public string tsknme;

		[SMBFieldName("tskclr")]
		[SMBFieldDescription("Task Color")]
		public string tskclr;

	}
}