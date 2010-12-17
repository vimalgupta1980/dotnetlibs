using System;

namespace SMB.Tables {
	public class srveqp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client#")]
		public int recnum;

		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment#")]
		public int eqpnum;

		[SMBFieldName("eqpnme")]
		[SMBFieldDescription("Description")]
		public string eqpnme;

		[SMBFieldName("manfct")]
		[SMBFieldDescription("Manufacturer")]
		public string manfct;

		[SMBFieldName("eqpmdl")]
		[SMBFieldDescription("Man Part#")]
		public string eqpmdl;

		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		[SMBFieldName("locnum")]
		[SMBFieldDescription("Client Location")]
		public int locnum;

		[SMBFieldName("sitloc")]
		[SMBFieldDescription("Site Location")]
		public string sitloc;

		[SMBFieldName("istdte")]
		[SMBFieldDescription("Installed Date")]
		public DateTime istdte;

		[SMBFieldName("isvdte")]
		[SMBFieldDescription("In Service Date")]
		public DateTime isvdte;

		[SMBFieldName("oemexp")]
		[SMBFieldDescription("OEM Warranty Exp")]
		public DateTime oemexp;

		[SMBFieldName("lstsrv")]
		[SMBFieldDescription("Last Service")]
		public DateTime lstsrv;

		[SMBFieldName("nxtsrv")]
		[SMBFieldDescription("Next Serv")]
		public DateTime nxtsrv;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}