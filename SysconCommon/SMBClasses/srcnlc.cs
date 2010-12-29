using System;

namespace SMB.Tables {
	public class srcnlc : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Location                        
		/// </summary>
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

	}
}