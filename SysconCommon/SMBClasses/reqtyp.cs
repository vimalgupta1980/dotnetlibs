using System;

namespace SMB.Tables {
	public class reqtyp : smbtable {
		/// <summary>
		/// Request Type#                   
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Request Type#")]
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