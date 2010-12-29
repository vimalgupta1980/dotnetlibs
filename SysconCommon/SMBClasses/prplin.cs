using System;

namespace SMB.Tables {
	public class prplin : smbtable {
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
		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Bid Item")]
		public long itmnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Material                        
		/// </summary>
		[SMBFieldName("matprp")]
		[SMBFieldDescription("Material")]
		public decimal matprp;

		/// <summary>
		/// Labor                           
		/// </summary>
		[SMBFieldName("labprp")]
		[SMBFieldDescription("Labor")]
		public decimal labprp;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpprp")]
		[SMBFieldDescription("Equipment")]
		public decimal eqpprp;

		/// <summary>
		/// Subcontract                     
		/// </summary>
		[SMBFieldName("subprp")]
		[SMBFieldDescription("Subcontract")]
		public decimal subprp;

		/// <summary>
		/// Other                           
		/// </summary>
		[SMBFieldName("othprp")]
		[SMBFieldDescription("Other")]
		public decimal othprp;

		/// <summary>
		/// User Def Type 6                 
		/// </summary>
		[SMBFieldName("usrcs6")]
		[SMBFieldDescription("User Def Type 6")]
		public decimal usrcs6;

		/// <summary>
		/// User Def Type 7                 
		/// </summary>
		[SMBFieldName("usrcs7")]
		[SMBFieldDescription("User Def Type 7")]
		public decimal usrcs7;

		/// <summary>
		/// User Def Type 8                 
		/// </summary>
		[SMBFieldName("usrcs8")]
		[SMBFieldDescription("User Def Type 8")]
		public decimal usrcs8;

		/// <summary>
		/// User Def Type 9                 
		/// </summary>
		[SMBFieldName("usrcs9")]
		[SMBFieldDescription("User Def Type 9")]
		public decimal usrcs9;

		/// <summary>
		/// Total                           
		/// </summary>
		[SMBFieldName("ttlprp")]
		[SMBFieldDescription("Total")]
		public decimal ttlprp;

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
		/// Orig Material                   
		/// </summary>
		[SMBFieldName("matorg")]
		[SMBFieldDescription("Orig Material")]
		public decimal matorg;

		/// <summary>
		/// Orig Labor                      
		/// </summary>
		[SMBFieldName("laborg")]
		[SMBFieldDescription("Orig Labor")]
		public decimal laborg;

		/// <summary>
		/// Orig Equipment                  
		/// </summary>
		[SMBFieldName("eqporg")]
		[SMBFieldDescription("Orig Equipment")]
		public decimal eqporg;

		/// <summary>
		/// Orig Subcontract                
		/// </summary>
		[SMBFieldName("suborg")]
		[SMBFieldDescription("Orig Subcontract")]
		public decimal suborg;

		/// <summary>
		/// Orig Other                      
		/// </summary>
		[SMBFieldName("othorg")]
		[SMBFieldDescription("Orig Other")]
		public decimal othorg;

		/// <summary>
		/// Orig User Def Type 6            
		/// </summary>
		[SMBFieldName("cs6org")]
		[SMBFieldDescription("Orig User Def Type 6")]
		public decimal cs6org;

		/// <summary>
		/// Orig User Def Type 7            
		/// </summary>
		[SMBFieldName("cs7org")]
		[SMBFieldDescription("Orig User Def Type 7")]
		public decimal cs7org;

		/// <summary>
		/// Orig User Def Type 8            
		/// </summary>
		[SMBFieldName("cs8org")]
		[SMBFieldDescription("Orig User Def Type 8")]
		public decimal cs8org;

		/// <summary>
		/// Orig User Def Type 9            
		/// </summary>
		[SMBFieldName("cs9org")]
		[SMBFieldDescription("Orig User Def Type 9")]
		public decimal cs9org;

		/// <summary>
		/// Orig Total                      
		/// </summary>
		[SMBFieldName("ttlorg")]
		[SMBFieldDescription("Orig Total")]
		public decimal ttlorg;

	}
}