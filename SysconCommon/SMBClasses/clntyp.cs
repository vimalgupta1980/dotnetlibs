using System;

namespace SMB.Tables {
	public class clntyp : smbtable {
		/// <summary>
		/// Client Type#                    
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client Type#")]
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