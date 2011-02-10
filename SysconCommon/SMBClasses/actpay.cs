using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class actpay : smbtable {
		/// <summary>
		/// Vendor#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor#")]
		public long recnum;

		/// <summary>
		/// Vendor Name                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("vndnme")]
		[SMBFieldDescription("Vendor Name")]
		public string vndnme;

		/// <summary>
		/// Short Name                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		/// <summary>
		/// Owner                           
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("ownnme")]
		[SMBFieldDescription("Owner")]
		public string ownnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Federal Id#                     
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("fedidn")]
		[SMBFieldDescription("Federal Id#")]
		public string fedidn;

		/// <summary>
		/// State Id#                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("steidn")]
		[SMBFieldDescription("State Id#")]
		public string steidn;

		/// <summary>
		/// Resale#                         
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("resnum")]
		[SMBFieldDescription("Resale#")]
		public string resnum;

		/// <summary>
		/// Account#                        
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account#")]
		public string actnum;

		/// <summary>
		/// License#                        
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Pager#                          
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("pagnum")]
		[SMBFieldDescription("Pager#")]
		public string pagnum;

		/// <summary>
		/// Fax#                            
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		/// <summary>
		/// Cell#                           
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell#")]
		public string cllphn;

		/// <summary>
		/// Home#                           
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("homphn")]
		[SMBFieldDescription("Home#")]
		public string homphn;

		/// <summary>
		/// Email                           
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		/// <summary>
		/// Disc Rate                       
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("dscrte")]
		[SMBFieldDescription("Disc Rate")]
		public decimal dscrte;

		/// <summary>
		/// Ledger Acct                     
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("lgrdft")]
		[SMBFieldDescription("Ledger Acct")]
		public long lgrdft;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("cdedft")]
		[SMBFieldDescription("Cost Code")]
		public decimal cdedft;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("typdft")]
		[SMBFieldDescription("Cost Type")]
		public long typdft;

		/// <summary>
		/// Invoice Status                  
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("stsdft")]
		[SMBFieldDescription("Invoice Status")]
		public long stsdft;

		/// <summary>
		/// PO Warning                      
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("wrndft")]
		[SMBFieldDescription("PO Warning")]
		public long wrndft;

		/// <summary>
		/// 1099 Balance                    
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("bal199")]
		[SMBFieldDescription("1099 Balance")]
		public decimal bal199;

		/// <summary>
		/// YTD Activity                    
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("ytdact")]
		[SMBFieldDescription("YTD Activity")]
		public decimal ytdact;

		/// <summary>
		/// LstYr Activity                  
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("lstact")]
		[SMBFieldDescription("LstYr Activity")]
		public decimal lstact;

		/// <summary>
		/// Beg Balance                     
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("begbal")]
		[SMBFieldDescription("Beg Balance")]
		public decimal begbal;

		/// <summary>
		/// End Balance                     
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("endbal")]
		[SMBFieldDescription("End Balance")]
		public decimal endbal;

		/// <summary>
		/// Vendor Type                     
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("vndtyp")]
		[SMBFieldDescription("Vendor Type")]
		public long vndtyp;

		/// <summary>
		/// 1099 Type                       
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("prt199")]
		[SMBFieldDescription("1099 Type")]
		public long prt199;

		/// <summary>
		/// Minority                        
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("minsts")]
		[SMBFieldDescription("Minority")]
		public long minsts;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Internal Vendor                 
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("intrnl")]
		[SMBFieldDescription("Internal Vendor")]
		public long intrnl;

		/// <summary>
		/// Comp Rate                       
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("cmprte")]
		[SMBFieldDescription("Comp Rate")]
		public decimal cmprte;

		/// <summary>
		/// 'Use Tax' Rate                  
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("utxrte")]
		[SMBFieldDescription("'Use Tax' Rate")]
		public decimal utxrte;

		/// <summary>
		/// Default Hot List                
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Default Hot List")]
		public string hotlst;

		/// <summary>
		/// Purchase Order Type             
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("ordtyp")]
		[SMBFieldDescription("Purchase Order Type")]
		public long ordtyp;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("orddsc")]
		[SMBFieldDescription("Description")]
		public string orddsc;

		/// <summary>
		/// Subcontract Type                
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("contyp")]
		[SMBFieldDescription("Subcontract Type")]
		public long contyp;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("condsc")]
		[SMBFieldDescription("Description")]
		public string condsc;

		/// <summary>
		/// Vendor Notes                    
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Vendor Notes")]
		public string ntetxt;

		/// <summary>
		/// Allow Duplicate Invoice #       
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("dupchk")]
		[SMBFieldDescription("Allow Duplicate Invoice #")]
		public long dupchk;

		/// <summary>
		/// RFP Type                        
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("rfptyp")]
		[SMBFieldDescription("RFP Type")]
		public long rfptyp;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(490)]
		[SMBFieldName("rfpdsc")]
		[SMBFieldDescription("Description")]
		public string rfpdsc;

		/// <summary>
		/// Separate Checks                 
		/// </summary>
		[ColumnOrder(500)]
		[SMBFieldName("sepchk")]
		[SMBFieldDescription("Separate Checks")]
		public long sepchk;

		/// <summary>
		/// Contact                         
		/// </summary>
		[ColumnOrder(510)]
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

	}
}