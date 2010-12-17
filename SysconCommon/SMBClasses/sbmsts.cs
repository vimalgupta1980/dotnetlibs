using System;

namespace SMB.Tables {
	public class sbmsts : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Submittal Line Status")]
		public int recnum;

		[SMBFieldName("stsnme")]
		[SMBFieldDescription("Description")]
		public string stsnme;

	}
}