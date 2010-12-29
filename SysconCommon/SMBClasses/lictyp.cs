using System;

namespace SMB.Tables {
	public class lictyp : smbtable {
		/// <summary>
		/// License#                        
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("License#")]
		public long recnum;

		/// <summary>
		/// License Type                    
		/// </summary>
		[SMBFieldName("typnme")]
		[SMBFieldDescription("License Type")]
		public string typnme;

	}
}