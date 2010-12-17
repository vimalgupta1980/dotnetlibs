using System;

namespace SMB.Tables {
	public class reccln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client#")]
		public int recnum;

		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		[SMBFieldName("clnnme")]
		[SMBFieldDescription("Long Name")]
		public string clnnme;

		[SMBFieldName("grting")]
		[SMBFieldDescription("Greeting")]
		public string grting;

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

		[SMBFieldName("bilad1")]
		[SMBFieldDescription("Bill Address 1")]
		public string bilad1;

		[SMBFieldName("bilad2")]
		[SMBFieldDescription("Bill Address 2")]
		public string bilad2;

		[SMBFieldName("bilcty")]
		[SMBFieldDescription("Bill City")]
		public string bilcty;

		[SMBFieldName("bilste")]
		[SMBFieldDescription("Bill State")]
		public string bilste;

		[SMBFieldName("bilzip")]
		[SMBFieldDescription("Bill Zip")]
		public string bilzip;

		[SMBFieldName("shpad1")]
		[SMBFieldDescription("Ship Address 1")]
		public string shpad1;

		[SMBFieldName("shpad2")]
		[SMBFieldDescription("Ship Address 2")]
		public string shpad2;

		[SMBFieldName("shpcty")]
		[SMBFieldDescription("Ship City")]
		public string shpcty;

		[SMBFieldName("shpste")]
		[SMBFieldDescription("Ship State")]
		public string shpste;

		[SMBFieldName("shpzip")]
		[SMBFieldDescription("Ship Zip")]
		public string shpzip;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("usrdf3")]
		[SMBFieldDescription("User Def3")]
		public string usrdf3;

		[SMBFieldName("usrdf4")]
		[SMBFieldDescription("User Def4")]
		public string usrdf4;

		[SMBFieldName("usrdf5")]
		[SMBFieldDescription("User Def5")]
		public string usrdf5;

		[SMBFieldName("usrdf6")]
		[SMBFieldDescription("User Defined")]
		public int usrdf6;

		[SMBFieldName("usrdf7")]
		[SMBFieldDescription("User Defined")]
		public int usrdf7;

		[SMBFieldName("usrdf8")]
		[SMBFieldDescription("User Defined")]
		public int usrdf8;

		[SMBFieldName("usrdf9")]
		[SMBFieldDescription("User Defined")]
		public int usrdf9;

		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact 1")]
		public string contct;

		[SMBFieldName("contc2")]
		[SMBFieldDescription("Contact 2")]
		public string contc2;

		[SMBFieldName("contc3")]
		[SMBFieldDescription("Contact 3")]
		public string contc3;

		[SMBFieldName("cntds1")]
		[SMBFieldDescription("Contact 1 Desc.")]
		public string cntds1;

		[SMBFieldName("cntds2")]
		[SMBFieldDescription("Contact 2 Desc.")]
		public string cntds2;

		[SMBFieldName("cntds3")]
		[SMBFieldDescription("Contact 3 Desc.")]
		public string cntds3;

		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone 1")]
		public string phnnum;

		[SMBFieldName("phn002")]
		[SMBFieldDescription("Phone 2")]
		public string phn002;

		[SMBFieldName("phn003")]
		[SMBFieldDescription("Phone 3")]
		public string phn003;

		[SMBFieldName("phnext")]
		[SMBFieldDescription("Phone Ext. 1")]
		public string phnext;

		[SMBFieldName("phext2")]
		[SMBFieldDescription("Phone Ext. 2")]
		public string phext2;

		[SMBFieldName("phext3")]
		[SMBFieldDescription("Phone Ext. 3")]
		public string phext3;

		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax 1")]
		public string faxnum;

		[SMBFieldName("fax002")]
		[SMBFieldDescription("Fax 2")]
		public string fax002;

		[SMBFieldName("fax003")]
		[SMBFieldDescription("Fax 3")]
		public string fax003;

		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell 1")]
		public string cllphn;

		[SMBFieldName("cell02")]
		[SMBFieldDescription("Cell 2")]
		public string cell02;

		[SMBFieldName("cell03")]
		[SMBFieldDescription("Cell 3")]
		public string cell03;

		[SMBFieldName("pagnum")]
		[SMBFieldDescription("Pager 1")]
		public string pagnum;

		[SMBFieldName("pagr02")]
		[SMBFieldDescription("Pager 2")]
		public string pagr02;

		[SMBFieldName("pagr03")]
		[SMBFieldDescription("Pager 3")]
		public string pagr03;

		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email 1")]
		public string e_mail;

		[SMBFieldName("email2")]
		[SMBFieldDescription("Email 2")]
		public string email2;

		[SMBFieldName("email3")]
		[SMBFieldDescription("Email 3")]
		public string email3;

		[SMBFieldName("dtercv")]
		[SMBFieldDescription("Received")]
		public DateTime dtercv;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Salesperson")]
		public int empnum;

		[SMBFieldName("mannum")]
		[SMBFieldDescription("Manager")]
		public int mannum;

		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public int taxdst;

		[SMBFieldName("lstctc")]
		[SMBFieldDescription("Contact")]
		public DateTime lstctc;

		[SMBFieldName("cllbck")]
		[SMBFieldDescription("Call Back")]
		public DateTime cllbck;

		[SMBFieldName("lstmal")]
		[SMBFieldDescription("Mail Piece")]
		public string lstmal;

		[SMBFieldName("lstdte")]
		[SMBFieldDescription("Date Mailed")]
		public DateTime lstdte;

		[SMBFieldName("pchdte")]
		[SMBFieldDescription("Purchase")]
		public DateTime pchdte;

		[SMBFieldName("refdte")]
		[SMBFieldDescription("Reference")]
		public DateTime refdte;

		[SMBFieldName("prdnum")]
		[SMBFieldDescription("Product")]
		public int prdnum;

		[SMBFieldName("dscrte")]
		[SMBFieldDescription("Disc Rate")]
		public decimal dscrte;

		[SMBFieldName("finrte")]
		[SMBFieldDescription("Finance")]
		public decimal finrte;

		[SMBFieldName("ledsrc")]
		[SMBFieldDescription("Source")]
		public int ledsrc;

		[SMBFieldName("clntyp")]
		[SMBFieldDescription("Type")]
		public int clntyp;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("mallst")]
		[SMBFieldDescription("Mail List")]
		public int mallst;

		[SMBFieldName("region")]
		[SMBFieldDescription("Area")]
		public int region;

		[SMBFieldName("cmpsze")]
		[SMBFieldDescription("Size")]
		public int cmpsze;

		[SMBFieldName("srvcon")]
		[SMBFieldDescription("Contract")]
		public int srvcon;

		[SMBFieldName("srvexp")]
		[SMBFieldDescription("Expiration")]
		public DateTime srvexp;

		[SMBFieldName("clndsc")]
		[SMBFieldDescription("Discount")]
		public decimal clndsc;

		[SMBFieldName("begbal")]
		[SMBFieldDescription("Beg Balance")]
		public decimal begbal;

		[SMBFieldName("endbal")]
		[SMBFieldDescription("End Balance")]
		public decimal endbal;

		[SMBFieldName("maploc")]
		[SMBFieldDescription("Map Location")]
		public string maploc;

		[SMBFieldName("crsstr")]
		[SMBFieldDescription("Cross Street")]
		public string crsstr;

		[SMBFieldName("bilbas")]
		[SMBFieldDescription("Billing Basis")]
		public int bilbas;

		[SMBFieldName("pchnum")]
		[SMBFieldDescription("PO#")]
		public string pchnum;

		[SMBFieldName("exmnum")]
		[SMBFieldDescription("Sales Tax Resale Exempt#")]
		public string exmnum;

		[SMBFieldName("crdnum")]
		[SMBFieldDescription("Credit Card #")]
		public string crdnum;

		[SMBFieldName("expdte")]
		[SMBFieldDescription("Expiration")]
		public DateTime expdte;

		[SMBFieldName("crdnme")]
		[SMBFieldDescription("Cardholder Name")]
		public string crdnme;

		[SMBFieldName("crdtyp")]
		[SMBFieldDescription("Credit Card Type")]
		public string crdtyp;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}