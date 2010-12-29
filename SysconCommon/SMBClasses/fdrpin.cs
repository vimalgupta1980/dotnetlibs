using System;

namespace SMB.Tables {
	public class fdrpin : smbtable {
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
		/// Incident Type                   
		/// </summary>
		[SMBFieldName("inctyp")]
		[SMBFieldDescription("Incident Type")]
		public long inctyp;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Time                            
		/// </summary>
		[SMBFieldName("inctim")]
		[SMBFieldDescription("Time")]
		public DateTime inctim;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}