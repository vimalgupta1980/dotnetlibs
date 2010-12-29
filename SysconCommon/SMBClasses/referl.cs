using System;

namespace SMB.Tables {
	public class referl : smbtable {
		/// <summary>
		/// Client                          
		/// </summary>
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Referred                        
		/// </summary>
		[SMBFieldName("referd")]
		[SMBFieldDescription("Referred")]
		public long referd;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("refdte")]
		[SMBFieldDescription("Date")]
		public DateTime refdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("refnte")]
		[SMBFieldDescription("Notes")]
		public string refnte;

	}
}