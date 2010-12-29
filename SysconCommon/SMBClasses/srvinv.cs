using System;

namespace SMB.Tables {
	public class srvinv : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Order#                          
		/// </summary>
		[SMBFieldName("ordnum")]
		[SMBFieldDescription("Order#")]
		public string ordnum;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		/// <summary>
		/// Client#                         
		/// </summary>
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client#")]
		public long clnnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("orddte")]
		[SMBFieldDescription("Date")]
		public DateTime orddte;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Location                        
		/// </summary>
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

		/// <summary>
		/// Contact                         
		/// </summary>
		[SMBFieldName("ctcnme")]
		[SMBFieldDescription("Contact")]
		public string ctcnme;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Map                             
		/// </summary>
		[SMBFieldName("maploc")]
		[SMBFieldDescription("Map")]
		public string maploc;

		/// <summary>
		/// Cross                           
		/// </summary>
		[SMBFieldName("crsstr")]
		[SMBFieldDescription("Cross")]
		public string crsstr;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[SMBFieldName("duedte")]
		[SMBFieldDescription("Due Date")]
		public DateTime duedte;

		/// <summary>
		/// Disc Date                       
		/// </summary>
		[SMBFieldName("dscdte")]
		[SMBFieldDescription("Disc Date")]
		public DateTime dscdte;

		/// <summary>
		/// Client PO#                      
		/// </summary>
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

		/// <summary>
		/// Reference#                      
		/// </summary>
		[SMBFieldName("refnum")]
		[SMBFieldDescription("Reference#")]
		public string refnum;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Card/Chk#                       
		/// </summary>
		[SMBFieldName("crdnum")]
		[SMBFieldDescription("Card/Chk#")]
		public string crdnum;

		/// <summary>
		/// Exp Date                        
		/// </summary>
		[SMBFieldName("expdte")]
		[SMBFieldDescription("Exp Date")]
		public DateTime expdte;

		/// <summary>
		/// Cardholder                      
		/// </summary>
		[SMBFieldName("crdnme")]
		[SMBFieldDescription("Cardholder")]
		public string crdnme;

		/// <summary>
		/// Deposit                         
		/// </summary>
		[SMBFieldName("depost")]
		[SMBFieldDescription("Deposit")]
		public decimal depost;

		/// <summary>
		/// Disc Avail                      
		/// </summary>
		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Disc Avail")]
		public decimal dscavl;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// Disc/Credit                     
		/// </summary>
		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Disc/Credit")]
		public decimal dsctkn;

		/// <summary>
		/// Invoice Date                    
		/// </summary>
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Invoice Date")]
		public DateTime invdte;

		/// <summary>
		/// Paid                            
		/// </summary>
		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid")]
		public decimal amtpad;

		/// <summary>
		/// Call Date                       
		/// </summary>
		[SMBFieldName("clldte")]
		[SMBFieldDescription("Call Date")]
		public DateTime clldte;

		/// <summary>
		/// Call Time                       
		/// </summary>
		[SMBFieldName("clltim")]
		[SMBFieldDescription("Call Time")]
		public DateTime clltim;

		/// <summary>
		/// Disp Date                       
		/// </summary>
		[SMBFieldName("dspdte")]
		[SMBFieldDescription("Disp Date")]
		public DateTime dspdte;

		/// <summary>
		/// Disp Time                       
		/// </summary>
		[SMBFieldName("dsptim")]
		[SMBFieldDescription("Disp Time")]
		public DateTime dsptim;

		/// <summary>
		/// Sch Date                        
		/// </summary>
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Sch Date")]
		public DateTime schdte;

		/// <summary>
		/// Sch Time                        
		/// </summary>
		[SMBFieldName("schtim")]
		[SMBFieldDescription("Sch Time")]
		public DateTime schtim;

		/// <summary>
		/// Start Date                      
		/// </summary>
		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		/// <summary>
		/// Start Time                      
		/// </summary>
		[SMBFieldName("strtim")]
		[SMBFieldDescription("Start Time")]
		public DateTime strtim;

		/// <summary>
		/// Finish Date                     
		/// </summary>
		[SMBFieldName("findte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime findte;

		/// <summary>
		/// Finish Time                     
		/// </summary>
		[SMBFieldName("fintim")]
		[SMBFieldDescription("Finish Time")]
		public DateTime fintim;

		/// <summary>
		/// Estimated Hours                 
		/// </summary>
		[SMBFieldName("schhrs")]
		[SMBFieldDescription("Estimated Hours")]
		public decimal schhrs;

		/// <summary>
		/// Actual Hours                    
		/// </summary>
		[SMBFieldName("acthrs")]
		[SMBFieldDescription("Actual Hours")]
		public decimal acthrs;

		/// <summary>
		/// Policy#                         
		/// </summary>
		[SMBFieldName("plcnum")]
		[SMBFieldDescription("Policy#")]
		public string plcnum;

		/// <summary>
		/// Policyholder                    
		/// </summary>
		[SMBFieldName("plcnme")]
		[SMBFieldDescription("Policyholder")]
		public string plcnme;

		/// <summary>
		/// Policy Phone                    
		/// </summary>
		[SMBFieldName("plcphn")]
		[SMBFieldDescription("Policy Phone")]
		public string plcphn;

		/// <summary>
		/// Policy Address 1                
		/// </summary>
		[SMBFieldName("plcad1")]
		[SMBFieldDescription("Policy Address 1")]
		public string plcad1;

		/// <summary>
		/// Policy Address 2                
		/// </summary>
		[SMBFieldName("plcad2")]
		[SMBFieldDescription("Policy Address 2")]
		public string plcad2;

		/// <summary>
		/// City/State/Zip                  
		/// </summary>
		[SMBFieldName("plccty")]
		[SMBFieldDescription("City/State/Zip")]
		public string plccty;

		/// <summary>
		/// Company                         
		/// </summary>
		[SMBFieldName("cmpnme")]
		[SMBFieldDescription("Company")]
		public string cmpnme;

		/// <summary>
		/// Adjuster Name                   
		/// </summary>
		[SMBFieldName("adjnme")]
		[SMBFieldDescription("Adjuster Name")]
		public string adjnme;

		/// <summary>
		/// Adjuster Phone                  
		/// </summary>
		[SMBFieldName("adjphn")]
		[SMBFieldDescription("Adjuster Phone")]
		public string adjphn;

		/// <summary>
		/// Adjuster Address 1              
		/// </summary>
		[SMBFieldName("adjad1")]
		[SMBFieldDescription("Adjuster Address 1")]
		public string adjad1;

		/// <summary>
		/// Adjuster Address 2              
		/// </summary>
		[SMBFieldName("adjad2")]
		[SMBFieldDescription("Adjuster Address 2")]
		public string adjad2;

		/// <summary>
		/// City/State/Zip                  
		/// </summary>
		[SMBFieldName("adjcty")]
		[SMBFieldDescription("City/State/Zip")]
		public string adjcty;

		/// <summary>
		/// Policy Type                     
		/// </summary>
		[SMBFieldName("plctyp")]
		[SMBFieldDescription("Policy Type")]
		public string plctyp;

		/// <summary>
		/// Deductible                      
		/// </summary>
		[SMBFieldName("dedabl")]
		[SMBFieldDescription("Deductible")]
		public decimal dedabl;

		/// <summary>
		/// Route                           
		/// </summary>
		[SMBFieldName("rutnum")]
		[SMBFieldDescription("Route")]
		public long rutnum;

		/// <summary>
		/// Contract Start Date             
		/// </summary>
		[SMBFieldName("constd")]
		[SMBFieldDescription("Contract Start Date")]
		public DateTime constd;

		/// <summary>
		/// Contract End Date               
		/// </summary>
		[SMBFieldName("conend")]
		[SMBFieldDescription("Contract End Date")]
		public DateTime conend;

		/// <summary>
		/// Billing Date                    
		/// </summary>
		[SMBFieldName("bildte")]
		[SMBFieldDescription("Billing Date")]
		public DateTime bildte;

		/// <summary>
		/// Technician                      
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Technician")]
		public long empnum;

		/// <summary>
		/// Salesperson                     
		/// </summary>
		[SMBFieldName("slspsn")]
		[SMBFieldDescription("Salesperson")]
		public long slspsn;

		/// <summary>
		/// Type                            
		/// </summary>
		[SMBFieldName("invtyp")]
		[SMBFieldDescription("Type")]
		public long invtyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Priority                        
		/// </summary>
		[SMBFieldName("priort")]
		[SMBFieldDescription("Priority")]
		public long priort;

		/// <summary>
		/// Source                          
		/// </summary>
		[SMBFieldName("invsrc")]
		[SMBFieldDescription("Source")]
		public long invsrc;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Payment                         
		/// </summary>
		[SMBFieldName("pmttyp")]
		[SMBFieldDescription("Payment")]
		public long pmttyp;

		/// <summary>
		/// Invoice Total                   
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		/// <summary>
		/// Balance                         
		/// </summary>
		[SMBFieldName("invbal")]
		[SMBFieldDescription("Balance")]
		public decimal invbal;

		/// <summary>
		/// Net Due                         
		/// </summary>
		[SMBFieldName("invnet")]
		[SMBFieldDescription("Net Due")]
		public decimal invnet;

		/// <summary>
		/// Taxable                         
		/// </summary>
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable")]
		public decimal taxabl;

		/// <summary>
		/// Non-Taxable                     
		/// </summary>
		[SMBFieldName("nontax")]
		[SMBFieldDescription("Non-Taxable")]
		public decimal nontax;

		/// <summary>
		/// Total Paid                      
		/// </summary>
		[SMBFieldName("ttlpad")]
		[SMBFieldDescription("Total Paid")]
		public decimal ttlpad;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Billing Cycle                   
		/// </summary>
		[SMBFieldName("bilcyc")]
		[SMBFieldDescription("Billing Cycle")]
		public long bilcyc;

		/// <summary>
		/// Service Area                    
		/// </summary>
		[SMBFieldName("srvgeo")]
		[SMBFieldDescription("Service Area")]
		public long srvgeo;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Shop Notes                      
		/// </summary>
		[SMBFieldName("shpnte")]
		[SMBFieldDescription("Shop Notes")]
		public string shpnte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Resale #                        
		/// </summary>
		[SMBFieldName("exmnum")]
		[SMBFieldDescription("Resale #")]
		public string exmnum;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Date Entered                    
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Date Entered")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Taxable Grid Total              
		/// </summary>
		[SMBFieldName("taxlin")]
		[SMBFieldDescription("Taxable Grid Total")]
		public decimal taxlin;

		/// <summary>
		/// Non-Tax Grid Total              
		/// </summary>
		[SMBFieldName("ntxlin")]
		[SMBFieldDescription("Non-Tax Grid Total")]
		public decimal ntxlin;

		/// <summary>
		/// Taxable Markup %                
		/// </summary>
		[SMBFieldName("taxmrt")]
		[SMBFieldDescription("Taxable Markup %")]
		public decimal taxmrt;

		/// <summary>
		/// Non-Tax Markup %                
		/// </summary>
		[SMBFieldName("ntxmrt")]
		[SMBFieldDescription("Non-Tax Markup %")]
		public decimal ntxmrt;

		/// <summary>
		/// Taxable Markup $                
		/// </summary>
		[SMBFieldName("txadmk")]
		[SMBFieldDescription("Taxable Markup $")]
		public decimal txadmk;

		/// <summary>
		/// Non-Tax Markup $                
		/// </summary>
		[SMBFieldName("ntadmk")]
		[SMBFieldDescription("Non-Tax Markup $")]
		public decimal ntadmk;

		/// <summary>
		/// Taxable Total Markup            
		/// </summary>
		[SMBFieldName("txmktl")]
		[SMBFieldDescription("Taxable Total Markup")]
		public decimal txmktl;

		/// <summary>
		/// Non-Tax Total  Markup           
		/// </summary>
		[SMBFieldName("ntmktl")]
		[SMBFieldDescription("Non-Tax Total  Markup")]
		public decimal ntmktl;

		/// <summary>
		/// Taxable Extended Total          
		/// </summary>
		[SMBFieldName("taxext")]
		[SMBFieldDescription("Taxable Extended Total")]
		public decimal taxext;

		/// <summary>
		/// Non-Tax Extended Total          
		/// </summary>
		[SMBFieldName("ntxext")]
		[SMBFieldDescription("Non-Tax Extended Total")]
		public decimal ntxext;

		/// <summary>
		/// Taxable Billing Amount          
		/// </summary>
		[SMBFieldName("taxovr")]
		[SMBFieldDescription("Taxable Billing Amount")]
		public decimal taxovr;

		/// <summary>
		/// Non-Tax Billing Amount          
		/// </summary>
		[SMBFieldName("ntxovr")]
		[SMBFieldDescription("Non-Tax Billing Amount")]
		public decimal ntxovr;

		/// <summary>
		/// Lock Taxable Billing Amt        
		/// </summary>
		[SMBFieldName("taxlck")]
		[SMBFieldDescription("Lock Taxable Billing Amt")]
		public long taxlck;

		/// <summary>
		/// Lock Non-Tax Billing Amt        
		/// </summary>
		[SMBFieldName("ntxlck")]
		[SMBFieldDescription("Lock Non-Tax Billing Amt")]
		public long ntxlck;

	}
}