using System;

namespace SMB.Tables {
	public class pchord : smbtable {
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
		/// Order Date                      
		/// </summary>
		[SMBFieldName("orddte")]
		[SMBFieldDescription("Order Date")]
		public DateTime orddte;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Attention                       
		/// </summary>
		[SMBFieldName("attion")]
		[SMBFieldDescription("Attention")]
		public string attion;

		/// <summary>
		/// Ordered by                      
		/// </summary>
		[SMBFieldName("odrdby")]
		[SMBFieldDescription("Ordered by")]
		public long odrdby;

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
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpmnt")]
		[SMBFieldDescription("Equipment")]
		public long eqpmnt;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Document #                      
		/// </summary>
		[SMBFieldName("docnum")]
		[SMBFieldDescription("Document #")]
		public string docnum;

		/// <summary>
		/// Source                          
		/// </summary>
		[SMBFieldName("docsrc")]
		[SMBFieldDescription("Source")]
		public long docsrc;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Approved                        
		/// </summary>
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Scheduled                       
		/// </summary>
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Scheduled")]
		public DateTime schdte;

		/// <summary>
		/// Delivery                        
		/// </summary>
		[SMBFieldName("deldte")]
		[SMBFieldDescription("Delivery")]
		public DateTime deldte;

		/// <summary>
		/// Via                             
		/// </summary>
		[SMBFieldName("delvia")]
		[SMBFieldDescription("Via")]
		public string delvia;

		/// <summary>
		/// PO Type                         
		/// </summary>
		[SMBFieldName("ordtyp")]
		[SMBFieldDescription("PO Type")]
		public long ordtyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

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
		/// Received                        
		/// </summary>
		[SMBFieldName("rcvdte")]
		[SMBFieldDescription("Received")]
		public decimal rcvdte;

		/// <summary>
		/// Current                         
		/// </summary>
		[SMBFieldName("currnt")]
		[SMBFieldDescription("Current")]
		public decimal currnt;

		/// <summary>
		/// Canceled                        
		/// </summary>
		[SMBFieldName("cancel")]
		[SMBFieldDescription("Canceled")]
		public decimal cancel;

		/// <summary>
		/// Subtotal                        
		/// </summary>
		[SMBFieldName("subttl")]
		[SMBFieldDescription("Subtotal")]
		public decimal subttl;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// Total                           
		/// </summary>
		[SMBFieldName("pchttl")]
		[SMBFieldDescription("Total")]
		public decimal pchttl;

		/// <summary>
		/// Balance                         
		/// </summary>
		[SMBFieldName("pchbal")]
		[SMBFieldDescription("Balance")]
		public decimal pchbal;

		/// <summary>
		/// Entered                         
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Task                            
		/// </summary>
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task")]
		public decimal tsknum;

		/// <summary>
		/// Issued Date                     
		/// </summary>
		[SMBFieldName("issdat")]
		[SMBFieldDescription("Issued Date")]
		public DateTime issdat;

		/// <summary>
		/// Issued Batch#                   
		/// </summary>
		[SMBFieldName("issbch")]
		[SMBFieldDescription("Issued Batch#")]
		public long issbch;

	}
}