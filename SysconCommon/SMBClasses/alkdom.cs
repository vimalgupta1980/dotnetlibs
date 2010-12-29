using System;

namespace SMB.Tables {
	public class alkdom : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Employee#")]
		public long recnum;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("addrss")]
		[SMBFieldDescription("Address 1")]
		public string addrss;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Certificate#                    
		/// </summary>
		[SMBFieldName("crtnum")]
		[SMBFieldDescription("Certificate#")]
		public string crtnum;

		/// <summary>
		/// Apprentice%                     
		/// </summary>
		[SMBFieldName("apprte")]
		[SMBFieldDescription("Apprentice%")]
		public decimal apprte;

		/// <summary>
		/// Bargaining                      
		/// </summary>
		[SMBFieldName("brgagr")]
		[SMBFieldDescription("Bargaining")]
		public string brgagr;

		/// <summary>
		/// Occupation                      
		/// </summary>
		[SMBFieldName("occnum")]
		[SMBFieldDescription("Occupation")]
		public string occnum;

		/// <summary>
		/// Area                            
		/// </summary>
		[SMBFieldName("arecde")]
		[SMBFieldDescription("Area")]
		public string arecde;

		/// <summary>
		/// License#                        
		/// </summary>
		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

	}
}