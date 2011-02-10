using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class eqpmnt : smbtable {
		/// <summary>
		/// Equip#                          
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Equip#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("eqpnme")]
		[SMBFieldDescription("Description")]
		public string eqpnme;

		/// <summary>
		/// Short Name                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("srlnum")]
		[SMBFieldDescription("Serial#")]
		public string srlnum;

		/// <summary>
		/// License#                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		/// <summary>
		/// PUC#                            
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("pucnum")]
		[SMBFieldDescription("PUC#")]
		public string pucnum;

		/// <summary>
		/// Loan#                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("lonnum")]
		[SMBFieldDescription("Loan#")]
		public string lonnum;

		/// <summary>
		/// Lender                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("lender")]
		[SMBFieldDescription("Lender")]
		public long lender;

		/// <summary>
		/// Purchased                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("pchdte")]
		[SMBFieldDescription("Purchased")]
		public DateTime pchdte;

		/// <summary>
		/// Pay Date                        
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("nxtpay")]
		[SMBFieldDescription("Pay Date")]
		public DateTime nxtpay;

		/// <summary>
		/// Loan Type                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("lontyp")]
		[SMBFieldDescription("Loan Type")]
		public long lontyp;

		/// <summary>
		/// Interest Rate                   
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("intrte")]
		[SMBFieldDescription("Interest Rate")]
		public decimal intrte;

		/// <summary>
		/// Payment                         
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("paymnt")]
		[SMBFieldDescription("Payment")]
		public decimal paymnt;

		/// <summary>
		/// Depreciation                    
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("deprte")]
		[SMBFieldDescription("Depreciation")]
		public decimal deprte;

		/// <summary>
		/// Deprec Acct                     
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("depact")]
		[SMBFieldDescription("Deprec Acct")]
		public long depact;

		/// <summary>
		/// Interest Acct                   
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("intact")]
		[SMBFieldDescription("Interest Acct")]
		public long intact;

		/// <summary>
		/// Department                      
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("depmnt")]
		[SMBFieldDescription("Department")]
		public long depmnt;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Last Location                   
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("lstloc")]
		[SMBFieldDescription("Last Location")]
		public string lstloc;

		/// <summary>
		/// Operated Bill                   
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("oprbll")]
		[SMBFieldDescription("Operated Bill")]
		public decimal oprbll;

		/// <summary>
		/// Operated Cost                   
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("oprcst")]
		[SMBFieldDescription("Operated Cost")]
		public decimal oprcst;

		/// <summary>
		/// Standby Bill                    
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("stbbll")]
		[SMBFieldDescription("Standby Bill")]
		public decimal stbbll;

		/// <summary>
		/// Standby Cost                    
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("stbcst")]
		[SMBFieldDescription("Standby Cost")]
		public decimal stbcst;

		/// <summary>
		/// Idle Bill                       
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("idlbll")]
		[SMBFieldDescription("Idle Bill")]
		public decimal idlbll;

		/// <summary>
		/// Idle Cost                       
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("idlcst")]
		[SMBFieldDescription("Idle Cost")]
		public decimal idlcst;

		/// <summary>
		/// Hours                           
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("ttlhrs")]
		[SMBFieldDescription("Hours")]
		public decimal ttlhrs;

		/// <summary>
		/// Miles                           
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("ttlmls")]
		[SMBFieldDescription("Miles")]
		public decimal ttlmls;

		/// <summary>
		/// Begin Capital                   
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("begcap")]
		[SMBFieldDescription("Begin Capital")]
		public decimal begcap;

		/// <summary>
		/// End Capital                     
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("capend")]
		[SMBFieldDescription("End Capital")]
		public decimal capend;

		/// <summary>
		/// Begin Deprec                    
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("begdep")]
		[SMBFieldDescription("Begin Deprec")]
		public decimal begdep;

		/// <summary>
		/// End Deprec                      
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("depend")]
		[SMBFieldDescription("End Deprec")]
		public decimal depend;

		/// <summary>
		/// Begin Loan                      
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("beglon")]
		[SMBFieldDescription("Begin Loan")]
		public decimal beglon;

		/// <summary>
		/// End Loan                        
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("lonend")]
		[SMBFieldDescription("End Loan")]
		public decimal lonend;

		/// <summary>
		/// Equip. Type                     
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Equip. Type")]
		public long eqptyp;

		/// <summary>
		/// Start Date                      
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		/// <summary>
		/// End Date                        
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("enddte")]
		[SMBFieldDescription("End Date")]
		public DateTime enddte;

		/// <summary>
		/// Start Value                     
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("strval")]
		[SMBFieldDescription("Start Value")]
		public decimal strval;

		/// <summary>
		/// Ending Value                    
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("endval")]
		[SMBFieldDescription("Ending Value")]
		public decimal endval;

		/// <summary>
		/// Insurance                       
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("insrnc")]
		[SMBFieldDescription("Insurance")]
		public decimal insrnc;

		/// <summary>
		/// Financing                       
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("financ")]
		[SMBFieldDescription("Financing")]
		public decimal financ;

		/// <summary>
		/// Tax/License                     
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("taxlic")]
		[SMBFieldDescription("Tax/License")]
		public decimal taxlic;

		/// <summary>
		/// Inspection                      
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("inspct")]
		[SMBFieldDescription("Inspection")]
		public decimal inspct;

		/// <summary>
		/// Overhaul                        
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("ovrhed")]
		[SMBFieldDescription("Overhaul")]
		public decimal ovrhed;

		/// <summary>
		/// Storage                         
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("storag")]
		[SMBFieldDescription("Storage")]
		public decimal storag;

		/// <summary>
		/// Cost of Capital                 
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("cstcap")]
		[SMBFieldDescription("Cost of Capital")]
		public decimal cstcap;

		/// <summary>
		/// Other Cost                      
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("othcst")]
		[SMBFieldDescription("Other Cost")]
		public decimal othcst;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("unttyp")]
		[SMBFieldDescription("Unit")]
		public long unttyp;

		/// <summary>
		/// Estimated Use                   
		/// </summary>
		[ColumnOrder(490)]
		[SMBFieldName("estuse")]
		[SMBFieldDescription("Estimated Use")]
		public decimal estuse;

		/// <summary>
		/// Fuel and Oil                    
		/// </summary>
		[ColumnOrder(500)]
		[SMBFieldName("fuloil")]
		[SMBFieldDescription("Fuel and Oil")]
		public decimal fuloil;

		/// <summary>
		/// Tires                           
		/// </summary>
		[ColumnOrder(510)]
		[SMBFieldName("csttir")]
		[SMBFieldDescription("Tires")]
		public decimal csttir;

		/// <summary>
		/// Maintenance                     
		/// </summary>
		[ColumnOrder(520)]
		[SMBFieldName("mntcst")]
		[SMBFieldDescription("Maintenance")]
		public decimal mntcst;

		/// <summary>
		/// Other Cost                      
		/// </summary>
		[ColumnOrder(530)]
		[SMBFieldName("othopr")]
		[SMBFieldDescription("Other Cost")]
		public decimal othopr;

		/// <summary>
		/// Last Posted (niu)               
		/// </summary>
		[ColumnOrder(540)]
		[SMBFieldName("lstpst")]
		[SMBFieldDescription("Last Posted (niu)")]
		public DateTime lstpst;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(550)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Fluid Change                    
		/// </summary>
		[ColumnOrder(560)]
		[SMBFieldName("fluchg")]
		[SMBFieldDescription("Fluid Change")]
		public decimal fluchg;

		/// <summary>
		/// Minor Repair                    
		/// </summary>
		[ColumnOrder(570)]
		[SMBFieldName("minrpr")]
		[SMBFieldDescription("Minor Repair")]
		public decimal minrpr;

		/// <summary>
		/// Oil Change                      
		/// </summary>
		[ColumnOrder(580)]
		[SMBFieldName("oilchg")]
		[SMBFieldDescription("Oil Change")]
		public decimal oilchg;

		/// <summary>
		/// Mobilization Billing            
		/// </summary>
		[ColumnOrder(590)]
		[SMBFieldName("moblbl")]
		[SMBFieldDescription("Mobilization Billing")]
		public decimal moblbl;

		/// <summary>
		/// Daily Operated Billing          
		/// </summary>
		[ColumnOrder(600)]
		[SMBFieldName("dyopbl")]
		[SMBFieldDescription("Daily Operated Billing")]
		public decimal dyopbl;

		/// <summary>
		/// Daily Standby Billing           
		/// </summary>
		[ColumnOrder(610)]
		[SMBFieldName("dystbl")]
		[SMBFieldDescription("Daily Standby Billing")]
		public decimal dystbl;

		/// <summary>
		/// Daily Idle Billing              
		/// </summary>
		[ColumnOrder(620)]
		[SMBFieldName("dyidbl")]
		[SMBFieldDescription("Daily Idle Billing")]
		public decimal dyidbl;

		/// <summary>
		/// Weekly Operated Billing         
		/// </summary>
		[ColumnOrder(630)]
		[SMBFieldName("wkopbl")]
		[SMBFieldDescription("Weekly Operated Billing")]
		public decimal wkopbl;

		/// <summary>
		/// Weekly Standby Billing          
		/// </summary>
		[ColumnOrder(640)]
		[SMBFieldName("wkstbl")]
		[SMBFieldDescription("Weekly Standby Billing")]
		public decimal wkstbl;

		/// <summary>
		/// Weekly Idle Billing             
		/// </summary>
		[ColumnOrder(650)]
		[SMBFieldName("wkidbl")]
		[SMBFieldDescription("Weekly Idle Billing")]
		public decimal wkidbl;

		/// <summary>
		/// Monthly Operated Billing        
		/// </summary>
		[ColumnOrder(660)]
		[SMBFieldName("mtopbl")]
		[SMBFieldDescription("Monthly Operated Billing")]
		public decimal mtopbl;

		/// <summary>
		/// Monthly Standby Billing         
		/// </summary>
		[ColumnOrder(670)]
		[SMBFieldName("mtstbl")]
		[SMBFieldDescription("Monthly Standby Billing")]
		public decimal mtstbl;

		/// <summary>
		/// Monthly Idle Billing            
		/// </summary>
		[ColumnOrder(680)]
		[SMBFieldName("mtidbl")]
		[SMBFieldDescription("Monthly Idle Billing")]
		public decimal mtidbl;

		/// <summary>
		/// Entered Date                    
		/// </summary>
		[ColumnOrder(690)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered Date")]
		public DateTime entdte;

		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(700)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(710)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Last Period                     
		/// </summary>
		[ColumnOrder(720)]
		[SMBFieldName("lstprd")]
		[SMBFieldDescription("Last Period")]
		public string lstprd;

		/// <summary>
		/// Original Hours                  
		/// </summary>
		[ColumnOrder(730)]
		[SMBFieldName("orghrs")]
		[SMBFieldDescription("Original Hours")]
		public decimal orghrs;

		/// <summary>
		/// Original Miles                  
		/// </summary>
		[ColumnOrder(740)]
		[SMBFieldName("orgmls")]
		[SMBFieldDescription("Original Miles")]
		public decimal orgmls;

	}
}