using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class lonlin : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("cdenme")]
		[SMBFieldDescription("Description")]
		public string cdenme;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Scheduled                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("schamt")]
		[SMBFieldDescription("Scheduled")]
		public decimal schamt;

		/// <summary>
		/// Changes                         
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("chgord")]
		[SMBFieldDescription("Changes")]
		public decimal chgord;

		/// <summary>
		/// Contract                        
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("newcon")]
		[SMBFieldDescription("Contract")]
		public decimal newcon;

		/// <summary>
		/// Previous                        
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("prvbll")]
		[SMBFieldDescription("Previous")]
		public decimal prvbll;

		/// <summary>
		/// Current                         
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current")]
		public decimal curbll;

		/// <summary>
		/// % Comp                          
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcmp;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total")]
		public decimal ttlcmp;

		/// <summary>
		/// Balance                         
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("balcon")]
		[SMBFieldDescription("Balance")]
		public decimal balcon;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}