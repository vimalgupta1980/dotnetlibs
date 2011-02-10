using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class prplin : smbtable {
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
		/// Bid Item                        
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Bid Item")]
		public long itmnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Material                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("matprp")]
		[SMBFieldDescription("Material")]
		public decimal matprp;

		/// <summary>
		/// Labor                           
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("labprp")]
		[SMBFieldDescription("Labor")]
		public decimal labprp;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("eqpprp")]
		[SMBFieldDescription("Equipment")]
		public decimal eqpprp;

		/// <summary>
		/// Subcontract                     
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("subprp")]
		[SMBFieldDescription("Subcontract")]
		public decimal subprp;

		/// <summary>
		/// Other                           
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("othprp")]
		[SMBFieldDescription("Other")]
		public decimal othprp;

		/// <summary>
		/// User Def Type 6                 
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("usrcs6")]
		[SMBFieldDescription("User Def Type 6")]
		public decimal usrcs6;

		/// <summary>
		/// User Def Type 7                 
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("usrcs7")]
		[SMBFieldDescription("User Def Type 7")]
		public decimal usrcs7;

		/// <summary>
		/// User Def Type 8                 
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("usrcs8")]
		[SMBFieldDescription("User Def Type 8")]
		public decimal usrcs8;

		/// <summary>
		/// User Def Type 9                 
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("usrcs9")]
		[SMBFieldDescription("User Def Type 9")]
		public decimal usrcs9;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("ttlprp")]
		[SMBFieldDescription("Total")]
		public decimal ttlprp;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Orig Material                   
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("matorg")]
		[SMBFieldDescription("Orig Material")]
		public decimal matorg;

		/// <summary>
		/// Orig Labor                      
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("laborg")]
		[SMBFieldDescription("Orig Labor")]
		public decimal laborg;

		/// <summary>
		/// Orig Equipment                  
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("eqporg")]
		[SMBFieldDescription("Orig Equipment")]
		public decimal eqporg;

		/// <summary>
		/// Orig Subcontract                
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("suborg")]
		[SMBFieldDescription("Orig Subcontract")]
		public decimal suborg;

		/// <summary>
		/// Orig Other                      
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("othorg")]
		[SMBFieldDescription("Orig Other")]
		public decimal othorg;

		/// <summary>
		/// Orig User Def Type 6            
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("cs6org")]
		[SMBFieldDescription("Orig User Def Type 6")]
		public decimal cs6org;

		/// <summary>
		/// Orig User Def Type 7            
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("cs7org")]
		[SMBFieldDescription("Orig User Def Type 7")]
		public decimal cs7org;

		/// <summary>
		/// Orig User Def Type 8            
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("cs8org")]
		[SMBFieldDescription("Orig User Def Type 8")]
		public decimal cs8org;

		/// <summary>
		/// Orig User Def Type 9            
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("cs9org")]
		[SMBFieldDescription("Orig User Def Type 9")]
		public decimal cs9org;

		/// <summary>
		/// Orig Total                      
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("ttlorg")]
		[SMBFieldDescription("Orig Total")]
		public decimal ttlorg;

	}
}