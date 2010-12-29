using System;

namespace SMB.Tables {
	public class hrcpln : smbtable {
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
		/// Budget Hours                    
		/// </summary>
		[SMBFieldName("bdghrs")]
		[SMBFieldDescription("Budget Hours")]
		public decimal bdghrs;

		/// <summary>
		/// Hours to Date                   
		/// </summary>
		[SMBFieldName("hrsdte")]
		[SMBFieldDescription("Hours to Date")]
		public decimal hrsdte;

		/// <summary>
		/// % Comp                          
		/// </summary>
		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcmp;

		/// <summary>
		/// % Actual                        
		/// </summary>
		[SMBFieldName("actcmp")]
		[SMBFieldDescription("% Actual")]
		public decimal actcmp;

		/// <summary>
		/// Hours to Comp                   
		/// </summary>
		[SMBFieldName("hrscmp")]
		[SMBFieldDescription("Hours to Comp")]
		public decimal hrscmp;

		/// <summary>
		/// Over/(Under)                    
		/// </summary>
		[SMBFieldName("ovrund")]
		[SMBFieldDescription("Over/(Under)")]
		public decimal ovrund;

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