using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class glbvar : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Variable Name                   
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("abvnme")]
		[SMBFieldDescription("Variable Name")]
		public string abvnme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Value                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("glbval")]
		[SMBFieldDescription("Value")]
		public decimal glbval;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}