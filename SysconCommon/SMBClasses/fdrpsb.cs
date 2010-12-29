using System;

namespace SMB.Tables {
	public class fdrpsb : smbtable {
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
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Arrival Time                    
		/// </summary>
		[SMBFieldName("arvtim")]
		[SMBFieldDescription("Arrival Time")]
		public DateTime arvtim;

		/// <summary>
		/// Leave Time                      
		/// </summary>
		[SMBFieldName("levtim")]
		[SMBFieldDescription("Leave Time")]
		public DateTime levtim;

		/// <summary>
		/// Emp Count                       
		/// </summary>
		[SMBFieldName("numemp")]
		[SMBFieldDescription("Emp Count")]
		public long numemp;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

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