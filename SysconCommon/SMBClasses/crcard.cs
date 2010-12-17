using System;

namespace SMB.Tables {
	public class crcard : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Credit Card Issuer")]
		public int recnum;

		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee")]
		public string payee1;

		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

	}
}