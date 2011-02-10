using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srvinv : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Order#                          
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("ordnum")]
		[SMBFieldDescription("Order#")]
		public string ordnum;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		/// <summary>
		/// Client#                         
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client#")]
		public long clnnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("orddte")]
		[SMBFieldDescription("Date")]
		public DateTime orddte;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Location                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

		/// <summary>
		/// Contact                         
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("ctcnme")]
		[SMBFieldDescription("Contact")]
		public string ctcnme;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Map                             
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("maploc")]
		[SMBFieldDescription("Map")]
		public string maploc;

		/// <summary>
		/// Cross                           
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("crsstr")]
		[SMBFieldDescription("Cross")]
		public string crsstr;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("duedte")]
		[SMBFieldDescription("Due Date")]
		public DateTime duedte;

		/// <summary>
		/// Disc Date                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("dscdte")]
		[SMBFieldDescription("Disc Date")]
		public DateTime dscdte;

		/// <summary>
		/// Client PO#                      
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

		/// <summary>
		/// Reference#                      
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("refnum")]
		[SMBFieldDescription("Reference#")]
		public string refnum;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Card/Chk#                       
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("crdnum")]
		[SMBFieldDescription("Card/Chk#")]
		public string crdnum;

		/// <summary>
		/// Exp Date                        
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("expdte")]
		[SMBFieldDescription("Exp Date")]
		public DateTime expdte;

		/// <summary>
		/// Cardholder                      
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("crdnme")]
		[SMBFieldDescription("Cardholder")]
		public string crdnme;

		/// <summary>
		/// Deposit                         
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("depost")]
		[SMBFieldDescription("Deposit")]
		public decimal depost;

		/// <summary>
		/// Disc Avail                      
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Disc Avail")]
		public decimal dscavl;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// Disc/Credit                     
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Disc/Credit")]
		public decimal dsctkn;

		/// <summary>
		/// Invoice Date                    
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Invoice Date")]
		public DateTime invdte;

		/// <summary>
		/// Paid                            
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid")]
		public decimal amtpad;

		/// <summary>
		/// Call Date                       
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("clldte")]
		[SMBFieldDescription("Call Date")]
		public DateTime clldte;

		/// <summary>
		/// Call Time                       
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("clltim")]
		[SMBFieldDescription("Call Time")]
		public DateTime clltim;

		/// <summary>
		/// Disp Date                       
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("dspdte")]
		[SMBFieldDescription("Disp Date")]
		public DateTime dspdte;

		/// <summary>
		/// Disp Time                       
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("dsptim")]
		[SMBFieldDescription("Disp Time")]
		public DateTime dsptim;

		/// <summary>
		/// Sch Date                        
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Sch Date")]
		public DateTime schdte;

		/// <summary>
		/// Sch Time                        
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("schtim")]
		[SMBFieldDescription("Sch Time")]
		public DateTime schtim;

		/// <summary>
		/// Start Date                      
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		/// <summary>
		/// Start Time                      
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("strtim")]
		[SMBFieldDescription("Start Time")]
		public DateTime strtim;

		/// <summary>
		/// Finish Date                     
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("findte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime findte;

		/// <summary>
		/// Finish Time                     
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("fintim")]
		[SMBFieldDescription("Finish Time")]
		public DateTime fintim;

		/// <summary>
		/// Estimated Hours                 
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("schhrs")]
		[SMBFieldDescription("Estimated Hours")]
		public decimal schhrs;

		/// <summary>
		/// Actual Hours                    
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("acthrs")]
		[SMBFieldDescription("Actual Hours")]
		public decimal acthrs;

		/// <summary>
		/// Policy#                         
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("plcnum")]
		[SMBFieldDescription("Policy#")]
		public string plcnum;

		/// <summary>
		/// Policyholder                    
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("plcnme")]
		[SMBFieldDescription("Policyholder")]
		public string plcnme;

		/// <summary>
		/// Policy Phone                    
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("plcphn")]
		[SMBFieldDescription("Policy Phone")]
		public string plcphn;

		/// <summary>
		/// Policy Address 1                
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("plcad1")]
		[SMBFieldDescription("Policy Address 1")]
		public string plcad1;

		/// <summary>
		/// Policy Address 2                
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("plcad2")]
		[SMBFieldDescription("Policy Address 2")]
		public string plcad2;

		/// <summary>
		/// City/State/Zip                  
		/// </summary>
		[ColumnOrder(490)]
		[SMBFieldName("plccty")]
		[SMBFieldDescription("City/State/Zip")]
		public string plccty;

		/// <summary>
		/// Company                         
		/// </summary>
		[ColumnOrder(500)]
		[SMBFieldName("cmpnme")]
		[SMBFieldDescription("Company")]
		public string cmpnme;

		/// <summary>
		/// Adjuster Name                   
		/// </summary>
		[ColumnOrder(510)]
		[SMBFieldName("adjnme")]
		[SMBFieldDescription("Adjuster Name")]
		public string adjnme;

		/// <summary>
		/// Adjuster Phone                  
		/// </summary>
		[ColumnOrder(520)]
		[SMBFieldName("adjphn")]
		[SMBFieldDescription("Adjuster Phone")]
		public string adjphn;

		/// <summary>
		/// Adjuster Address 1              
		/// </summary>
		[ColumnOrder(530)]
		[SMBFieldName("adjad1")]
		[SMBFieldDescription("Adjuster Address 1")]
		public string adjad1;

		/// <summary>
		/// Adjuster Address 2              
		/// </summary>
		[ColumnOrder(540)]
		[SMBFieldName("adjad2")]
		[SMBFieldDescription("Adjuster Address 2")]
		public string adjad2;

		/// <summary>
		/// City/State/Zip                  
		/// </summary>
		[ColumnOrder(550)]
		[SMBFieldName("adjcty")]
		[SMBFieldDescription("City/State/Zip")]
		public string adjcty;

		/// <summary>
		/// Policy Type                     
		/// </summary>
		[ColumnOrder(560)]
		[SMBFieldName("plctyp")]
		[SMBFieldDescription("Policy Type")]
		public string plctyp;

		/// <summary>
		/// Deductible                      
		/// </summary>
		[ColumnOrder(570)]
		[SMBFieldName("dedabl")]
		[SMBFieldDescription("Deductible")]
		public decimal dedabl;

		/// <summary>
		/// Route                           
		/// </summary>
		[ColumnOrder(580)]
		[SMBFieldName("rutnum")]
		[SMBFieldDescription("Route")]
		public long rutnum;

		/// <summary>
		/// Contract Start Date             
		/// </summary>
		[ColumnOrder(590)]
		[SMBFieldName("constd")]
		[SMBFieldDescription("Contract Start Date")]
		public DateTime constd;

		/// <summary>
		/// Contract End Date               
		/// </summary>
		[ColumnOrder(600)]
		[SMBFieldName("conend")]
		[SMBFieldDescription("Contract End Date")]
		public DateTime conend;

		/// <summary>
		/// Billing Date                    
		/// </summary>
		[ColumnOrder(610)]
		[SMBFieldName("bildte")]
		[SMBFieldDescription("Billing Date")]
		public DateTime bildte;

		/// <summary>
		/// Technician                      
		/// </summary>
		[ColumnOrder(620)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Technician")]
		public long empnum;

		/// <summary>
		/// Salesperson                     
		/// </summary>
		[ColumnOrder(630)]
		[SMBFieldName("slspsn")]
		[SMBFieldDescription("Salesperson")]
		public long slspsn;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(640)]
		[SMBFieldName("invtyp")]
		[SMBFieldDescription("Type")]
		public long invtyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(650)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Priority                        
		/// </summary>
		[ColumnOrder(660)]
		[SMBFieldName("priort")]
		[SMBFieldDescription("Priority")]
		public long priort;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(670)]
		[SMBFieldName("invsrc")]
		[SMBFieldDescription("Source")]
		public long invsrc;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[ColumnOrder(680)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Payment                         
		/// </summary>
		[ColumnOrder(690)]
		[SMBFieldName("pmttyp")]
		[SMBFieldDescription("Payment")]
		public long pmttyp;

		/// <summary>
		/// Invoice Total                   
		/// </summary>
		[ColumnOrder(700)]
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		/// <summary>
		/// Balance                         
		/// </summary>
		[ColumnOrder(710)]
		[SMBFieldName("invbal")]
		[SMBFieldDescription("Balance")]
		public decimal invbal;

		/// <summary>
		/// Net Due                         
		/// </summary>
		[ColumnOrder(720)]
		[SMBFieldName("invnet")]
		[SMBFieldDescription("Net Due")]
		public decimal invnet;

		/// <summary>
		/// Taxable                         
		/// </summary>
		[ColumnOrder(730)]
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable")]
		public decimal taxabl;

		/// <summary>
		/// Non-Taxable                     
		/// </summary>
		[ColumnOrder(740)]
		[SMBFieldName("nontax")]
		[SMBFieldDescription("Non-Taxable")]
		public decimal nontax;

		/// <summary>
		/// Total Paid                      
		/// </summary>
		[ColumnOrder(750)]
		[SMBFieldName("ttlpad")]
		[SMBFieldDescription("Total Paid")]
		public decimal ttlpad;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(760)]
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Billing Cycle                   
		/// </summary>
		[ColumnOrder(770)]
		[SMBFieldName("bilcyc")]
		[SMBFieldDescription("Billing Cycle")]
		public long bilcyc;

		/// <summary>
		/// Service Area                    
		/// </summary>
		[ColumnOrder(780)]
		[SMBFieldName("srvgeo")]
		[SMBFieldDescription("Service Area")]
		public long srvgeo;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(790)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Shop Notes                      
		/// </summary>
		[ColumnOrder(800)]
		[SMBFieldName("shpnte")]
		[SMBFieldDescription("Shop Notes")]
		public string shpnte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(810)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(820)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Resale #                        
		/// </summary>
		[ColumnOrder(830)]
		[SMBFieldName("exmnum")]
		[SMBFieldDescription("Resale #")]
		public string exmnum;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(840)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Date Entered                    
		/// </summary>
		[ColumnOrder(850)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Date Entered")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(860)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Taxable Grid Total              
		/// </summary>
		[ColumnOrder(870)]
		[SMBFieldName("taxlin")]
		[SMBFieldDescription("Taxable Grid Total")]
		public decimal taxlin;

		/// <summary>
		/// Non-Tax Grid Total              
		/// </summary>
		[ColumnOrder(880)]
		[SMBFieldName("ntxlin")]
		[SMBFieldDescription("Non-Tax Grid Total")]
		public decimal ntxlin;

		/// <summary>
		/// Taxable Markup %                
		/// </summary>
		[ColumnOrder(890)]
		[SMBFieldName("taxmrt")]
		[SMBFieldDescription("Taxable Markup %")]
		public decimal taxmrt;

		/// <summary>
		/// Non-Tax Markup %                
		/// </summary>
		[ColumnOrder(900)]
		[SMBFieldName("ntxmrt")]
		[SMBFieldDescription("Non-Tax Markup %")]
		public decimal ntxmrt;

		/// <summary>
		/// Taxable Markup $                
		/// </summary>
		[ColumnOrder(910)]
		[SMBFieldName("txadmk")]
		[SMBFieldDescription("Taxable Markup $")]
		public decimal txadmk;

		/// <summary>
		/// Non-Tax Markup $                
		/// </summary>
		[ColumnOrder(920)]
		[SMBFieldName("ntadmk")]
		[SMBFieldDescription("Non-Tax Markup $")]
		public decimal ntadmk;

		/// <summary>
		/// Taxable Total Markup            
		/// </summary>
		[ColumnOrder(930)]
		[SMBFieldName("txmktl")]
		[SMBFieldDescription("Taxable Total Markup")]
		public decimal txmktl;

		/// <summary>
		/// Non-Tax Total  Markup           
		/// </summary>
		[ColumnOrder(940)]
		[SMBFieldName("ntmktl")]
		[SMBFieldDescription("Non-Tax Total  Markup")]
		public decimal ntmktl;

		/// <summary>
		/// Taxable Extended Total          
		/// </summary>
		[ColumnOrder(950)]
		[SMBFieldName("taxext")]
		[SMBFieldDescription("Taxable Extended Total")]
		public decimal taxext;

		/// <summary>
		/// Non-Tax Extended Total          
		/// </summary>
		[ColumnOrder(960)]
		[SMBFieldName("ntxext")]
		[SMBFieldDescription("Non-Tax Extended Total")]
		public decimal ntxext;

		/// <summary>
		/// Taxable Billing Amount          
		/// </summary>
		[ColumnOrder(970)]
		[SMBFieldName("taxovr")]
		[SMBFieldDescription("Taxable Billing Amount")]
		public decimal taxovr;

		/// <summary>
		/// Non-Tax Billing Amount          
		/// </summary>
		[ColumnOrder(980)]
		[SMBFieldName("ntxovr")]
		[SMBFieldDescription("Non-Tax Billing Amount")]
		public decimal ntxovr;

		/// <summary>
		/// Lock Taxable Billing Amt        
		/// </summary>
		[ColumnOrder(990)]
		[SMBFieldName("taxlck")]
		[SMBFieldDescription("Lock Taxable Billing Amt")]
		public long taxlck;

		/// <summary>
		/// Lock Non-Tax Billing Amt        
		/// </summary>
		[ColumnOrder(1000)]
		[SMBFieldName("ntxlck")]
		[SMBFieldDescription("Lock Non-Tax Billing Amt")]
		public long ntxlck;

	}
}