using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class aialin : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Division                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Scheduled                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("schamt")]
		[SMBFieldDescription("Scheduled")]
		public decimal schamt;

		/// <summary>
		/// Changes                         
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("chgamt")]
		[SMBFieldDescription("Changes")]
		public decimal chgamt;

		/// <summary>
		/// Contract                        
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("newcon")]
		[SMBFieldDescription("Contract")]
		public decimal newcon;

		/// <summary>
		/// Prev. Comp.                     
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("prvbll")]
		[SMBFieldDescription("Prev. Comp.")]
		public decimal prvbll;

		/// <summary>
		/// Current Comp.                   
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current Comp.")]
		public decimal curbll;

		/// <summary>
		/// Ret. Rate                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("retrte")]
		[SMBFieldDescription("Ret. Rate")]
		public decimal retrte;

		/// <summary>
		/// Comp. Ret.                      
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("curret")]
		[SMBFieldDescription("Comp. Ret.")]
		public decimal curret;

		/// <summary>
		/// Prev. Stored                    
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("prvstr")]
		[SMBFieldDescription("Prev. Stored")]
		public decimal prvstr;

		/// <summary>
		/// Current Stored                  
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("curstr")]
		[SMBFieldDescription("Current Stored")]
		public decimal curstr;

		/// <summary>
		/// Total Stored                    
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("strmat")]
		[SMBFieldDescription("Total Stored")]
		public decimal strmat;

		/// <summary>
		/// Stored Ret.                     
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("strret")]
		[SMBFieldDescription("Stored Ret.")]
		public decimal strret;

		/// <summary>
		/// Total Comp.                     
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total Comp.")]
		public decimal ttlcmp;

		/// <summary>
		/// % Comp                          
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcmp;

		/// <summary>
		/// Balance                         
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("balfin")]
		[SMBFieldDescription("Balance")]
		public decimal balfin;

		/// <summary>
		/// Total Ret.                      
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("retamt")]
		[SMBFieldDescription("Total Ret.")]
		public decimal retamt;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}