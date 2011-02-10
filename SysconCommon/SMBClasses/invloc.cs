using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class invloc : smbtable {
		/// <summary>
		/// Inv. Location#                  
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Inv. Location#")]
		public long recnum;

		/// <summary>
		/// Location Name                   
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("locnme")]
		[SMBFieldDescription("Location Name")]
		public string locnme;

		/// <summary>
		/// Employee                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

	}
}