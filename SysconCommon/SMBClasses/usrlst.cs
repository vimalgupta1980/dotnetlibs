using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class usrlst : smbtable {
		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Password                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("usrpsw")]
		[SMBFieldDescription("Password")]
		public string usrpsw;

		/// <summary>
		/// License Group                   
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("licgrp")]
		[SMBFieldDescription("License Group")]
		public string licgrp;

		/// <summary>
		/// Group 1                         
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("group1")]
		[SMBFieldDescription("Group 1")]
		public long group1;

		/// <summary>
		/// Group 2                         
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("group2")]
		[SMBFieldDescription("Group 2")]
		public long group2;

		/// <summary>
		/// Group 3                         
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("group3")]
		[SMBFieldDescription("Group 3")]
		public long group3;

		/// <summary>
		/// Group 4                         
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("group4")]
		[SMBFieldDescription("Group 4")]
		public long group4;

		/// <summary>
		/// Group 5                         
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("group5")]
		[SMBFieldDescription("Group 5")]
		public long group5;

	}
}