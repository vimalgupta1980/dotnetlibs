using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class tmcdln : smbtable {
		/// <summary>
		/// Record #                        
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record #")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dtewrk")]
		[SMBFieldDescription("Date")]
		public DateTime dtewrk;

		/// <summary>
		/// Day                             
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("daywrk")]
		[SMBFieldDescription("Day")]
		public string daywrk;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Service Order#                  
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Service Order#")]
		public string wrkord;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Equip Repaired                  
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equip Repaired")]
		public long eqpnum;

		/// <summary>
		/// Locale                          
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("loctax")]
		[SMBFieldDescription("Locale")]
		public long loctax;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Pay Type                        
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public long paytyp;

		/// <summary>
		/// Paygroup                        
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public long paygrp;

		/// <summary>
		/// Pay Rate                        
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("payrte")]
		[SMBFieldDescription("Pay Rate")]
		public decimal payrte;

		/// <summary>
		/// Hours                           
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("hrswrk")]
		[SMBFieldDescription("Hours")]
		public decimal hrswrk;

		/// <summary>
		/// Piece Rate                      
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Rate")]
		public decimal pcerte;

		/// <summary>
		/// Pieces                          
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("pieces")]
		[SMBFieldDescription("Pieces")]
		public decimal pieces;

		/// <summary>
		/// Comp Code                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("cmpcde")]
		[SMBFieldDescription("Comp Code")]
		public long cmpcde;

		/// <summary>
		/// Department                      
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Job Cost                        
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("jobcst")]
		[SMBFieldDescription("Job Cost")]
		public decimal jobcst;

		/// <summary>
		/// Sub Rate                        
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("cmpsub")]
		[SMBFieldDescription("Sub Rate")]
		public decimal cmpsub;

		/// <summary>
		/// Sub Benefit                     
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("bensub")]
		[SMBFieldDescription("Sub Benefit")]
		public decimal bensub;

		/// <summary>
		/// Comp Wage                       
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("cmpwge")]
		[SMBFieldDescription("Comp Wage")]
		public decimal cmpwge;

		/// <summary>
		/// Comp Gross                      
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("cmpgrs")]
		[SMBFieldDescription("Comp Gross")]
		public decimal cmpgrs;

		/// <summary>
		/// Absence                         
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("absnce")]
		[SMBFieldDescription("Absence")]
		public long absnce;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}