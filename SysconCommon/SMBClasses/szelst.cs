using System;

namespace SMB.Tables {
	public class szelst : smbtable {
		/// <summary>
		/// Client Size#                    
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client Size#")]
		public long recnum;

		/// <summary>
		/// Size Description                
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Size Description")]
		public string dscrpt;

	}
}