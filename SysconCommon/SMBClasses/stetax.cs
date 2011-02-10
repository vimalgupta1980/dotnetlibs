using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class stetax : smbtable {
		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// State Tax Id#                   
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("stetax")]
		[SMBFieldDescription("State Tax Id#")]
		public string _stetax;

	}
}