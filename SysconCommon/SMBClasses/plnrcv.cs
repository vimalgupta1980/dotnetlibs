using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class plnrcv : smbtable {
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
		/// Subcontractor                   
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("vendor")]
		[SMBFieldDescription("Subcontractor")]
		public long vendor;

		/// <summary>
		/// Contact                         
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

		/// <summary>
		/// Copies                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("numcpy")]
		[SMBFieldDescription("Copies")]
		public long numcpy;

		/// <summary>
		/// Date Sent                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dtegiv")]
		[SMBFieldDescription("Date Sent")]
		public DateTime dtegiv;

		/// <summary>
		/// Deposit                         
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("depamt")]
		[SMBFieldDescription("Deposit")]
		public decimal depamt;

		/// <summary>
		/// Date Returned                   
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("dtertn")]
		[SMBFieldDescription("Date Returned")]
		public DateTime dtertn;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}