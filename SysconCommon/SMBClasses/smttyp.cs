using System;

namespace SMB.Tables {
	public class smttyp : smbtable {
		/// <summary>
		/// Submittal Type#                 
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Submittal Type#")]
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