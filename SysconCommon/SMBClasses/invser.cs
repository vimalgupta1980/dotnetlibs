using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class invser : smbtable {
		/// <summary>
		/// Part#                           
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Part#")]
		public long recnum;

		/// <summary>
		/// Location                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		/// <summary>
		/// Stocked Date                    
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("stkdte")]
		[SMBFieldDescription("Stocked Date")]
		public DateTime stkdte;

	}
}