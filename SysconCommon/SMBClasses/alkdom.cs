using System;

namespace SMB.Tables {
	public class alkdom : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Employee#")]
		public int recnum;

		[SMBFieldName("addrss")]
		[SMBFieldDescription("Address 1")]
		public string addrss;

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

		[SMBFieldName("crtnum")]
		[SMBFieldDescription("Certificate#")]
		public string crtnum;

		[SMBFieldName("apprte")]
		[SMBFieldDescription("Apprentice%")]
		public decimal apprte;

		[SMBFieldName("brgagr")]
		[SMBFieldDescription("Bargaining")]
		public string brgagr;

		[SMBFieldName("occnum")]
		[SMBFieldDescription("Occupation")]
		public string occnum;

		[SMBFieldName("arecde")]
		[SMBFieldDescription("Area")]
		public string arecde;

		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

	}
}