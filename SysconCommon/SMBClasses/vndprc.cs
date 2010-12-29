using System;

namespace SMB.Tables {
	public class vndprc : smbtable {
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
		/// Preference#                     
		/// </summary>
		[SMBFieldName("vndprf")]
		[SMBFieldDescription("Preference#")]
		public long vndprf;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Order#                          
		/// </summary>
		[SMBFieldName("vndord")]
		[SMBFieldDescription("Order#")]
		public string vndord;

		/// <summary>
		/// Disc. Rate                      
		/// </summary>
		[SMBFieldName("vnddsc")]
		[SMBFieldDescription("Disc. Rate")]
		public decimal vnddsc;

		/// <summary>
		/// Price                           
		/// </summary>
		[SMBFieldName("vndprc")]
		[SMBFieldDescription("Price")]
		public decimal _vndprc;

		/// <summary>
		/// Last Update                     
		/// </summary>
		[SMBFieldName("lstupd")]
		[SMBFieldDescription("Last Update")]
		public DateTime lstupd;

	}
}