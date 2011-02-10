using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class fdrpsb : smbtable {
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
		/// Vendor                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Arrival Time                    
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("arvtim")]
		[SMBFieldDescription("Arrival Time")]
		public DateTime arvtim;

		/// <summary>
		/// Leave Time                      
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("levtim")]
		[SMBFieldDescription("Leave Time")]
		public DateTime levtim;

		/// <summary>
		/// Emp Count                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("numemp")]
		[SMBFieldDescription("Emp Count")]
		public long numemp;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}