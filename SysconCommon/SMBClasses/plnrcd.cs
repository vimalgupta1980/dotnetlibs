using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class plnrcd : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Plan#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("plnnum")]
		[SMBFieldDescription("Plan#")]
		public string plnnum;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Division                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

		/// <summary>
		/// Architect                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Architect")]
		public long vndnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("orgdte")]
		[SMBFieldDescription("Date")]
		public DateTime orgdte;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Entered Date                    
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered Date")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}