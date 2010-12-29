using System;

namespace SMB.Tables {
	public class subcon : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Subcontract#                    
		/// </summary>
		[SMBFieldName("ctcnum")]
		[SMBFieldDescription("Subcontract#")]
		public string ctcnum;

		/// <summary>
		/// Division                        
		/// </summary>
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

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
		/// Tax District                    
		/// </summary>
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

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
		/// Type                            
		/// </summary>
		[SMBFieldName("contyp")]
		[SMBFieldDescription("Type")]
		public long contyp;

		/// <summary>
		/// Retention                       
		/// </summary>
		[SMBFieldName("rtnrte")]
		[SMBFieldDescription("Retention")]
		public decimal rtnrte;

		/// <summary>
		/// Bid Bond                        
		/// </summary>
		[SMBFieldName("pmtbnd")]
		[SMBFieldDescription("Bid Bond")]
		public decimal pmtbnd;

		/// <summary>
		/// Perf Bond                       
		/// </summary>
		[SMBFieldName("prfbnd")]
		[SMBFieldDescription("Perf Bond")]
		public decimal prfbnd;

		/// <summary>
		/// Approved                        
		/// </summary>
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Contract Date                   
		/// </summary>
		[SMBFieldName("condte")]
		[SMBFieldDescription("Contract Date")]
		public DateTime condte;

		/// <summary>
		/// Original Start                  
		/// </summary>
		[SMBFieldName("orgstr")]
		[SMBFieldDescription("Original Start")]
		public DateTime orgstr;

		/// <summary>
		/// Original Finish                 
		/// </summary>
		[SMBFieldName("orgfin")]
		[SMBFieldDescription("Original Finish")]
		public DateTime orgfin;

		/// <summary>
		/// Actual Start                    
		/// </summary>
		[SMBFieldName("strdte")]
		[SMBFieldDescription("Actual Start")]
		public DateTime strdte;

		/// <summary>
		/// Subst Complete                  
		/// </summary>
		[SMBFieldName("subcmp")]
		[SMBFieldDescription("Subst Complete")]
		public DateTime subcmp;

		/// <summary>
		/// Finish Date                     
		/// </summary>
		[SMBFieldName("findte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime findte;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Hold Pay                        
		/// </summary>
		[SMBFieldName("paysts")]
		[SMBFieldDescription("Hold Pay")]
		public long paysts;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

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
		/// Original Subcontract Total      
		/// </summary>
		[SMBFieldName("cntttl")]
		[SMBFieldDescription("Original Subcontract Total")]
		public decimal cntttl;

		/// <summary>
		/// Changes Total                   
		/// </summary>
		[SMBFieldName("chgttl")]
		[SMBFieldDescription("Changes Total")]
		public decimal chgttl;

		/// <summary>
		/// New Subcontract Total           
		/// </summary>
		[SMBFieldName("ctcttl")]
		[SMBFieldDescription("New Subcontract Total")]
		public decimal ctcttl;

		/// <summary>
		/// Sales Tax Total                 
		/// </summary>
		[SMBFieldName("taxttl")]
		[SMBFieldDescription("Sales Tax Total")]
		public decimal taxttl;

		/// <summary>
		/// Invoiced Total                  
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoiced Total")]
		public decimal invttl;

		/// <summary>
		/// Remaining Total                 
		/// </summary>
		[SMBFieldName("balttl")]
		[SMBFieldDescription("Remaining Total")]
		public decimal balttl;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}