using System;

namespace SMB.Tables {
	public partial class actrec : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Job Name                        
		/// </summary>
		[SMBFieldName("jobnme")]
		[SMBFieldDescription("Job Name")]
		public string jobnme;

		/// <summary>
		/// Short Name                      
		/// </summary>
		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		/// <summary>
		/// Client                          
		/// </summary>
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Contact                         
		/// </summary>
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

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
		/// Phone#                          
		/// </summary>
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Fax#                            
		/// </summary>
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		/// <summary>
		/// Architect                       
		/// </summary>
		[SMBFieldName("achtct")]
		[SMBFieldDescription("Architect")]
		public long achtct;

		/// <summary>
		/// Lender                          
		/// </summary>
		[SMBFieldName("lender")]
		[SMBFieldDescription("Lender")]
		public long lender;

		/// <summary>
		/// Supervisor                      
		/// </summary>
		[SMBFieldName("sprvsr")]
		[SMBFieldDescription("Supervisor")]
		public long sprvsr;

		/// <summary>
		/// Salesperson                     
		/// </summary>
		[SMBFieldName("slsemp")]
		[SMBFieldDescription("Salesperson")]
		public long slsemp;

		/// <summary>
		/// Estimator                       
		/// </summary>
		[SMBFieldName("estemp")]
		[SMBFieldDescription("Estimator")]
		public long estemp;

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
		/// Payroll Locale                  
		/// </summary>
		[SMBFieldName("lcltax")]
		[SMBFieldDescription("Payroll Locale")]
		public long lcltax;

		/// <summary>
		/// Sales Tax Dist                  
		/// </summary>
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax Dist")]
		public long slstax;

		/// <summary>
		/// Income Acct                     
		/// </summary>
		[SMBFieldName("lgract")]
		[SMBFieldDescription("Income Acct")]
		public long lgract;

		/// <summary>
		/// Department                      
		/// </summary>
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Disc Rate                       
		/// </summary>
		[SMBFieldName("dsccnt")]
		[SMBFieldDescription("Disc Rate")]
		public decimal dsccnt;

		/// <summary>
		/// Finance %                       
		/// </summary>
		[SMBFieldName("finchg")]
		[SMBFieldDescription("Finance %")]
		public decimal finchg;

		/// <summary>
		/// Retain Rate                     
		/// </summary>
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retain Rate")]
		public decimal retain;

		/// <summary>
		/// Contract                        
		/// </summary>
		[SMBFieldName("cntrct")]
		[SMBFieldDescription("Contract")]
		public decimal cntrct;

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
		/// Bid Open Date                   
		/// </summary>
		[SMBFieldName("biddte")]
		[SMBFieldDescription("Bid Open Date")]
		public DateTime biddte;

		/// <summary>
		/// Plans Received                  
		/// </summary>
		[SMBFieldName("plnrcv")]
		[SMBFieldDescription("Plans Received")]
		public DateTime plnrcv;

		/// <summary>
		/// Bid Completed                   
		/// </summary>
		[SMBFieldName("actbid")]
		[SMBFieldDescription("Bid Completed")]
		public DateTime actbid;

		/// <summary>
		/// Contract Date                   
		/// </summary>
		[SMBFieldName("ctcdte")]
		[SMBFieldDescription("Contract Date")]
		public DateTime ctcdte;

		/// <summary>
		/// Pre-Lien                        
		/// </summary>
		[SMBFieldName("prelen")]
		[SMBFieldDescription("Pre-Lien")]
		public DateTime prelen;

		/// <summary>
		/// Start Date                      
		/// </summary>
		[SMBFieldName("sttdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime sttdte;

		/// <summary>
		/// Finish Date                     
		/// </summary>
		[SMBFieldName("cmpdte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime cmpdte;

		/// <summary>
		/// Lien Filed                      
		/// </summary>
		[SMBFieldName("lenfld")]
		[SMBFieldDescription("Lien Filed")]
		public DateTime lenfld;

		/// <summary>
		/// Lien Released                   
		/// </summary>
		[SMBFieldName("lenrls")]
		[SMBFieldDescription("Lien Released")]
		public DateTime lenrls;

		/// <summary>
		/// Job Type                        
		/// </summary>
		[SMBFieldName("jobtyp")]
		[SMBFieldDescription("Job Type")]
		public long jobtyp;

		/// <summary>
		/// Job Status                      
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Job Status")]
		public long status;

		/// <summary>
		/// Post to WIP                     
		/// </summary>
		[SMBFieldName("pstwip")]
		[SMBFieldDescription("Post to WIP")]
		public long pstwip;

		/// <summary>
		/// Certified Payroll               
		/// </summary>
		[SMBFieldName("crtfid")]
		[SMBFieldDescription("Certified Payroll")]
		public long crtfid;

		/// <summary>
		/// Contract#                       
		/// </summary>
		[SMBFieldName("connum")]
		[SMBFieldDescription("Contract#")]
		public string connum;

		/// <summary>
		/// Client PO#                      
		/// </summary>
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Export Data                     
		/// </summary>
		[SMBFieldName("export")]
		[SMBFieldDescription("Export Data")]
		public string export;

		/// <summary>
		/// Color Scheme                    
		/// </summary>
		[SMBFieldName("lotclr")]
		[SMBFieldDescription("Color Scheme")]
		public string lotclr;

		/// <summary>
		/// Lot Premium                     
		/// </summary>
		[SMBFieldName("lotprm")]
		[SMBFieldDescription("Lot Premium")]
		public decimal lotprm;

		/// <summary>
		/// Est. Sales Price                
		/// </summary>
		[SMBFieldName("plnprc")]
		[SMBFieldDescription("Est. Sales Price")]
		public decimal plnprc;

		/// <summary>
		/// Actual Sales Price              
		/// </summary>
		[SMBFieldName("actprc")]
		[SMBFieldDescription("Actual Sales Price")]
		public decimal actprc;

		/// <summary>
		/// Est. Closing Date               
		/// </summary>
		[SMBFieldName("estdte")]
		[SMBFieldDescription("Est. Closing Date")]
		public DateTime estdte;

		/// <summary>
		/// Actual Closing Date             
		/// </summary>
		[SMBFieldName("actdte")]
		[SMBFieldDescription("Actual Closing Date")]
		public DateTime actdte;

		/// <summary>
		/// Lot Number                      
		/// </summary>
		[SMBFieldName("lotnum")]
		[SMBFieldDescription("Lot Number")]
		public string lotnum;

		/// <summary>
		/// Model Name                      
		/// </summary>
		[SMBFieldName("modnme")]
		[SMBFieldDescription("Model Name")]
		public string modnme;

		/// <summary>
		/// Square Feet                     
		/// </summary>
		[SMBFieldName("sqarft")]
		[SMBFieldDescription("Square Feet")]
		public long sqarft;

	}
}