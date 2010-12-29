using System;

namespace SMB.Tables {
	public class jobtyp : smbtable {
		/// <summary>
		/// Job Type#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job Type#")]
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