using System;

namespace SMB.Tables {
	public class wkrcmp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Code#")]
		public int recnum;

		[SMBFieldName("cdenme")]
		[SMBFieldDescription("Description")]
		public string cdenme;

		[SMBFieldName("taxste")]
		[SMBFieldDescription("State")]
		public string taxste;

		[SMBFieldName("pctrte")]
		[SMBFieldDescription("Employer %")]
		public decimal pctrte;

		[SMBFieldName("emehrs")]
		[SMBFieldDescription("Employee Hrly")]
		public decimal emehrs;

		[SMBFieldName("emrhrs")]
		[SMBFieldDescription("Employer Hrly")]
		public decimal emrhrs;

		[SMBFieldName("libins")]
		[SMBFieldDescription("Liability")]
		public decimal libins;

		[SMBFieldName("expmod")]
		[SMBFieldDescription("Exper Mod")]
		public decimal expmod;

		[SMBFieldName("addmod")]
		[SMBFieldDescription("Add Exper Mod")]
		public decimal addmod;

		[SMBFieldName("maxwge")]
		[SMBFieldDescription("Maximum Wage")]
		public decimal maxwge;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}