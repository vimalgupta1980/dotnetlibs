using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srvcnt : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Contract#                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("connum")]
		[SMBFieldDescription("Contract#")]
		public string connum;

		/// <summary>
		/// Client                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Start Date                      
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		/// <summary>
		/// Expiration                      
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("expdte")]
		[SMBFieldDescription("Expiration")]
		public DateTime expdte;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("contyp")]
		[SMBFieldDescription("Type")]
		public long contyp;

		/// <summary>
		/// Amount                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("conamt")]
		[SMBFieldDescription("Amount")]
		public decimal conamt;

		/// <summary>
		/// Contract Coverage               
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("disply")]
		[SMBFieldDescription("Contract Coverage")]
		public long disply;

		/// <summary>
		/// Entered Date                    
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered Date")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}