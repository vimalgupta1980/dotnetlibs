using System;

namespace SMB.Tables {
	public class aiafrm : smbtable {
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
		/// Primary Ret. Rate               
		/// </summary>
		[SMBFieldName("retain")]
		[SMBFieldDescription("Primary Ret. Rate")]
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
		/// Max Retention                   
		/// </summary>
		[SMBFieldName("maxret")]
		[SMBFieldDescription("Max Retention")]
		public decimal maxret;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

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
		/// Total Scheduled                 
		/// </summary>
		[SMBFieldName("schttl")]
		[SMBFieldDescription("Total Scheduled")]
		public decimal schttl;

		/// <summary>
		/// Total Changes                   
		/// </summary>
		[SMBFieldName("chgttl")]
		[SMBFieldDescription("Total Changes")]
		public decimal chgttl;

		/// <summary>
		/// Total Contract                  
		/// </summary>
		[SMBFieldName("conttl")]
		[SMBFieldDescription("Total Contract")]
		public decimal conttl;

		/// <summary>
		/// Total Previous                  
		/// </summary>
		[SMBFieldName("prvttl")]
		[SMBFieldDescription("Total Previous")]
		public decimal prvttl;

		/// <summary>
		/// Total Current                   
		/// </summary>
		[SMBFieldName("curttl")]
		[SMBFieldDescription("Total Current")]
		public decimal curttl;

		/// <summary>
		/// Total Stored                    
		/// </summary>
		[SMBFieldName("strttl")]
		[SMBFieldDescription("Total Stored")]
		public decimal strttl;

		/// <summary>
		/// Total Comp                      
		/// </summary>
		[SMBFieldName("cmpttl")]
		[SMBFieldDescription("Total Comp")]
		public decimal cmpttl;

		/// <summary>
		/// % Complete                      
		/// </summary>
		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Complete")]
		public decimal pctcmp;

		/// <summary>
		/// Total Balance                   
		/// </summary>
		[SMBFieldName("balttl")]
		[SMBFieldDescription("Total Balance")]
		public decimal balttl;

		/// <summary>
		/// Total Retention                 
		/// </summary>
		[SMBFieldName("retttl")]
		[SMBFieldDescription("Total Retention")]
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
		/// Contract Bal                    
		/// </summary>
		[SMBFieldName("balcon")]
		[SMBFieldDescription("Contract Bal")]
		public decimal balcon;

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
		/// Material Ret. Rate              
		/// </summary>
		[SMBFieldName("matret")]
		[SMBFieldDescription("Material Ret. Rate")]
		public decimal matret;

		/// <summary>
		/// User Def 1                      
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def 1")]
		public string usrdf1;

		/// <summary>
		/// User Def 2                      
		/// </summary>
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def 2")]
		public string usrdf2;

		/// <summary>
		/// Total Taxable                   
		/// </summary>
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Total Taxable")]
		public decimal taxabl;

		/// <summary>
		/// Total Non-Tax                   
		/// </summary>
		[SMBFieldName("nontax")]
		[SMBFieldDescription("Total Non-Tax")]
		public decimal nontax;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// Invoice Amount                  
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Amount")]
		public decimal invttl;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Billing Basis                   
		/// </summary>
		[SMBFieldName("bllbas")]
		[SMBFieldDescription("Billing Basis")]
		public long bllbas;

		/// <summary>
		/// Earned Less Retention           
		/// </summary>
		[SMBFieldName("erlsrt")]
		[SMBFieldDescription("Earned Less Retention")]
		public decimal erlsrt;

		/// <summary>
		/// Balance to Finish               
		/// </summary>
		[SMBFieldName("balfin")]
		[SMBFieldDescription("Balance to Finish")]
		public decimal balfin;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Secondary Ret. Rate             
		/// </summary>
		[SMBFieldName("secrte")]
		[SMBFieldDescription("Secondary Ret. Rate")]
		public decimal secrte;

		/// <summary>
		/// Primary Retention               
		/// </summary>
		[SMBFieldName("prmret")]
		[SMBFieldDescription("Primary Retention")]
		public decimal prmret;

		/// <summary>
		/// Retention Total                 
		/// </summary>
		[SMBFieldName("ttlret")]
		[SMBFieldDescription("Retention Total")]
		public decimal ttlret;

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