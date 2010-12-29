using System;

namespace SMB.Tables {
	public class tmcddd : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Calculation                     
		/// </summary>
		[SMBFieldName("clcnum")]
		[SMBFieldDescription("Calculation")]
		public long clcnum;

		/// <summary>
		/// Amount                          
		/// </summary>
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

		/// <summary>
		/// State Wages                     
		/// </summary>
		[SMBFieldName("stewge")]
		[SMBFieldDescription("State Wages")]
		public decimal stewge;

		/// <summary>
		/// State Gross                     
		/// </summary>
		[SMBFieldName("stegrs")]
		[SMBFieldDescription("State Gross")]
		public decimal stegrs;

	}
}