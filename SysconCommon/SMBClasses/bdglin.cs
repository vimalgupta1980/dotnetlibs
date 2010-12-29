using System;

namespace SMB.Tables {
	public class bdglin : smbtable {
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
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Hours                           
		/// </summary>
		[SMBFieldName("hrsbdg")]
		[SMBFieldDescription("Hours")]
		public decimal hrsbdg;

		/// <summary>
		/// Material                        
		/// </summary>
		[SMBFieldName("matbdg")]
		[SMBFieldDescription("Material")]
		public decimal matbdg;

		/// <summary>
		/// Labor                           
		/// </summary>
		[SMBFieldName("labbdg")]
		[SMBFieldDescription("Labor")]
		public decimal labbdg;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpbdg")]
		[SMBFieldDescription("Equipment")]
		public decimal eqpbdg;

		/// <summary>
		/// Subcontract                     
		/// </summary>
		[SMBFieldName("subbdg")]
		[SMBFieldDescription("Subcontract")]
		public decimal subbdg;

		/// <summary>
		/// Other                           
		/// </summary>
		[SMBFieldName("othbdg")]
		[SMBFieldDescription("Other")]
		public decimal othbdg;

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
		[SMBFieldName("ttlbdg")]
		[SMBFieldDescription("Total")]
		public decimal ttlbdg;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("estunt")]
		[SMBFieldDescription("Quantity")]
		public decimal estunt;

		/// <summary>
		/// Unit Cost                       
		/// </summary>
		[SMBFieldName("untcst")]
		[SMBFieldDescription("Unit Cost")]
		public decimal untcst;

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
		/// Orig Hours                      
		/// </summary>
		[SMBFieldName("hrsorg")]
		[SMBFieldDescription("Orig Hours")]
		public decimal hrsorg;

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

		/// <summary>
		/// Orig Quantity                   
		/// </summary>
		[SMBFieldName("euntor")]
		[SMBFieldDescription("Orig Quantity")]
		public decimal euntor;

		/// <summary>
		/// Org Unit Cost                   
		/// </summary>
		[SMBFieldName("ucstor")]
		[SMBFieldDescription("Org Unit Cost")]
		public decimal ucstor;

	}
}