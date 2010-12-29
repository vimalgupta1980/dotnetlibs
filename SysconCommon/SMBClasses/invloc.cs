using System;

namespace SMB.Tables {
	public class invloc : smbtable {
		/// <summary>
		/// Inv. Location#                  
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Inv. Location#")]
		public long recnum;

		/// <summary>
		/// Location Name                   
		/// </summary>
		[SMBFieldName("locnme")]
		[SMBFieldDescription("Location Name")]
		public string locnme;

		/// <summary>
		/// Employee                        
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

	}
}