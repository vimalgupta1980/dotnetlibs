using System;

namespace SMB.Tables {
	public class vndtyp : smbtable {
		/// <summary>
		/// Vendor Type#                    
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}