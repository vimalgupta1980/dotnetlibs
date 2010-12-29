using System;

namespace SMB.Tables {
	public class cortyp : smbtable {
		/// <summary>
		/// Correspondence Type#            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Correspondence Type#")]
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