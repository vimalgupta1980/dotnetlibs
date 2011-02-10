using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srvrte : smbtable {
		/// <summary>
		/// Service Route#                  
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Service Route#")]
		public long recnum;

		/// <summary>
		/// Route Name                      
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("rtenme")]
		[SMBFieldDescription("Route Name")]
		public string rtenme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}