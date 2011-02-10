using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class rqifat : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Document                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("docnme")]
		[SMBFieldDescription("Document")]
		public string docnme;

		/// <summary>
		/// Copies                          
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("copies")]
		[SMBFieldDescription("Copies")]
		public long copies;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}