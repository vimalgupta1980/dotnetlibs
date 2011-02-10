using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srvtyp : smbtable {
		/// <summary>
		/// Invoice Type#                   
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Invoice Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		/// <summary>
		/// Department                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Cash Acct                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("cshact")]
		[SMBFieldDescription("Cash Acct")]
		public long cshact;

		/// <summary>
		/// Taxable Income Acct             
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("taxinc")]
		[SMBFieldDescription("Taxable Income Acct")]
		public long taxinc;

		/// <summary>
		/// Non-Tax Income Acct             
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("ntxinc")]
		[SMBFieldDescription("Non-Tax Income Acct")]
		public long ntxinc;

		/// <summary>
		/// Disc Given Acct                 
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("dscgvn")]
		[SMBFieldDescription("Disc Given Acct")]
		public long dscgvn;

		/// <summary>
		/// Cost of Goods Acct              
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("invexp")]
		[SMBFieldDescription("Cost of Goods Acct")]
		public long invexp;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}