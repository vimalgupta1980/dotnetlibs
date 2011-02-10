using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class hrcpln : smbtable {
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
		/// Budget Hours                    
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("bdghrs")]
		[SMBFieldDescription("Budget Hours")]
		public decimal bdghrs;

		/// <summary>
		/// Hours to Date                   
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("hrsdte")]
		[SMBFieldDescription("Hours to Date")]
		public decimal hrsdte;

		/// <summary>
		/// % Comp                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcmp;

		/// <summary>
		/// % Actual                        
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("actcmp")]
		[SMBFieldDescription("% Actual")]
		public decimal actcmp;

		/// <summary>
		/// Hours to Comp                   
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("hrscmp")]
		[SMBFieldDescription("Hours to Comp")]
		public decimal hrscmp;

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