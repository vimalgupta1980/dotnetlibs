using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class taxdst : smbtable {
		/// <summary>
		/// District#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("District#")]
		public long recnum;

		/// <summary>
		/// District Name                   
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dstnme")]
		[SMBFieldDescription("District Name")]
		public string dstnme;

		/// <summary>
		/// Tax Entity 1                    
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("entty1")]
		[SMBFieldDescription("Tax Entity 1")]
		public long entty1;

		/// <summary>
		/// Tax Entity 2                    
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("entty2")]
		[SMBFieldDescription("Tax Entity 2")]
		public long entty2;

		/// <summary>
		/// Tax Entity 3                    
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("entty3")]
		[SMBFieldDescription("Tax Entity 3")]
		public long entty3;

		/// <summary>
		/// Tax Entity 4                    
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("entty4")]
		[SMBFieldDescription("Tax Entity 4")]
		public long entty4;

		/// <summary>
		/// Tax Entity 5                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("entty5")]
		[SMBFieldDescription("Tax Entity 5")]
		public long entty5;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}