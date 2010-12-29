using System;

namespace SMB.Tables {
	public class eqpmnt : smbtable {
		/// <summary>
		/// Equip#                          
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Equip#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("eqpnme")]
		[SMBFieldDescription("Description")]
		public string eqpnme;

		/// <summary>
		/// Short Name                      
		/// </summary>
		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[SMBFieldName("srlnum")]
		[SMBFieldDescription("Serial#")]
		public string srlnum;

		/// <summary>
		/// License#                        
		/// </summary>
		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		/// <summary>
		/// PUC#                            
		/// </summary>
		[SMBFieldName("pucnum")]
		[SMBFieldDescription("PUC#")]
		public string pucnum;

		/// <summary>
		/// Loan#                           
		/// </summary>
		[SMBFieldName("lonnum")]
		[SMBFieldDescription("Loan#")]
		public string lonnum;

		/// <summary>
		/// Lender                          
		/// </summary>
		[SMBFieldName("lender")]
		[SMBFieldDescription("Lender")]
		public long lender;

		/// <summary>
		/// Purchased                       
		/// </summary>
		[SMBFieldName("pchdte")]
		[SMBFieldDescription("Purchased")]
		public DateTime pchdte;

		/// <summary>
		/// Pay Date                        
		/// </summary>
		[SMBFieldName("nxtpay")]
		[SMBFieldDescription("Pay Date")]
		public DateTime nxtpay;

		/// <summary>
		/// Loan Type                       
		/// </summary>
		[SMBFieldName("lontyp")]
		[SMBFieldDescription("Loan Type")]
		public long lontyp;

		/// <summary>
		/// Interest Rate                   
		/// </summary>
		[SMBFieldName("intrte")]
		[SMBFieldDescription("Interest Rate")]
		public decimal intrte;

		/// <summary>
		/// Payment                         
		/// </summary>
		[SMBFieldName("paymnt")]
		[SMBFieldDescription("Payment")]
		public decimal paymnt;

		/// <summary>
		/// Depreciation                    
		/// </summary>
		[SMBFieldName("deprte")]
		[SMBFieldDescription("Depreciation")]
		public decimal deprte;

		/// <summary>
		/// Deprec Acct                     
		/// </summary>
		[SMBFieldName("depact")]
		[SMBFieldDescription("Deprec Acct")]
		public long depact;

		/// <summary>
		/// Interest Acct                   
		/// </summary>
		[SMBFieldName("intact")]
		[SMBFieldDescription("Interest Acct")]
		public long intact;

		/// <summary>
		/// Department                      
		/// </summary>
		[SMBFieldName("depmnt")]
		[SMBFieldDescription("Department")]
		public long depmnt;

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
		/// Last Location                   
		/// </summary>
		[SMBFieldName("lstloc")]
		[SMBFieldDescription("Last Location")]
		public string lstloc;

		/// <summary>
		/// Operated Bill                   
		/// </summary>
		[SMBFieldName("oprbll")]
		[SMBFieldDescription("Operated Bill")]
		public decimal oprbll;

		/// <summary>
		/// Operated Cost                   
		/// </summary>
		[SMBFieldName("oprcst")]
		[SMBFieldDescription("Operated Cost")]
		public decimal oprcst;

		/// <summary>
		/// Standby Bill                    
		/// </summary>
		[SMBFieldName("stbbll")]
		[SMBFieldDescription("Standby Bill")]
		public decimal stbbll;

		/// <summary>
		/// Standby Cost                    
		/// </summary>
		[SMBFieldName("stbcst")]
		[SMBFieldDescription("Standby Cost")]
		public decimal stbcst;

		/// <summary>
		/// Idle Bill                       
		/// </summary>
		[SMBFieldName("idlbll")]
		[SMBFieldDescription("Idle Bill")]
		public decimal idlbll;

		/// <summary>
		/// Idle Cost                       
		/// </summary>
		[SMBFieldName("idlcst")]
		[SMBFieldDescription("Idle Cost")]
		public decimal idlcst;

		/// <summary>
		/// Hours                           
		/// </summary>
		[SMBFieldName("ttlhrs")]
		[SMBFieldDescription("Hours")]
		public decimal ttlhrs;

		/// <summary>
		/// Miles                           
		/// </summary>
		[SMBFieldName("ttlmls")]
		[SMBFieldDescription("Miles")]
		public decimal ttlmls;

		/// <summary>
		/// Begin Capital                   
		/// </summary>
		[SMBFieldName("begcap")]
		[SMBFieldDescription("Begin Capital")]
		public decimal begcap;

		/// <summary>
		/// End Capital                     
		/// </summary>
		[SMBFieldName("capend")]
		[SMBFieldDescription("End Capital")]
		public decimal capend;

		/// <summary>
		/// Begin Deprec                    
		/// </summary>
		[SMBFieldName("begdep")]
		[SMBFieldDescription("Begin Deprec")]
		public decimal begdep;

		/// <summary>
		/// End Deprec                      
		/// </summary>
		[SMBFieldName("depend")]
		[SMBFieldDescription("End Deprec")]
		public decimal depend;

		/// <summary>
		/// Begin Loan                      
		/// </summary>
		[SMBFieldName("beglon")]
		[SMBFieldDescription("Begin Loan")]
		public decimal beglon;

		/// <summary>
		/// End Loan                        
		/// </summary>
		[SMBFieldName("lonend")]
		[SMBFieldDescription("End Loan")]
		public decimal lonend;

		/// <summary>
		/// Equip. Type                     
		/// </summary>
		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Equip. Type")]
		public long eqptyp;

		/// <summary>
		/// Start Date                      
		/// </summary>
		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		/// <summary>
		/// End Date                        
		/// </summary>
		[SMBFieldName("enddte")]
		[SMBFieldDescription("End Date")]
		public DateTime enddte;

		/// <summary>
		/// Start Value                     
		/// </summary>
		[SMBFieldName("strval")]
		[SMBFieldDescription("Start Value")]
		public decimal strval;

		/// <summary>
		/// Ending Value                    
		/// </summary>
		[SMBFieldName("endval")]
		[SMBFieldDescription("Ending Value")]
		public decimal endval;

		/// <summary>
		/// Insurance                       
		/// </summary>
		[SMBFieldName("insrnc")]
		[SMBFieldDescription("Insurance")]
		public decimal insrnc;

		/// <summary>
		/// Financing                       
		/// </summary>
		[SMBFieldName("financ")]
		[SMBFieldDescription("Financing")]
		public decimal financ;

		/// <summary>
		/// Tax/License                     
		/// </summary>
		[SMBFieldName("taxlic")]
		[SMBFieldDescription("Tax/License")]
		public decimal taxlic;

		/// <summary>
		/// Inspection                      
		/// </summary>
		[SMBFieldName("inspct")]
		[SMBFieldDescription("Inspection")]
		public decimal inspct;

		/// <summary>
		/// Overhaul                        
		/// </summary>
		[SMBFieldName("ovrhed")]
		[SMBFieldDescription("Overhaul")]
		public decimal ovrhed;

		/// <summary>
		/// Storage                         
		/// </summary>
		[SMBFieldName("storag")]
		[SMBFieldDescription("Storage")]
		public decimal storag;

		/// <summary>
		/// Cost of Capital                 
		/// </summary>
		[SMBFieldName("cstcap")]
		[SMBFieldDescription("Cost of Capital")]
		public decimal cstcap;

		/// <summary>
		/// Other Cost                      
		/// </summary>
		[SMBFieldName("othcst")]
		[SMBFieldDescription("Other Cost")]
		public decimal othcst;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("unttyp")]
		[SMBFieldDescription("Unit")]
		public long unttyp;

		/// <summary>
		/// Estimated Use                   
		/// </summary>
		[SMBFieldName("estuse")]
		[SMBFieldDescription("Estimated Use")]
		public decimal estuse;

		/// <summary>
		/// Fuel and Oil                    
		/// </summary>
		[SMBFieldName("fuloil")]
		[SMBFieldDescription("Fuel and Oil")]
		public decimal fuloil;

		/// <summary>
		/// Tires                           
		/// </summary>
		[SMBFieldName("csttir")]
		[SMBFieldDescription("Tires")]
		public decimal csttir;

		/// <summary>
		/// Maintenance                     
		/// </summary>
		[SMBFieldName("mntcst")]
		[SMBFieldDescription("Maintenance")]
		public decimal mntcst;

		/// <summary>
		/// Other Cost                      
		/// </summary>
		[SMBFieldName("othopr")]
		[SMBFieldDescription("Other Cost")]
		public decimal othopr;

		/// <summary>
		/// Last Posted (niu)               
		/// </summary>
		[SMBFieldName("lstpst")]
		[SMBFieldDescription("Last Posted (niu)")]
		public DateTime lstpst;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Fluid Change                    
		/// </summary>
		[SMBFieldName("fluchg")]
		[SMBFieldDescription("Fluid Change")]
		public decimal fluchg;

		/// <summary>
		/// Minor Repair                    
		/// </summary>
		[SMBFieldName("minrpr")]
		[SMBFieldDescription("Minor Repair")]
		public decimal minrpr;

		/// <summary>
		/// Oil Change                      
		/// </summary>
		[SMBFieldName("oilchg")]
		[SMBFieldDescription("Oil Change")]
		public decimal oilchg;

		/// <summary>
		/// Mobilization Billing            
		/// </summary>
		[SMBFieldName("moblbl")]
		[SMBFieldDescription("Mobilization Billing")]
		public decimal moblbl;

		/// <summary>
		/// Daily Operated Billing          
		/// </summary>
		[SMBFieldName("dyopbl")]
		[SMBFieldDescription("Daily Operated Billing")]
		public decimal dyopbl;

		/// <summary>
		/// Daily Standby Billing           
		/// </summary>
		[SMBFieldName("dystbl")]
		[SMBFieldDescription("Daily Standby Billing")]
		public decimal dystbl;

		/// <summary>
		/// Daily Idle Billing              
		/// </summary>
		[SMBFieldName("dyidbl")]
		[SMBFieldDescription("Daily Idle Billing")]
		public decimal dyidbl;

		/// <summary>
		/// Weekly Operated Billing         
		/// </summary>
		[SMBFieldName("wkopbl")]
		[SMBFieldDescription("Weekly Operated Billing")]
		public decimal wkopbl;

		/// <summary>
		/// Weekly Standby Billing          
		/// </summary>
		[SMBFieldName("wkstbl")]
		[SMBFieldDescription("Weekly Standby Billing")]
		public decimal wkstbl;

		/// <summary>
		/// Weekly Idle Billing             
		/// </summary>
		[SMBFieldName("wkidbl")]
		[SMBFieldDescription("Weekly Idle Billing")]
		public decimal wkidbl;

		/// <summary>
		/// Monthly Operated Billing        
		/// </summary>
		[SMBFieldName("mtopbl")]
		[SMBFieldDescription("Monthly Operated Billing")]
		public decimal mtopbl;

		/// <summary>
		/// Monthly Standby Billing         
		/// </summary>
		[SMBFieldName("mtstbl")]
		[SMBFieldDescription("Monthly Standby Billing")]
		public decimal mtstbl;

		/// <summary>
		/// Monthly Idle Billing            
		/// </summary>
		[SMBFieldName("mtidbl")]
		[SMBFieldDescription("Monthly Idle Billing")]
		public decimal mtidbl;

		/// <summary>
		/// Entered Date                    
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered Date")]
		public DateTime entdte;

		/// <summary>
		/// User Name                       
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Last Period                     
		/// </summary>
		[SMBFieldName("lstprd")]
		[SMBFieldDescription("Last Period")]
		public string lstprd;

		/// <summary>
		/// Original Hours                  
		/// </summary>
		[SMBFieldName("orghrs")]
		[SMBFieldDescription("Original Hours")]
		public decimal orghrs;

		/// <summary>
		/// Original Miles                  
		/// </summary>
		[SMBFieldName("orgmls")]
		[SMBFieldDescription("Original Miles")]
		public decimal orgmls;

	}
}