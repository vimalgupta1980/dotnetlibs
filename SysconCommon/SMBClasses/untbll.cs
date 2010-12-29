using System;

namespace SMB.Tables {
	public class untbll : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

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
		/// Architect                       
		/// </summary>
		[SMBFieldName("achnum")]
		[SMBFieldDescription("Architect")]
		public long achnum;

		/// <summary>
		/// Architect's Job#                
		/// </summary>
		[SMBFieldName("achjob")]
		[SMBFieldDescription("Architect's Job#")]
		public string achjob;

		/// <summary>
		/// Application#                    
		/// </summary>
		[SMBFieldName("appnum")]
		[SMBFieldDescription("Application#")]
		public long appnum;

		/// <summary>
		/// Billing Date                    
		/// </summary>
		[SMBFieldName("period")]
		[SMBFieldDescription("Billing Date")]
		public DateTime period;

		/// <summary>
		/// Submitted                       
		/// </summary>
		[SMBFieldName("subdte")]
		[SMBFieldDescription("Submitted")]
		public DateTime subdte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Retention Rate                  
		/// </summary>
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention Rate")]
		public decimal retain;

		/// <summary>
		/// Net Prev Billings               
		/// </summary>
		[SMBFieldName("prvbil")]
		[SMBFieldDescription("Net Prev Billings")]
		public decimal prvbil;

		/// <summary>
		/// Prev Retention                  
		/// </summary>
		[SMBFieldName("prvret")]
		[SMBFieldDescription("Prev Retention")]
		public decimal prvret;

		/// <summary>
		/// Income Account                  
		/// </summary>
		[SMBFieldName("incact")]
		[SMBFieldDescription("Income Account")]
		public long incact;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[SMBFieldName("incsub")]
		[SMBFieldDescription("Subaccount")]
		public long incsub;

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
		/// Scheduled                       
		/// </summary>
		[SMBFieldName("schttl")]
		[SMBFieldDescription("Scheduled")]
		public decimal schttl;

		/// <summary>
		/// Changes                         
		/// </summary>
		[SMBFieldName("chgttl")]
		[SMBFieldDescription("Changes")]
		public decimal chgttl;

		/// <summary>
		/// Contract                        
		/// </summary>
		[SMBFieldName("conttl")]
		[SMBFieldDescription("Contract")]
		public decimal conttl;

		/// <summary>
		/// Previous                        
		/// </summary>
		[SMBFieldName("prvttl")]
		[SMBFieldDescription("Previous")]
		public decimal prvttl;

		/// <summary>
		/// Current                         
		/// </summary>
		[SMBFieldName("curttl")]
		[SMBFieldDescription("Current")]
		public decimal curttl;

		/// <summary>
		/// Total                           
		/// </summary>
		[SMBFieldName("cmpttl")]
		[SMBFieldDescription("Total")]
		public decimal cmpttl;

		/// <summary>
		/// Balance                         
		/// </summary>
		[SMBFieldName("balttl")]
		[SMBFieldDescription("Balance")]
		public decimal balttl;

		/// <summary>
		/// Retention                       
		/// </summary>
		[SMBFieldName("retttl")]
		[SMBFieldDescription("Retention")]
		public decimal retttl;

		/// <summary>
		/// Total Earned                    
		/// </summary>
		[SMBFieldName("ttlern")]
		[SMBFieldDescription("Total Earned")]
		public decimal ttlern;

		/// <summary>
		/// Current Due                     
		/// </summary>
		[SMBFieldName("crtdue")]
		[SMBFieldDescription("Current Due")]
		public decimal crtdue;

		/// <summary>
		/// Contract Balance                
		/// </summary>
		[SMBFieldName("balcon")]
		[SMBFieldDescription("Contract Balance")]
		public decimal balcon;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Earned Less Retention           
		/// </summary>
		[SMBFieldName("erlsrt")]
		[SMBFieldDescription("Earned Less Retention")]
		public decimal erlsrt;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// Taxable                         
		/// </summary>
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable")]
		public decimal taxabl;

		/// <summary>
		/// Non-Taxable                     
		/// </summary>
		[SMBFieldName("nontax")]
		[SMBFieldDescription("Non-Taxable")]
		public decimal nontax;

		/// <summary>
		/// Invoice Total                   
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public decimal lgrrec;

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

		/// <summary>
		/// Combine Phases                  
		/// </summary>
		[SMBFieldName("cmbphs")]
		[SMBFieldDescription("Combine Phases")]
		public long cmbphs;

	}
}