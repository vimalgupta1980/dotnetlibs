using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srcneq : smbtable {
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
		/// Equipment                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Location                        
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

	}
}