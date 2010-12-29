using System;

namespace SMB.Tables {
	public class conlst : smbtable {
		/// <summary>
		/// Contract#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Contract#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}