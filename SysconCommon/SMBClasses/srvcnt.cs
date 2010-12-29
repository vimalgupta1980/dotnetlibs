using System;

namespace SMB.Tables {
	public class srvcnt : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Contract#                       
		/// </summary>
		[SMBFieldName("connum")]
		[SMBFieldDescription("Contract#")]
		public string connum;

		/// <summary>
		/// Client                          
		/// </summary>
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Start Date                      
		/// </summary>
		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		/// <summary>
		/// Expiration                      
		/// </summary>
		[SMBFieldName("expdte")]
		[SMBFieldDescription("Expiration")]
		public DateTime expdte;

		/// <summary>
		/// Type                            
		/// </summary>
		[SMBFieldName("contyp")]
		[SMBFieldDescription("Type")]
		public long contyp;

		/// <summary>
		/// Amount                          
		/// </summary>
		[SMBFieldName("conamt")]
		[SMBFieldDescription("Amount")]
		public decimal conamt;

		/// <summary>
		/// Contract Coverage               
		/// </summary>
		[SMBFieldName("disply")]
		[SMBFieldDescription("Contract Coverage")]
		public long disply;

		/// <summary>
		/// Entered Date                    
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered Date")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}