using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srvsch : smbtable {
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
		/// Employee                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Priority                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("priort")]
		[SMBFieldDescription("Priority")]
		public long priort;

		/// <summary>
		/// Sched. Date                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Sched. Date")]
		public DateTime schdte;

		/// <summary>
		/// Sched. Start                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("schstr")]
		[SMBFieldDescription("Sched. Start")]
		public DateTime schstr;

		/// <summary>
		/// Sched. Finish                   
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("schfin")]
		[SMBFieldDescription("Sched. Finish")]
		public DateTime schfin;

		/// <summary>
		/// Sched. Hours                    
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("esthrs")]
		[SMBFieldDescription("Sched. Hours")]
		public decimal esthrs;

		/// <summary>
		/// Travel Time                     
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("tvltim")]
		[SMBFieldDescription("Travel Time")]
		public string tvltim;

		/// <summary>
		/// Completed Date                  
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("findte")]
		[SMBFieldDescription("Completed Date")]
		public DateTime findte;

		/// <summary>
		/// Actual Start                    
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("actstr")]
		[SMBFieldDescription("Actual Start")]
		public DateTime actstr;

		/// <summary>
		/// Actual Finish                   
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("actfin")]
		[SMBFieldDescription("Actual Finish")]
		public DateTime actfin;

		/// <summary>
		/// Actual Hours                    
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("acthrs")]
		[SMBFieldDescription("Actual Hours")]
		public decimal acthrs;

		/// <summary>
		/// Billed Date                     
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("bildte")]
		[SMBFieldDescription("Billed Date")]
		public DateTime bildte;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

	}
}