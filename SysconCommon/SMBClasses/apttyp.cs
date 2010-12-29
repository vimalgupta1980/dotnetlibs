using System;

namespace SMB.Tables {
	public class apttyp : smbtable {
		/// <summary>
		/// Appointment#                    
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Appointment#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}