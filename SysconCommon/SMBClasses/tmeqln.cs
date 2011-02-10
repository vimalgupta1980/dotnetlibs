using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class tmeqln : smbtable {
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
		/// Equipment Type                  
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Equipment Type")]
		public long eqptyp;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Operated                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("oprrte")]
		[SMBFieldDescription("Operated")]
		public decimal oprrte;

		/// <summary>
		/// Standby                         
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("stdrte")]
		[SMBFieldDescription("Standby")]
		public decimal stdrte;

		/// <summary>
		/// Idle                            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("idlrte")]
		[SMBFieldDescription("Idle")]
		public decimal idlrte;

		/// <summary>
		/// Minimum Hrs                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("minhrs")]
		[SMBFieldDescription("Minimum Hrs")]
		public decimal minhrs;

	}
}