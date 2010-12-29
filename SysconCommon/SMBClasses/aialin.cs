using System;

namespace SMB.Tables {
	public class aialin : smbtable {
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
		/// Division                        
		/// </summary>
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

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
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Scheduled                       
		/// </summary>
		[SMBFieldName("schamt")]
		[SMBFieldDescription("Scheduled")]
		public decimal schamt;

		/// <summary>
		/// Changes                         
		/// </summary>
		[SMBFieldName("chgamt")]
		[SMBFieldDescription("Changes")]
		public decimal chgamt;

		/// <summary>
		/// Contract                        
		/// </summary>
		[SMBFieldName("newcon")]
		[SMBFieldDescription("Contract")]
		public decimal newcon;

		/// <summary>
		/// Prev. Comp.                     
		/// </summary>
		[SMBFieldName("prvbll")]
		[SMBFieldDescription("Prev. Comp.")]
		public decimal prvbll;

		/// <summary>
		/// Current Comp.                   
		/// </summary>
		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current Comp.")]
		public decimal curbll;

		/// <summary>
		/// Ret. Rate                       
		/// </summary>
		[SMBFieldName("retrte")]
		[SMBFieldDescription("Ret. Rate")]
		public decimal retrte;

		/// <summary>
		/// Comp. Ret.                      
		/// </summary>
		[SMBFieldName("curret")]
		[SMBFieldDescription("Comp. Ret.")]
		public decimal curret;

		/// <summary>
		/// Prev. Stored                    
		/// </summary>
		[SMBFieldName("prvstr")]
		[SMBFieldDescription("Prev. Stored")]
		public decimal prvstr;

		/// <summary>
		/// Current Stored                  
		/// </summary>
		[SMBFieldName("curstr")]
		[SMBFieldDescription("Current Stored")]
		public decimal curstr;

		/// <summary>
		/// Total Stored                    
		/// </summary>
		[SMBFieldName("strmat")]
		[SMBFieldDescription("Total Stored")]
		public decimal strmat;

		/// <summary>
		/// Stored Ret.                     
		/// </summary>
		[SMBFieldName("strret")]
		[SMBFieldDescription("Stored Ret.")]
		public decimal strret;

		/// <summary>
		/// Total Comp.                     
		/// </summary>
		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total Comp.")]
		public decimal ttlcmp;

		/// <summary>
		/// % Comp                          
		/// </summary>
		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcmp;

		/// <summary>
		/// Balance                         
		/// </summary>
		[SMBFieldName("balfin")]
		[SMBFieldDescription("Balance")]
		public decimal balfin;

		/// <summary>
		/// Total Ret.                      
		/// </summary>
		[SMBFieldName("retamt")]
		[SMBFieldDescription("Total Ret.")]
		public decimal retamt;

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