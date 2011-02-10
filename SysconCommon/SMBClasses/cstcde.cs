using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class cstcde : smbtable {
		/// <summary>
		/// Cost Code#                      
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Cost Code#")]
		public decimal recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("cdenme")]
		[SMBFieldDescription("Description")]
		public string cdenme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Division                        
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

		/// <summary>
		/// Comp Code1                      
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("cmpcde")]
		[SMBFieldDescription("Comp Code1")]
		public long cmpcde;

		/// <summary>
		/// Wage Max                        
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("maxwge")]
		[SMBFieldDescription("Wage Max")]
		public decimal maxwge;

		/// <summary>
		/// Comp Code2                      
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("cmpcd2")]
		[SMBFieldDescription("Comp Code2")]
		public long cmpcd2;

		/// <summary>
		/// Department                      
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("dptnum")]
		[SMBFieldDescription("Department")]
		public long dptnum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}