using System;

namespace SMB.Tables {
	public class stetax : smbtable {
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		[SMBFieldName("stetax")]
		[SMBFieldDescription("State Tax Id#")]
		public string _stetax;

	}
}