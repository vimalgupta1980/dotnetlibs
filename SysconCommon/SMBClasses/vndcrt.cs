using System;

namespace SMB.Tables {
	public class vndcrt : smbtable {
		/// <summary>
		/// Vendor#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Received                        
		/// </summary>
		[SMBFieldName("dtercv")]
		[SMBFieldDescription("Received")]
		public DateTime dtercv;

		/// <summary>
		/// Expires                         
		/// </summary>
		[SMBFieldName("expdte")]
		[SMBFieldDescription("Expires")]
		public DateTime expdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}