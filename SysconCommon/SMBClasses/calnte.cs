using System;

namespace SMB.Tables {
	public class calnte : smbtable {
		[SMBFieldName("caldte")]
		[SMBFieldDescription("Date")]
		public DateTime caldte;

		[SMBFieldName("caltim")]
		[SMBFieldDescription("Start")]
		public DateTime caltim;

		[SMBFieldName("endtim")]
		[SMBFieldDescription("End")]
		public DateTime endtim;

		[SMBFieldName("apttyp")]
		[SMBFieldDescription("Appt. Type")]
		public int apttyp;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public int clnnum;

		[SMBFieldName("caltxt")]
		[SMBFieldDescription("Notes")]
		public string caltxt;

	}
}