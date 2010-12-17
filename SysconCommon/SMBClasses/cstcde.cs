using System;

namespace SMB.Tables {
	public class cstcde : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Cost Code#")]
		public decimal recnum;

		[SMBFieldName("cdenme")]
		[SMBFieldDescription("Description")]
		public string cdenme;

		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public int divnum;

		[SMBFieldName("cmpcde")]
		[SMBFieldDescription("Comp Code1")]
		public int cmpcde;

		[SMBFieldName("maxwge")]
		[SMBFieldDescription("Wage Max")]
		public decimal maxwge;

		[SMBFieldName("cmpcd2")]
		[SMBFieldDescription("Comp Code2")]
		public int cmpcd2;

		[SMBFieldName("dptnum")]
		[SMBFieldDescription("Department")]
		public int dptnum;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}