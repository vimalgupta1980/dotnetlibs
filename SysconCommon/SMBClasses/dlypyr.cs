using System;

namespace SMB.Tables {
	public class dlypyr : smbtable {
		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("paydte")]
		[SMBFieldDescription("Date")]
		public DateTime paydte;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Employee                        
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

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
		/// Locality                        
		/// </summary>
		[SMBFieldName("loctax")]
		[SMBFieldDescription("Locality")]
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
		[SMBFieldName("payhrs")]
		[SMBFieldDescription("Hours")]
		public decimal payhrs;

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
		/// Oper Equipment                  
		/// </summary>
		[SMBFieldName("opreqp")]
		[SMBFieldDescription("Oper Equipment")]
		public long opreqp;

		/// <summary>
		/// Cost Unit                       
		/// </summary>
		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Cost Unit")]
		public long eqpunt;

		/// <summary>
		/// Operated                        
		/// </summary>
		[SMBFieldName("oprhrs")]
		[SMBFieldDescription("Operated")]
		public decimal oprhrs;

		/// <summary>
		/// Standby                         
		/// </summary>
		[SMBFieldName("stdhrs")]
		[SMBFieldDescription("Standby")]
		public decimal stdhrs;

		/// <summary>
		/// Idle                            
		/// </summary>
		[SMBFieldName("idlhrs")]
		[SMBFieldDescription("Idle")]
		public decimal idlhrs;

		/// <summary>
		/// Rental Unit                     
		/// </summary>
		[SMBFieldName("bllunt")]
		[SMBFieldDescription("Rental Unit")]
		public long bllunt;

		/// <summary>
		/// Operated Rental                 
		/// </summary>
		[SMBFieldName("oprbll")]
		[SMBFieldDescription("Operated Rental")]
		public decimal oprbll;

		/// <summary>
		/// Standby Rental                  
		/// </summary>
		[SMBFieldName("stdbll")]
		[SMBFieldDescription("Standby Rental")]
		public decimal stdbll;

		/// <summary>
		/// Idle Rental                     
		/// </summary>
		[SMBFieldName("idlbll")]
		[SMBFieldDescription("Idle Rental")]
		public decimal idlbll;

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

		/// <summary>
		/// Absence                         
		/// </summary>
		[SMBFieldName("absnce")]
		[SMBFieldDescription("Absence")]
		public long absnce;

	}
}