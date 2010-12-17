using System;

namespace SMB.Tables {
	public class srvloc : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client#")]
		public int recnum;

		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location#")]
		public int locnum;

		[SMBFieldName("locnme")]
		[SMBFieldDescription("Name")]
		public string locnme;

		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

		[SMBFieldName("srvgeo")]
		[SMBFieldDescription("Area")]
		public int srvgeo;

		[SMBFieldName("maploc")]
		[SMBFieldDescription("Map Locate")]
		public string maploc;

		[SMBFieldName("crsstr")]
		[SMBFieldDescription("Cross Street")]
		public string crsstr;

		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public int taxdst;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}