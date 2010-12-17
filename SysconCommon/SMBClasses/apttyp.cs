using System;

namespace SMB.Tables {
	public class apttyp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Appointment#")]
		public int recnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}