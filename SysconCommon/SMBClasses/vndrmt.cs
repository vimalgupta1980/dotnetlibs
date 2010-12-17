using System;

namespace SMB.Tables {
	public class vndrmt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor")]
		public int recnum;

		[SMBFieldName("rmtnme")]
		[SMBFieldDescription("Payee")]
		public string rmtnme;

		[SMBFieldName("rmtad1")]
		[SMBFieldDescription("Address 1")]
		public string rmtad1;

		[SMBFieldName("rmtad2")]
		[SMBFieldDescription("Address 2")]
		public string rmtad2;

		[SMBFieldName("rmtcty")]
		[SMBFieldDescription("City/State")]
		public string rmtcty;

		[SMBFieldName("rmtzip")]
		[SMBFieldDescription("Zip")]
		public string rmtzip;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}