using System;

namespace SMB.Tables {
	public class jobphs : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public int phsnum;

		[SMBFieldName("phsnme")]
		[SMBFieldDescription("Description")]
		public string phsnme;

		[SMBFieldName("bllamt")]
		[SMBFieldDescription("Billing Amount")]
		public decimal bllamt;

		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		[SMBFieldName("mdldsc")]
		[SMBFieldDescription("Model")]
		public string mdldsc;

		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		[SMBFieldName("untqty")]
		[SMBFieldDescription("Quantity")]
		public decimal untqty;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}