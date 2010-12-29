using System;

namespace SMB.Tables {
	public class actpay : smbtable {
		/// <summary>
		/// Vendor#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor#")]
		public long recnum;

		/// <summary>
		/// Vendor Name                     
		/// </summary>
		[SMBFieldName("vndnme")]
		[SMBFieldDescription("Vendor Name")]
		public string vndnme;

		/// <summary>
		/// Short Name                      
		/// </summary>
		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		/// <summary>
		/// Owner                           
		/// </summary>
		[SMBFieldName("ownnme")]
		[SMBFieldDescription("Owner")]
		public string ownnme;

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
		/// Federal Id#                     
		/// </summary>
		[SMBFieldName("fedidn")]
		[SMBFieldDescription("Federal Id#")]
		public string fedidn;

		/// <summary>
		/// State Id#                       
		/// </summary>
		[SMBFieldName("steidn")]
		[SMBFieldDescription("State Id#")]
		public string steidn;

		/// <summary>
		/// Resale#                         
		/// </summary>
		[SMBFieldName("resnum")]
		[SMBFieldDescription("Resale#")]
		public string resnum;

		/// <summary>
		/// Account#                        
		/// </summary>
		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account#")]
		public string actnum;

		/// <summary>
		/// License#                        
		/// </summary>
		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

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
		/// Phone#                          
		/// </summary>
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Pager#                          
		/// </summary>
		[SMBFieldName("pagnum")]
		[SMBFieldDescription("Pager#")]
		public string pagnum;

		/// <summary>
		/// Fax#                            
		/// </summary>
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		/// <summary>
		/// Cell#                           
		/// </summary>
		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell#")]
		public string cllphn;

		/// <summary>
		/// Home#                           
		/// </summary>
		[SMBFieldName("homphn")]
		[SMBFieldDescription("Home#")]
		public string homphn;

		/// <summary>
		/// Email                           
		/// </summary>
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		/// <summary>
		/// Disc Rate                       
		/// </summary>
		[SMBFieldName("dscrte")]
		[SMBFieldDescription("Disc Rate")]
		public decimal dscrte;

		/// <summary>
		/// Ledger Acct                     
		/// </summary>
		[SMBFieldName("lgrdft")]
		[SMBFieldDescription("Ledger Acct")]
		public long lgrdft;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cdedft")]
		[SMBFieldDescription("Cost Code")]
		public decimal cdedft;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[SMBFieldName("typdft")]
		[SMBFieldDescription("Cost Type")]
		public long typdft;

		/// <summary>
		/// Invoice Status                  
		/// </summary>
		[SMBFieldName("stsdft")]
		[SMBFieldDescription("Invoice Status")]
		public long stsdft;

		/// <summary>
		/// PO Warning                      
		/// </summary>
		[SMBFieldName("wrndft")]
		[SMBFieldDescription("PO Warning")]
		public long wrndft;

		/// <summary>
		/// 1099 Balance                    
		/// </summary>
		[SMBFieldName("bal199")]
		[SMBFieldDescription("1099 Balance")]
		public decimal bal199;

		/// <summary>
		/// YTD Activity                    
		/// </summary>
		[SMBFieldName("ytdact")]
		[SMBFieldDescription("YTD Activity")]
		public decimal ytdact;

		/// <summary>
		/// LstYr Activity                  
		/// </summary>
		[SMBFieldName("lstact")]
		[SMBFieldDescription("LstYr Activity")]
		public decimal lstact;

		/// <summary>
		/// Beg Balance                     
		/// </summary>
		[SMBFieldName("begbal")]
		[SMBFieldDescription("Beg Balance")]
		public decimal begbal;

		/// <summary>
		/// End Balance                     
		/// </summary>
		[SMBFieldName("endbal")]
		[SMBFieldDescription("End Balance")]
		public decimal endbal;

		/// <summary>
		/// Vendor Type                     
		/// </summary>
		[SMBFieldName("vndtyp")]
		[SMBFieldDescription("Vendor Type")]
		public long vndtyp;

		/// <summary>
		/// 1099 Type                       
		/// </summary>
		[SMBFieldName("prt199")]
		[SMBFieldDescription("1099 Type")]
		public long prt199;

		/// <summary>
		/// Minority                        
		/// </summary>
		[SMBFieldName("minsts")]
		[SMBFieldDescription("Minority")]
		public long minsts;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Internal Vendor                 
		/// </summary>
		[SMBFieldName("intrnl")]
		[SMBFieldDescription("Internal Vendor")]
		public long intrnl;

		/// <summary>
		/// Comp Rate                       
		/// </summary>
		[SMBFieldName("cmprte")]
		[SMBFieldDescription("Comp Rate")]
		public decimal cmprte;

		/// <summary>
		/// 'Use Tax' Rate                  
		/// </summary>
		[SMBFieldName("utxrte")]
		[SMBFieldDescription("'Use Tax' Rate")]
		public decimal utxrte;

		/// <summary>
		/// Default Hot List                
		/// </summary>
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Default Hot List")]
		public string hotlst;

		/// <summary>
		/// Purchase Order Type             
		/// </summary>
		[SMBFieldName("ordtyp")]
		[SMBFieldDescription("Purchase Order Type")]
		public long ordtyp;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("orddsc")]
		[SMBFieldDescription("Description")]
		public string orddsc;

		/// <summary>
		/// Subcontract Type                
		/// </summary>
		[SMBFieldName("contyp")]
		[SMBFieldDescription("Subcontract Type")]
		public long contyp;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("condsc")]
		[SMBFieldDescription("Description")]
		public string condsc;

		/// <summary>
		/// Vendor Notes                    
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Vendor Notes")]
		public string ntetxt;

		/// <summary>
		/// Allow Duplicate Invoice #       
		/// </summary>
		[SMBFieldName("dupchk")]
		[SMBFieldDescription("Allow Duplicate Invoice #")]
		public long dupchk;

		/// <summary>
		/// RFP Type                        
		/// </summary>
		[SMBFieldName("rfptyp")]
		[SMBFieldDescription("RFP Type")]
		public long rfptyp;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("rfpdsc")]
		[SMBFieldDescription("Description")]
		public string rfpdsc;

		/// <summary>
		/// Separate Checks                 
		/// </summary>
		[SMBFieldName("sepchk")]
		[SMBFieldDescription("Separate Checks")]
		public long sepchk;

		/// <summary>
		/// Contact                         
		/// </summary>
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

	}
}