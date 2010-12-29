using System;

namespace SMB.Tables {
	public class clnsts : smbtable {
		/// <summary>
		/// Client Status#                  
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client Status#")]
		public long recnum;

		/// <summary>
		/// Status Name                     
		/// </summary>
		[SMBFieldName("stsnme")]
		[SMBFieldDescription("Status Name")]
		public string stsnme;

	}
}