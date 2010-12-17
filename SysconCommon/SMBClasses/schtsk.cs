using System;

namespace SMB.Tables {
	public class schtsk : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Task#")]
		public decimal recnum;

		[SMBFieldName("tsknme")]
		[SMBFieldDescription("Description")]
		public string tsknme;

		[SMBFieldName("tsktyp")]
		[SMBFieldDescription("Task Type")]
		public int tsktyp;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}