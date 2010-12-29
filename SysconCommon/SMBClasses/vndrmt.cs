using System;

namespace SMB.Tables {
	public class vndrmt : smbtable {
		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor")]
		public long recnum;

		/// <summary>
		/// Payee                           
		/// </summary>
		[SMBFieldName("rmtnme")]
		[SMBFieldDescription("Payee")]
		public string rmtnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("rmtad1")]
		[SMBFieldDescription("Address 1")]
		public string rmtad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("rmtad2")]
		[SMBFieldDescription("Address 2")]
		public string rmtad2;

		/// <summary>
		/// City/State                      
		/// </summary>
		[SMBFieldName("rmtcty")]
		[SMBFieldDescription("City/State")]
		public string rmtcty;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("rmtzip")]
		[SMBFieldDescription("Zip")]
		public string rmtzip;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}