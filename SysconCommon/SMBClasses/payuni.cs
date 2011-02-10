using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class payuni : smbtable {
		/// <summary>
		/// Union#                          
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Union#")]
		public long recnum;

		/// <summary>
		/// Union Name                      
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("uninme")]
		[SMBFieldDescription("Union Name")]
		public string uninme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

	}
}