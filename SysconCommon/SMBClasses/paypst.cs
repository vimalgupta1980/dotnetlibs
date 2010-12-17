using System;

namespace SMB.Tables {
	public class paypst : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Position#")]
		public int recnum;

		[SMBFieldName("pstnme")]
		[SMBFieldDescription("Description")]
		public string pstnme;

		[SMBFieldName("jobact")]
		[SMBFieldDescription("Job Wages")]
		public int jobact;

		[SMBFieldName("eqpact")]
		[SMBFieldDescription("Equip/Shop Wages")]
		public int eqpact;

		[SMBFieldName("othact")]
		[SMBFieldDescription("Other Wages")]
		public int othact;

		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public int dptmnt;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}