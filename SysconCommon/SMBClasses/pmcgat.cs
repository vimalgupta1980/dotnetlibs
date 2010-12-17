using System;

namespace SMB.Tables {
	public class pmcgat : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("docnme")]
		[SMBFieldDescription("Document")]
		public string docnme;

		[SMBFieldName("copies")]
		[SMBFieldDescription("Copies")]
		public int copies;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}