using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class glbclc : smbtable {
		/// <summary>
		/// Name                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("clcnme")]
		[SMBFieldDescription("Name")]
		public string clcnme;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("clcdsc")]
		[SMBFieldDescription("Description")]
		public string clcdsc;

		/// <summary>
		/// Expression                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("clcexp")]
		[SMBFieldDescription("Expression")]
		public string clcexp;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// OMware Lock                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("omwlck")]
		[SMBFieldDescription("OMware Lock")]
		public long omwlck;

	}
}