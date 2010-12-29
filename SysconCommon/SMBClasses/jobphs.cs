using System;

namespace SMB.Tables {
	public class jobphs : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase#                          
		/// </summary>
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public long phsnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("phsnme")]
		[SMBFieldDescription("Description")]
		public string phsnme;

		/// <summary>
		/// Billing Amount                  
		/// </summary>
		[SMBFieldName("bllamt")]
		[SMBFieldDescription("Billing Amount")]
		public decimal bllamt;

		/// <summary>
		/// Retention                       
		/// </summary>
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		/// <summary>
		/// Model                           
		/// </summary>
		[SMBFieldName("mdldsc")]
		[SMBFieldDescription("Model")]
		public string mdldsc;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("untqty")]
		[SMBFieldDescription("Quantity")]
		public decimal untqty;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}