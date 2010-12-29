using System;

namespace SMB.Tables {
	public class calend : smbtable {
		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("caldte")]
		[SMBFieldDescription("Date")]
		public DateTime caldte;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("wrksts")]
		[SMBFieldDescription("Status")]
		public long wrksts;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("daydsc")]
		[SMBFieldDescription("Description")]
		public string daydsc;

	}
}