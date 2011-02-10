using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class attdtl : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Attachment File/Link            
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("target")]
		[SMBFieldDescription("Attachment File/Link")]
		public string target;

		/// <summary>
		/// Description of Attachment       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description of Attachment")]
		public string dscrpt;

		/// <summary>
		/// User Who Added Attachment       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("attusr")]
		[SMBFieldDescription("User Who Added Attachment")]
		public string attusr;

		/// <summary>
		/// Date Attachment Was Added       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("attdte")]
		[SMBFieldDescription("Date Attachment Was Added")]
		public DateTime attdte;

	}
}