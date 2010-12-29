using System;

namespace SMB.Tables {
	public class plnrcv : smbtable {
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
		/// Subcontractor                   
		/// </summary>
		[SMBFieldName("vendor")]
		[SMBFieldDescription("Subcontractor")]
		public long vendor;

		/// <summary>
		/// Contact                         
		/// </summary>
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

		/// <summary>
		/// Copies                          
		/// </summary>
		[SMBFieldName("numcpy")]
		[SMBFieldDescription("Copies")]
		public long numcpy;

		/// <summary>
		/// Date Sent                       
		/// </summary>
		[SMBFieldName("dtegiv")]
		[SMBFieldDescription("Date Sent")]
		public DateTime dtegiv;

		/// <summary>
		/// Deposit                         
		/// </summary>
		[SMBFieldName("depamt")]
		[SMBFieldDescription("Deposit")]
		public decimal depamt;

		/// <summary>
		/// Date Returned                   
		/// </summary>
		[SMBFieldName("dtertn")]
		[SMBFieldDescription("Date Returned")]
		public DateTime dtertn;

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