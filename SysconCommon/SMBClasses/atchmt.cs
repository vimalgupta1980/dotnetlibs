using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class atchmt : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Attachment Owner's Table        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("tblnme")]
		[SMBFieldDescription("Attachment Owner's Table")]
		public string tblnme;

		/// <summary>
		/// Attachment Owner's Record#      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("tblrec")]
		[SMBFieldDescription("Attachment Owner's Record#")]
		public long tblrec;

		/// <summary>
		/// Owner's Parent Table            
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("prntbl")]
		[SMBFieldDescription("Owner's Parent Table")]
		public string prntbl;

		/// <summary>
		/// Owner's Parent Record#          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("prnrec")]
		[SMBFieldDescription("Owner's Parent Record#")]
		public long prnrec;

	}
}