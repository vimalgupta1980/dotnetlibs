using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class cscpln : smbtable {
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
		/// Budget                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("bdgttl")]
		[SMBFieldDescription("Budget")]
		public decimal bdgttl;

		/// <summary>
		/// Cost to Date                    
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("cstdte")]
		[SMBFieldDescription("Cost to Date")]
		public decimal cstdte;

		/// <summary>
		/// % Comp                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("pctcst")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcst;

		/// <summary>
		/// % Actual                        
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("actcmp")]
		[SMBFieldDescription("% Actual")]
		public decimal actcmp;

		/// <summary>
		/// Cost to Comp                    
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("cstcmp")]
		[SMBFieldDescription("Cost to Comp")]
		public decimal cstcmp;

		/// <summary>
		/// Over/(Under)                    
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("ovrund")]
		[SMBFieldDescription("Over/(Under)")]
		public decimal ovrund;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}