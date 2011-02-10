using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class dlypyr : smbtable {
		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("paydte")]
		[SMBFieldDescription("Date")]
		public DateTime paydte;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Employee                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Service Order#                  
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Service Order#")]
		public string wrkord;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Equip Repaired                  
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equip Repaired")]
		public long eqpnum;

		/// <summary>
		/// Locality                        
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("loctax")]
		[SMBFieldDescription("Locality")]
		public long loctax;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Pay Type                        
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public long paytyp;

		/// <summary>
		/// Paygroup                        
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public long paygrp;

		/// <summary>
		/// Pay Rate                        
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("payrte")]
		[SMBFieldDescription("Pay Rate")]
		public decimal payrte;

		/// <summary>
		/// Hours                           
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("payhrs")]
		[SMBFieldDescription("Hours")]
		public decimal payhrs;

		/// <summary>
		/// Piece Rate                      
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Rate")]
		public decimal pcerte;

		/// <summary>
		/// Pieces                          
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("pieces")]
		[SMBFieldDescription("Pieces")]
		public decimal pieces;

		/// <summary>
		/// Comp Code                       
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("cmpcde")]
		[SMBFieldDescription("Comp Code")]
		public long cmpcde;

		/// <summary>
		/// Department                      
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Oper Equipment                  
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("opreqp")]
		[SMBFieldDescription("Oper Equipment")]
		public long opreqp;

		/// <summary>
		/// Cost Unit                       
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Cost Unit")]
		public long eqpunt;

		/// <summary>
		/// Operated                        
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("oprhrs")]
		[SMBFieldDescription("Operated")]
		public decimal oprhrs;

		/// <summary>
		/// Standby                         
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("stdhrs")]
		[SMBFieldDescription("Standby")]
		public decimal stdhrs;

		/// <summary>
		/// Idle                            
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("idlhrs")]
		[SMBFieldDescription("Idle")]
		public decimal idlhrs;

		/// <summary>
		/// Rental Unit                     
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("bllunt")]
		[SMBFieldDescription("Rental Unit")]
		public long bllunt;

		/// <summary>
		/// Operated Rental                 
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("oprbll")]
		[SMBFieldDescription("Operated Rental")]
		public decimal oprbll;

		/// <summary>
		/// Standby Rental                  
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("stdbll")]
		[SMBFieldDescription("Standby Rental")]
		public decimal stdbll;

		/// <summary>
		/// Idle Rental                     
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("idlbll")]
		[SMBFieldDescription("Idle Rental")]
		public decimal idlbll;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Absence                         
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("absnce")]
		[SMBFieldDescription("Absence")]
		public long absnce;

	}
}