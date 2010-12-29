using System;

namespace SMB.Tables {
	public class mscfld : smbtable {
		/// <summary>
		/// Account#                        
		/// </summary>
		[SMBFieldName("lgr1_1")]
		[SMBFieldDescription("Account#")]
		public long lgr1_1;

		/// <summary>
		/// Statement Cutoff Date           
		/// </summary>
		[SMBFieldName("dterge")]
		[SMBFieldDescription("Statement Cutoff Date")]
		public DateTime dterge;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public long actprd;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Client                          
		/// </summary>
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Ledger Accnt. Range             
		/// </summary>
		[SMBFieldName("lgrrge")]
		[SMBFieldDescription("Ledger Accnt. Range")]
		public long lgrrge;

		/// <summary>
		/// Fiscal Year End Date            
		/// </summary>
		[SMBFieldName("enddte")]
		[SMBFieldDescription("Fiscal Year End Date")]
		public DateTime enddte;

		/// <summary>
		/// Subsidiary Ledger Accnt.#'s     
		/// </summary>
		[SMBFieldName("subact")]
		[SMBFieldDescription("Subsidiary Ledger Accnt.#'s")]
		public long subact;

		/// <summary>
		/// Posting Accnt.#'s               
		/// </summary>
		[SMBFieldName("pstact")]
		[SMBFieldDescription("Posting Accnt.#'s")]
		public long pstact;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("period")]
		[SMBFieldDescription("Period")]
		public long period;

		/// <summary>
		/// Period Ending                   
		/// </summary>
		[SMBFieldName("perdte")]
		[SMBFieldDescription("Period Ending")]
		public DateTime perdte;

		/// <summary>
		/// Employee# Lower Range           
		/// </summary>
		[SMBFieldName("emprgf")]
		[SMBFieldDescription("Employee# Lower Range")]
		public long emprgf;

		/// <summary>
		/// Employee# Upper Range           
		/// </summary>
		[SMBFieldName("emprgl")]
		[SMBFieldDescription("Employee# Upper Range")]
		public long emprgl;

		/// <summary>
		/// Employee Pick List              
		/// </summary>
		[SMBFieldName("emplst")]
		[SMBFieldDescription("Employee Pick List")]
		public long emplst;

		/// <summary>
		/// First Payroll Record#           
		/// </summary>
		[SMBFieldName("payrcf")]
		[SMBFieldDescription("First Payroll Record#")]
		public long payrcf;

		/// <summary>
		/// Last Payrol Record#             
		/// </summary>
		[SMBFieldName("payrcl")]
		[SMBFieldDescription("Last Payrol Record#")]
		public long payrcl;

		/// <summary>
		/// Record Pick List                
		/// </summary>
		[SMBFieldName("reclst")]
		[SMBFieldDescription("Record Pick List")]
		public long reclst;

		/// <summary>
		/// Checking Act.#                  
		/// </summary>
		[SMBFieldName("chkact")]
		[SMBFieldDescription("Checking Act.#")]
		public long chkact;

		/// <summary>
		/// Payroll Ending Date             
		/// </summary>
		[SMBFieldName("paydte")]
		[SMBFieldDescription("Payroll Ending Date")]
		public DateTime paydte;

		/// <summary>
		/// Type                            
		/// </summary>
		[SMBFieldName("trntyp")]
		[SMBFieldDescription("Type")]
		public string trntyp;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Lender                          
		/// </summary>
		[SMBFieldName("lender")]
		[SMBFieldDescription("Lender")]
		public long lender;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[SMBFieldName("duedte")]
		[SMBFieldDescription("Due Date")]
		public DateTime duedte;

		/// <summary>
		/// Payment                         
		/// </summary>
		[SMBFieldName("paymnt")]
		[SMBFieldDescription("Payment")]
		public decimal paymnt;

		/// <summary>
		/// Set to Pay                      
		/// </summary>
		[SMBFieldName("setpay")]
		[SMBFieldDescription("Set to Pay")]
		public decimal setpay;

		/// <summary>
		/// Capitalized                     
		/// </summary>
		[SMBFieldName("capend")]
		[SMBFieldDescription("Capitalized")]
		public decimal capend;

		/// <summary>
		/// To Date                         
		/// </summary>
		[SMBFieldName("depend")]
		[SMBFieldDescription("To Date")]
		public decimal depend;

		/// <summary>
		/// Last Posted                     
		/// </summary>
		[SMBFieldName("lstpst")]
		[SMBFieldDescription("Last Posted")]
		public string lstpst;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[SMBFieldName("msceqp")]
		[SMBFieldDescription("Equipment")]
		public long msceqp;

		/// <summary>
		/// Account#                        
		/// </summary>
		[SMBFieldName("lgracc")]
		[SMBFieldDescription("Account#")]
		public long lgracc;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		/// <summary>
		/// Deposit#                        
		/// </summary>
		[SMBFieldName("depnum")]
		[SMBFieldDescription("Deposit#")]
		public string depnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Client#                         
		/// </summary>
		[SMBFieldName("reccln")]
		[SMBFieldDescription("Client#")]
		public long reccln;

		/// <summary>
		/// Preference#                     
		/// </summary>
		[SMBFieldName("vndprf")]
		[SMBFieldDescription("Preference#")]
		public long vndprf;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Field Selection                 
		/// </summary>
		[SMBFieldName("slccrt")]
		[SMBFieldDescription("Field Selection")]
		public string slccrt;

		/// <summary>
		/// Field Selection  Criteria       
		/// </summary>
		[SMBFieldName("crttyp")]
		[SMBFieldDescription("Field Selection  Criteria")]
		public string crttyp;

		/// <summary>
		/// Field Selection  Value          
		/// </summary>
		[SMBFieldName("crtval")]
		[SMBFieldDescription("Field Selection  Value")]
		public string crtval;

		/// <summary>
		/// Change Field                    
		/// </summary>
		[SMBFieldName("chgfld")]
		[SMBFieldDescription("Change Field")]
		public string chgfld;

		/// <summary>
		/// Change Field Based On           
		/// </summary>
		[SMBFieldName("baseon")]
		[SMBFieldDescription("Change Field Based On")]
		public string baseon;

		/// <summary>
		/// Change Field By                 
		/// </summary>
		[SMBFieldName("chg_by")]
		[SMBFieldDescription("Change Field By")]
		public string chg_by;

		/// <summary>
		/// New Field Value                 
		/// </summary>
		[SMBFieldName("newval")]
		[SMBFieldDescription("New Field Value")]
		public string newval;

		/// <summary>
		/// Part#                           
		/// </summary>
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("prtdsc")]
		[SMBFieldDescription("Description")]
		public string prtdsc;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("prtunt")]
		[SMBFieldDescription("Unit")]
		public string prtunt;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		/// <summary>
		/// Price                           
		/// </summary>
		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Price")]
		public decimal prtprc;

		/// <summary>
		/// Extended                        
		/// </summary>
		[SMBFieldName("extprc")]
		[SMBFieldDescription("Extended")]
		public decimal extprc;

		/// <summary>
		/// Payroll Check Date              
		/// </summary>
		[SMBFieldName("crddte")]
		[SMBFieldDescription("Payroll Check Date")]
		public DateTime crddte;

		/// <summary>
		/// Payroll Quarter                 
		/// </summary>
		[SMBFieldName("crdqtr")]
		[SMBFieldDescription("Payroll Quarter")]
		public long crdqtr;

		/// <summary>
		/// Account#                        
		/// </summary>
		[SMBFieldName("lgr1_2")]
		[SMBFieldDescription("Account#")]
		public long lgr1_2;

		/// <summary>
		/// Account#                        
		/// </summary>
		[SMBFieldName("lgr1_5")]
		[SMBFieldDescription("Account#")]
		public long lgr1_5;

		/// <summary>
		/// Labor Burden                    
		/// </summary>
		[SMBFieldName("lbrbur")]
		[SMBFieldDescription("Labor Burden")]
		public decimal lbrbur;

		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("cshrec")]
		[SMBFieldDescription("Record#")]
		public long cshrec;

		/// <summary>
		/// Account                         
		/// </summary>
		[SMBFieldName("lgr3_3")]
		[SMBFieldDescription("Account")]
		public long lgr3_3;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[SMBFieldName("cshdte")]
		[SMBFieldDescription("Due Date")]
		public DateTime cshdte;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("cshdsc")]
		[SMBFieldDescription("Description")]
		public string cshdsc;

		/// <summary>
		/// Amount                          
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Amount")]
		public decimal invttl;

		/// <summary>
		/// Balance                         
		/// </summary>
		[SMBFieldName("invbal")]
		[SMBFieldDescription("Balance")]
		public decimal invbal;

		/// <summary>
		/// Retention                       
		/// </summary>
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		/// <summary>
		/// Disc Avail                      
		/// </summary>
		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Disc Avail")]
		public decimal dscavl;

		/// <summary>
		/// Check#                          
		/// </summary>
		[SMBFieldName("chknum")]
		[SMBFieldDescription("Check#")]
		public string chknum;

		/// <summary>
		/// Paid(Cash)                      
		/// </summary>
		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid(Cash)")]
		public decimal amtpad;

		/// <summary>
		/// Discount                        
		/// </summary>
		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Discount")]
		public decimal dsctkn;

		/// <summary>
		/// Credit                          
		/// </summary>
		[SMBFieldName("credit")]
		[SMBFieldDescription("Credit")]
		public decimal credit;

		/// <summary>
		/// Bid Item                        
		/// </summary>
		[SMBFieldName("biditm")]
		[SMBFieldDescription("Bid Item")]
		public long biditm;

		/// <summary>
		/// Labor Markups                   
		/// </summary>
		[SMBFieldName("mrklab")]
		[SMBFieldDescription("Labor Markups")]
		public decimal mrklab;

		/// <summary>
		/// Phase                           
		/// </summary>
		[SMBFieldName("jobphs")]
		[SMBFieldDescription("Phase")]
		public long jobphs;

		/// <summary>
		/// Markups                         
		/// </summary>
		[SMBFieldName("mrkups")]
		[SMBFieldDescription("Markups")]
		public decimal mrkups;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("schjob")]
		[SMBFieldDescription("Job")]
		public long schjob;

		/// <summary>
		/// Service Contract Discount       
		/// </summary>
		[SMBFieldName("mrkdsc")]
		[SMBFieldDescription("Service Contract Discount")]
		public decimal mrkdsc;

		/// <summary>
		/// Phase                           
		/// </summary>
		[SMBFieldName("schphs")]
		[SMBFieldDescription("Phase")]
		public long schphs;

		/// <summary>
		/// Apply to Classes                
		/// </summary>
		[SMBFieldName("mrkcls")]
		[SMBFieldDescription("Apply to Classes")]
		public long mrkcls;

		/// <summary>
		/// Check#                          
		/// </summary>
		[SMBFieldName("chk1_1")]
		[SMBFieldDescription("Check#")]
		public string chk1_1;

		/// <summary>
		/// Cutoff Date                     
		/// </summary>
		[SMBFieldName("cutdte")]
		[SMBFieldDescription("Cutoff Date")]
		public DateTime cutdte;

		/// <summary>
		/// Deposit#                        
		/// </summary>
		[SMBFieldName("dep1_2")]
		[SMBFieldDescription("Deposit#")]
		public string dep1_2;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[SMBFieldName("srvinv")]
		[SMBFieldDescription("Invoice#")]
		public string srvinv;

		/// <summary>
		/// Client                          
		/// </summary>
		[SMBFieldName("client")]
		[SMBFieldDescription("Client")]
		public long client;

		/// <summary>
		/// Overpayment                     
		/// </summary>
		[SMBFieldName("ovrpay")]
		[SMBFieldDescription("Overpayment")]
		public decimal ovrpay;

		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("cntjob")]
		[SMBFieldDescription("Job#")]
		public long cntjob;

		/// <summary>
		/// Deposit#                        
		/// </summary>
		[SMBFieldName("trn3_3")]
		[SMBFieldDescription("Deposit#")]
		public string trn3_3;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("dte3_3")]
		[SMBFieldDescription("Date")]
		public DateTime dte3_3;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dsc3_3")]
		[SMBFieldDescription("Description")]
		public string dsc3_3;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("retdte")]
		[SMBFieldDescription("Date")]
		public DateTime retdte;

		/// <summary>
		/// Invoice# for Prog. Bill         
		/// </summary>
		[SMBFieldName("inv3_7")]
		[SMBFieldDescription("Invoice# for Prog. Bill")]
		public string inv3_7;

		/// <summary>
		/// Part#                           
		/// </summary>
		[SMBFieldName("tkfprt")]
		[SMBFieldDescription("Part#")]
		public long tkfprt;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dsc666")]
		[SMBFieldDescription("Description")]
		public string dsc666;

		/// <summary>
		/// Alpha Part#                     
		/// </summary>
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("unt666")]
		[SMBFieldDescription("Unit")]
		public string unt666;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("linqty")]
		[SMBFieldDescription("Quantity")]
		public decimal linqty;

		/// <summary>
		/// Inventory Location              
		/// </summary>
		[SMBFieldName("invloc")]
		[SMBFieldDescription("Inventory Location")]
		public long invloc;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		/// <summary>
		/// Shipping#                       
		/// </summary>
		[SMBFieldName("shpnum")]
		[SMBFieldDescription("Shipping#")]
		public string shpnum;

		/// <summary>
		/// Vendor Lower Range              
		/// </summary>
		[SMBFieldName("vnd43f")]
		[SMBFieldDescription("Vendor Lower Range")]
		public long vnd43f;

		/// <summary>
		/// Vendor Upper Range              
		/// </summary>
		[SMBFieldName("vnd43l")]
		[SMBFieldDescription("Vendor Upper Range")]
		public long vnd43l;

		/// <summary>
		/// Vendor List                     
		/// </summary>
		[SMBFieldName("vndlst")]
		[SMBFieldDescription("Vendor List")]
		public long vndlst;

		/// <summary>
		/// Job Upper Range                 
		/// </summary>
		[SMBFieldName("job43l")]
		[SMBFieldDescription("Job Upper Range")]
		public long job43l;

		/// <summary>
		/// Job Lower Rasnge                
		/// </summary>
		[SMBFieldName("job43f")]
		[SMBFieldDescription("Job Lower Rasnge")]
		public long job43f;

		/// <summary>
		/// Job List                        
		/// </summary>
		[SMBFieldName("joblst")]
		[SMBFieldDescription("Job List")]
		public long joblst;

		/// <summary>
		/// Due/Disc Date                   
		/// </summary>
		[SMBFieldName("dte4_3")]
		[SMBFieldDescription("Due/Disc Date")]
		public DateTime dte4_3;

		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("rec4_3")]
		[SMBFieldDescription("Record#")]
		public long rec4_3;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vnd4_3")]
		[SMBFieldDescription("Vendor")]
		public long vnd4_3;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("job4_3")]
		[SMBFieldDescription("Job")]
		public long job4_3;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[SMBFieldName("inv4_3")]
		[SMBFieldDescription("Invoice#")]
		public string inv4_3;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[SMBFieldName("due4_3")]
		[SMBFieldDescription("Due Date")]
		public DateTime due4_3;

		/// <summary>
		/// Disc Date                       
		/// </summary>
		[SMBFieldName("dsc4_3")]
		[SMBFieldDescription("Disc Date")]
		public DateTime dsc4_3;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("stat43")]
		[SMBFieldDescription("Status")]
		public long stat43;

		/// <summary>
		/// Posting Subaccount              
		/// </summary>
		[SMBFieldName("pstsub")]
		[SMBFieldDescription("Posting Subaccount")]
		public long pstsub;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("trnd84")]
		[SMBFieldDescription("Date")]
		public DateTime trnd84;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dsc8_4")]
		[SMBFieldDescription("Description")]
		public string dsc8_4;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("job8_4")]
		[SMBFieldDescription("Job")]
		public long job8_4;

		/// <summary>
		/// Equip Repaired                  
		/// </summary>
		[SMBFieldName("eqp8_4")]
		[SMBFieldDescription("Equip Repaired")]
		public long eqp8_4;

		/// <summary>
		/// Phase                           
		/// </summary>
		[SMBFieldName("phs8_4")]
		[SMBFieldDescription("Phase")]
		public long phs8_4;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cst8_4")]
		[SMBFieldDescription("Cost Code")]
		public decimal cst8_4;

		/// <summary>
		/// Operated Equipment              
		/// </summary>
		[SMBFieldName("eqop84")]
		[SMBFieldDescription("Operated Equipment")]
		public long eqop84;

		/// <summary>
		/// Operated                        
		/// </summary>
		[SMBFieldName("ohr8_4")]
		[SMBFieldDescription("Operated")]
		public decimal ohr8_4;

		/// <summary>
		/// Standby                         
		/// </summary>
		[SMBFieldName("shr8_4")]
		[SMBFieldDescription("Standby")]
		public decimal shr8_4;

		/// <summary>
		/// Idle                            
		/// </summary>
		[SMBFieldName("ihr8_4")]
		[SMBFieldDescription("Idle")]
		public decimal ihr8_4;

		/// <summary>
		/// Rental Unit                     
		/// </summary>
		[SMBFieldName("bunt84")]
		[SMBFieldDescription("Rental Unit")]
		public long bunt84;

		/// <summary>
		/// Operated Rental                 
		/// </summary>
		[SMBFieldName("opbl84")]
		[SMBFieldDescription("Operated Rental")]
		public decimal opbl84;

		/// <summary>
		/// Standby Rental                  
		/// </summary>
		[SMBFieldName("stbl84")]
		[SMBFieldDescription("Standby Rental")]
		public decimal stbl84;

		/// <summary>
		/// Idle Rental                     
		/// </summary>
		[SMBFieldName("idbl84")]
		[SMBFieldDescription("Idle Rental")]
		public decimal idbl84;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("nte8_4")]
		[SMBFieldDescription("Notes")]
		public string nte8_4;

		/// <summary>
		/// Total                           
		/// </summary>
		[SMBFieldName("extcst")]
		[SMBFieldDescription("Total")]
		public decimal extcst;

		/// <summary>
		/// Account                         
		/// </summary>
		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Account")]
		public long dbtact;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[SMBFieldName("dbtsub")]
		[SMBFieldDescription("Subaccount")]
		public long dbtsub;

		/// <summary>
		/// Department                      
		/// </summary>
		[SMBFieldName("dptact")]
		[SMBFieldDescription("Department")]
		public long dptact;

		/// <summary>
		/// Cost Unit                       
		/// </summary>
		[SMBFieldName("csun84")]
		[SMBFieldDescription("Cost Unit")]
		public string csun84;

		/// <summary>
		/// Deprec Balance                  
		/// </summary>
		[SMBFieldName("dpbl86")]
		[SMBFieldDescription("Deprec Balance")]
		public decimal dpbl86;

		/// <summary>
		/// Template Name                   
		/// </summary>
		[SMBFieldName("tmpnme")]
		[SMBFieldDescription("Template Name")]
		public string tmpnme;

		/// <summary>
		/// Batch#                          
		/// </summary>
		[SMBFieldName("apbtch")]
		[SMBFieldDescription("Batch#")]
		public long apbtch;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("job619")]
		[SMBFieldDescription("Job")]
		public long job619;

		/// <summary>
		/// Job Supervisor                  
		/// </summary>
		[SMBFieldName("emp619")]
		[SMBFieldDescription("Job Supervisor")]
		public long emp619;

		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("rec619")]
		[SMBFieldDescription("Record#")]
		public long rec619;

		/// <summary>
		/// Transaction#                    
		/// </summary>
		[SMBFieldName("trn619")]
		[SMBFieldDescription("Transaction#")]
		public string trn619;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dsc619")]
		[SMBFieldDescription("Description")]
		public string dsc619;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("dte619")]
		[SMBFieldDescription("Date")]
		public DateTime dte619;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("jbg619")]
		[SMBFieldDescription("Job")]
		public long jbg619;

		/// <summary>
		/// Table                           
		/// </summary>
		[SMBFieldName("tbl619")]
		[SMBFieldDescription("Table")]
		public string tbl619;

		/// <summary>
		/// Calc Type                       
		/// </summary>
		[SMBFieldName("clctyp")]
		[SMBFieldDescription("Calc Type")]
		public string clctyp;

		/// <summary>
		/// Beginning Date Post Serv. Con.  
		/// </summary>
		[SMBFieldName("srcndl")]
		[SMBFieldDescription("Beginning Date Post Serv. Con.")]
		public DateTime srcndl;

		/// <summary>
		/// Ending Date Post Srv. Con.      
		/// </summary>
		[SMBFieldName("srcndh")]
		[SMBFieldDescription("Ending Date Post Srv. Con.")]
		public DateTime srcndh;

		/// <summary>
		/// Beginning Date Post Srv. Route  
		/// </summary>
		[SMBFieldName("srrtdl")]
		[SMBFieldDescription("Beginning Date Post Srv. Route")]
		public DateTime srrtdl;

		/// <summary>
		/// Ending Date Post Srv. Route     
		/// </summary>
		[SMBFieldName("srrtdh")]
		[SMBFieldDescription("Ending Date Post Srv. Route")]
		public DateTime srrtdh;

		/// <summary>
		/// Beginning Rcd. Post Srv. Route  
		/// </summary>
		[SMBFieldName("srrtlw")]
		[SMBFieldDescription("Beginning Rcd. Post Srv. Route")]
		public long srrtlw;

		/// <summary>
		/// Ending Rcd. Post Srv. Route     
		/// </summary>
		[SMBFieldName("srrthg")]
		[SMBFieldDescription("Ending Rcd. Post Srv. Route")]
		public long srrthg;

		/// <summary>
		/// Service Order Copy Formatting   
		/// </summary>
		[SMBFieldName("cpywrk")]
		[SMBFieldDescription("Service Order Copy Formatting")]
		public long cpywrk;

		/// <summary>
		/// Remove Service Date             
		/// </summary>
		[SMBFieldName("rmvsrv")]
		[SMBFieldDescription("Remove Service Date")]
		public DateTime rmvsrv;

		/// <summary>
		/// Field Report Date Low           
		/// </summary>
		[SMBFieldName("fdrdtl")]
		[SMBFieldDescription("Field Report Date Low")]
		public DateTime fdrdtl;

		/// <summary>
		/// Field Report Date High          
		/// </summary>
		[SMBFieldName("fdrdth")]
		[SMBFieldDescription("Field Report Date High")]
		public DateTime fdrdth;

		/// <summary>
		/// Summary Account                 
		/// </summary>
		[SMBFieldName("sumact")]
		[SMBFieldDescription("Summary Account")]
		public long sumact;

		/// <summary>
		/// Post in Summary                 
		/// </summary>
		[SMBFieldName("pstsum")]
		[SMBFieldDescription("Post in Summary")]
		public long pstsum;

		/// <summary>
		/// Starting Check Number           
		/// </summary>
		[SMBFieldName("chknbr")]
		[SMBFieldDescription("Starting Check Number")]
		public long chknbr;

		/// <summary>
		/// Check Date                      
		/// </summary>
		[SMBFieldName("chkdte")]
		[SMBFieldDescription("Check Date")]
		public DateTime chkdte;

		/// <summary>
		/// General Checking Account        
		/// </summary>
		[SMBFieldName("chkgnl")]
		[SMBFieldDescription("General Checking Account")]
		public long chkgnl;

		/// <summary>
		/// Payroll Checking Account        
		/// </summary>
		[SMBFieldName("chkpyr")]
		[SMBFieldDescription("Payroll Checking Account")]
		public long chkpyr;

		/// <summary>
		/// Voucher clearing account        
		/// </summary>
		[SMBFieldName("vchact")]
		[SMBFieldDescription("Voucher clearing account")]
		public long vchact;

		/// <summary>
		/// Invoice #                       
		/// </summary>
		[SMBFieldName("timinv")]
		[SMBFieldDescription("Invoice #")]
		public string timinv;

		/// <summary>
		/// Invoice Date                    
		/// </summary>
		[SMBFieldName("tmindt")]
		[SMBFieldDescription("Invoice Date")]
		public DateTime tmindt;

		/// <summary>
		/// T&M First Job                   
		/// </summary>
		[SMBFieldName("tmjblw")]
		[SMBFieldDescription("T&M First Job")]
		public long tmjblw;

		/// <summary>
		/// T&M Last Job                    
		/// </summary>
		[SMBFieldName("tmjbhg")]
		[SMBFieldDescription("T&M Last Job")]
		public long tmjbhg;

		/// <summary>
		/// T&M Job Picklist                
		/// </summary>
		[SMBFieldName("tmjobs")]
		[SMBFieldDescription("T&M Job Picklist")]
		public long tmjobs;

		/// <summary>
		/// T&M First Phase                 
		/// </summary>
		[SMBFieldName("tmphlw")]
		[SMBFieldDescription("T&M First Phase")]
		public long tmphlw;

		/// <summary>
		/// T&M Last Phase                  
		/// </summary>
		[SMBFieldName("tmphhg")]
		[SMBFieldDescription("T&M Last Phase")]
		public long tmphhg;

		/// <summary>
		/// T&M Phase Picklist              
		/// </summary>
		[SMBFieldName("tmphas")]
		[SMBFieldDescription("T&M Phase Picklist")]
		public long tmphas;

		/// <summary>
		/// T&M First Cost Code             
		/// </summary>
		[SMBFieldName("tmcdlw")]
		[SMBFieldDescription("T&M First Cost Code")]
		public decimal tmcdlw;

		/// <summary>
		/// T&M Last Cost Code              
		/// </summary>
		[SMBFieldName("tmcdhg")]
		[SMBFieldDescription("T&M Last Cost Code")]
		public decimal tmcdhg;

		/// <summary>
		/// T&M Cost Code Picklist          
		/// </summary>
		[SMBFieldName("tmcscd")]
		[SMBFieldDescription("T&M Cost Code Picklist")]
		public decimal tmcscd;

		/// <summary>
		/// T&M Cutoff Date                 
		/// </summary>
		[SMBFieldName("tmctdt")]
		[SMBFieldDescription("T&M Cutoff Date")]
		public DateTime tmctdt;

		/// <summary>
		/// T&M First Cost Record           
		/// </summary>
		[SMBFieldName("tmcstl")]
		[SMBFieldDescription("T&M First Cost Record")]
		public long tmcstl;

		/// <summary>
		/// T&M Last Cost Record            
		/// </summary>
		[SMBFieldName("tmcsth")]
		[SMBFieldDescription("T&M Last Cost Record")]
		public long tmcsth;

		/// <summary>
		/// Percent Subject to Rate         
		/// </summary>
		[SMBFieldName("subjct")]
		[SMBFieldDescription("Percent Subject to Rate")]
		public decimal subjct;

		/// <summary>
		/// Rate                            
		/// </summary>
		[SMBFieldName("sumrte")]
		[SMBFieldDescription("Rate")]
		public decimal sumrte;

		/// <summary>
		/// Bonding Limit                   
		/// </summary>
		[SMBFieldName("bndlmt")]
		[SMBFieldDescription("Bonding Limit")]
		public long bndlmt;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Summary Amount                  
		/// </summary>
		[SMBFieldName("sumamt")]
		[SMBFieldDescription("Summary Amount")]
		public decimal sumamt;

		/// <summary>
		/// Account Balance                 
		/// </summary>
		[SMBFieldName("bal1_1")]
		[SMBFieldDescription("Account Balance")]
		public decimal bal1_1;

		/// <summary>
		/// Account Balance                 
		/// </summary>
		[SMBFieldName("bal1_2")]
		[SMBFieldDescription("Account Balance")]
		public decimal bal1_2;

		/// <summary>
		/// Account Balance                 
		/// </summary>
		[SMBFieldName("bal1_3")]
		[SMBFieldDescription("Account Balance")]
		public decimal bal1_3;

		/// <summary>
		/// Update 1099 Balance             
		/// </summary>
		[SMBFieldName("upd109")]
		[SMBFieldDescription("Update 1099 Balance")]
		public long upd109;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// 7-7 Field Key                   
		/// </summary>
		[SMBFieldName("keyfld")]
		[SMBFieldDescription("7-7 Field Key")]
		public long keyfld;

		/// <summary>
		/// Quarter Ending                  
		/// </summary>
		[SMBFieldName("dte542")]
		[SMBFieldDescription("Quarter Ending")]
		public DateTime dte542;

		/// <summary>
		/// Reporting Year                  
		/// </summary>
		[SMBFieldName("rptgyr")]
		[SMBFieldDescription("Reporting Year")]
		public long rptgyr;

		/// <summary>
		/// Tax State                       
		/// </summary>
		[SMBFieldName("ste546")]
		[SMBFieldDescription("Tax State")]
		public string ste546;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("rptprd")]
		[SMBFieldDescription("Period")]
		public long rptprd;

		/// <summary>
		/// Depreciation Acct               
		/// </summary>
		[SMBFieldName("dpr210")]
		[SMBFieldDescription("Depreciation Acct")]
		public long dpr210;

		/// <summary>
		/// Sales Account                   
		/// </summary>
		[SMBFieldName("sls210")]
		[SMBFieldDescription("Sales Account")]
		public long sls210;

		/// <summary>
		/// Prepaid Expense Acct            
		/// </summary>
		[SMBFieldName("exp210")]
		[SMBFieldDescription("Prepaid Expense Acct")]
		public long exp210;

		/// <summary>
		/// Default Cost Code               
		/// </summary>
		[SMBFieldName("dftcde")]
		[SMBFieldDescription("Default Cost Code")]
		public decimal dftcde;

		/// <summary>
		/// Payroll Period Start Date       
		/// </summary>
		[SMBFieldName("crdstr")]
		[SMBFieldDescription("Payroll Period Start Date")]
		public DateTime crdstr;

		/// <summary>
		/// Payroll Period End Date         
		/// </summary>
		[SMBFieldName("crdend")]
		[SMBFieldDescription("Payroll Period End Date")]
		public DateTime crdend;

		/// <summary>
		/// Vendor Discount                 
		/// </summary>
		[SMBFieldName("vnddsc")]
		[SMBFieldDescription("Vendor Discount")]
		public decimal vnddsc;

		/// <summary>
		/// Minimum Number of Invoices      
		/// </summary>
		[SMBFieldName("mininv")]
		[SMBFieldDescription("Minimum Number of Invoices")]
		public long mininv;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("finprd")]
		[SMBFieldDescription("Period")]
		public long finprd;

		/// <summary>
		/// Statement Date                  
		/// </summary>
		[SMBFieldName("stmdte")]
		[SMBFieldDescription("Statement Date")]
		public DateTime stmdte;

		/// <summary>
		/// Balance                         
		/// </summary>
		[SMBFieldName("bal3_3")]
		[SMBFieldDescription("Balance")]
		public decimal bal3_3;

		/// <summary>
		/// SUI Payments                    
		/// </summary>
		[SMBFieldName("unmpay")]
		[SMBFieldDescription("SUI Payments")]
		public decimal unmpay;

		/// <summary>
		/// SUI State                       
		/// </summary>
		[SMBFieldName("unmste")]
		[SMBFieldDescription("SUI State")]
		public string unmste;

		/// <summary>
		/// State Unemployment Id#          
		/// </summary>
		[SMBFieldName("unmnum")]
		[SMBFieldDescription("State Unemployment Id#")]
		public string unmnum;

		/// <summary>
		/// FUTA Deposited                  
		/// </summary>
		[SMBFieldName("futadp")]
		[SMBFieldDescription("FUTA Deposited")]
		public decimal futadp;

		/// <summary>
		/// Terminated Business             
		/// </summary>
		[SMBFieldName("trmbus")]
		[SMBFieldDescription("Terminated Business")]
		public long trmbus;

		/// <summary>
		///  PIN                            
		/// </summary>
		[SMBFieldName("subpin")]
		[SMBFieldDescription("PIN")]
		public string subpin;

		/// <summary>
		/// Contact Name                    
		/// </summary>
		[SMBFieldName("subnme")]
		[SMBFieldDescription("Contact Name")]
		public string subnme;

		/// <summary>
		/// Contact Phone Number            
		/// </summary>
		[SMBFieldName("subphn")]
		[SMBFieldDescription("Contact Phone Number")]
		public string subphn;

		/// <summary>
		/// Contact Phone Extension         
		/// </summary>
		[SMBFieldName("subphx")]
		[SMBFieldDescription("Contact Phone Extension")]
		public string subphx;

		/// <summary>
		/// Contact FAX                     
		/// </summary>
		[SMBFieldName("subfax")]
		[SMBFieldDescription("Contact FAX")]
		public string subfax;

		/// <summary>
		/// Conact E-Mail                   
		/// </summary>
		[SMBFieldName("subeml")]
		[SMBFieldDescription("Conact E-Mail")]
		public string subeml;

		/// <summary>
		/// PO Type List                    
		/// </summary>
		[SMBFieldName("potype")]
		[SMBFieldDescription("PO Type List")]
		public long potype;

		/// <summary>
		/// PO Task List                    
		/// </summary>
		[SMBFieldName("potask")]
		[SMBFieldDescription("PO Task List")]
		public decimal potask;

		/// <summary>
		/// Year to Date                    
		/// </summary>
		[SMBFieldName("empytd")]
		[SMBFieldDescription("Year to Date")]
		public decimal empytd;

		/// <summary>
		/// Flat Rate Time                  
		/// </summary>
		[SMBFieldName("flttim")]
		[SMBFieldDescription("Flat Rate Time")]
		public long flttim;

		/// <summary>
		/// Flat Rate Cost                  
		/// </summary>
		[SMBFieldName("fltcst")]
		[SMBFieldDescription("Flat Rate Cost")]
		public decimal fltcst;

		/// <summary>
		/// Flat Rate Markup                
		/// </summary>
		[SMBFieldName("fltmrk")]
		[SMBFieldDescription("Flat Rate Markup")]
		public decimal fltmrk;

		/// <summary>
		/// Flat Rate Sell Price            
		/// </summary>
		[SMBFieldName("fltsel")]
		[SMBFieldDescription("Flat Rate Sell Price")]
		public decimal fltsel;

		/// <summary>
		/// Flat Rate Profit                
		/// </summary>
		[SMBFieldName("fltpft")]
		[SMBFieldDescription("Flat Rate Profit")]
		public decimal fltpft;

		/// <summary>
		/// Flat Rate Margin                
		/// </summary>
		[SMBFieldName("fltmrg")]
		[SMBFieldDescription("Flat Rate Margin")]
		public decimal fltmrg;

		/// <summary>
		/// Direct Dep. Batch#              
		/// </summary>
		[SMBFieldName("ddpbch")]
		[SMBFieldDescription("Direct Dep. Batch#")]
		public long ddpbch;

		/// <summary>
		/// Scheduled Report End Date       
		/// </summary>
		[SMBFieldName("rpscdt")]
		[SMBFieldDescription("Scheduled Report End Date")]
		public DateTime rpscdt;

		/// <summary>
		/// Sched. Report Number of Times   
		/// </summary>
		[SMBFieldName("rpscnm")]
		[SMBFieldDescription("Sched. Report Number of Times")]
		public long rpscnm;

		/// <summary>
		/// Sched. Report Day of Month      
		/// </summary>
		[SMBFieldName("rpscdy")]
		[SMBFieldDescription("Sched. Report Day of Month")]
		public long rpscdy;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("jobjdk")]
		[SMBFieldDescription("Job")]
		public long jobjdk;

		/// <summary>
		/// Second Payee - Vendor To Pay    
		/// </summary>
		[SMBFieldName("42scdy")]
		[SMBFieldDescription("Second Payee - Vendor To Pay")]
		public decimal _42scdy;

		/// <summary>
		/// Remove Purchase Order Date      
		/// </summary>
		[SMBFieldName("rmvpch")]
		[SMBFieldDescription("Remove Purchase Order Date")]
		public DateTime rmvpch;

		/// <summary>
		/// Job Costing Ledger Total        
		/// </summary>
		[SMBFieldName("jclegr")]
		[SMBFieldDescription("Job Costing Ledger Total")]
		public decimal jclegr;

		/// <summary>
		/// Job Costing Cost Total          
		/// </summary>
		[SMBFieldName("jccost")]
		[SMBFieldDescription("Job Costing Cost Total")]
		public decimal jccost;

		/// <summary>
		/// Equipment Costing Ledger Total  
		/// </summary>
		[SMBFieldName("eqlegr")]
		[SMBFieldDescription("Equipment Costing Ledger Total")]
		public decimal eqlegr;

		/// <summary>
		/// Equipment Costing Cost Total    
		/// </summary>
		[SMBFieldName("eqcost")]
		[SMBFieldDescription("Equipment Costing Cost Total")]
		public decimal eqcost;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[SMBFieldName("crdtrn")]
		[SMBFieldDescription("Trans#")]
		public string crdtrn;

		/// <summary>
		/// Trans Date                      
		/// </summary>
		[SMBFieldName("dtecrd")]
		[SMBFieldDescription("Trans Date")]
		public DateTime dtecrd;

		/// <summary>
		/// Credit Card                     
		/// </summary>
		[SMBFieldName("crdcrd")]
		[SMBFieldDescription("Credit Card")]
		public long crdcrd;

		/// <summary>
		/// Payee                           
		/// </summary>
		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee")]
		public string payee1;

		/// <summary>
		/// Select Card Issuer Account      
		/// </summary>
		[SMBFieldName("lgrcrd")]
		[SMBFieldDescription("Select Card Issuer Account")]
		public long lgrcrd;

		/// <summary>
		/// Verified                        
		/// </summary>
		[SMBFieldName("verify")]
		[SMBFieldDescription("Verified")]
		public string verify;

		/// <summary>
		/// Credits                         
		/// </summary>
		[SMBFieldName("crdpay")]
		[SMBFieldDescription("Credits")]
		public decimal crdpay;

		/// <summary>
		/// Charges                         
		/// </summary>
		[SMBFieldName("charge")]
		[SMBFieldDescription("Charges")]
		public decimal charge;

		/// <summary>
		/// Pay By                          
		/// </summary>
		[SMBFieldName("paymth")]
		[SMBFieldDescription("Pay By")]
		public string paymth;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("crdvnd")]
		[SMBFieldDescription("Vendor")]
		public long crdvnd;

		/// <summary>
		/// Card Issuer Account             
		/// </summary>
		[SMBFieldName("issuer")]
		[SMBFieldDescription("Card Issuer Account")]
		public long issuer;

		/// <summary>
		/// Issuer Name                     
		/// </summary>
		[SMBFieldName("issnme")]
		[SMBFieldDescription("Issuer Name")]
		public string issnme;

		/// <summary>
		/// Current Balance                 
		/// </summary>
		[SMBFieldName("476bal")]
		[SMBFieldDescription("Current Balance")]
		public decimal _476bal;

		/// <summary>
		/// Last Reconciled Balance         
		/// </summary>
		[SMBFieldName("476rcl")]
		[SMBFieldDescription("Last Reconciled Balance")]
		public decimal _476rcl;

		/// <summary>
		/// Print this receipt when saving  
		/// </summary>
		[SMBFieldName("prnrct")]
		[SMBFieldDescription("Print this receipt when saving")]
		public long prnrct;

		/// <summary>
		/// Contact Type                    
		/// </summary>
		[SMBFieldName("cnttyp")]
		[SMBFieldDescription("Contact Type")]
		public string cnttyp;

		/// <summary>
		/// Contact Record                  
		/// </summary>
		[SMBFieldName("cntrec")]
		[SMBFieldDescription("Contact Record")]
		public string cntrec;

		/// <summary>
		/// Company                         
		/// </summary>
		[SMBFieldName("cntcmp")]
		[SMBFieldDescription("Company")]
		public string cntcmp;

		/// <summary>
		/// Link with Outlook               
		/// </summary>
		[SMBFieldName("outlnk")]
		[SMBFieldDescription("Link with Outlook")]
		public string outlnk;

		/// <summary>
		/// Outllook ID                     
		/// </summary>
		[SMBFieldName("msolid")]
		[SMBFieldDescription("Outllook ID")]
		public string msolid;

		/// <summary>
		/// Short Name                      
		/// </summary>
		[SMBFieldName("cntsht")]
		[SMBFieldDescription("Short Name")]
		public string cntsht;

	}
}