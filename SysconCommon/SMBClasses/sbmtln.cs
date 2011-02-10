using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class sbmtln : smbtable {
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
		/// Action Required                 
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("actreq")]
		[SMBFieldDescription("Action Required")]
		public string actreq;

		/// <summary>
		/// Date Required                   
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("reqdte")]
		[SMBFieldDescription("Date Required")]
		public DateTime reqdte;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("sbmsts")]
		[SMBFieldDescription("Status")]
		public long sbmsts;

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