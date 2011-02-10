using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class sbcnln : smbtable {
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
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Original Contract               
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("amount")]
		[SMBFieldDescription("Original Contract")]
		public decimal amount;

		/// <summary>
		/// Changes                         
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("change")]
		[SMBFieldDescription("Changes")]
		public decimal change;

		/// <summary>
		/// New Contract                    
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("cntrct")]
		[SMBFieldDescription("New Contract")]
		public decimal cntrct;

		/// <summary>
		/// Invoiced                        
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("billed")]
		[SMBFieldDescription("Invoiced")]
		public decimal billed;

		/// <summary>
		/// Remaining                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("remain")]
		[SMBFieldDescription("Remaining")]
		public decimal remain;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Subcontract Line Reference #    
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("linref")]
		[SMBFieldDescription("Subcontract Line Reference #")]
		public string linref;

	}
}