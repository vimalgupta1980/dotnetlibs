using System;

namespace SMB.Tables {
	public class sbmtln : smbtable {
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
		/// Item                            
		/// </summary>
		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Item")]
		public string itmnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Action Required                 
		/// </summary>
		[SMBFieldName("actreq")]
		[SMBFieldDescription("Action Required")]
		public string actreq;

		/// <summary>
		/// Date Required                   
		/// </summary>
		[SMBFieldName("reqdte")]
		[SMBFieldDescription("Date Required")]
		public DateTime reqdte;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("sbmsts")]
		[SMBFieldDescription("Status")]
		public long sbmsts;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}