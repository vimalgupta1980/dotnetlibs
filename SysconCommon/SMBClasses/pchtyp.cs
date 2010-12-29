using System;

namespace SMB.Tables {
	public class pchtyp : smbtable {
		/// <summary>
		/// PO Type#                        
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("PO Type#")]
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