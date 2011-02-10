using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class routin : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("rourec")]
		[SMBFieldDescription("Record#")]
		public long rourec;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Routing Table                   
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("routbl")]
		[SMBFieldDescription("Routing Table")]
		public string routbl;

		/// <summary>
		/// Routed To                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("routto")]
		[SMBFieldDescription("Routed To")]
		public string routto;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Date Sent                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("sentdt")]
		[SMBFieldDescription("Date Sent")]
		public DateTime sentdt;

		/// <summary>
		/// Date Needed by                  
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("needdt")]
		[SMBFieldDescription("Date Needed by")]
		public DateTime needdt;

		/// <summary>
		/// Date Returned                   
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("retdte")]
		[SMBFieldDescription("Date Returned")]
		public DateTime retdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}