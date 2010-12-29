using System;

namespace SMB.Tables {
	public class rfityp : smbtable {
		/// <summary>
		/// RFI Type#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("RFI Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Type Name")]
		public string dscrpt;

	}
}