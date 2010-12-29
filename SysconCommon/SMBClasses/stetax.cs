using System;

namespace SMB.Tables {
	public class stetax : smbtable {
		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// State Tax Id#                   
		/// </summary>
		[SMBFieldName("stetax")]
		[SMBFieldDescription("State Tax Id#")]
		public string _stetax;

	}
}