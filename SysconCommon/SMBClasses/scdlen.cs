using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class scdlen : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Prelien#                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("lennum")]
		[SMBFieldDescription("Prelien#")]
		public string lennum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Second Vendor                   
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("scdvnd")]
		[SMBFieldDescription("Second Vendor")]
		public long scdvnd;

		/// <summary>
		/// Date Rcvd                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dtercd")]
		[SMBFieldDescription("Date Rcvd")]
		public DateTime dtercd;

		/// <summary>
		/// First Date                      
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("fstdte")]
		[SMBFieldDescription("First Date")]
		public DateTime fstdte;

		/// <summary>
		/// Last Date                       
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("lstdte")]
		[SMBFieldDescription("Last Date")]
		public DateTime lstdte;

		/// <summary>
		/// Final Date                      
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("findte")]
		[SMBFieldDescription("Final Date")]
		public DateTime findte;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}