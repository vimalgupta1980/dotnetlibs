using System;

namespace SMB.Tables {
	public class tmcdtx : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("locale")]
		[SMBFieldDescription("Site Locale")]
		public int locale;

		[SMBFieldName("wgettl")]
		[SMBFieldDescription("Site Wages")]
		public decimal wgettl;

		[SMBFieldName("locrte")]
		[SMBFieldDescription("Site Tax Rate")]
		public decimal locrte;

		[SMBFieldName("loctax")]
		[SMBFieldDescription("Site Tax")]
		public decimal loctax;

		[SMBFieldName("resloc")]
		[SMBFieldDescription("Res. Locale")]
		public int resloc;

		[SMBFieldName("resrte")]
		[SMBFieldDescription("Res. Tax Rate")]
		public decimal resrte;

		[SMBFieldName("effrte")]
		[SMBFieldDescription("Effective Rate")]
		public decimal effrte;

		[SMBFieldName("restax")]
		[SMBFieldDescription("Res. Tax")]
		public decimal restax;

	}
}