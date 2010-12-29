using System;

namespace SMB.Tables {
	public class mtgtyp : smbtable {
		/// <summary>
		/// Type#                           
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Type Name")]
		public string dscrpt;

	}
}