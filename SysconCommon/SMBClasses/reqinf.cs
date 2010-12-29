using System;

namespace SMB.Tables {
	public class reqinf : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Client                          
		/// </summary>
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Attention                       
		/// </summary>
		[SMBFieldName("attion")]
		[SMBFieldDescription("Attention")]
		public string attion;

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
		/// Division                        
		/// </summary>
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("subdte")]
		[SMBFieldDescription("Date")]
		public DateTime subdte;

		/// <summary>
		/// RFI #                           
		/// </summary>
		[SMBFieldName("rfinum")]
		[SMBFieldDescription("RFI #")]
		public string rfinum;

		/// <summary>
		/// RFI Type                        
		/// </summary>
		[SMBFieldName("rfityp")]
		[SMBFieldDescription("RFI Type")]
		public long rfityp;

		/// <summary>
		/// Required                        
		/// </summary>
		[SMBFieldName("reqdte")]
		[SMBFieldDescription("Required")]
		public DateTime reqdte;

		/// <summary>
		/// Request by                      
		/// </summary>
		[SMBFieldName("reqsby")]
		[SMBFieldDescription("Request by")]
		public long reqsby;

		/// <summary>
		/// Answered by                     
		/// </summary>
		[SMBFieldName("ansrby")]
		[SMBFieldDescription("Answered by")]
		public string ansrby;

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
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Returned                        
		/// </summary>
		[SMBFieldName("retdte")]
		[SMBFieldDescription("Returned")]
		public DateTime retdte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Requested                       
		/// </summary>
		[SMBFieldName("reqinf")]
		[SMBFieldDescription("Requested")]
		public string _reqinf;

		/// <summary>
		/// Supplied                        
		/// </summary>
		[SMBFieldName("retinf")]
		[SMBFieldDescription("Supplied")]
		public string retinf;

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
		/// Schedule Change                 
		/// </summary>
		[SMBFieldName("possch")]
		[SMBFieldDescription("Schedule Change")]
		public long possch;

		/// <summary>
		/// Change Order                    
		/// </summary>
		[SMBFieldName("poschg")]
		[SMBFieldDescription("Change Order")]
		public long poschg;

		/// <summary>
		/// Plan Change                     
		/// </summary>
		[SMBFieldName("plnchg")]
		[SMBFieldDescription("Plan Change")]
		public long plnchg;

		/// <summary>
		/// User Def Check 1                
		/// </summary>
		[SMBFieldName("usrck1")]
		[SMBFieldDescription("User Def Check 1")]
		public long usrck1;

		/// <summary>
		/// User Def Check 2                
		/// </summary>
		[SMBFieldName("usrck2")]
		[SMBFieldDescription("User Def Check 2")]
		public long usrck2;

		/// <summary>
		/// Address1                        
		/// </summary>
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address1")]
		public string addrs1;

		/// <summary>
		/// Address2                        
		/// </summary>
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
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
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}