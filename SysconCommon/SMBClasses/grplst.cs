using System;

namespace SMB.Tables {
	public class grplst : smbtable {
		/// <summary>
		/// Group#                          
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Group#")]
		public long recnum;

		/// <summary>
		/// Group Name                      
		/// </summary>
		[SMBFieldName("grpnme")]
		[SMBFieldDescription("Group Name")]
		public string grpnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}