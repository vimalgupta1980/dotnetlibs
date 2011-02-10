using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class emplic : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee#")]
		public long empnum;

		/// <summary>
		/// License Type                    
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("typnum")]
		[SMBFieldDescription("License Type")]
		public long typnum;

		/// <summary>
		/// License#                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		/// <summary>
		/// Exp. Date                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("expdte")]
		[SMBFieldDescription("Exp. Date")]
		public DateTime expdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}