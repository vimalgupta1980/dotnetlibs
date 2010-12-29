using System;

namespace SMB.Tables {
	public class emptrn : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee#")]
		public long empnum;

		/// <summary>
		/// Training Type                   
		/// </summary>
		[SMBFieldName("typnum")]
		[SMBFieldDescription("Training Type")]
		public long typnum;

		/// <summary>
		/// Last Date                       
		/// </summary>
		[SMBFieldName("lstdte")]
		[SMBFieldDescription("Last Date")]
		public DateTime lstdte;

		/// <summary>
		/// Next Date                       
		/// </summary>
		[SMBFieldName("nxtdte")]
		[SMBFieldDescription("Next Date")]
		public DateTime nxtdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}