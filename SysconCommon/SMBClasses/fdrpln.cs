using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class fdrpln : smbtable {
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
		/// Employee                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Pay Type                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public long paytyp;

		/// <summary>
		/// Paygroup                        
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public long paygrp;

		/// <summary>
		/// Hours/Pieces                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("hrspce")]
		[SMBFieldDescription("Hours/Pieces")]
		public decimal hrspce;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Absence Reason                  
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("absnce")]
		[SMBFieldDescription("Absence Reason")]
		public long absnce;

		/// <summary>
		/// Required Training               
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("reqtrn")]
		[SMBFieldDescription("Required Training")]
		public long reqtrn;

	}
}