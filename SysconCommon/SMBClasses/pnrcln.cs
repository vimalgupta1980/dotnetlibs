using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class pnrcln : smbtable {
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
		/// Revised                         
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("revdte")]
		[SMBFieldDescription("Revised")]
		public DateTime revdte;

		/// <summary>
		/// Reference                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("refnum")]
		[SMBFieldDescription("Reference")]
		public string refnum;

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