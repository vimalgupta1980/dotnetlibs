using System;

namespace SMB.Tables {
	public class srcneq : smbtable {
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
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Location                        
		/// </summary>
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

	}
}