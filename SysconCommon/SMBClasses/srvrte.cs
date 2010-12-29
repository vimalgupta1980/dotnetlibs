using System;

namespace SMB.Tables {
	public class srvrte : smbtable {
		/// <summary>
		/// Service Route#                  
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Service Route#")]
		public long recnum;

		/// <summary>
		/// Route Name                      
		/// </summary>
		[SMBFieldName("rtenme")]
		[SMBFieldDescription("Route Name")]
		public string rtenme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}