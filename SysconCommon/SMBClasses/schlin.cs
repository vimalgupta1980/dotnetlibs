using System;

namespace SMB.Tables {
	public class schlin : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase#                          
		/// </summary>
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public long phsnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Task#                           
		/// </summary>
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("tsknme")]
		[SMBFieldDescription("Description")]
		public string tsknme;

		/// <summary>
		/// Duration                        
		/// </summary>
		[SMBFieldName("tskdur")]
		[SMBFieldDescription("Duration")]
		public long tskdur;

		/// <summary>
		/// Task Type                       
		/// </summary>
		[SMBFieldName("tsktyp")]
		[SMBFieldDescription("Task Type")]
		public long tsktyp;

		/// <summary>
		/// Fixed Date                      
		/// </summary>
		[SMBFieldName("fxddte")]
		[SMBFieldDescription("Fixed Date")]
		public DateTime fxddte;

		/// <summary>
		/// Not Before                      
		/// </summary>
		[SMBFieldName("notbfr")]
		[SMBFieldDescription("Not Before")]
		public DateTime notbfr;

		/// <summary>
		/// Not After                       
		/// </summary>
		[SMBFieldName("notaft")]
		[SMBFieldDescription("Not After")]
		public DateTime notaft;

		/// <summary>
		/// Start Date                      
		/// </summary>
		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		/// <summary>
		/// Finish Date                     
		/// </summary>
		[SMBFieldName("findte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime findte;

		/// <summary>
		/// Late Start                      
		/// </summary>
		[SMBFieldName("ltestr")]
		[SMBFieldDescription("Late Start")]
		public DateTime ltestr;

		/// <summary>
		/// Late Finish                     
		/// </summary>
		[SMBFieldName("ltefin")]
		[SMBFieldDescription("Late Finish")]
		public DateTime ltefin;

		/// <summary>
		/// Float                           
		/// </summary>
		[SMBFieldName("tskflt")]
		[SMBFieldDescription("Float")]
		public long tskflt;

		/// <summary>
		/// Original Duration               
		/// </summary>
		[SMBFieldName("orgdur")]
		[SMBFieldDescription("Original Duration")]
		public long orgdur;

		/// <summary>
		/// Original Start                  
		/// </summary>
		[SMBFieldName("orgstr")]
		[SMBFieldDescription("Original Start")]
		public DateTime orgstr;

		/// <summary>
		/// Original Finish                 
		/// </summary>
		[SMBFieldName("orgfin")]
		[SMBFieldDescription("Original Finish")]
		public DateTime orgfin;

		/// <summary>
		/// Original Float                  
		/// </summary>
		[SMBFieldName("orgflt")]
		[SMBFieldDescription("Original Float")]
		public long orgflt;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}