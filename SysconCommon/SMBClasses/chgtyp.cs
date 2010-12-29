using System;

namespace SMB.Tables {
	public class chgtyp : smbtable {
		/// <summary>
		/// CO Type#                        
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("CO Type#")]
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