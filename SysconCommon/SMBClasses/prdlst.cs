using System;

namespace SMB.Tables {
	public class prdlst : smbtable {
		/// <summary>
		/// Product#                        
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Product#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}