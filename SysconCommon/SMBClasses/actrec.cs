using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class actrec : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Job Name                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("jobnme")]
		[SMBFieldDescription("Job Name")]
		public string jobnme;

		/// <summary>
		/// Short Name                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		/// <summary>
		/// Client                          
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Contact                         
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Fax#                            
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		/// <summary>
		/// Architect                       
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("achtct")]
		[SMBFieldDescription("Architect")]
		public long achtct;

		/// <summary>
		/// Lender                          
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("lender")]
		[SMBFieldDescription("Lender")]
		public long lender;

		/// <summary>
		/// Supervisor                      
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("sprvsr")]
		[SMBFieldDescription("Supervisor")]
		public long sprvsr;

		/// <summary>
		/// Salesperson                     
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("slsemp")]
		[SMBFieldDescription("Salesperson")]
		public long slsemp;

		/// <summary>
		/// Estimator                       
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("estemp")]
		[SMBFieldDescription("Estimator")]
		public long estemp;

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
		/// Payroll Locale                  
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("lcltax")]
		[SMBFieldDescription("Payroll Locale")]
		public long lcltax;

		/// <summary>
		/// Sales Tax Dist                  
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax Dist")]
		public long slstax;

		/// <summary>
		/// Income Acct                     
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("lgract")]
		[SMBFieldDescription("Income Acct")]
		public long lgract;

		/// <summary>
		/// Department                      
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Disc Rate                       
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("dsccnt")]
		[SMBFieldDescription("Disc Rate")]
		public decimal dsccnt;

		/// <summary>
		/// Finance %                       
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("finchg")]
		[SMBFieldDescription("Finance %")]
		public decimal finchg;

		/// <summary>
		/// Retain Rate                     
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retain Rate")]
		public decimal retain;

		/// <summary>
		/// Contract                        
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("cntrct")]
		[SMBFieldDescription("Contract")]
		public decimal cntrct;

		/// <summary>
		/// Beg Balance                     
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("begbal")]
		[SMBFieldDescription("Beg Balance")]
		public decimal begbal;

		/// <summary>
		/// End Balance                     
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("endbal")]
		[SMBFieldDescription("End Balance")]
		public decimal endbal;

		/// <summary>
		/// Bid Open Date                   
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("biddte")]
		[SMBFieldDescription("Bid Open Date")]
		public DateTime biddte;

		/// <summary>
		/// Plans Received                  
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("plnrcv")]
		[SMBFieldDescription("Plans Received")]
		public DateTime plnrcv;

		/// <summary>
		/// Bid Completed                   
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("actbid")]
		[SMBFieldDescription("Bid Completed")]
		public DateTime actbid;

		/// <summary>
		/// Contract Date                   
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("ctcdte")]
		[SMBFieldDescription("Contract Date")]
		public DateTime ctcdte;

		/// <summary>
		/// Pre-Lien                        
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("prelen")]
		[SMBFieldDescription("Pre-Lien")]
		public DateTime prelen;

		/// <summary>
		/// Start Date                      
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("sttdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime sttdte;

		/// <summary>
		/// Finish Date                     
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("cmpdte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime cmpdte;

		/// <summary>
		/// Lien Filed                      
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("lenfld")]
		[SMBFieldDescription("Lien Filed")]
		public DateTime lenfld;

		/// <summary>
		/// Lien Released                   
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("lenrls")]
		[SMBFieldDescription("Lien Released")]
		public DateTime lenrls;

		/// <summary>
		/// Job Type                        
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("jobtyp")]
		[SMBFieldDescription("Job Type")]
		public long jobtyp;

		/// <summary>
		/// Job Status                      
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Job Status")]
		public long status;

		/// <summary>
		/// Post to WIP                     
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("pstwip")]
		[SMBFieldDescription("Post to WIP")]
		public long pstwip;

		/// <summary>
		/// Certified Payroll               
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("crtfid")]
		[SMBFieldDescription("Certified Payroll")]
		public long crtfid;

		/// <summary>
		/// Contract#                       
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("connum")]
		[SMBFieldDescription("Contract#")]
		public string connum;

		/// <summary>
		/// Client PO#                      
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Export Data                     
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("export")]
		[SMBFieldDescription("Export Data")]
		public string export;

		/// <summary>
		/// Color Scheme                    
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("lotclr")]
		[SMBFieldDescription("Color Scheme")]
		public string lotclr;

		/// <summary>
		/// Lot Premium                     
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("lotprm")]
		[SMBFieldDescription("Lot Premium")]
		public decimal lotprm;

		/// <summary>
		/// Est. Sales Price                
		/// </summary>
		[ColumnOrder(490)]
		[SMBFieldName("plnprc")]
		[SMBFieldDescription("Est. Sales Price")]
		public decimal plnprc;

		/// <summary>
		/// Actual Sales Price              
		/// </summary>
		[ColumnOrder(500)]
		[SMBFieldName("actprc")]
		[SMBFieldDescription("Actual Sales Price")]
		public decimal actprc;

		/// <summary>
		/// Est. Closing Date               
		/// </summary>
		[ColumnOrder(510)]
		[SMBFieldName("estdte")]
		[SMBFieldDescription("Est. Closing Date")]
		public DateTime estdte;

		/// <summary>
		/// Actual Closing Date             
		/// </summary>
		[ColumnOrder(520)]
		[SMBFieldName("actdte")]
		[SMBFieldDescription("Actual Closing Date")]
		public DateTime actdte;

		/// <summary>
		/// Lot Number                      
		/// </summary>
		[ColumnOrder(530)]
		[SMBFieldName("lotnum")]
		[SMBFieldDescription("Lot Number")]
		public string lotnum;

		/// <summary>
		/// Model Name                      
		/// </summary>
		[ColumnOrder(540)]
		[SMBFieldName("modnme")]
		[SMBFieldDescription("Model Name")]
		public string modnme;

		/// <summary>
		/// Square Feet                     
		/// </summary>
		[ColumnOrder(550)]
		[SMBFieldName("sqarft")]
		[SMBFieldDescription("Square Feet")]
		public long sqarft;

	}
}