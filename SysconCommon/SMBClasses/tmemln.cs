using System;

namespace SMB.Tables {
	public class tmemln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("rate01")]
		[SMBFieldDescription("Pay Rate1")]
		public decimal rate01;

		[SMBFieldName("rate02")]
		[SMBFieldDescription("Pay Rate2")]
		public decimal rate02;

		[SMBFieldName("rate03")]
		[SMBFieldDescription("Pay Rate3")]
		public decimal rate03;

		[SMBFieldName("minhrs")]
		[SMBFieldDescription("Minimum Hrs")]
		public decimal minhrs;

	}
}