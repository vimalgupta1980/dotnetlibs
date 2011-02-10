using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class vndrmt : smbtable {
		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor")]
		public long recnum;

		/// <summary>
		/// Payee                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("rmtnme")]
		[SMBFieldDescription("Payee")]
		public string rmtnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("rmtad1")]
		[SMBFieldDescription("Address 1")]
		public string rmtad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("rmtad2")]
		[SMBFieldDescription("Address 2")]
		public string rmtad2;

		/// <summary>
		/// City/State                      
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("rmtcty")]
		[SMBFieldDescription("City/State")]
		public string rmtcty;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("rmtzip")]
		[SMBFieldDescription("Zip")]
		public string rmtzip;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}