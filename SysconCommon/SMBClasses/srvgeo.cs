using System;

namespace SMB.Tables {
	public class srvgeo : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Area#")]
		public int recnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("geoclr")]
		[SMBFieldDescription("Dispatch Color")]
		public string geoclr;

	}
}