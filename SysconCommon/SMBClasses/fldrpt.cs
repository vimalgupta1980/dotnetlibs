using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class fldrpt : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("rptdte")]
		[SMBFieldDescription("Date")]
		public DateTime rptdte;

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
		/// Description                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Reported by                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Reported by")]
		public long empnum;

		/// <summary>
		/// Weather                         
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("wthcon")]
		[SMBFieldDescription("Weather")]
		public string wthcon;

		/// <summary>
		/// Temperature                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("tmptur")]
		[SMBFieldDescription("Temperature")]
		public string tmptur;

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
		/// Entered                         
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}