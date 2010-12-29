using System;

namespace SMB.Tables {
	public class lonlin : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

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
		/// Description                     
		/// </summary>
		[SMBFieldName("cdenme")]
		[SMBFieldDescription("Description")]
		public string cdenme;

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
		[SMBFieldName("chgord")]
		[SMBFieldDescription("Changes")]
		public decimal chgord;

		/// <summary>
		/// Contract                        
		/// </summary>
		[SMBFieldName("newcon")]
		[SMBFieldDescription("Contract")]
		public decimal newcon;

		/// <summary>
		/// Previous                        
		/// </summary>
		[SMBFieldName("prvbll")]
		[SMBFieldDescription("Previous")]
		public decimal prvbll;

		/// <summary>
		/// Current                         
		/// </summary>
		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current")]
		public decimal curbll;

		/// <summary>
		/// % Comp                          
		/// </summary>
		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcmp;

		/// <summary>
		/// Total                           
		/// </summary>
		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total")]
		public decimal ttlcmp;

		/// <summary>
		/// Balance                         
		/// </summary>
		[SMBFieldName("balcon")]
		[SMBFieldDescription("Balance")]
		public decimal balcon;

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