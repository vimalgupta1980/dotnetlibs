using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class asmcls : smbtable {
		/// <summary>
		/// Class#                          
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Class#")]
		public long recnum;

		/// <summary>
		/// Class Name                      
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("clsnme")]
		[SMBFieldDescription("Class Name")]
		public string clsnme;

		/// <summary>
		/// Indention Level                 
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("indent")]
		[SMBFieldDescription("Indention Level")]
		public long indent;

		/// <summary>
		/// Class Parent#                   
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("parcls")]
		[SMBFieldDescription("Class Parent#")]
		public long parcls;

		/// <summary>
		/// Class Has Children              
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("haskid")]
		[SMBFieldDescription("Class Has Children")]
		public long haskid;

	}
}