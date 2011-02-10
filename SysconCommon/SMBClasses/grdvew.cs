using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class grdvew : smbtable {
		/// <summary>
		/// Grid View Option/User           
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("vewnme")]
		[SMBFieldDescription("Grid View Option/User")]
		public string vewnme;

		/// <summary>
		/// Grid View Data                  
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("vewdta")]
		[SMBFieldDescription("Grid View Data")]
		public string vewdta;

		/// <summary>
		/// OMware Lock                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("omwlck")]
		[SMBFieldDescription("OMware Lock")]
		public long omwlck;

	}
}