using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class fdrpmt : smbtable {
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
		/// Meeting Type                    
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("mettyp")]
		[SMBFieldDescription("Meeting Type")]
		public long mettyp;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Present                         
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("presnt")]
		[SMBFieldDescription("Present")]
		public string presnt;

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