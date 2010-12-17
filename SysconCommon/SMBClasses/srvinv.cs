using System;

namespace SMB.Tables {
	public class srvinv : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("ordnum")]
		[SMBFieldDescription("Order#")]
		public string ordnum;

		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client#")]
		public int clnnum;

		[SMBFieldName("orddte")]
		[SMBFieldDescription("Date")]
		public DateTime orddte;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

		[SMBFieldName("ctcnme")]
		[SMBFieldDescription("Contact")]
		public string ctcnme;

		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

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

		[SMBFieldName("maploc")]
		[SMBFieldDescription("Map")]
		public string maploc;

		[SMBFieldName("crsstr")]
		[SMBFieldDescription("Cross")]
		public string crsstr;

		[SMBFieldName("duedte")]
		[SMBFieldDescription("Due Date")]
		public DateTime duedte;

		[SMBFieldName("dscdte")]
		[SMBFieldDescription("Disc Date")]
		public DateTime dscdte;

		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

		[SMBFieldName("refnum")]
		[SMBFieldDescription("Reference#")]
		public string refnum;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("crdnum")]
		[SMBFieldDescription("Card/Chk#")]
		public string crdnum;

		[SMBFieldName("expdte")]
		[SMBFieldDescription("Exp Date")]
		public DateTime expdte;

		[SMBFieldName("crdnme")]
		[SMBFieldDescription("Cardholder")]
		public string crdnme;

		[SMBFieldName("depost")]
		[SMBFieldDescription("Deposit")]
		public decimal depost;

		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Disc Avail")]
		public decimal dscavl;

		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Disc/Credit")]
		public decimal dsctkn;

		[SMBFieldName("invdte")]
		[SMBFieldDescription("Invoice Date")]
		public DateTime invdte;

		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid")]
		public decimal amtpad;

		[SMBFieldName("clldte")]
		[SMBFieldDescription("Call Date")]
		public DateTime clldte;

		[SMBFieldName("clltim")]
		[SMBFieldDescription("Call Time")]
		public DateTime clltim;

		[SMBFieldName("dspdte")]
		[SMBFieldDescription("Disp Date")]
		public DateTime dspdte;

		[SMBFieldName("dsptim")]
		[SMBFieldDescription("Disp Time")]
		public DateTime dsptim;

		[SMBFieldName("schdte")]
		[SMBFieldDescription("Sch Date")]
		public DateTime schdte;

		[SMBFieldName("schtim")]
		[SMBFieldDescription("Sch Time")]
		public DateTime schtim;

		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		[SMBFieldName("strtim")]
		[SMBFieldDescription("Start Time")]
		public DateTime strtim;

		[SMBFieldName("findte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime findte;

		[SMBFieldName("fintim")]
		[SMBFieldDescription("Finish Time")]
		public DateTime fintim;

		[SMBFieldName("schhrs")]
		[SMBFieldDescription("Estimated Hours")]
		public decimal schhrs;

		[SMBFieldName("acthrs")]
		[SMBFieldDescription("Actual Hours")]
		public decimal acthrs;

		[SMBFieldName("plcnum")]
		[SMBFieldDescription("Policy#")]
		public string plcnum;

		[SMBFieldName("plcnme")]
		[SMBFieldDescription("Policyholder")]
		public string plcnme;

		[SMBFieldName("plcphn")]
		[SMBFieldDescription("Policy Phone")]
		public string plcphn;

		[SMBFieldName("plcad1")]
		[SMBFieldDescription("Policy Address 1")]
		public string plcad1;

		[SMBFieldName("plcad2")]
		[SMBFieldDescription("Policy Address 2")]
		public string plcad2;

		[SMBFieldName("plccty")]
		[SMBFieldDescription("City/State/Zip")]
		public string plccty;

		[SMBFieldName("cmpnme")]
		[SMBFieldDescription("Company")]
		public string cmpnme;

		[SMBFieldName("adjnme")]
		[SMBFieldDescription("Adjuster Name")]
		public string adjnme;

		[SMBFieldName("adjphn")]
		[SMBFieldDescription("Adjuster Phone")]
		public string adjphn;

		[SMBFieldName("adjad1")]
		[SMBFieldDescription("Adjuster Address 1")]
		public string adjad1;

		[SMBFieldName("adjad2")]
		[SMBFieldDescription("Adjuster Address 2")]
		public string adjad2;

		[SMBFieldName("adjcty")]
		[SMBFieldDescription("City/State/Zip")]
		public string adjcty;

		[SMBFieldName("plctyp")]
		[SMBFieldDescription("Policy Type")]
		public string plctyp;

		[SMBFieldName("dedabl")]
		[SMBFieldDescription("Deductible")]
		public decimal dedabl;

		[SMBFieldName("rutnum")]
		[SMBFieldDescription("Route")]
		public int rutnum;

		[SMBFieldName("constd")]
		[SMBFieldDescription("Contract Start Date")]
		public DateTime constd;

		[SMBFieldName("conend")]
		[SMBFieldDescription("Contract End Date")]
		public DateTime conend;

		[SMBFieldName("bildte")]
		[SMBFieldDescription("Billing Date")]
		public DateTime bildte;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Technician")]
		public int empnum;

		[SMBFieldName("slspsn")]
		[SMBFieldDescription("Salesperson")]
		public int slspsn;

		[SMBFieldName("invtyp")]
		[SMBFieldDescription("Type")]
		public int invtyp;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("priort")]
		[SMBFieldDescription("Priority")]
		public int priort;

		[SMBFieldName("invsrc")]
		[SMBFieldDescription("Source")]
		public int invsrc;

		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public int taxdst;

		[SMBFieldName("pmttyp")]
		[SMBFieldDescription("Payment")]
		public int pmttyp;

		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		[SMBFieldName("invbal")]
		[SMBFieldDescription("Balance")]
		public decimal invbal;

		[SMBFieldName("invnet")]
		[SMBFieldDescription("Net Due")]
		public decimal invnet;

		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable")]
		public decimal taxabl;

		[SMBFieldName("nontax")]
		[SMBFieldDescription("Non-Taxable")]
		public decimal nontax;

		[SMBFieldName("ttlpad")]
		[SMBFieldDescription("Total Paid")]
		public decimal ttlpad;

		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public int actper;

		[SMBFieldName("bilcyc")]
		[SMBFieldDescription("Billing Cycle")]
		public int bilcyc;

		[SMBFieldName("srvgeo")]
		[SMBFieldDescription("Service Area")]
		public int srvgeo;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public int lgrrec;

		[SMBFieldName("shpnte")]
		[SMBFieldDescription("Shop Notes")]
		public string shpnte;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("exmnum")]
		[SMBFieldDescription("Resale #")]
		public string exmnum;

		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public int lckedt;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Date Entered")]
		public DateTime entdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("taxlin")]
		[SMBFieldDescription("Taxable Grid Total")]
		public decimal taxlin;

		[SMBFieldName("ntxlin")]
		[SMBFieldDescription("Non-Tax Grid Total")]
		public decimal ntxlin;

		[SMBFieldName("taxmrt")]
		[SMBFieldDescription("Taxable Markup %")]
		public decimal taxmrt;

		[SMBFieldName("ntxmrt")]
		[SMBFieldDescription("Non-Tax Markup %")]
		public decimal ntxmrt;

		[SMBFieldName("txadmk")]
		[SMBFieldDescription("Taxable Markup $")]
		public decimal txadmk;

		[SMBFieldName("ntadmk")]
		[SMBFieldDescription("Non-Tax Markup $")]
		public decimal ntadmk;

		[SMBFieldName("txmktl")]
		[SMBFieldDescription("Taxable Total Markup")]
		public decimal txmktl;

		[SMBFieldName("ntmktl")]
		[SMBFieldDescription("Non-Tax Total  Markup")]
		public decimal ntmktl;

		[SMBFieldName("taxext")]
		[SMBFieldDescription("Taxable Extended Total")]
		public decimal taxext;

		[SMBFieldName("ntxext")]
		[SMBFieldDescription("Non-Tax Extended Total")]
		public decimal ntxext;

		[SMBFieldName("taxovr")]
		[SMBFieldDescription("Taxable Billing Amount")]
		public decimal taxovr;

		[SMBFieldName("ntxovr")]
		[SMBFieldDescription("Non-Tax Billing Amount")]
		public decimal ntxovr;

		[SMBFieldName("taxlck")]
		[SMBFieldDescription("Lock Taxable Billing Amt")]
		public int taxlck;

		[SMBFieldName("ntxlck")]
		[SMBFieldDescription("Lock Non-Tax Billing Amt")]
		public int ntxlck;

	}
}