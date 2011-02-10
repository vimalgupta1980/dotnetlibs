using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class sbcgln : smbtable {
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
		/// Description                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Budget Hours                    
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("chghrs")]
		[SMBFieldDescription("Budget Hours")]
		public decimal chghrs;

		/// <summary>
		/// Budget Units                    
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("chgunt")]
		[SMBFieldDescription("Budget Units")]
		public decimal chgunt;

		/// <summary>
		/// Budget Amount                   
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("bdgprc")]
		[SMBFieldDescription("Budget Amount")]
		public decimal bdgprc;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Subcontract                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("vndctc")]
		[SMBFieldDescription("Subcontract")]
		public long vndctc;

		/// <summary>
		/// Subcontract Line                
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("ctclin")]
		[SMBFieldDescription("Subcontract Line")]
		public long ctclin;

		/// <summary>
		/// Change#                         
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("chgnum")]
		[SMBFieldDescription("Change#")]
		public string chgnum;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("chgsts")]
		[SMBFieldDescription("Status")]
		public long chgsts;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("chgdte")]
		[SMBFieldDescription("Date")]
		public DateTime chgdte;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Change Order Notes              
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Change Order Notes")]
		public string ntetxt;

		/// <summary>
		/// Subcontract Line Reference #    
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("linref")]
		[SMBFieldDescription("Subcontract Line Reference #")]
		public string linref;

	}
}