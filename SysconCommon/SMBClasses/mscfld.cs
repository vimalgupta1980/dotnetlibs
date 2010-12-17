using System;

namespace SMB.Tables {
	public class mscfld : smbtable {
		[SMBFieldName("lgr1_1")]
		[SMBFieldDescription("Account#")]
		public int lgr1_1;

		[SMBFieldName("dterge")]
		[SMBFieldDescription("Statement Cutoff Date")]
		public DateTime dterge;

		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public int actprd;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public int clnnum;

		[SMBFieldName("lgrrge")]
		[SMBFieldDescription("Ledger Accnt. Range")]
		public int lgrrge;

		[SMBFieldName("enddte")]
		[SMBFieldDescription("Fiscal Year End Date")]
		public DateTime enddte;

		[SMBFieldName("subact")]
		[SMBFieldDescription("Subsidiary Ledger Accnt.#'s")]
		public int subact;

		[SMBFieldName("pstact")]
		[SMBFieldDescription("Posting Accnt.#'s")]
		public int pstact;

		[SMBFieldName("period")]
		[SMBFieldDescription("Period")]
		public int period;

		[SMBFieldName("perdte")]
		[SMBFieldDescription("Period Ending")]
		public DateTime perdte;

		[SMBFieldName("emprgf")]
		[SMBFieldDescription("Employee# Lower Range")]
		public int emprgf;

		[SMBFieldName("emprgl")]
		[SMBFieldDescription("Employee# Upper Range")]
		public int emprgl;

		[SMBFieldName("emplst")]
		[SMBFieldDescription("Employee Pick List")]
		public int emplst;

		[SMBFieldName("payrcf")]
		[SMBFieldDescription("First Payroll Record#")]
		public int payrcf;

		[SMBFieldName("payrcl")]
		[SMBFieldDescription("Last Payrol Record#")]
		public int payrcl;

		[SMBFieldName("reclst")]
		[SMBFieldDescription("Record Pick List")]
		public int reclst;

		[SMBFieldName("chkact")]
		[SMBFieldDescription("Checking Act.#")]
		public int chkact;

		[SMBFieldName("paydte")]
		[SMBFieldDescription("Payroll Ending Date")]
		public DateTime paydte;

		[SMBFieldName("trntyp")]
		[SMBFieldDescription("Type")]
		public string trntyp;

		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public int eqpnum;

		[SMBFieldName("lender")]
		[SMBFieldDescription("Lender")]
		public int lender;

		[SMBFieldName("duedte")]
		[SMBFieldDescription("Due Date")]
		public DateTime duedte;

		[SMBFieldName("paymnt")]
		[SMBFieldDescription("Payment")]
		public decimal paymnt;

		[SMBFieldName("setpay")]
		[SMBFieldDescription("Set to Pay")]
		public decimal setpay;

		[SMBFieldName("capend")]
		[SMBFieldDescription("Capitalized")]
		public decimal capend;

		[SMBFieldName("depend")]
		[SMBFieldDescription("To Date")]
		public decimal depend;

		[SMBFieldName("lstpst")]
		[SMBFieldDescription("Last Posted")]
		public string lstpst;

		[SMBFieldName("msceqp")]
		[SMBFieldDescription("Equipment")]
		public int msceqp;

		[SMBFieldName("lgracc")]
		[SMBFieldDescription("Account#")]
		public int lgracc;

		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		[SMBFieldName("depnum")]
		[SMBFieldDescription("Deposit#")]
		public string depnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("reccln")]
		[SMBFieldDescription("Client#")]
		public int reccln;

		[SMBFieldName("vndprf")]
		[SMBFieldDescription("Preference#")]
		public int vndprf;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("slccrt")]
		[SMBFieldDescription("Field Selection")]
		public string slccrt;

		[SMBFieldName("crttyp")]
		[SMBFieldDescription("Field Selection  Criteria")]
		public string crttyp;

		[SMBFieldName("crtval")]
		[SMBFieldDescription("Field Selection  Value")]
		public string crtval;

		[SMBFieldName("chgfld")]
		[SMBFieldDescription("Change Field")]
		public string chgfld;

		[SMBFieldName("baseon")]
		[SMBFieldDescription("Change Field Based On")]
		public string baseon;

		[SMBFieldName("chg_by")]
		[SMBFieldDescription("Change Field By")]
		public string chg_by;

		[SMBFieldName("newval")]
		[SMBFieldDescription("New Field Value")]
		public string newval;

		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public int prtnum;

		[SMBFieldName("prtdsc")]
		[SMBFieldDescription("Description")]
		public string prtdsc;

		[SMBFieldName("prtunt")]
		[SMBFieldDescription("Unit")]
		public string prtunt;

		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Price")]
		public decimal prtprc;

		[SMBFieldName("extprc")]
		[SMBFieldDescription("Extended")]
		public decimal extprc;

		[SMBFieldName("crddte")]
		[SMBFieldDescription("Payroll Check Date")]
		public DateTime crddte;

		[SMBFieldName("crdqtr")]
		[SMBFieldDescription("Payroll Quarter")]
		public int crdqtr;

		[SMBFieldName("lgr1_2")]
		[SMBFieldDescription("Account#")]
		public int lgr1_2;

		[SMBFieldName("lgr1_5")]
		[SMBFieldDescription("Account#")]
		public int lgr1_5;

		[SMBFieldName("lbrbur")]
		[SMBFieldDescription("Labor Burden")]
		public decimal lbrbur;

		[SMBFieldName("cshrec")]
		[SMBFieldDescription("Record#")]
		public int cshrec;

		[SMBFieldName("lgr3_3")]
		[SMBFieldDescription("Account")]
		public int lgr3_3;

		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		[SMBFieldName("cshdte")]
		[SMBFieldDescription("Due Date")]
		public DateTime cshdte;

		[SMBFieldName("cshdsc")]
		[SMBFieldDescription("Description")]
		public string cshdsc;

		[SMBFieldName("invttl")]
		[SMBFieldDescription("Amount")]
		public decimal invttl;

		[SMBFieldName("invbal")]
		[SMBFieldDescription("Balance")]
		public decimal invbal;

		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Disc Avail")]
		public decimal dscavl;

		[SMBFieldName("chknum")]
		[SMBFieldDescription("Check#")]
		public string chknum;

		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid(Cash)")]
		public decimal amtpad;

		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Discount")]
		public decimal dsctkn;

		[SMBFieldName("credit")]
		[SMBFieldDescription("Credit")]
		public decimal credit;

		[SMBFieldName("biditm")]
		[SMBFieldDescription("Bid Item")]
		public int biditm;

		[SMBFieldName("mrklab")]
		[SMBFieldDescription("Labor Markups")]
		public decimal mrklab;

		[SMBFieldName("jobphs")]
		[SMBFieldDescription("Phase")]
		public int jobphs;

		[SMBFieldName("mrkups")]
		[SMBFieldDescription("Markups")]
		public decimal mrkups;

		[SMBFieldName("schjob")]
		[SMBFieldDescription("Job")]
		public int schjob;

		[SMBFieldName("mrkdsc")]
		[SMBFieldDescription("Service Contract Discount")]
		public decimal mrkdsc;

		[SMBFieldName("schphs")]
		[SMBFieldDescription("Phase")]
		public int schphs;

		[SMBFieldName("mrkcls")]
		[SMBFieldDescription("Apply to Classes")]
		public int mrkcls;

		[SMBFieldName("chk1_1")]
		[SMBFieldDescription("Check#")]
		public string chk1_1;

		[SMBFieldName("cutdte")]
		[SMBFieldDescription("Cutoff Date")]
		public DateTime cutdte;

		[SMBFieldName("dep1_2")]
		[SMBFieldDescription("Deposit#")]
		public string dep1_2;

		[SMBFieldName("srvinv")]
		[SMBFieldDescription("Invoice#")]
		public string srvinv;

		[SMBFieldName("client")]
		[SMBFieldDescription("Client")]
		public int client;

		[SMBFieldName("ovrpay")]
		[SMBFieldDescription("Overpayment")]
		public decimal ovrpay;

		[SMBFieldName("cntjob")]
		[SMBFieldDescription("Job#")]
		public int cntjob;

		[SMBFieldName("trn3_3")]
		[SMBFieldDescription("Deposit#")]
		public string trn3_3;

		[SMBFieldName("dte3_3")]
		[SMBFieldDescription("Date")]
		public DateTime dte3_3;

		[SMBFieldName("dsc3_3")]
		[SMBFieldDescription("Description")]
		public string dsc3_3;

		[SMBFieldName("retdte")]
		[SMBFieldDescription("Date")]
		public DateTime retdte;

		[SMBFieldName("inv3_7")]
		[SMBFieldDescription("Invoice# for Prog. Bill")]
		public string inv3_7;

		[SMBFieldName("tkfprt")]
		[SMBFieldDescription("Part#")]
		public int tkfprt;

		[SMBFieldName("dsc666")]
		[SMBFieldDescription("Description")]
		public string dsc666;

		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		[SMBFieldName("unt666")]
		[SMBFieldDescription("Unit")]
		public string unt666;

		[SMBFieldName("linqty")]
		[SMBFieldDescription("Quantity")]
		public decimal linqty;

		[SMBFieldName("invloc")]
		[SMBFieldDescription("Inventory Location")]
		public int invloc;

		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		[SMBFieldName("shpnum")]
		[SMBFieldDescription("Shipping#")]
		public string shpnum;

		[SMBFieldName("vnd43f")]
		[SMBFieldDescription("Vendor Lower Range")]
		public int vnd43f;

		[SMBFieldName("vnd43l")]
		[SMBFieldDescription("Vendor Upper Range")]
		public int vnd43l;

		[SMBFieldName("vndlst")]
		[SMBFieldDescription("Vendor List")]
		public int vndlst;

		[SMBFieldName("job43l")]
		[SMBFieldDescription("Job Upper Range")]
		public int job43l;

		[SMBFieldName("job43f")]
		[SMBFieldDescription("Job Lower Rasnge")]
		public int job43f;

		[SMBFieldName("joblst")]
		[SMBFieldDescription("Job List")]
		public int joblst;

		[SMBFieldName("dte4_3")]
		[SMBFieldDescription("Due/Disc Date")]
		public DateTime dte4_3;

		[SMBFieldName("rec4_3")]
		[SMBFieldDescription("Record#")]
		public int rec4_3;

		[SMBFieldName("vnd4_3")]
		[SMBFieldDescription("Vendor")]
		public int vnd4_3;

		[SMBFieldName("job4_3")]
		[SMBFieldDescription("Job")]
		public int job4_3;

		[SMBFieldName("inv4_3")]
		[SMBFieldDescription("Invoice#")]
		public string inv4_3;

		[SMBFieldName("due4_3")]
		[SMBFieldDescription("Due Date")]
		public DateTime due4_3;

		[SMBFieldName("dsc4_3")]
		[SMBFieldDescription("Disc Date")]
		public DateTime dsc4_3;

		[SMBFieldName("stat43")]
		[SMBFieldDescription("Status")]
		public int stat43;

		[SMBFieldName("pstsub")]
		[SMBFieldDescription("Posting Subaccount")]
		public int pstsub;

		[SMBFieldName("trnd84")]
		[SMBFieldDescription("Date")]
		public DateTime trnd84;

		[SMBFieldName("dsc8_4")]
		[SMBFieldDescription("Description")]
		public string dsc8_4;

		[SMBFieldName("job8_4")]
		[SMBFieldDescription("Job")]
		public int job8_4;

		[SMBFieldName("eqp8_4")]
		[SMBFieldDescription("Equip Repaired")]
		public int eqp8_4;

		[SMBFieldName("phs8_4")]
		[SMBFieldDescription("Phase")]
		public int phs8_4;

		[SMBFieldName("cst8_4")]
		[SMBFieldDescription("Cost Code")]
		public decimal cst8_4;

		[SMBFieldName("eqop84")]
		[SMBFieldDescription("Operated Equipment")]
		public int eqop84;

		[SMBFieldName("ohr8_4")]
		[SMBFieldDescription("Operated")]
		public decimal ohr8_4;

		[SMBFieldName("shr8_4")]
		[SMBFieldDescription("Standby")]
		public decimal shr8_4;

		[SMBFieldName("ihr8_4")]
		[SMBFieldDescription("Idle")]
		public decimal ihr8_4;

		[SMBFieldName("bunt84")]
		[SMBFieldDescription("Rental Unit")]
		public int bunt84;

		[SMBFieldName("opbl84")]
		[SMBFieldDescription("Operated Rental")]
		public decimal opbl84;

		[SMBFieldName("stbl84")]
		[SMBFieldDescription("Standby Rental")]
		public decimal stbl84;

		[SMBFieldName("idbl84")]
		[SMBFieldDescription("Idle Rental")]
		public decimal idbl84;

		[SMBFieldName("nte8_4")]
		[SMBFieldDescription("Notes")]
		public string nte8_4;

		[SMBFieldName("extcst")]
		[SMBFieldDescription("Total")]
		public decimal extcst;

		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Account")]
		public int dbtact;

		[SMBFieldName("dbtsub")]
		[SMBFieldDescription("Subaccount")]
		public int dbtsub;

		[SMBFieldName("dptact")]
		[SMBFieldDescription("Department")]
		public int dptact;

		[SMBFieldName("csun84")]
		[SMBFieldDescription("Cost Unit")]
		public string csun84;

		[SMBFieldName("dpbl86")]
		[SMBFieldDescription("Deprec Balance")]
		public decimal dpbl86;

		[SMBFieldName("tmpnme")]
		[SMBFieldDescription("Template Name")]
		public string tmpnme;

		[SMBFieldName("apbtch")]
		[SMBFieldDescription("Batch#")]
		public int apbtch;

		[SMBFieldName("job619")]
		[SMBFieldDescription("Job")]
		public int job619;

		[SMBFieldName("emp619")]
		[SMBFieldDescription("Job Supervisor")]
		public int emp619;

		[SMBFieldName("rec619")]
		[SMBFieldDescription("Record#")]
		public int rec619;

		[SMBFieldName("trn619")]
		[SMBFieldDescription("Transaction#")]
		public string trn619;

		[SMBFieldName("dsc619")]
		[SMBFieldDescription("Description")]
		public string dsc619;

		[SMBFieldName("dte619")]
		[SMBFieldDescription("Date")]
		public DateTime dte619;

		[SMBFieldName("jbg619")]
		[SMBFieldDescription("Job")]
		public int jbg619;

		[SMBFieldName("tbl619")]
		[SMBFieldDescription("Table")]
		public string tbl619;

		[SMBFieldName("clctyp")]
		[SMBFieldDescription("Calc Type")]
		public string clctyp;

		[SMBFieldName("srcndl")]
		[SMBFieldDescription("Beginning Date Post Serv. Con.")]
		public DateTime srcndl;

		[SMBFieldName("srcndh")]
		[SMBFieldDescription("Ending Date Post Srv. Con.")]
		public DateTime srcndh;

		[SMBFieldName("srrtdl")]
		[SMBFieldDescription("Beginning Date Post Srv. Route")]
		public DateTime srrtdl;

		[SMBFieldName("srrtdh")]
		[SMBFieldDescription("Ending Date Post Srv. Route")]
		public DateTime srrtdh;

		[SMBFieldName("srrtlw")]
		[SMBFieldDescription("Beginning Rcd. Post Srv. Route")]
		public int srrtlw;

		[SMBFieldName("srrthg")]
		[SMBFieldDescription("Ending Rcd. Post Srv. Route")]
		public int srrthg;

		[SMBFieldName("cpywrk")]
		[SMBFieldDescription("Service Order Copy Formatting")]
		public int cpywrk;

		[SMBFieldName("rmvsrv")]
		[SMBFieldDescription("Remove Service Date")]
		public DateTime rmvsrv;

		[SMBFieldName("fdrdtl")]
		[SMBFieldDescription("Field Report Date Low")]
		public DateTime fdrdtl;

		[SMBFieldName("fdrdth")]
		[SMBFieldDescription("Field Report Date High")]
		public DateTime fdrdth;

		[SMBFieldName("sumact")]
		[SMBFieldDescription("Summary Account")]
		public int sumact;

		[SMBFieldName("pstsum")]
		[SMBFieldDescription("Post in Summary")]
		public int pstsum;

		[SMBFieldName("chknbr")]
		[SMBFieldDescription("Starting Check Number")]
		public int chknbr;

		[SMBFieldName("chkdte")]
		[SMBFieldDescription("Check Date")]
		public DateTime chkdte;

		[SMBFieldName("chkgnl")]
		[SMBFieldDescription("General Checking Account")]
		public int chkgnl;

		[SMBFieldName("chkpyr")]
		[SMBFieldDescription("Payroll Checking Account")]
		public int chkpyr;

		[SMBFieldName("vchact")]
		[SMBFieldDescription("Voucher clearing account")]
		public int vchact;

		[SMBFieldName("timinv")]
		[SMBFieldDescription("Invoice #")]
		public string timinv;

		[SMBFieldName("tmindt")]
		[SMBFieldDescription("Invoice Date")]
		public DateTime tmindt;

		[SMBFieldName("tmjblw")]
		[SMBFieldDescription("T&M First Job")]
		public int tmjblw;

		[SMBFieldName("tmjbhg")]
		[SMBFieldDescription("T&M Last Job")]
		public int tmjbhg;

		[SMBFieldName("tmjobs")]
		[SMBFieldDescription("T&M Job Picklist")]
		public int tmjobs;

		[SMBFieldName("tmphlw")]
		[SMBFieldDescription("T&M First Phase")]
		public int tmphlw;

		[SMBFieldName("tmphhg")]
		[SMBFieldDescription("T&M Last Phase")]
		public int tmphhg;

		[SMBFieldName("tmphas")]
		[SMBFieldDescription("T&M Phase Picklist")]
		public int tmphas;

		[SMBFieldName("tmcdlw")]
		[SMBFieldDescription("T&M First Cost Code")]
		public decimal tmcdlw;

		[SMBFieldName("tmcdhg")]
		[SMBFieldDescription("T&M Last Cost Code")]
		public decimal tmcdhg;

		[SMBFieldName("tmcscd")]
		[SMBFieldDescription("T&M Cost Code Picklist")]
		public decimal tmcscd;

		[SMBFieldName("tmctdt")]
		[SMBFieldDescription("T&M Cutoff Date")]
		public DateTime tmctdt;

		[SMBFieldName("tmcstl")]
		[SMBFieldDescription("T&M First Cost Record")]
		public int tmcstl;

		[SMBFieldName("tmcsth")]
		[SMBFieldDescription("T&M Last Cost Record")]
		public int tmcsth;

		[SMBFieldName("subjct")]
		[SMBFieldDescription("Percent Subject to Rate")]
		public decimal subjct;

		[SMBFieldName("sumrte")]
		[SMBFieldDescription("Rate")]
		public decimal sumrte;

		[SMBFieldName("bndlmt")]
		[SMBFieldDescription("Bonding Limit")]
		public int bndlmt;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("sumamt")]
		[SMBFieldDescription("Summary Amount")]
		public decimal sumamt;

		[SMBFieldName("bal1_1")]
		[SMBFieldDescription("Account Balance")]
		public decimal bal1_1;

		[SMBFieldName("bal1_2")]
		[SMBFieldDescription("Account Balance")]
		public decimal bal1_2;

		[SMBFieldName("bal1_3")]
		[SMBFieldDescription("Account Balance")]
		public decimal bal1_3;

		[SMBFieldName("upd109")]
		[SMBFieldDescription("Update 1099 Balance")]
		public int upd109;

		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public int actper;

		[SMBFieldName("keyfld")]
		[SMBFieldDescription("7-7 Field Key")]
		public int keyfld;

		[SMBFieldName("dte542")]
		[SMBFieldDescription("Quarter Ending")]
		public DateTime dte542;

		[SMBFieldName("rptgyr")]
		[SMBFieldDescription("Reporting Year")]
		public int rptgyr;

		[SMBFieldName("ste546")]
		[SMBFieldDescription("Tax State")]
		public string ste546;

		[SMBFieldName("rptprd")]
		[SMBFieldDescription("Period")]
		public int rptprd;

		[SMBFieldName("dpr210")]
		[SMBFieldDescription("Depreciation Acct")]
		public int dpr210;

		[SMBFieldName("sls210")]
		[SMBFieldDescription("Sales Account")]
		public int sls210;

		[SMBFieldName("exp210")]
		[SMBFieldDescription("Prepaid Expense Acct")]
		public int exp210;

		[SMBFieldName("dftcde")]
		[SMBFieldDescription("Default Cost Code")]
		public decimal dftcde;

		[SMBFieldName("crdstr")]
		[SMBFieldDescription("Payroll Period Start Date")]
		public DateTime crdstr;

		[SMBFieldName("crdend")]
		[SMBFieldDescription("Payroll Period End Date")]
		public DateTime crdend;

		[SMBFieldName("vnddsc")]
		[SMBFieldDescription("Vendor Discount")]
		public decimal vnddsc;

		[SMBFieldName("mininv")]
		[SMBFieldDescription("Minimum Number of Invoices")]
		public int mininv;

		[SMBFieldName("finprd")]
		[SMBFieldDescription("Period")]
		public int finprd;

		[SMBFieldName("stmdte")]
		[SMBFieldDescription("Statement Date")]
		public DateTime stmdte;

		[SMBFieldName("bal3_3")]
		[SMBFieldDescription("Balance")]
		public decimal bal3_3;

		[SMBFieldName("unmpay")]
		[SMBFieldDescription("SUI Payments")]
		public decimal unmpay;

		[SMBFieldName("unmste")]
		[SMBFieldDescription("SUI State")]
		public string unmste;

		[SMBFieldName("unmnum")]
		[SMBFieldDescription("State Unemployment Id#")]
		public string unmnum;

		[SMBFieldName("futadp")]
		[SMBFieldDescription("FUTA Deposited")]
		public decimal futadp;

		[SMBFieldName("trmbus")]
		[SMBFieldDescription("Terminated Business")]
		public int trmbus;

		[SMBFieldName("subpin")]
		[SMBFieldDescription("PIN")]
		public string subpin;

		[SMBFieldName("subnme")]
		[SMBFieldDescription("Contact Name")]
		public string subnme;

		[SMBFieldName("subphn")]
		[SMBFieldDescription("Contact Phone Number")]
		public string subphn;

		[SMBFieldName("subphx")]
		[SMBFieldDescription("Contact Phone Extension")]
		public string subphx;

		[SMBFieldName("subfax")]
		[SMBFieldDescription("Contact FAX")]
		public string subfax;

		[SMBFieldName("subeml")]
		[SMBFieldDescription("Conact E-Mail")]
		public string subeml;

		[SMBFieldName("potype")]
		[SMBFieldDescription("PO Type List")]
		public int potype;

		[SMBFieldName("potask")]
		[SMBFieldDescription("PO Task List")]
		public decimal potask;

		[SMBFieldName("empytd")]
		[SMBFieldDescription("Year to Date")]
		public decimal empytd;

		[SMBFieldName("flttim")]
		[SMBFieldDescription("Flat Rate Time")]
		public int flttim;

		[SMBFieldName("fltcst")]
		[SMBFieldDescription("Flat Rate Cost")]
		public decimal fltcst;

		[SMBFieldName("fltmrk")]
		[SMBFieldDescription("Flat Rate Markup")]
		public decimal fltmrk;

		[SMBFieldName("fltsel")]
		[SMBFieldDescription("Flat Rate Sell Price")]
		public decimal fltsel;

		[SMBFieldName("fltpft")]
		[SMBFieldDescription("Flat Rate Profit")]
		public decimal fltpft;

		[SMBFieldName("fltmrg")]
		[SMBFieldDescription("Flat Rate Margin")]
		public decimal fltmrg;

		[SMBFieldName("ddpbch")]
		[SMBFieldDescription("Direct Dep. Batch#")]
		public int ddpbch;

		[SMBFieldName("rpscdt")]
		[SMBFieldDescription("Scheduled Report End Date")]
		public DateTime rpscdt;

		[SMBFieldName("rpscnm")]
		[SMBFieldDescription("Sched. Report Number of Times")]
		public int rpscnm;

		[SMBFieldName("rpscdy")]
		[SMBFieldDescription("Sched. Report Day of Month")]
		public int rpscdy;

		[SMBFieldName("jobjdk")]
		[SMBFieldDescription("Job")]
		public int jobjdk;

		[SMBFieldName("42scdy")]
		[SMBFieldDescription("Second Payee - Vendor To Pay")]
		public decimal _42scdy;

		[SMBFieldName("rmvpch")]
		[SMBFieldDescription("Remove Purchase Order Date")]
		public DateTime rmvpch;

		[SMBFieldName("jclegr")]
		[SMBFieldDescription("Job Costing Ledger Total")]
		public decimal jclegr;

		[SMBFieldName("jccost")]
		[SMBFieldDescription("Job Costing Cost Total")]
		public decimal jccost;

		[SMBFieldName("eqlegr")]
		[SMBFieldDescription("Equipment Costing Ledger Total")]
		public decimal eqlegr;

		[SMBFieldName("eqcost")]
		[SMBFieldDescription("Equipment Costing Cost Total")]
		public decimal eqcost;

		[SMBFieldName("crdtrn")]
		[SMBFieldDescription("Trans#")]
		public string crdtrn;

		[SMBFieldName("dtecrd")]
		[SMBFieldDescription("Trans Date")]
		public DateTime dtecrd;

		[SMBFieldName("crdcrd")]
		[SMBFieldDescription("Credit Card")]
		public int crdcrd;

		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee")]
		public string payee1;

		[SMBFieldName("lgrcrd")]
		[SMBFieldDescription("Select Card Issuer Account")]
		public int lgrcrd;

		[SMBFieldName("verify")]
		[SMBFieldDescription("Verified")]
		public string verify;

		[SMBFieldName("crdpay")]
		[SMBFieldDescription("Credits")]
		public decimal crdpay;

		[SMBFieldName("charge")]
		[SMBFieldDescription("Charges")]
		public decimal charge;

		[SMBFieldName("paymth")]
		[SMBFieldDescription("Pay By")]
		public string paymth;

		[SMBFieldName("crdvnd")]
		[SMBFieldDescription("Vendor")]
		public int crdvnd;

		[SMBFieldName("issuer")]
		[SMBFieldDescription("Card Issuer Account")]
		public int issuer;

		[SMBFieldName("issnme")]
		[SMBFieldDescription("Issuer Name")]
		public string issnme;

		[SMBFieldName("476bal")]
		[SMBFieldDescription("Current Balance")]
		public decimal _476bal;

		[SMBFieldName("476rcl")]
		[SMBFieldDescription("Last Reconciled Balance")]
		public decimal _476rcl;

		[SMBFieldName("prnrct")]
		[SMBFieldDescription("Print this receipt when saving")]
		public int prnrct;

		[SMBFieldName("cnttyp")]
		[SMBFieldDescription("Contact Type")]
		public string cnttyp;

		[SMBFieldName("cntrec")]
		[SMBFieldDescription("Contact Record")]
		public string cntrec;

		[SMBFieldName("cntcmp")]
		[SMBFieldDescription("Company")]
		public string cntcmp;

		[SMBFieldName("outlnk")]
		[SMBFieldDescription("Link with Outlook")]
		public string outlnk;

		[SMBFieldName("msolid")]
		[SMBFieldDescription("Outllook ID")]
		public string msolid;

		[SMBFieldName("cntsht")]
		[SMBFieldDescription("Short Name")]
		public string cntsht;

	}
}