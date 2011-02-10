using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class vndprc : smbtable {
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
		/// Preference#                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("vndprf")]
		[SMBFieldDescription("Preference#")]
		public long vndprf;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Order#                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("vndord")]
		[SMBFieldDescription("Order#")]
		public string vndord;

		/// <summary>
		/// Disc. Rate                      
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("vnddsc")]
		[SMBFieldDescription("Disc. Rate")]
		public decimal vnddsc;

		/// <summary>
		/// Price                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("vndprc")]
		[SMBFieldDescription("Price")]
		public decimal _vndprc;

		/// <summary>
		/// Last Update                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("lstupd")]
		[SMBFieldDescription("Last Update")]
		public DateTime lstupd;

	}
}