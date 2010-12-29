using System;

namespace SMB.Tables {
	public class rccpay : smbtable {
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
		/// Next Date                       
		/// </summary>
		[SMBFieldName("nxtdte")]
		[SMBFieldDescription("Next Date")]
		public DateTime nxtdte;

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
		/// Invoice Total                   
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		/// <summary>
		/// Invoice Net                     
		/// </summary>
		[SMBFieldName("invnet")]
		[SMBFieldDescription("Invoice Net")]
		public decimal invnet;

		/// <summary>
		/// Edited Date                     
		/// </summary>
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edited Date")]
		public DateTime edtdte;

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
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}