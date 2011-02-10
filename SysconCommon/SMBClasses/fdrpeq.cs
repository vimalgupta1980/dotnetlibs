using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class fdrpeq : smbtable {
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
		/// Equipment                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public long eqpunt;

		/// <summary>
		/// Operated                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("oprtim")]
		[SMBFieldDescription("Operated")]
		public decimal oprtim;

		/// <summary>
		/// Standby                         
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("stdtim")]
		[SMBFieldDescription("Standby")]
		public decimal stdtim;

		/// <summary>
		/// Idle                            
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("idltim")]
		[SMBFieldDescription("Idle")]
		public decimal idltim;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}