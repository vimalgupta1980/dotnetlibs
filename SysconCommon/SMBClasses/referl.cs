using System;

namespace SMB.Tables {
	public class referl : smbtable {
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public int clnnum;

		[SMBFieldName("referd")]
		[SMBFieldDescription("Referred")]
		public int referd;

		[SMBFieldName("refdte")]
		[SMBFieldDescription("Date")]
		public DateTime refdte;

		[SMBFieldName("refnte")]
		[SMBFieldDescription("Notes")]
		public string refnte;

	}
}