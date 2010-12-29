using System;

namespace SMB.Tables {
	public class emplic : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee#")]
		public long empnum;

		/// <summary>
		/// License Type                    
		/// </summary>
		[SMBFieldName("typnum")]
		[SMBFieldDescription("License Type")]
		public long typnum;

		/// <summary>
		/// License#                        
		/// </summary>
		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		/// <summary>
		/// Exp. Date                       
		/// </summary>
		[SMBFieldName("expdte")]
		[SMBFieldDescription("Exp. Date")]
		public DateTime expdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}