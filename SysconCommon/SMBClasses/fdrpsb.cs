using System;

namespace SMB.Tables {
	public class fdrpsb : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("arvtim")]
		[SMBFieldDescription("Arrival Time")]
		public DateTime arvtim;

		[SMBFieldName("levtim")]
		[SMBFieldDescription("Leave Time")]
		public DateTime levtim;

		[SMBFieldName("numemp")]
		[SMBFieldDescription("Emp Count")]
		public int numemp;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}