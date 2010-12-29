using System;

namespace SMB.Tables {
	public class unprln : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Bid Item                        
		/// </summary>
		[SMBFieldName("biditm")]
		[SMBFieldDescription("Bid Item")]
		public long biditm;

		/// <summary>
		/// Item Code                       
		/// </summary>
		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("numunt")]
		[SMBFieldDescription("Quantity")]
		public decimal numunt;

		/// <summary>
		/// Unit Price                      
		/// </summary>
		[SMBFieldName("cstunt")]
		[SMBFieldDescription("Unit Price")]
		public decimal cstunt;

		/// <summary>
		/// Total Price                     
		/// </summary>
		[SMBFieldName("ttlcst")]
		[SMBFieldDescription("Total Price")]
		public decimal ttlcst;

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

		/// <summary>
		/// Orig Quantity                   
		/// </summary>
		[SMBFieldName("untorg")]
		[SMBFieldDescription("Orig Quantity")]
		public decimal untorg;

		/// <summary>
		/// Orig Unit Price                 
		/// </summary>
		[SMBFieldName("cstorg")]
		[SMBFieldDescription("Orig Unit Price")]
		public decimal cstorg;

		/// <summary>
		/// Orig Total Price                
		/// </summary>
		[SMBFieldName("ttlorg")]
		[SMBFieldDescription("Orig Total Price")]
		public decimal ttlorg;

	}
}