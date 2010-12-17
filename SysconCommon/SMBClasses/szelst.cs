using System;

namespace SMB.Tables {
	public class szelst : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client Size#")]
		public int recnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Size Description")]
		public string dscrpt;

	}
}