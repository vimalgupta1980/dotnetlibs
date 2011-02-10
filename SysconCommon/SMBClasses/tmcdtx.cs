using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class tmcdtx : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Site Locale                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("locale")]
		[SMBFieldDescription("Site Locale")]
		public long locale;

		/// <summary>
		/// Site Wages                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("wgettl")]
		[SMBFieldDescription("Site Wages")]
		public decimal wgettl;

		/// <summary>
		/// Site Tax Rate                   
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("locrte")]
		[SMBFieldDescription("Site Tax Rate")]
		public decimal locrte;

		/// <summary>
		/// Site Tax                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("loctax")]
		[SMBFieldDescription("Site Tax")]
		public decimal loctax;

		/// <summary>
		/// Res. Locale                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("resloc")]
		[SMBFieldDescription("Res. Locale")]
		public long resloc;

		/// <summary>
		/// Res. Tax Rate                   
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("resrte")]
		[SMBFieldDescription("Res. Tax Rate")]
		public decimal resrte;

		/// <summary>
		/// Effective Rate                  
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("effrte")]
		[SMBFieldDescription("Effective Rate")]
		public decimal effrte;

		/// <summary>
		/// Res. Tax                        
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("restax")]
		[SMBFieldDescription("Res. Tax")]
		public decimal restax;

	}
}