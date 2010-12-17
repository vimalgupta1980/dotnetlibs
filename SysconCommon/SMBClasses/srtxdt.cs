using System;

namespace SMB.Tables {
	public class srtxdt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("taxent")]
		[SMBFieldDescription("Tax Entity")]
		public int taxent;

		[SMBFieldName("sbjtax")]
		[SMBFieldDescription("Subject to Tax")]
		public decimal sbjtax;

		[SMBFieldName("taxrte")]
		[SMBFieldDescription("Tax Rate")]
		public decimal taxrte;

		[SMBFieldName("taxamt")]
		[SMBFieldDescription("Tax Amount")]
		public decimal taxamt;

	}
}