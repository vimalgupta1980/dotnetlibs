using System;

namespace SMB.Tables {
	public class prelen : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("ownnme")]
		[SMBFieldDescription("Name")]
		public string ownnme;

		[SMBFieldName("ownad1")]
		[SMBFieldDescription("Address 1")]
		public string ownad1;

		[SMBFieldName("ownad2")]
		[SMBFieldDescription("Address 2")]
		public string ownad2;

		[SMBFieldName("owncty")]
		[SMBFieldDescription("City")]
		public string owncty;

		[SMBFieldName("ownste")]
		[SMBFieldDescription("State")]
		public string ownste;

		[SMBFieldName("ownzip")]
		[SMBFieldDescription("Zip")]
		public string ownzip;

		[SMBFieldName("lndnme")]
		[SMBFieldDescription("Name")]
		public string lndnme;

		[SMBFieldName("lndad1")]
		[SMBFieldDescription("Address 1")]
		public string lndad1;

		[SMBFieldName("lndad2")]
		[SMBFieldDescription("Address 2")]
		public string lndad2;

		[SMBFieldName("lndcty")]
		[SMBFieldDescription("City")]
		public string lndcty;

		[SMBFieldName("lndste")]
		[SMBFieldDescription("State")]
		public string lndste;

		[SMBFieldName("lndzip")]
		[SMBFieldDescription("Zip")]
		public string lndzip;

		[SMBFieldName("connme")]
		[SMBFieldDescription("Name")]
		public string connme;

		[SMBFieldName("conad1")]
		[SMBFieldDescription("Address 1")]
		public string conad1;

		[SMBFieldName("conad2")]
		[SMBFieldDescription("Address 2")]
		public string conad2;

		[SMBFieldName("concty")]
		[SMBFieldDescription("City")]
		public string concty;

		[SMBFieldName("conste")]
		[SMBFieldDescription("State")]
		public string conste;

		[SMBFieldName("conzip")]
		[SMBFieldDescription("Zip")]
		public string conzip;

		[SMBFieldName("subnme")]
		[SMBFieldDescription("Name")]
		public string subnme;

		[SMBFieldName("subad1")]
		[SMBFieldDescription("Address 1")]
		public string subad1;

		[SMBFieldName("subad2")]
		[SMBFieldDescription("Address 2")]
		public string subad2;

		[SMBFieldName("subcty")]
		[SMBFieldDescription("City")]
		public string subcty;

		[SMBFieldName("subste")]
		[SMBFieldDescription("State")]
		public string subste;

		[SMBFieldName("subzip")]
		[SMBFieldDescription("Zip")]
		public string subzip;

		[SMBFieldName("cntnme")]
		[SMBFieldDescription("Name")]
		public string cntnme;

		[SMBFieldName("cntad1")]
		[SMBFieldDescription("Address 1")]
		public string cntad1;

		[SMBFieldName("cntad2")]
		[SMBFieldDescription("Address 2")]
		public string cntad2;

		[SMBFieldName("cntcty")]
		[SMBFieldDescription("City")]
		public string cntcty;

		[SMBFieldName("cntste")]
		[SMBFieldDescription("State")]
		public string cntste;

		[SMBFieldName("cntzip")]
		[SMBFieldDescription("Zip")]
		public string cntzip;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}