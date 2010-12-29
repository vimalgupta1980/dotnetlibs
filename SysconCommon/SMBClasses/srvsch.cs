using System;

namespace SMB.Tables {
	public class srvsch : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Employee                        
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Priority                        
		/// </summary>
		[SMBFieldName("priort")]
		[SMBFieldDescription("Priority")]
		public long priort;

		/// <summary>
		/// Sched. Date                     
		/// </summary>
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Sched. Date")]
		public DateTime schdte;

		/// <summary>
		/// Sched. Start                    
		/// </summary>
		[SMBFieldName("schstr")]
		[SMBFieldDescription("Sched. Start")]
		public DateTime schstr;

		/// <summary>
		/// Sched. Finish                   
		/// </summary>
		[SMBFieldName("schfin")]
		[SMBFieldDescription("Sched. Finish")]
		public DateTime schfin;

		/// <summary>
		/// Sched. Hours                    
		/// </summary>
		[SMBFieldName("esthrs")]
		[SMBFieldDescription("Sched. Hours")]
		public decimal esthrs;

		/// <summary>
		/// Travel Time                     
		/// </summary>
		[SMBFieldName("tvltim")]
		[SMBFieldDescription("Travel Time")]
		public string tvltim;

		/// <summary>
		/// Completed Date                  
		/// </summary>
		[SMBFieldName("findte")]
		[SMBFieldDescription("Completed Date")]
		public DateTime findte;

		/// <summary>
		/// Actual Start                    
		/// </summary>
		[SMBFieldName("actstr")]
		[SMBFieldDescription("Actual Start")]
		public DateTime actstr;

		/// <summary>
		/// Actual Finish                   
		/// </summary>
		[SMBFieldName("actfin")]
		[SMBFieldDescription("Actual Finish")]
		public DateTime actfin;

		/// <summary>
		/// Actual Hours                    
		/// </summary>
		[SMBFieldName("acthrs")]
		[SMBFieldDescription("Actual Hours")]
		public decimal acthrs;

		/// <summary>
		/// Billed Date                     
		/// </summary>
		[SMBFieldName("bildte")]
		[SMBFieldDescription("Billed Date")]
		public DateTime bildte;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

	}
}