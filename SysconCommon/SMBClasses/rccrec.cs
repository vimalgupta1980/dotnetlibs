using System;

namespace SMB.Tables {
	public class rccrec : smbtable {
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
		/// Total                           
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Total")]
		public decimal invttl;

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
		/// Non-Tax                         
		/// </summary>
		[SMBFieldName("nontax")]
		[SMBFieldDescription("Non-Tax")]
		public decimal nontax;

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