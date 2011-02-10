using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class brdftg : smbtable {
		/// <summary>
		/// Part Class                      
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("prtcls")]
		[SMBFieldDescription("Part Class")]
		public long prtcls;

		/// <summary>
		/// Cost/1000Bf                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("cstbdf")]
		[SMBFieldDescription("Cost/1000Bf")]
		public decimal cstbdf;

		/// <summary>
		/// Bill/1000Bf                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("bilbdf")]
		[SMBFieldDescription("Bill/1000Bf")]
		public decimal bilbdf;

	}
}