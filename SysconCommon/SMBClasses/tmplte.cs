using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class tmplte : smbtable {
		/// <summary>
		/// Template Name                   
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("dtanme")]
		[SMBFieldDescription("Template Name")]
		public string dtanme;

		/// <summary>
		/// Line Data                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dtalin")]
		[SMBFieldDescription("Line Data")]
		public string dtalin;

	}
}