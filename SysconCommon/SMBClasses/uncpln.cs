using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class uncpln : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Budget Cost                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("bdgcst")]
		[SMBFieldDescription("Budget Cost")]
		public decimal bdgcst;

		/// <summary>
		/// Budget Units                    
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("bdgunt")]
		[SMBFieldDescription("Budget Units")]
		public decimal bdgunt;

		/// <summary>
		/// Cost to Date                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("cstdte")]
		[SMBFieldDescription("Cost to Date")]
		public decimal cstdte;

		/// <summary>
		/// Units Comp                      
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("untcmp")]
		[SMBFieldDescription("Units Comp")]
		public decimal untcmp;

		/// <summary>
		/// Bdg. $/Unit                     
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("bdgprc")]
		[SMBFieldDescription("Bdg. $/Unit")]
		public decimal bdgprc;

		/// <summary>
		/// Act. $/Unit                     
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("actprc")]
		[SMBFieldDescription("Act. $/Unit")]
		public decimal actprc;

		/// <summary>
		/// O/(U) /Unit                     
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("ovrund")]
		[SMBFieldDescription("O/(U) /Unit")]
		public decimal ovrund;

		/// <summary>
		/// Units Remain                    
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("untrem")]
		[SMBFieldDescription("Units Remain")]
		public decimal untrem;

		/// <summary>
		/// Cost to Comp                    
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("cstcmp")]
		[SMBFieldDescription("Cost to Comp")]
		public decimal cstcmp;

		/// <summary>
		/// Over/(Under)                    
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("ovrttl")]
		[SMBFieldDescription("Over/(Under)")]
		public decimal ovrttl;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}