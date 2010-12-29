using System;

namespace SMB.Tables {
	public class pcorat : smbtable {
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
		/// Document                        
		/// </summary>
		[SMBFieldName("docnme")]
		[SMBFieldDescription("Document")]
		public string docnme;

		/// <summary>
		/// Copies                          
		/// </summary>
		[SMBFieldName("copies")]
		[SMBFieldDescription("Copies")]
		public long copies;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}