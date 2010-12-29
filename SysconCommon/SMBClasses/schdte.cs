using System;

namespace SMB.Tables {
	public class schdte : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase#                          
		/// </summary>
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public long phsnum;

		/// <summary>
		/// Task#                           
		/// </summary>
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Date")]
		public DateTime _schdte;

	}
}