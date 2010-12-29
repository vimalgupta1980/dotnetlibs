using System;

namespace SMB.Tables {
	public class empabs : smbtable {
		/// <summary>
		/// Absence#                        
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Absence#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("resabs")]
		[SMBFieldDescription("Description")]
		public string resabs;

	}
}