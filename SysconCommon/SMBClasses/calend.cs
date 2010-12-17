using System;

namespace SMB.Tables {
	public class calend : smbtable {
		[SMBFieldName("caldte")]
		[SMBFieldDescription("Date")]
		public DateTime caldte;

		[SMBFieldName("wrksts")]
		[SMBFieldDescription("Status")]
		public int wrksts;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("daydsc")]
		[SMBFieldDescription("Description")]
		public string daydsc;

	}
}