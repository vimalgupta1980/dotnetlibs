using System;

namespace SMB.Tables {
	public class srvcnt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("connum")]
		[SMBFieldDescription("Contract#")]
		public string connum;

		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public int clnnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		[SMBFieldName("expdte")]
		[SMBFieldDescription("Expiration")]
		public DateTime expdte;

		[SMBFieldName("contyp")]
		[SMBFieldDescription("Type")]
		public int contyp;

		[SMBFieldName("conamt")]
		[SMBFieldDescription("Amount")]
		public decimal conamt;

		[SMBFieldName("disply")]
		[SMBFieldDescription("Contract Coverage")]
		public int disply;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered Date")]
		public DateTime entdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}