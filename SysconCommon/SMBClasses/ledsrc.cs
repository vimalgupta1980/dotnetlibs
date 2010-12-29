using System;

namespace SMB.Tables {
	public class ledsrc : smbtable {
		/// <summary>
		/// Lead Source#                    
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Lead Source#")]
		public long recnum;

		/// <summary>
		/// Source Name                     
		/// </summary>
		[SMBFieldName("srcnme")]
		[SMBFieldDescription("Source Name")]
		public string srcnme;

	}
}