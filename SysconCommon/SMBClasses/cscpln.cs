using System;

namespace SMB.Tables {
	public class cscpln : smbtable {
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
		/// Budget                          
		/// </summary>
		[SMBFieldName("bdgttl")]
		[SMBFieldDescription("Budget")]
		public decimal bdgttl;

		/// <summary>
		/// Cost to Date                    
		/// </summary>
		[SMBFieldName("cstdte")]
		[SMBFieldDescription("Cost to Date")]
		public decimal cstdte;

		/// <summary>
		/// % Comp                          
		/// </summary>
		[SMBFieldName("pctcst")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcst;

		/// <summary>
		/// % Actual                        
		/// </summary>
		[SMBFieldName("actcmp")]
		[SMBFieldDescription("% Actual")]
		public decimal actcmp;

		/// <summary>
		/// Cost to Comp                    
		/// </summary>
		[SMBFieldName("cstcmp")]
		[SMBFieldDescription("Cost to Comp")]
		public decimal cstcmp;

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