using System;

namespace SMB.Tables {
	public class tmcddd : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("clcnum")]
		[SMBFieldDescription("Calculation")]
		public int clcnum;

		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

		[SMBFieldName("stewge")]
		[SMBFieldDescription("State Wages")]
		public decimal stewge;

		[SMBFieldName("stegrs")]
		[SMBFieldDescription("State Gross")]
		public decimal stegrs;

	}
}