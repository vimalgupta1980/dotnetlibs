using System;

namespace SMB.Tables {
	public class srcnlc : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public int locnum;

	}
}