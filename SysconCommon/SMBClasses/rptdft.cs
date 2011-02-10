using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class rptdft : smbtable {
		/// <summary>
		/// Report Name                     
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("rptnme")]
		[SMBFieldDescription("Report Name")]
		public string rptnme;

		/// <summary>
		/// Default Data                    
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dftdta")]
		[SMBFieldDescription("Default Data")]
		public string dftdta;

	}
}