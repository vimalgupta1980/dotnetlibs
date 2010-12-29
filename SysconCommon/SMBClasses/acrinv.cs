using System;

namespace SMB.Tables {
	public class acrinv : smbtable {
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
		/// Date                            
		/// </summary>
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Date")]
		public DateTime invdte;

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
		/// Tax Dist                        
		/// </summary>
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax Dist")]
		public long taxdst;

		/// <summary>
		/// Client PO#                      
		/// </summary>
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

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
		/// Disc Avail                      
		/// </summary>
		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Disc Avail")]
		public decimal dscavl;

		/// <summary>
		/// Retention                       
		/// </summary>
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

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
		/// Total                           
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Total")]
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
		/// Taxable Total                   
		/// </summary>
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable Total")]
		public decimal taxabl;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Non-Tax                         
		/// </summary>
		[SMBFieldName("nontax")]
		[SMBFieldDescription("Non-Tax")]
		public decimal nontax;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Total Paid                      
		/// </summary>
		[SMBFieldName("ttlpad")]
		[SMBFieldDescription("Total Paid")]
		public decimal ttlpad;

		/// <summary>
		/// User Name                       
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}