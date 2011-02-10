using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class mscfld : smbtable {
		/// <summary>
		/// Account#                        
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("lgr1_1")]
		[SMBFieldDescription("Account#")]
		public long lgr1_1;

		/// <summary>
		/// Statement Cutoff Date           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dterge")]
		[SMBFieldDescription("Statement Cutoff Date")]
		public DateTime dterge;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public long actprd;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Client                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Ledger Accnt. Range             
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("lgrrge")]
		[SMBFieldDescription("Ledger Accnt. Range")]
		public long lgrrge;

		/// <summary>
		/// Fiscal Year End Date            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("enddte")]
		[SMBFieldDescription("Fiscal Year End Date")]
		public DateTime enddte;

		/// <summary>
		/// Subsidiary Ledger Accnt.#'s     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("subact")]
		[SMBFieldDescription("Subsidiary Ledger Accnt.#'s")]
		public long subact;

		/// <summary>
		/// Posting Accnt.#'s               
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("pstact")]
		[SMBFieldDescription("Posting Accnt.#'s")]
		public long pstact;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("period")]
		[SMBFieldDescription("Period")]
		public long period;

		/// <summary>
		/// Period Ending                   
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("perdte")]
		[SMBFieldDescription("Period Ending")]
		public DateTime perdte;

		/// <summary>
		/// Employee# Lower Range           
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("emprgf")]
		[SMBFieldDescription("Employee# Lower Range")]
		public long emprgf;

		/// <summary>
		/// Employee# Upper Range           
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("emprgl")]
		[SMBFieldDescription("Employee# Upper Range")]
		public long emprgl;

		/// <summary>
		/// Employee Pick List              
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("emplst")]
		[SMBFieldDescription("Employee Pick List")]
		public long emplst;

		/// <summary>
		/// First Payroll Record#           
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("payrcf")]
		[SMBFieldDescription("First Payroll Record#")]
		public long payrcf;

		/// <summary>
		/// Last Payrol Record#             
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("payrcl")]
		[SMBFieldDescription("Last Payrol Record#")]
		public long payrcl;

		/// <summary>
		/// Record Pick List                
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("reclst")]
		[SMBFieldDescription("Record Pick List")]
		public long reclst;

		/// <summary>
		/// Checking Act.#                  
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("chkact")]
		[SMBFieldDescription("Checking Act.#")]
		public long chkact;

		/// <summary>
		/// Payroll Ending Date             
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("paydte")]
		[SMBFieldDescription("Payroll Ending Date")]
		public DateTime paydte;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("trntyp")]
		[SMBFieldDescription("Type")]
		public string trntyp;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Lender                          
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("lender")]
		[SMBFieldDescription("Lender")]
		public long lender;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("duedte")]
		[SMBFieldDescription("Due Date")]
		public DateTime duedte;

		/// <summary>
		/// Payment                         
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("paymnt")]
		[SMBFieldDescription("Payment")]
		public decimal paymnt;

		/// <summary>
		/// Set to Pay                      
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("setpay")]
		[SMBFieldDescription("Set to Pay")]
		public decimal setpay;

		/// <summary>
		/// Capitalized                     
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("capend")]
		[SMBFieldDescription("Capitalized")]
		public decimal capend;

		/// <summary>
		/// To Date                         
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("depend")]
		[SMBFieldDescription("To Date")]
		public decimal depend;

		/// <summary>
		/// Last Posted                     
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("lstpst")]
		[SMBFieldDescription("Last Posted")]
		public string lstpst;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("msceqp")]
		[SMBFieldDescription("Equipment")]
		public long msceqp;

		/// <summary>
		/// Account#                        
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("lgracc")]
		[SMBFieldDescription("Account#")]
		public long lgracc;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		/// <summary>
		/// Deposit#                        
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("depnum")]
		[SMBFieldDescription("Deposit#")]
		public string depnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Client#                         
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("reccln")]
		[SMBFieldDescription("Client#")]
		public long reccln;

		/// <summary>
		/// Preference#                     
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("vndprf")]
		[SMBFieldDescription("Preference#")]
		public long vndprf;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Field Selection                 
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("slccrt")]
		[SMBFieldDescription("Field Selection")]
		public string slccrt;

		/// <summary>
		/// Field Selection  Criteria       
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("crttyp")]
		[SMBFieldDescription("Field Selection  Criteria")]
		public string crttyp;

		/// <summary>
		/// Field Selection  Value          
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("crtval")]
		[SMBFieldDescription("Field Selection  Value")]
		public string crtval;

		/// <summary>
		/// Change Field                    
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("chgfld")]
		[SMBFieldDescription("Change Field")]
		public string chgfld;

		/// <summary>
		/// Change Field Based On           
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("baseon")]
		[SMBFieldDescription("Change Field Based On")]
		public string baseon;

		/// <summary>
		/// Change Field By                 
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("chg_by")]
		[SMBFieldDescription("Change Field By")]
		public string chg_by;

		/// <summary>
		/// New Field Value                 
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("newval")]
		[SMBFieldDescription("New Field Value")]
		public string newval;

		/// <summary>
		/// Part#                           
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("prtdsc")]
		[SMBFieldDescription("Description")]
		public string prtdsc;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("prtunt")]
		[SMBFieldDescription("Unit")]
		public string prtunt;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		/// <summary>
		/// Price                           
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Price")]
		public decimal prtprc;

		/// <summary>
		/// Extended                        
		/// </summary>
		[ColumnOrder(490)]
		[SMBFieldName("extprc")]
		[SMBFieldDescription("Extended")]
		public decimal extprc;

		/// <summary>
		/// Payroll Check Date              
		/// </summary>
		[ColumnOrder(500)]
		[SMBFieldName("crddte")]
		[SMBFieldDescription("Payroll Check Date")]
		public DateTime crddte;

		/// <summary>
		/// Payroll Quarter                 
		/// </summary>
		[ColumnOrder(510)]
		[SMBFieldName("crdqtr")]
		[SMBFieldDescription("Payroll Quarter")]
		public long crdqtr;

		/// <summary>
		/// Account#                        
		/// </summary>
		[ColumnOrder(520)]
		[SMBFieldName("lgr1_2")]
		[SMBFieldDescription("Account#")]
		public long lgr1_2;

		/// <summary>
		/// Account#                        
		/// </summary>
		[ColumnOrder(530)]
		[SMBFieldName("lgr1_5")]
		[SMBFieldDescription("Account#")]
		public long lgr1_5;

		/// <summary>
		/// Labor Burden                    
		/// </summary>
		[ColumnOrder(540)]
		[SMBFieldName("lbrbur")]
		[SMBFieldDescription("Labor Burden")]
		public decimal lbrbur;

		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(550)]
		[SMBFieldName("cshrec")]
		[SMBFieldDescription("Record#")]
		public long cshrec;

		/// <summary>
		/// Account                         
		/// </summary>
		[ColumnOrder(560)]
		[SMBFieldName("lgr3_3")]
		[SMBFieldDescription("Account")]
		public long lgr3_3;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[ColumnOrder(570)]
		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[ColumnOrder(580)]
		[SMBFieldName("cshdte")]
		[SMBFieldDescription("Due Date")]
		public DateTime cshdte;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(590)]
		[SMBFieldName("cshdsc")]
		[SMBFieldDescription("Description")]
		public string cshdsc;

		/// <summary>
		/// Amount                          
		/// </summary>
		[ColumnOrder(600)]
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Amount")]
		public decimal invttl;

		/// <summary>
		/// Balance                         
		/// </summary>
		[ColumnOrder(610)]
		[SMBFieldName("invbal")]
		[SMBFieldDescription("Balance")]
		public decimal invbal;

		/// <summary>
		/// Retention                       
		/// </summary>
		[ColumnOrder(620)]
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		/// <summary>
		/// Disc Avail                      
		/// </summary>
		[ColumnOrder(630)]
		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Disc Avail")]
		public decimal dscavl;

		/// <summary>
		/// Check#                          
		/// </summary>
		[ColumnOrder(640)]
		[SMBFieldName("chknum")]
		[SMBFieldDescription("Check#")]
		public string chknum;

		/// <summary>
		/// Paid(Cash)                      
		/// </summary>
		[ColumnOrder(650)]
		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid(Cash)")]
		public decimal amtpad;

		/// <summary>
		/// Discount                        
		/// </summary>
		[ColumnOrder(660)]
		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Discount")]
		public decimal dsctkn;

		/// <summary>
		/// Credit                          
		/// </summary>
		[ColumnOrder(670)]
		[SMBFieldName("credit")]
		[SMBFieldDescription("Credit")]
		public decimal credit;

		/// <summary>
		/// Bid Item                        
		/// </summary>
		[ColumnOrder(680)]
		[SMBFieldName("biditm")]
		[SMBFieldDescription("Bid Item")]
		public long biditm;

		/// <summary>
		/// Labor Markups                   
		/// </summary>
		[ColumnOrder(690)]
		[SMBFieldName("mrklab")]
		[SMBFieldDescription("Labor Markups")]
		public decimal mrklab;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(700)]
		[SMBFieldName("jobphs")]
		[SMBFieldDescription("Phase")]
		public long jobphs;

		/// <summary>
		/// Markups                         
		/// </summary>
		[ColumnOrder(710)]
		[SMBFieldName("mrkups")]
		[SMBFieldDescription("Markups")]
		public decimal mrkups;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(720)]
		[SMBFieldName("schjob")]
		[SMBFieldDescription("Job")]
		public long schjob;

		/// <summary>
		/// Service Contract Discount       
		/// </summary>
		[ColumnOrder(730)]
		[SMBFieldName("mrkdsc")]
		[SMBFieldDescription("Service Contract Discount")]
		public decimal mrkdsc;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(740)]
		[SMBFieldName("schphs")]
		[SMBFieldDescription("Phase")]
		public long schphs;

		/// <summary>
		/// Apply to Classes                
		/// </summary>
		[ColumnOrder(750)]
		[SMBFieldName("mrkcls")]
		[SMBFieldDescription("Apply to Classes")]
		public long mrkcls;

		/// <summary>
		/// Check#                          
		/// </summary>
		[ColumnOrder(760)]
		[SMBFieldName("chk1_1")]
		[SMBFieldDescription("Check#")]
		public string chk1_1;

		/// <summary>
		/// Cutoff Date                     
		/// </summary>
		[ColumnOrder(770)]
		[SMBFieldName("cutdte")]
		[SMBFieldDescription("Cutoff Date")]
		public DateTime cutdte;

		/// <summary>
		/// Deposit#                        
		/// </summary>
		[ColumnOrder(780)]
		[SMBFieldName("dep1_2")]
		[SMBFieldDescription("Deposit#")]
		public string dep1_2;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[ColumnOrder(790)]
		[SMBFieldName("srvinv")]
		[SMBFieldDescription("Invoice#")]
		public string srvinv;

		/// <summary>
		/// Client                          
		/// </summary>
		[ColumnOrder(800)]
		[SMBFieldName("client")]
		[SMBFieldDescription("Client")]
		public long client;

		/// <summary>
		/// Overpayment                     
		/// </summary>
		[ColumnOrder(810)]
		[SMBFieldName("ovrpay")]
		[SMBFieldDescription("Overpayment")]
		public decimal ovrpay;

		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(820)]
		[SMBFieldName("cntjob")]
		[SMBFieldDescription("Job#")]
		public long cntjob;

		/// <summary>
		/// Deposit#                        
		/// </summary>
		[ColumnOrder(830)]
		[SMBFieldName("trn3_3")]
		[SMBFieldDescription("Deposit#")]
		public string trn3_3;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(840)]
		[SMBFieldName("dte3_3")]
		[SMBFieldDescription("Date")]
		public DateTime dte3_3;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(850)]
		[SMBFieldName("dsc3_3")]
		[SMBFieldDescription("Description")]
		public string dsc3_3;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(860)]
		[SMBFieldName("retdte")]
		[SMBFieldDescription("Date")]
		public DateTime retdte;

		/// <summary>
		/// Invoice# for Prog. Bill         
		/// </summary>
		[ColumnOrder(870)]
		[SMBFieldName("inv3_7")]
		[SMBFieldDescription("Invoice# for Prog. Bill")]
		public string inv3_7;

		/// <summary>
		/// Part#                           
		/// </summary>
		[ColumnOrder(880)]
		[SMBFieldName("tkfprt")]
		[SMBFieldDescription("Part#")]
		public long tkfprt;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(890)]
		[SMBFieldName("dsc666")]
		[SMBFieldDescription("Description")]
		public string dsc666;

		/// <summary>
		/// Alpha Part#                     
		/// </summary>
		[ColumnOrder(900)]
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(910)]
		[SMBFieldName("unt666")]
		[SMBFieldDescription("Unit")]
		public string unt666;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(920)]
		[SMBFieldName("linqty")]
		[SMBFieldDescription("Quantity")]
		public decimal linqty;

		/// <summary>
		/// Inventory Location              
		/// </summary>
		[ColumnOrder(930)]
		[SMBFieldName("invloc")]
		[SMBFieldDescription("Inventory Location")]
		public long invloc;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[ColumnOrder(940)]
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		/// <summary>
		/// Shipping#                       
		/// </summary>
		[ColumnOrder(950)]
		[SMBFieldName("shpnum")]
		[SMBFieldDescription("Shipping#")]
		public string shpnum;

		/// <summary>
		/// Vendor Lower Range              
		/// </summary>
		[ColumnOrder(960)]
		[SMBFieldName("vnd43f")]
		[SMBFieldDescription("Vendor Lower Range")]
		public long vnd43f;

		/// <summary>
		/// Vendor Upper Range              
		/// </summary>
		[ColumnOrder(970)]
		[SMBFieldName("vnd43l")]
		[SMBFieldDescription("Vendor Upper Range")]
		public long vnd43l;

		/// <summary>
		/// Vendor List                     
		/// </summary>
		[ColumnOrder(980)]
		[SMBFieldName("vndlst")]
		[SMBFieldDescription("Vendor List")]
		public long vndlst;

		/// <summary>
		/// Job Upper Range                 
		/// </summary>
		[ColumnOrder(990)]
		[SMBFieldName("job43l")]
		[SMBFieldDescription("Job Upper Range")]
		public long job43l;

		/// <summary>
		/// Job Lower Rasnge                
		/// </summary>
		[ColumnOrder(1000)]
		[SMBFieldName("job43f")]
		[SMBFieldDescription("Job Lower Rasnge")]
		public long job43f;

		/// <summary>
		/// Job List                        
		/// </summary>
		[ColumnOrder(1010)]
		[SMBFieldName("joblst")]
		[SMBFieldDescription("Job List")]
		public long joblst;

		/// <summary>
		/// Due/Disc Date                   
		/// </summary>
		[ColumnOrder(1020)]
		[SMBFieldName("dte4_3")]
		[SMBFieldDescription("Due/Disc Date")]
		public DateTime dte4_3;

		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(1030)]
		[SMBFieldName("rec4_3")]
		[SMBFieldDescription("Record#")]
		public long rec4_3;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(1040)]
		[SMBFieldName("vnd4_3")]
		[SMBFieldDescription("Vendor")]
		public long vnd4_3;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(1050)]
		[SMBFieldName("job4_3")]
		[SMBFieldDescription("Job")]
		public long job4_3;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[ColumnOrder(1060)]
		[SMBFieldName("inv4_3")]
		[SMBFieldDescription("Invoice#")]
		public string inv4_3;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[ColumnOrder(1070)]
		[SMBFieldName("due4_3")]
		[SMBFieldDescription("Due Date")]
		public DateTime due4_3;

		/// <summary>
		/// Disc Date                       
		/// </summary>
		[ColumnOrder(1080)]
		[SMBFieldName("dsc4_3")]
		[SMBFieldDescription("Disc Date")]
		public DateTime dsc4_3;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(1090)]
		[SMBFieldName("stat43")]
		[SMBFieldDescription("Status")]
		public long stat43;

		/// <summary>
		/// Posting Subaccount              
		/// </summary>
		[ColumnOrder(1100)]
		[SMBFieldName("pstsub")]
		[SMBFieldDescription("Posting Subaccount")]
		public long pstsub;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(1110)]
		[SMBFieldName("trnd84")]
		[SMBFieldDescription("Date")]
		public DateTime trnd84;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(1120)]
		[SMBFieldName("dsc8_4")]
		[SMBFieldDescription("Description")]
		public string dsc8_4;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(1130)]
		[SMBFieldName("job8_4")]
		[SMBFieldDescription("Job")]
		public long job8_4;

		/// <summary>
		/// Equip Repaired                  
		/// </summary>
		[ColumnOrder(1140)]
		[SMBFieldName("eqp8_4")]
		[SMBFieldDescription("Equip Repaired")]
		public long eqp8_4;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(1150)]
		[SMBFieldName("phs8_4")]
		[SMBFieldDescription("Phase")]
		public long phs8_4;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(1160)]
		[SMBFieldName("cst8_4")]
		[SMBFieldDescription("Cost Code")]
		public decimal cst8_4;

		/// <summary>
		/// Operated Equipment              
		/// </summary>
		[ColumnOrder(1170)]
		[SMBFieldName("eqop84")]
		[SMBFieldDescription("Operated Equipment")]
		public long eqop84;

		/// <summary>
		/// Operated                        
		/// </summary>
		[ColumnOrder(1180)]
		[SMBFieldName("ohr8_4")]
		[SMBFieldDescription("Operated")]
		public decimal ohr8_4;

		/// <summary>
		/// Standby                         
		/// </summary>
		[ColumnOrder(1190)]
		[SMBFieldName("shr8_4")]
		[SMBFieldDescription("Standby")]
		public decimal shr8_4;

		/// <summary>
		/// Idle                            
		/// </summary>
		[ColumnOrder(1200)]
		[SMBFieldName("ihr8_4")]
		[SMBFieldDescription("Idle")]
		public decimal ihr8_4;

		/// <summary>
		/// Rental Unit                     
		/// </summary>
		[ColumnOrder(1210)]
		[SMBFieldName("bunt84")]
		[SMBFieldDescription("Rental Unit")]
		public long bunt84;

		/// <summary>
		/// Operated Rental                 
		/// </summary>
		[ColumnOrder(1220)]
		[SMBFieldName("opbl84")]
		[SMBFieldDescription("Operated Rental")]
		public decimal opbl84;

		/// <summary>
		/// Standby Rental                  
		/// </summary>
		[ColumnOrder(1230)]
		[SMBFieldName("stbl84")]
		[SMBFieldDescription("Standby Rental")]
		public decimal stbl84;

		/// <summary>
		/// Idle Rental                     
		/// </summary>
		[ColumnOrder(1240)]
		[SMBFieldName("idbl84")]
		[SMBFieldDescription("Idle Rental")]
		public decimal idbl84;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(1250)]
		[SMBFieldName("nte8_4")]
		[SMBFieldDescription("Notes")]
		public string nte8_4;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(1260)]
		[SMBFieldName("extcst")]
		[SMBFieldDescription("Total")]
		public decimal extcst;

		/// <summary>
		/// Account                         
		/// </summary>
		[ColumnOrder(1270)]
		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Account")]
		public long dbtact;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[ColumnOrder(1280)]
		[SMBFieldName("dbtsub")]
		[SMBFieldDescription("Subaccount")]
		public long dbtsub;

		/// <summary>
		/// Department                      
		/// </summary>
		[ColumnOrder(1290)]
		[SMBFieldName("dptact")]
		[SMBFieldDescription("Department")]
		public long dptact;

		/// <summary>
		/// Cost Unit                       
		/// </summary>
		[ColumnOrder(1300)]
		[SMBFieldName("csun84")]
		[SMBFieldDescription("Cost Unit")]
		public string csun84;

		/// <summary>
		/// Deprec Balance                  
		/// </summary>
		[ColumnOrder(1310)]
		[SMBFieldName("dpbl86")]
		[SMBFieldDescription("Deprec Balance")]
		public decimal dpbl86;

		/// <summary>
		/// Template Name                   
		/// </summary>
		[ColumnOrder(1320)]
		[SMBFieldName("tmpnme")]
		[SMBFieldDescription("Template Name")]
		public string tmpnme;

		/// <summary>
		/// Batch#                          
		/// </summary>
		[ColumnOrder(1330)]
		[SMBFieldName("apbtch")]
		[SMBFieldDescription("Batch#")]
		public long apbtch;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(1340)]
		[SMBFieldName("job619")]
		[SMBFieldDescription("Job")]
		public long job619;

		/// <summary>
		/// Job Supervisor                  
		/// </summary>
		[ColumnOrder(1350)]
		[SMBFieldName("emp619")]
		[SMBFieldDescription("Job Supervisor")]
		public long emp619;

		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(1360)]
		[SMBFieldName("rec619")]
		[SMBFieldDescription("Record#")]
		public long rec619;

		/// <summary>
		/// Transaction#                    
		/// </summary>
		[ColumnOrder(1370)]
		[SMBFieldName("trn619")]
		[SMBFieldDescription("Transaction#")]
		public string trn619;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(1380)]
		[SMBFieldName("dsc619")]
		[SMBFieldDescription("Description")]
		public string dsc619;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(1390)]
		[SMBFieldName("dte619")]
		[SMBFieldDescription("Date")]
		public DateTime dte619;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(1400)]
		[SMBFieldName("jbg619")]
		[SMBFieldDescription("Job")]
		public long jbg619;

		/// <summary>
		/// Table                           
		/// </summary>
		[ColumnOrder(1410)]
		[SMBFieldName("tbl619")]
		[SMBFieldDescription("Table")]
		public string tbl619;

		/// <summary>
		/// Calc Type                       
		/// </summary>
		[ColumnOrder(1420)]
		[SMBFieldName("clctyp")]
		[SMBFieldDescription("Calc Type")]
		public string clctyp;

		/// <summary>
		/// Beginning Date Post Serv. Con.  
		/// </summary>
		[ColumnOrder(1430)]
		[SMBFieldName("srcndl")]
		[SMBFieldDescription("Beginning Date Post Serv. Con.")]
		public DateTime srcndl;

		/// <summary>
		/// Ending Date Post Srv. Con.      
		/// </summary>
		[ColumnOrder(1440)]
		[SMBFieldName("srcndh")]
		[SMBFieldDescription("Ending Date Post Srv. Con.")]
		public DateTime srcndh;

		/// <summary>
		/// Beginning Date Post Srv. Route  
		/// </summary>
		[ColumnOrder(1450)]
		[SMBFieldName("srrtdl")]
		[SMBFieldDescription("Beginning Date Post Srv. Route")]
		public DateTime srrtdl;

		/// <summary>
		/// Ending Date Post Srv. Route     
		/// </summary>
		[ColumnOrder(1460)]
		[SMBFieldName("srrtdh")]
		[SMBFieldDescription("Ending Date Post Srv. Route")]
		public DateTime srrtdh;

		/// <summary>
		/// Beginning Rcd. Post Srv. Route  
		/// </summary>
		[ColumnOrder(1470)]
		[SMBFieldName("srrtlw")]
		[SMBFieldDescription("Beginning Rcd. Post Srv. Route")]
		public long srrtlw;

		/// <summary>
		/// Ending Rcd. Post Srv. Route     
		/// </summary>
		[ColumnOrder(1480)]
		[SMBFieldName("srrthg")]
		[SMBFieldDescription("Ending Rcd. Post Srv. Route")]
		public long srrthg;

		/// <summary>
		/// Service Order Copy Formatting   
		/// </summary>
		[ColumnOrder(1490)]
		[SMBFieldName("cpywrk")]
		[SMBFieldDescription("Service Order Copy Formatting")]
		public long cpywrk;

		/// <summary>
		/// Remove Service Date             
		/// </summary>
		[ColumnOrder(1500)]
		[SMBFieldName("rmvsrv")]
		[SMBFieldDescription("Remove Service Date")]
		public DateTime rmvsrv;

		/// <summary>
		/// Field Report Date Low           
		/// </summary>
		[ColumnOrder(1510)]
		[SMBFieldName("fdrdtl")]
		[SMBFieldDescription("Field Report Date Low")]
		public DateTime fdrdtl;

		/// <summary>
		/// Field Report Date High          
		/// </summary>
		[ColumnOrder(1520)]
		[SMBFieldName("fdrdth")]
		[SMBFieldDescription("Field Report Date High")]
		public DateTime fdrdth;

		/// <summary>
		/// Summary Account                 
		/// </summary>
		[ColumnOrder(1530)]
		[SMBFieldName("sumact")]
		[SMBFieldDescription("Summary Account")]
		public long sumact;

		/// <summary>
		/// Post in Summary                 
		/// </summary>
		[ColumnOrder(1540)]
		[SMBFieldName("pstsum")]
		[SMBFieldDescription("Post in Summary")]
		public long pstsum;

		/// <summary>
		/// Starting Check Number           
		/// </summary>
		[ColumnOrder(1550)]
		[SMBFieldName("chknbr")]
		[SMBFieldDescription("Starting Check Number")]
		public long chknbr;

		/// <summary>
		/// Check Date                      
		/// </summary>
		[ColumnOrder(1560)]
		[SMBFieldName("chkdte")]
		[SMBFieldDescription("Check Date")]
		public DateTime chkdte;

		/// <summary>
		/// General Checking Account        
		/// </summary>
		[ColumnOrder(1570)]
		[SMBFieldName("chkgnl")]
		[SMBFieldDescription("General Checking Account")]
		public long chkgnl;

		/// <summary>
		/// Payroll Checking Account        
		/// </summary>
		[ColumnOrder(1580)]
		[SMBFieldName("chkpyr")]
		[SMBFieldDescription("Payroll Checking Account")]
		public long chkpyr;

		/// <summary>
		/// Voucher clearing account        
		/// </summary>
		[ColumnOrder(1590)]
		[SMBFieldName("vchact")]
		[SMBFieldDescription("Voucher clearing account")]
		public long vchact;

		/// <summary>
		/// Invoice #                       
		/// </summary>
		[ColumnOrder(1600)]
		[SMBFieldName("timinv")]
		[SMBFieldDescription("Invoice #")]
		public string timinv;

		/// <summary>
		/// Invoice Date                    
		/// </summary>
		[ColumnOrder(1610)]
		[SMBFieldName("tmindt")]
		[SMBFieldDescription("Invoice Date")]
		public DateTime tmindt;

		/// <summary>
		/// T&M First Job                   
		/// </summary>
		[ColumnOrder(1620)]
		[SMBFieldName("tmjblw")]
		[SMBFieldDescription("T&M First Job")]
		public long tmjblw;

		/// <summary>
		/// T&M Last Job                    
		/// </summary>
		[ColumnOrder(1630)]
		[SMBFieldName("tmjbhg")]
		[SMBFieldDescription("T&M Last Job")]
		public long tmjbhg;

		/// <summary>
		/// T&M Job Picklist                
		/// </summary>
		[ColumnOrder(1640)]
		[SMBFieldName("tmjobs")]
		[SMBFieldDescription("T&M Job Picklist")]
		public long tmjobs;

		/// <summary>
		/// T&M First Phase                 
		/// </summary>
		[ColumnOrder(1650)]
		[SMBFieldName("tmphlw")]
		[SMBFieldDescription("T&M First Phase")]
		public long tmphlw;

		/// <summary>
		/// T&M Last Phase                  
		/// </summary>
		[ColumnOrder(1660)]
		[SMBFieldName("tmphhg")]
		[SMBFieldDescription("T&M Last Phase")]
		public long tmphhg;

		/// <summary>
		/// T&M Phase Picklist              
		/// </summary>
		[ColumnOrder(1670)]
		[SMBFieldName("tmphas")]
		[SMBFieldDescription("T&M Phase Picklist")]
		public long tmphas;

		/// <summary>
		/// T&M First Cost Code             
		/// </summary>
		[ColumnOrder(1680)]
		[SMBFieldName("tmcdlw")]
		[SMBFieldDescription("T&M First Cost Code")]
		public decimal tmcdlw;

		/// <summary>
		/// T&M Last Cost Code              
		/// </summary>
		[ColumnOrder(1690)]
		[SMBFieldName("tmcdhg")]
		[SMBFieldDescription("T&M Last Cost Code")]
		public decimal tmcdhg;

		/// <summary>
		/// T&M Cost Code Picklist          
		/// </summary>
		[ColumnOrder(1700)]
		[SMBFieldName("tmcscd")]
		[SMBFieldDescription("T&M Cost Code Picklist")]
		public decimal tmcscd;

		/// <summary>
		/// T&M Cutoff Date                 
		/// </summary>
		[ColumnOrder(1710)]
		[SMBFieldName("tmctdt")]
		[SMBFieldDescription("T&M Cutoff Date")]
		public DateTime tmctdt;

		/// <summary>
		/// T&M First Cost Record           
		/// </summary>
		[ColumnOrder(1720)]
		[SMBFieldName("tmcstl")]
		[SMBFieldDescription("T&M First Cost Record")]
		public long tmcstl;

		/// <summary>
		/// T&M Last Cost Record            
		/// </summary>
		[ColumnOrder(1730)]
		[SMBFieldName("tmcsth")]
		[SMBFieldDescription("T&M Last Cost Record")]
		public long tmcsth;

		/// <summary>
		/// Percent Subject to Rate         
		/// </summary>
		[ColumnOrder(1740)]
		[SMBFieldName("subjct")]
		[SMBFieldDescription("Percent Subject to Rate")]
		public decimal subjct;

		/// <summary>
		/// Rate                            
		/// </summary>
		[ColumnOrder(1750)]
		[SMBFieldName("sumrte")]
		[SMBFieldDescription("Rate")]
		public decimal sumrte;

		/// <summary>
		/// Bonding Limit                   
		/// </summary>
		[ColumnOrder(1760)]
		[SMBFieldName("bndlmt")]
		[SMBFieldDescription("Bonding Limit")]
		public long bndlmt;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(1770)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(1780)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Summary Amount                  
		/// </summary>
		[ColumnOrder(1790)]
		[SMBFieldName("sumamt")]
		[SMBFieldDescription("Summary Amount")]
		public decimal sumamt;

		/// <summary>
		/// Account Balance                 
		/// </summary>
		[ColumnOrder(1800)]
		[SMBFieldName("bal1_1")]
		[SMBFieldDescription("Account Balance")]
		public decimal bal1_1;

		/// <summary>
		/// Account Balance                 
		/// </summary>
		[ColumnOrder(1810)]
		[SMBFieldName("bal1_2")]
		[SMBFieldDescription("Account Balance")]
		public decimal bal1_2;

		/// <summary>
		/// Account Balance                 
		/// </summary>
		[ColumnOrder(1820)]
		[SMBFieldName("bal1_3")]
		[SMBFieldDescription("Account Balance")]
		public decimal bal1_3;

		/// <summary>
		/// Update 1099 Balance             
		/// </summary>
		[ColumnOrder(1830)]
		[SMBFieldName("upd109")]
		[SMBFieldDescription("Update 1099 Balance")]
		public long upd109;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(1840)]
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// 7-7 Field Key                   
		/// </summary>
		[ColumnOrder(1850)]
		[SMBFieldName("keyfld")]
		[SMBFieldDescription("7-7 Field Key")]
		public long keyfld;

		/// <summary>
		/// Quarter Ending                  
		/// </summary>
		[ColumnOrder(1860)]
		[SMBFieldName("dte542")]
		[SMBFieldDescription("Quarter Ending")]
		public DateTime dte542;

		/// <summary>
		/// Reporting Year                  
		/// </summary>
		[ColumnOrder(1870)]
		[SMBFieldName("rptgyr")]
		[SMBFieldDescription("Reporting Year")]
		public long rptgyr;

		/// <summary>
		/// Tax State                       
		/// </summary>
		[ColumnOrder(1880)]
		[SMBFieldName("ste546")]
		[SMBFieldDescription("Tax State")]
		public string ste546;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(1890)]
		[SMBFieldName("rptprd")]
		[SMBFieldDescription("Period")]
		public long rptprd;

		/// <summary>
		/// Depreciation Acct               
		/// </summary>
		[ColumnOrder(1900)]
		[SMBFieldName("dpr210")]
		[SMBFieldDescription("Depreciation Acct")]
		public long dpr210;

		/// <summary>
		/// Sales Account                   
		/// </summary>
		[ColumnOrder(1910)]
		[SMBFieldName("sls210")]
		[SMBFieldDescription("Sales Account")]
		public long sls210;

		/// <summary>
		/// Prepaid Expense Acct            
		/// </summary>
		[ColumnOrder(1920)]
		[SMBFieldName("exp210")]
		[SMBFieldDescription("Prepaid Expense Acct")]
		public long exp210;

		/// <summary>
		/// Default Cost Code               
		/// </summary>
		[ColumnOrder(1930)]
		[SMBFieldName("dftcde")]
		[SMBFieldDescription("Default Cost Code")]
		public decimal dftcde;

		/// <summary>
		/// Payroll Period Start Date       
		/// </summary>
		[ColumnOrder(1940)]
		[SMBFieldName("crdstr")]
		[SMBFieldDescription("Payroll Period Start Date")]
		public DateTime crdstr;

		/// <summary>
		/// Payroll Period End Date         
		/// </summary>
		[ColumnOrder(1950)]
		[SMBFieldName("crdend")]
		[SMBFieldDescription("Payroll Period End Date")]
		public DateTime crdend;

		/// <summary>
		/// Vendor Discount                 
		/// </summary>
		[ColumnOrder(1960)]
		[SMBFieldName("vnddsc")]
		[SMBFieldDescription("Vendor Discount")]
		public decimal vnddsc;

		/// <summary>
		/// Minimum Number of Invoices      
		/// </summary>
		[ColumnOrder(1970)]
		[SMBFieldName("mininv")]
		[SMBFieldDescription("Minimum Number of Invoices")]
		public long mininv;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(1980)]
		[SMBFieldName("finprd")]
		[SMBFieldDescription("Period")]
		public long finprd;

		/// <summary>
		/// Statement Date                  
		/// </summary>
		[ColumnOrder(1990)]
		[SMBFieldName("stmdte")]
		[SMBFieldDescription("Statement Date")]
		public DateTime stmdte;

		/// <summary>
		/// Balance                         
		/// </summary>
		[ColumnOrder(2000)]
		[SMBFieldName("bal3_3")]
		[SMBFieldDescription("Balance")]
		public decimal bal3_3;

		/// <summary>
		/// SUI Payments                    
		/// </summary>
		[ColumnOrder(2010)]
		[SMBFieldName("unmpay")]
		[SMBFieldDescription("SUI Payments")]
		public decimal unmpay;

		/// <summary>
		/// SUI State                       
		/// </summary>
		[ColumnOrder(2020)]
		[SMBFieldName("unmste")]
		[SMBFieldDescription("SUI State")]
		public string unmste;

		/// <summary>
		/// State Unemployment Id#          
		/// </summary>
		[ColumnOrder(2030)]
		[SMBFieldName("unmnum")]
		[SMBFieldDescription("State Unemployment Id#")]
		public string unmnum;

		/// <summary>
		/// FUTA Deposited                  
		/// </summary>
		[ColumnOrder(2040)]
		[SMBFieldName("futadp")]
		[SMBFieldDescription("FUTA Deposited")]
		public decimal futadp;

		/// <summary>
		/// Terminated Business             
		/// </summary>
		[ColumnOrder(2050)]
		[SMBFieldName("trmbus")]
		[SMBFieldDescription("Terminated Business")]
		public long trmbus;

		/// <summary>
		///  PIN                            
		/// </summary>
		[ColumnOrder(2060)]
		[SMBFieldName("subpin")]
		[SMBFieldDescription("PIN")]
		public string subpin;

		/// <summary>
		/// Contact Name                    
		/// </summary>
		[ColumnOrder(2070)]
		[SMBFieldName("subnme")]
		[SMBFieldDescription("Contact Name")]
		public string subnme;

		/// <summary>
		/// Contact Phone Number            
		/// </summary>
		[ColumnOrder(2080)]
		[SMBFieldName("subphn")]
		[SMBFieldDescription("Contact Phone Number")]
		public string subphn;

		/// <summary>
		/// Contact Phone Extension         
		/// </summary>
		[ColumnOrder(2090)]
		[SMBFieldName("subphx")]
		[SMBFieldDescription("Contact Phone Extension")]
		public string subphx;

		/// <summary>
		/// Contact FAX                     
		/// </summary>
		[ColumnOrder(2100)]
		[SMBFieldName("subfax")]
		[SMBFieldDescription("Contact FAX")]
		public string subfax;

		/// <summary>
		/// Conact E-Mail                   
		/// </summary>
		[ColumnOrder(2110)]
		[SMBFieldName("subeml")]
		[SMBFieldDescription("Conact E-Mail")]
		public string subeml;

		/// <summary>
		/// PO Type List                    
		/// </summary>
		[ColumnOrder(2120)]
		[SMBFieldName("potype")]
		[SMBFieldDescription("PO Type List")]
		public long potype;

		/// <summary>
		/// PO Task List                    
		/// </summary>
		[ColumnOrder(2130)]
		[SMBFieldName("potask")]
		[SMBFieldDescription("PO Task List")]
		public decimal potask;

		/// <summary>
		/// Year to Date                    
		/// </summary>
		[ColumnOrder(2140)]
		[SMBFieldName("empytd")]
		[SMBFieldDescription("Year to Date")]
		public decimal empytd;

		/// <summary>
		/// Flat Rate Time                  
		/// </summary>
		[ColumnOrder(2150)]
		[SMBFieldName("flttim")]
		[SMBFieldDescription("Flat Rate Time")]
		public long flttim;

		/// <summary>
		/// Flat Rate Cost                  
		/// </summary>
		[ColumnOrder(2160)]
		[SMBFieldName("fltcst")]
		[SMBFieldDescription("Flat Rate Cost")]
		public decimal fltcst;

		/// <summary>
		/// Flat Rate Markup                
		/// </summary>
		[ColumnOrder(2170)]
		[SMBFieldName("fltmrk")]
		[SMBFieldDescription("Flat Rate Markup")]
		public decimal fltmrk;

		/// <summary>
		/// Flat Rate Sell Price            
		/// </summary>
		[ColumnOrder(2180)]
		[SMBFieldName("fltsel")]
		[SMBFieldDescription("Flat Rate Sell Price")]
		public decimal fltsel;

		/// <summary>
		/// Flat Rate Profit                
		/// </summary>
		[ColumnOrder(2190)]
		[SMBFieldName("fltpft")]
		[SMBFieldDescription("Flat Rate Profit")]
		public decimal fltpft;

		/// <summary>
		/// Flat Rate Margin                
		/// </summary>
		[ColumnOrder(2200)]
		[SMBFieldName("fltmrg")]
		[SMBFieldDescription("Flat Rate Margin")]
		public decimal fltmrg;

		/// <summary>
		/// Direct Dep. Batch#              
		/// </summary>
		[ColumnOrder(2210)]
		[SMBFieldName("ddpbch")]
		[SMBFieldDescription("Direct Dep. Batch#")]
		public long ddpbch;

		/// <summary>
		/// Scheduled Report End Date       
		/// </summary>
		[ColumnOrder(2220)]
		[SMBFieldName("rpscdt")]
		[SMBFieldDescription("Scheduled Report End Date")]
		public DateTime rpscdt;

		/// <summary>
		/// Sched. Report Number of Times   
		/// </summary>
		[ColumnOrder(2230)]
		[SMBFieldName("rpscnm")]
		[SMBFieldDescription("Sched. Report Number of Times")]
		public long rpscnm;

		/// <summary>
		/// Sched. Report Day of Month      
		/// </summary>
		[ColumnOrder(2240)]
		[SMBFieldName("rpscdy")]
		[SMBFieldDescription("Sched. Report Day of Month")]
		public long rpscdy;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(2250)]
		[SMBFieldName("jobjdk")]
		[SMBFieldDescription("Job")]
		public long jobjdk;

		/// <summary>
		/// Second Payee - Vendor To Pay    
		/// </summary>
		[ColumnOrder(2260)]
		[SMBFieldName("42scdy")]
		[SMBFieldDescription("Second Payee - Vendor To Pay")]
		public decimal _42scdy;

		/// <summary>
		/// Remove Purchase Order Date      
		/// </summary>
		[ColumnOrder(2270)]
		[SMBFieldName("rmvpch")]
		[SMBFieldDescription("Remove Purchase Order Date")]
		public DateTime rmvpch;

		/// <summary>
		/// Job Costing Ledger Total        
		/// </summary>
		[ColumnOrder(2280)]
		[SMBFieldName("jclegr")]
		[SMBFieldDescription("Job Costing Ledger Total")]
		public decimal jclegr;

		/// <summary>
		/// Job Costing Cost Total          
		/// </summary>
		[ColumnOrder(2290)]
		[SMBFieldName("jccost")]
		[SMBFieldDescription("Job Costing Cost Total")]
		public decimal jccost;

		/// <summary>
		/// Equipment Costing Ledger Total  
		/// </summary>
		[ColumnOrder(2300)]
		[SMBFieldName("eqlegr")]
		[SMBFieldDescription("Equipment Costing Ledger Total")]
		public decimal eqlegr;

		/// <summary>
		/// Equipment Costing Cost Total    
		/// </summary>
		[ColumnOrder(2310)]
		[SMBFieldName("eqcost")]
		[SMBFieldDescription("Equipment Costing Cost Total")]
		public decimal eqcost;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[ColumnOrder(2320)]
		[SMBFieldName("crdtrn")]
		[SMBFieldDescription("Trans#")]
		public string crdtrn;

		/// <summary>
		/// Trans Date                      
		/// </summary>
		[ColumnOrder(2330)]
		[SMBFieldName("dtecrd")]
		[SMBFieldDescription("Trans Date")]
		public DateTime dtecrd;

		/// <summary>
		/// Credit Card                     
		/// </summary>
		[ColumnOrder(2340)]
		[SMBFieldName("crdcrd")]
		[SMBFieldDescription("Credit Card")]
		public long crdcrd;

		/// <summary>
		/// Payee                           
		/// </summary>
		[ColumnOrder(2350)]
		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee")]
		public string payee1;

		/// <summary>
		/// Select Card Issuer Account      
		/// </summary>
		[ColumnOrder(2360)]
		[SMBFieldName("lgrcrd")]
		[SMBFieldDescription("Select Card Issuer Account")]
		public long lgrcrd;

		/// <summary>
		/// Verified                        
		/// </summary>
		[ColumnOrder(2370)]
		[SMBFieldName("verify")]
		[SMBFieldDescription("Verified")]
		public string verify;

		/// <summary>
		/// Credits                         
		/// </summary>
		[ColumnOrder(2380)]
		[SMBFieldName("crdpay")]
		[SMBFieldDescription("Credits")]
		public decimal crdpay;

		/// <summary>
		/// Charges                         
		/// </summary>
		[ColumnOrder(2390)]
		[SMBFieldName("charge")]
		[SMBFieldDescription("Charges")]
		public decimal charge;

		/// <summary>
		/// Pay By                          
		/// </summary>
		[ColumnOrder(2400)]
		[SMBFieldName("paymth")]
		[SMBFieldDescription("Pay By")]
		public string paymth;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(2410)]
		[SMBFieldName("crdvnd")]
		[SMBFieldDescription("Vendor")]
		public long crdvnd;

		/// <summary>
		/// Card Issuer Account             
		/// </summary>
		[ColumnOrder(2420)]
		[SMBFieldName("issuer")]
		[SMBFieldDescription("Card Issuer Account")]
		public long issuer;

		/// <summary>
		/// Issuer Name                     
		/// </summary>
		[ColumnOrder(2430)]
		[SMBFieldName("issnme")]
		[SMBFieldDescription("Issuer Name")]
		public string issnme;

		/// <summary>
		/// Current Balance                 
		/// </summary>
		[ColumnOrder(2440)]
		[SMBFieldName("476bal")]
		[SMBFieldDescription("Current Balance")]
		public decimal _476bal;

		/// <summary>
		/// Last Reconciled Balance         
		/// </summary>
		[ColumnOrder(2450)]
		[SMBFieldName("476rcl")]
		[SMBFieldDescription("Last Reconciled Balance")]
		public decimal _476rcl;

		/// <summary>
		/// Print this receipt when saving  
		/// </summary>
		[ColumnOrder(2460)]
		[SMBFieldName("prnrct")]
		[SMBFieldDescription("Print this receipt when saving")]
		public long prnrct;

		/// <summary>
		/// Contact Type                    
		/// </summary>
		[ColumnOrder(2470)]
		[SMBFieldName("cnttyp")]
		[SMBFieldDescription("Contact Type")]
		public string cnttyp;

		/// <summary>
		/// Contact Record                  
		/// </summary>
		[ColumnOrder(2480)]
		[SMBFieldName("cntrec")]
		[SMBFieldDescription("Contact Record")]
		public string cntrec;

		/// <summary>
		/// Company                         
		/// </summary>
		[ColumnOrder(2490)]
		[SMBFieldName("cntcmp")]
		[SMBFieldDescription("Company")]
		public string cntcmp;

		/// <summary>
		/// Link with Outlook               
		/// </summary>
		[ColumnOrder(2500)]
		[SMBFieldName("outlnk")]
		[SMBFieldDescription("Link with Outlook")]
		public string outlnk;

		/// <summary>
		/// Outllook ID                     
		/// </summary>
		[ColumnOrder(2510)]
		[SMBFieldName("msolid")]
		[SMBFieldDescription("Outllook ID")]
		public string msolid;

		/// <summary>
		/// Short Name                      
		/// </summary>
		[ColumnOrder(2520)]
		[SMBFieldName("cntsht")]
		[SMBFieldDescription("Short Name")]
		public string cntsht;

	}
}