using System;

namespace SMB.Tables {
	public class srvgeo : smbtable {
		/// <summary>
		/// Area#                           
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Area#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Dispatch Color                  
		/// </summary>
		[SMBFieldName("geoclr")]
		[SMBFieldDescription("Dispatch Color")]
		public string geoclr;

	}
}