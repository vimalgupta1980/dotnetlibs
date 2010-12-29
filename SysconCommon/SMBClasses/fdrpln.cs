using System;

namespace SMB.Tables {
	public class fdrpln : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

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
		/// Hours/Pieces                    
		/// </summary>
		[SMBFieldName("hrspce")]
		[SMBFieldDescription("Hours/Pieces")]
		public decimal hrspce;

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
		/// Absence Reason                  
		/// </summary>
		[SMBFieldName("absnce")]
		[SMBFieldDescription("Absence Reason")]
		public long absnce;

		/// <summary>
		/// Required Training               
		/// </summary>
		[SMBFieldName("reqtrn")]
		[SMBFieldDescription("Required Training")]
		public long reqtrn;

	}
}