using System;

namespace SMB.Tables {
	public class sbctyp : smbtable {
		/// <summary>
		/// Subcontract Type#               
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Subcontract Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Type Name")]
		public string dscrpt;

	}
}