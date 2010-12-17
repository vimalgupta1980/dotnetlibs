using System;

namespace SMB.Tables {
	public class clnsts : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client Status#")]
		public int recnum;

		[SMBFieldName("stsnme")]
		[SMBFieldDescription("Status Name")]
		public string stsnme;

	}
}