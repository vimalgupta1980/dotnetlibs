using System;

namespace SMB.Tables {
	public class uncpln : smbtable {
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
		/// Budget Cost                     
		/// </summary>
		[SMBFieldName("bdgcst")]
		[SMBFieldDescription("Budget Cost")]
		public decimal bdgcst;

		/// <summary>
		/// Budget Units                    
		/// </summary>
		[SMBFieldName("bdgunt")]
		[SMBFieldDescription("Budget Units")]
		public decimal bdgunt;

		/// <summary>
		/// Cost to Date                    
		/// </summary>
		[SMBFieldName("cstdte")]
		[SMBFieldDescription("Cost to Date")]
		public decimal cstdte;

		/// <summary>
		/// Units Comp                      
		/// </summary>
		[SMBFieldName("untcmp")]
		[SMBFieldDescription("Units Comp")]
		public decimal untcmp;

		/// <summary>
		/// Bdg. $/Unit                     
		/// </summary>
		[SMBFieldName("bdgprc")]
		[SMBFieldDescription("Bdg. $/Unit")]
		public decimal bdgprc;

		/// <summary>
		/// Act. $/Unit                     
		/// </summary>
		[SMBFieldName("actprc")]
		[SMBFieldDescription("Act. $/Unit")]
		public decimal actprc;

		/// <summary>
		/// O/(U) /Unit                     
		/// </summary>
		[SMBFieldName("ovrund")]
		[SMBFieldDescription("O/(U) /Unit")]
		public decimal ovrund;

		/// <summary>
		/// Units Remain                    
		/// </summary>
		[SMBFieldName("untrem")]
		[SMBFieldDescription("Units Remain")]
		public decimal untrem;

		/// <summary>
		/// Cost to Comp                    
		/// </summary>
		[SMBFieldName("cstcmp")]
		[SMBFieldDescription("Cost to Comp")]
		public decimal cstcmp;

		/// <summary>
		/// Over/(Under)                    
		/// </summary>
		[SMBFieldName("ovrttl")]
		[SMBFieldDescription("Over/(Under)")]
		public decimal ovrttl;

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