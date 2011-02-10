using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class bdglin : smbtable {
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
		/// Hours                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("hrsbdg")]
		[SMBFieldDescription("Hours")]
		public decimal hrsbdg;

		/// <summary>
		/// Material                        
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("matbdg")]
		[SMBFieldDescription("Material")]
		public decimal matbdg;

		/// <summary>
		/// Labor                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("labbdg")]
		[SMBFieldDescription("Labor")]
		public decimal labbdg;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("eqpbdg")]
		[SMBFieldDescription("Equipment")]
		public decimal eqpbdg;

		/// <summary>
		/// Subcontract                     
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("subbdg")]
		[SMBFieldDescription("Subcontract")]
		public decimal subbdg;

		/// <summary>
		/// Other                           
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("othbdg")]
		[SMBFieldDescription("Other")]
		public decimal othbdg;

		/// <summary>
		/// User Def Type 6                 
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("usrcs6")]
		[SMBFieldDescription("User Def Type 6")]
		public decimal usrcs6;

		/// <summary>
		/// User Def Type 7                 
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("usrcs7")]
		[SMBFieldDescription("User Def Type 7")]
		public decimal usrcs7;

		/// <summary>
		/// User Def Type 8                 
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("usrcs8")]
		[SMBFieldDescription("User Def Type 8")]
		public decimal usrcs8;

		/// <summary>
		/// User Def Type 9                 
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("usrcs9")]
		[SMBFieldDescription("User Def Type 9")]
		public decimal usrcs9;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("ttlbdg")]
		[SMBFieldDescription("Total")]
		public decimal ttlbdg;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("estunt")]
		[SMBFieldDescription("Quantity")]
		public decimal estunt;

		/// <summary>
		/// Unit Cost                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("untcst")]
		[SMBFieldDescription("Unit Cost")]
		public decimal untcst;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Orig Hours                      
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("hrsorg")]
		[SMBFieldDescription("Orig Hours")]
		public decimal hrsorg;

		/// <summary>
		/// Orig Material                   
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("matorg")]
		[SMBFieldDescription("Orig Material")]
		public decimal matorg;

		/// <summary>
		/// Orig Labor                      
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("laborg")]
		[SMBFieldDescription("Orig Labor")]
		public decimal laborg;

		/// <summary>
		/// Orig Equipment                  
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("eqporg")]
		[SMBFieldDescription("Orig Equipment")]
		public decimal eqporg;

		/// <summary>
		/// Orig Subcontract                
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("suborg")]
		[SMBFieldDescription("Orig Subcontract")]
		public decimal suborg;

		/// <summary>
		/// Orig Other                      
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("othorg")]
		[SMBFieldDescription("Orig Other")]
		public decimal othorg;

		/// <summary>
		/// Orig User Def Type 6            
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("cs6org")]
		[SMBFieldDescription("Orig User Def Type 6")]
		public decimal cs6org;

		/// <summary>
		/// Orig User Def Type 7            
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("cs7org")]
		[SMBFieldDescription("Orig User Def Type 7")]
		public decimal cs7org;

		/// <summary>
		/// Orig User Def Type 8            
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("cs8org")]
		[SMBFieldDescription("Orig User Def Type 8")]
		public decimal cs8org;

		/// <summary>
		/// Orig User Def Type 9            
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("cs9org")]
		[SMBFieldDescription("Orig User Def Type 9")]
		public decimal cs9org;

		/// <summary>
		/// Orig Total                      
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("ttlorg")]
		[SMBFieldDescription("Orig Total")]
		public decimal ttlorg;

		/// <summary>
		/// Orig Quantity                   
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("euntor")]
		[SMBFieldDescription("Orig Quantity")]
		public decimal euntor;

		/// <summary>
		/// Org Unit Cost                   
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("ucstor")]
		[SMBFieldDescription("Org Unit Cost")]
		public decimal ucstor;

	}
}