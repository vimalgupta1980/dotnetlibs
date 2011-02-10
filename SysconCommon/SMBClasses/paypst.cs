using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class paypst : smbtable {
		/// <summary>
		/// Position#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Position#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("pstnme")]
		[SMBFieldDescription("Description")]
		public string pstnme;

		/// <summary>
		/// Job Wages                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("jobact")]
		[SMBFieldDescription("Job Wages")]
		public long jobact;

		/// <summary>
		/// Equip/Shop Wages                
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("eqpact")]
		[SMBFieldDescription("Equip/Shop Wages")]
		public long eqpact;

		/// <summary>
		/// Other Wages                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("othact")]
		[SMBFieldDescription("Other Wages")]
		public long othact;

		/// <summary>
		/// Department                      
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}