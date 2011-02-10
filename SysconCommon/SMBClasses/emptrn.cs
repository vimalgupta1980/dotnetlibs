using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class emptrn : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee#")]
		public long empnum;

		/// <summary>
		/// Training Type                   
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("typnum")]
		[SMBFieldDescription("Training Type")]
		public long typnum;

		/// <summary>
		/// Last Date                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("lstdte")]
		[SMBFieldDescription("Last Date")]
		public DateTime lstdte;

		/// <summary>
		/// Next Date                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("nxtdte")]
		[SMBFieldDescription("Next Date")]
		public DateTime nxtdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}