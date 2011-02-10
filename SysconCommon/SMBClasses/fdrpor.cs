using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class fdrpor : smbtable {
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
		/// Order#                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("ordnum")]
		[SMBFieldDescription("Order#")]
		public string ordnum;

		/// <summary>
		/// Order Type                      
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("ordtyp")]
		[SMBFieldDescription("Order Type")]
		public string ordtyp;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}