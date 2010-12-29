using System;

namespace SMB.Tables {
	public class dptmnt : smbtable {
		/// <summary>
		/// Department#                     
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Department#")]
		public long recnum;

		/// <summary>
		/// Department Name                 
		/// </summary>
		[SMBFieldName("dptnme")]
		[SMBFieldDescription("Department Name")]
		public string dptnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}