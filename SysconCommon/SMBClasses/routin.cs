using System;

namespace SMB.Tables {
	public class routin : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("rourec")]
		[SMBFieldDescription("Record#")]
		public long rourec;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Routing Table                   
		/// </summary>
		[SMBFieldName("routbl")]
		[SMBFieldDescription("Routing Table")]
		public string routbl;

		/// <summary>
		/// Routed To                       
		/// </summary>
		[SMBFieldName("routto")]
		[SMBFieldDescription("Routed To")]
		public string routto;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Date Sent                       
		/// </summary>
		[SMBFieldName("sentdt")]
		[SMBFieldDescription("Date Sent")]
		public DateTime sentdt;

		/// <summary>
		/// Date Needed by                  
		/// </summary>
		[SMBFieldName("needdt")]
		[SMBFieldDescription("Date Needed by")]
		public DateTime needdt;

		/// <summary>
		/// Date Returned                   
		/// </summary>
		[SMBFieldName("retdte")]
		[SMBFieldDescription("Date Returned")]
		public DateTime retdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}