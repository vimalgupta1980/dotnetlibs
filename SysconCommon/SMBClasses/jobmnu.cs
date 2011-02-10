using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class jobmnu : smbtable {
		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("userid")]
		[SMBFieldDescription("User Name")]
		public string userid;

		/// <summary>
		/// First Level Menu Number         
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("menu1")]
		[SMBFieldDescription("First Level Menu Number")]
		public long menu1 ;

		/// <summary>
		/// Second Level Menu Number        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("menu2")]
		[SMBFieldDescription("Second Level Menu Number")]
		public long menu2 ;

		/// <summary>
		/// Third Level Menu Number         
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("menu3")]
		[SMBFieldDescription("Third Level Menu Number")]
		public long menu3 ;

		/// <summary>
		/// Menu Description                
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("mnudsc")]
		[SMBFieldDescription("Menu Description")]
		public string mnudsc;

	}
}