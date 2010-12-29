using System;

namespace SMB.Tables {
	public class tmcdln : smbtable {
		/// <summary>
		/// Record #                        
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record #")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("dtewrk")]
		[SMBFieldDescription("Date")]
		public DateTime dtewrk;

		/// <summary>
		/// Day                             
		/// </summary>
		[SMBFieldName("daywrk")]
		[SMBFieldDescription("Day")]
		public string daywrk;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Service Order#                  
		/// </summary>
		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Service Order#")]
		public string wrkord;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Equip Repaired                  
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equip Repaired")]
		public long eqpnum;

		/// <summary>
		/// Locale                          
		/// </summary>
		[SMBFieldName("loctax")]
		[SMBFieldDescription("Locale")]
		public long loctax;

		/// <summary>
		/// Phase                           
		/// </summary>
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Pay Type                        
		/// </summary>
		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public long paytyp;

		/// <summary>
		/// Paygroup                        
		/// </summary>
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public long paygrp;

		/// <summary>
		/// Pay Rate                        
		/// </summary>
		[SMBFieldName("payrte")]
		[SMBFieldDescription("Pay Rate")]
		public decimal payrte;

		/// <summary>
		/// Hours                           
		/// </summary>
		[SMBFieldName("hrswrk")]
		[SMBFieldDescription("Hours")]
		public decimal hrswrk;

		/// <summary>
		/// Piece Rate                      
		/// </summary>
		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Rate")]
		public decimal pcerte;

		/// <summary>
		/// Pieces                          
		/// </summary>
		[SMBFieldName("pieces")]
		[SMBFieldDescription("Pieces")]
		public decimal pieces;

		/// <summary>
		/// Comp Code                       
		/// </summary>
		[SMBFieldName("cmpcde")]
		[SMBFieldDescription("Comp Code")]
		public long cmpcde;

		/// <summary>
		/// Department                      
		/// </summary>
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Job Cost                        
		/// </summary>
		[SMBFieldName("jobcst")]
		[SMBFieldDescription("Job Cost")]
		public decimal jobcst;

		/// <summary>
		/// Sub Rate                        
		/// </summary>
		[SMBFieldName("cmpsub")]
		[SMBFieldDescription("Sub Rate")]
		public decimal cmpsub;

		/// <summary>
		/// Sub Benefit                     
		/// </summary>
		[SMBFieldName("bensub")]
		[SMBFieldDescription("Sub Benefit")]
		public decimal bensub;

		/// <summary>
		/// Comp Wage                       
		/// </summary>
		[SMBFieldName("cmpwge")]
		[SMBFieldDescription("Comp Wage")]
		public decimal cmpwge;

		/// <summary>
		/// Comp Gross                      
		/// </summary>
		[SMBFieldName("cmpgrs")]
		[SMBFieldDescription("Comp Gross")]
		public decimal cmpgrs;

		/// <summary>
		/// Absence                         
		/// </summary>
		[SMBFieldName("absnce")]
		[SMBFieldDescription("Absence")]
		public long absnce;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}