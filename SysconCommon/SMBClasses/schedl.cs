using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class schedl : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("schphs")]
		[SMBFieldDescription("Phase")]
		public long schphs;

		/// <summary>
		/// Edit Date                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edit Date")]
		public DateTime edtdte;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// First Date                      
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("strdte")]
		[SMBFieldDescription("First Date")]
		public DateTime strdte;

		/// <summary>
		/// Last Date                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("findte")]
		[SMBFieldDescription("Last Date")]
		public DateTime findte;

		/// <summary>
		/// Check Boxes                     
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("chkbox")]
		[SMBFieldDescription("Check Boxes")]
		public string chkbox;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Work Days                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("wrkdys")]
		[SMBFieldDescription("Work Days")]
		public long wrkdys;

		/// <summary>
		/// Calendar Days                   
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("caldys")]
		[SMBFieldDescription("Calendar Days")]
		public long caldys;

	}
}