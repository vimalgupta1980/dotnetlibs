using System;

namespace SMB.Tables {
	public class payuni : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Union#")]
		public int recnum;

		[SMBFieldName("uninme")]
		[SMBFieldDescription("Union Name")]
		public string uninme;

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

		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

	}
}