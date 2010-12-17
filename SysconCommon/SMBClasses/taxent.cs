using System;

namespace SMB.Tables {
	public class taxent : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Tax Entity#")]
		public int recnum;

		[SMBFieldName("entnme")]
		[SMBFieldDescription("Entity Name")]
		public string entnme;

		[SMBFieldName("paynme")]
		[SMBFieldDescription("Remit To")]
		public string paynme;

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

		[SMBFieldName("taxrt1")]
		[SMBFieldDescription("Tax Rate")]
		public decimal taxrt1;

		[SMBFieldName("limit1")]
		[SMBFieldDescription("Billing Limit")]
		public decimal limit1;

		[SMBFieldName("lmtyp1")]
		[SMBFieldDescription("Limit Type")]
		public int lmtyp1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}