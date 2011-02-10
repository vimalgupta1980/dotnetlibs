using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class wkrcmp : smbtable {
		/// <summary>
		/// Code#                           
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Code#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("cdenme")]
		[SMBFieldDescription("Description")]
		public string cdenme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("taxste")]
		[SMBFieldDescription("State")]
		public string taxste;

		/// <summary>
		/// Employer %                      
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("pctrte")]
		[SMBFieldDescription("Employer %")]
		public decimal pctrte;

		/// <summary>
		/// Employee Hrly                   
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("emehrs")]
		[SMBFieldDescription("Employee Hrly")]
		public decimal emehrs;

		/// <summary>
		/// Employer Hrly                   
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("emrhrs")]
		[SMBFieldDescription("Employer Hrly")]
		public decimal emrhrs;

		/// <summary>
		/// Liability                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("libins")]
		[SMBFieldDescription("Liability")]
		public decimal libins;

		/// <summary>
		/// Exper Mod                       
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("expmod")]
		[SMBFieldDescription("Exper Mod")]
		public decimal expmod;

		/// <summary>
		/// Add Exper Mod                   
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("addmod")]
		[SMBFieldDescription("Add Exper Mod")]
		public decimal addmod;

		/// <summary>
		/// Maximum Wage                    
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("maxwge")]
		[SMBFieldDescription("Maximum Wage")]
		public decimal maxwge;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}