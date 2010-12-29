using System;

namespace SMB.Tables {
	public class schsub : smbtable {
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
		/// Task#                           
		/// </summary>
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		/// <summary>
		/// Subcontractor                   
		/// </summary>
		[SMBFieldName("subnum")]
		[SMBFieldDescription("Subcontractor")]
		public long subnum;

		/// <summary>
		/// Start Time                      
		/// </summary>
		[SMBFieldName("strtme")]
		[SMBFieldDescription("Start Time")]
		public DateTime strtme;

		/// <summary>
		/// End Time                        
		/// </summary>
		[SMBFieldName("endtme")]
		[SMBFieldDescription("End Time")]
		public DateTime endtme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}