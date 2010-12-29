using System;

namespace SMB.Tables {
	public class acpinv : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		/// <summary>
		/// Order#                          
		/// </summary>
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Order#")]
		public string pchord;

		/// <summary>
		/// Contract#                       
		/// </summary>
		[SMBFieldName("ctcnum")]
		[SMBFieldDescription("Contract#")]
		public string ctcnum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Date")]
		public DateTime invdte;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[SMBFieldName("duedte")]
		[SMBFieldDescription("Due Date")]
		public DateTime duedte;

		/// <summary>
		/// Reference#                      
		/// </summary>
		[SMBFieldName("refnum")]
		[SMBFieldDescription("Reference#")]
		public string refnum;

		/// <summary>
		/// Disc Date                       
		/// </summary>
		[SMBFieldName("dscdte")]
		[SMBFieldDescription("Disc Date")]
		public DateTime dscdte;

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
		/// 2nd Payee                       
		/// </summary>
		[SMBFieldName("payee2")]
		[SMBFieldDescription("2nd Payee")]
		public string payee2;

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
		/// Discount                        
		/// </summary>
		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Discount")]
		public decimal dscavl;

		/// <summary>
		/// Retention                       
		/// </summary>
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		/// <summary>
		/// Set to Pay                      
		/// </summary>
		[SMBFieldName("setpay")]
		[SMBFieldDescription("Set to Pay")]
		public decimal setpay;

		/// <summary>
		/// Paid                            
		/// </summary>
		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid")]
		public decimal amtpad;

		/// <summary>
		/// Disc/Credit                     
		/// </summary>
		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Disc/Credit")]
		public decimal dsctkn;

		/// <summary>
		/// Invoice Total                   
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		/// <summary>
		/// Variance                        
		/// </summary>
		[SMBFieldName("adjust")]
		[SMBFieldDescription("Variance")]
		public decimal adjust;

		/// <summary>
		/// Freight                         
		/// </summary>
		[SMBFieldName("freigh")]
		[SMBFieldDescription("Freight")]
		public decimal freigh;

		/// <summary>
		/// Total Paid                      
		/// </summary>
		[SMBFieldName("ttlpad")]
		[SMBFieldDescription("Total Paid")]
		public decimal ttlpad;

		/// <summary>
		/// Invoice Balance                 
		/// </summary>
		[SMBFieldName("invbal")]
		[SMBFieldDescription("Invoice Balance")]
		public decimal invbal;

		/// <summary>
		/// Invoice Net                     
		/// </summary>
		[SMBFieldName("invnet")]
		[SMBFieldDescription("Invoice Net")]
		public decimal invnet;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// User Name                       
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Batch#                          
		/// </summary>
		[SMBFieldName("btcnum")]
		[SMBFieldDescription("Batch#")]
		public long btcnum;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Shipping#                       
		/// </summary>
		[SMBFieldName("shpnum")]
		[SMBFieldDescription("Shipping#")]
		public string shpnum;

		/// <summary>
		/// Work Comp                       
		/// </summary>
		[SMBFieldName("cmpamt")]
		[SMBFieldDescription("Work Comp")]
		public decimal cmpamt;

		/// <summary>
		/// 'Use Tax' Rate                  
		/// </summary>
		[SMBFieldName("usetax")]
		[SMBFieldDescription("'Use Tax' Rate")]
		public decimal usetax;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}