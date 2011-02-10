using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class tnmtln : smbtable {
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
		/// Item                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Item")]
		public string itmnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("linqty")]
		[SMBFieldDescription("Quantity")]
		public long linqty;

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