using System;

namespace SMB.Tables {
	public class vndprc : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("vndprf")]
		[SMBFieldDescription("Preference#")]
		public int vndprf;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("vndord")]
		[SMBFieldDescription("Order#")]
		public string vndord;

		[SMBFieldName("vnddsc")]
		[SMBFieldDescription("Disc. Rate")]
		public decimal vnddsc;

		[SMBFieldName("vndprc")]
		[SMBFieldDescription("Price")]
		public decimal _vndprc;

		[SMBFieldName("lstupd")]
		[SMBFieldDescription("Last Update")]
		public DateTime lstupd;

	}
}