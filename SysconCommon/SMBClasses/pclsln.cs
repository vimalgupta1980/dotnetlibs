using System;

namespace SMB.Tables {
	public class pclsln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("itemnu")]
		[SMBFieldDescription("Item#")]
		public string itemnu;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("locion")]
		[SMBFieldDescription("Location")]
		public string locion;

		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public int divnum;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

		[SMBFieldName("dscdte")]
		[SMBFieldDescription("Discovered")]
		public DateTime dscdte;

		[SMBFieldName("notdte")]
		[SMBFieldDescription("Notified")]
		public DateTime notdte;

		[SMBFieldName("schdte")]
		[SMBFieldDescription("Scheduled")]
		public DateTime schdte;

		[SMBFieldName("cmpdte")]
		[SMBFieldDescription("Completed")]
		public DateTime cmpdte;

		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		[SMBFieldName("appval")]
		[SMBFieldDescription("Value")]
		public decimal appval;

		[SMBFieldName("billto")]
		[SMBFieldDescription("Bill To")]
		public int billto;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}