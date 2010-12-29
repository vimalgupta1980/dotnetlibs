using System;

namespace SMB.Tables {
	public class trmtyp : smbtable {
		/// <summary>
		/// Transmittal Type#               
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Transmittal Type#")]
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