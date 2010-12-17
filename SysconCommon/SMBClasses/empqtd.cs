using System;

namespace SMB.Tables {
	public class empqtd : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Employee#")]
		public int recnum;

		[SMBFieldName("clcnum")]
		[SMBFieldDescription("Calculation")]
		public int clcnum;

		[SMBFieldName("dedrte")]
		[SMBFieldDescription("Rate")]
		public decimal dedrte;

		[SMBFieldName("dedmax")]
		[SMBFieldDescription("Maximum")]
		public decimal dedmax;

		[SMBFieldName("mrtsts")]
		[SMBFieldDescription("Marital")]
		public int mrtsts;

		[SMBFieldName("allows")]
		[SMBFieldDescription("Std Allow")]
		public int allows;

		[SMBFieldName("addall")]
		[SMBFieldDescription("Add Allow")]
		public int addall;

		[SMBFieldName("tblnum")]
		[SMBFieldDescription("Table#")]
		public int tblnum;

		[SMBFieldName("addste")]
		[SMBFieldDescription("Add W/H")]
		public decimal addste;

		[SMBFieldName("offset")]
		[SMBFieldDescription("Offset")]
		public decimal offset;

		[SMBFieldName("fstqtr")]
		[SMBFieldDescription("Quarter 1")]
		public decimal fstqtr;

		[SMBFieldName("scdqtr")]
		[SMBFieldDescription("Quarter 2")]
		public decimal scdqtr;

		[SMBFieldName("thdqtr")]
		[SMBFieldDescription("Quarter 3")]
		public decimal thdqtr;

		[SMBFieldName("fthqtr")]
		[SMBFieldDescription("Quarter 4")]
		public decimal fthqtr;

	}
}