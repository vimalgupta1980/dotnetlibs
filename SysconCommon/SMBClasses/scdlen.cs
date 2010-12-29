using System;

namespace SMB.Tables {
	public class scdlen : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Prelien#                        
		/// </summary>
		[SMBFieldName("lennum")]
		[SMBFieldDescription("Prelien#")]
		public string lennum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Second Vendor                   
		/// </summary>
		[SMBFieldName("scdvnd")]
		[SMBFieldDescription("Second Vendor")]
		public long scdvnd;

		/// <summary>
		/// Date Rcvd                       
		/// </summary>
		[SMBFieldName("dtercd")]
		[SMBFieldDescription("Date Rcvd")]
		public DateTime dtercd;

		/// <summary>
		/// First Date                      
		/// </summary>
		[SMBFieldName("fstdte")]
		[SMBFieldDescription("First Date")]
		public DateTime fstdte;

		/// <summary>
		/// Last Date                       
		/// </summary>
		[SMBFieldName("lstdte")]
		[SMBFieldDescription("Last Date")]
		public DateTime lstdte;

		/// <summary>
		/// Final Date                      
		/// </summary>
		[SMBFieldName("findte")]
		[SMBFieldDescription("Final Date")]
		public DateTime findte;

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