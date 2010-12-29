using System;

namespace SMB.Tables {
	public class prmchg : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Change#                         
		/// </summary>
		[SMBFieldName("chgnum")]
		[SMBFieldDescription("Change#")]
		public string chgnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("chgdte")]
		[SMBFieldDescription("Date")]
		public DateTime chgdte;

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
		/// Reason                          
		/// </summary>
		[SMBFieldName("reason")]
		[SMBFieldDescription("Reason")]
		public string reason;

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
		/// Client PO#                      
		/// </summary>
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

		/// <summary>
		/// Submitted                       
		/// </summary>
		[SMBFieldName("subdte")]
		[SMBFieldDescription("Submitted")]
		public DateTime subdte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[SMBFieldName("aprdte")]
		[SMBFieldDescription("Approved")]
		public DateTime aprdte;

		/// <summary>
		/// Invoiced                        
		/// </summary>
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Invoiced")]
		public DateTime invdte;

		/// <summary>
		/// Delay Requested                 
		/// </summary>
		[SMBFieldName("delreq")]
		[SMBFieldDescription("Delay Requested")]
		public long delreq;

		/// <summary>
		/// Delay Approved                  
		/// </summary>
		[SMBFieldName("dysdly")]
		[SMBFieldDescription("Delay Approved")]
		public long dysdly;

		/// <summary>
		/// CO Type                         
		/// </summary>
		[SMBFieldName("chgtyp")]
		[SMBFieldDescription("CO Type")]
		public long chgtyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Submit to                       
		/// </summary>
		[SMBFieldName("submto")]
		[SMBFieldDescription("Submit to")]
		public string submto;

		/// <summary>
		/// Submit by                       
		/// </summary>
		[SMBFieldName("submby")]
		[SMBFieldDescription("Submit by")]
		public long submby;

		/// <summary>
		/// Requested Amount                
		/// </summary>
		[SMBFieldName("reqamt")]
		[SMBFieldDescription("Requested Amount")]
		public decimal reqamt;

		/// <summary>
		/// Approved Amount                 
		/// </summary>
		[SMBFieldName("appamt")]
		[SMBFieldDescription("Approved Amount")]
		public decimal appamt;

		/// <summary>
		/// Cost Amount                     
		/// </summary>
		[SMBFieldName("cstamt")]
		[SMBFieldDescription("Cost Amount")]
		public decimal cstamt;

		/// <summary>
		/// Overhead Amount                 
		/// </summary>
		[SMBFieldName("ovhamt")]
		[SMBFieldDescription("Overhead Amount")]
		public decimal ovhamt;

		/// <summary>
		/// Profit Amount                   
		/// </summary>
		[SMBFieldName("pftamt")]
		[SMBFieldDescription("Profit Amount")]
		public decimal pftamt;

		/// <summary>
		/// Req. Profit Amount              
		/// </summary>
		[SMBFieldName("reqpft")]
		[SMBFieldDescription("Req. Profit Amount")]
		public decimal reqpft;

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
		/// Scope                           
		/// </summary>
		[SMBFieldName("chgscp")]
		[SMBFieldDescription("Scope")]
		public string chgscp;

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
		/// Period                          
		/// </summary>
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Gross Margin                    
		/// </summary>
		[SMBFieldName("mrgamt")]
		[SMBFieldDescription("Gross Margin")]
		public decimal mrgamt;

		/// <summary>
		/// Req. Gross Margin               
		/// </summary>
		[SMBFieldName("reqmrg")]
		[SMBFieldDescription("Req. Gross Margin")]
		public decimal reqmrg;

		/// <summary>
		/// Estimated Total                 
		/// </summary>
		[SMBFieldName("estamt")]
		[SMBFieldDescription("Estimated Total")]
		public decimal estamt;

		/// <summary>
		/// Estimated O/H                   
		/// </summary>
		[SMBFieldName("estovh")]
		[SMBFieldDescription("Estimated O/H")]
		public decimal estovh;

		/// <summary>
		/// Upgrade                         
		/// </summary>
		[SMBFieldName("upgrde")]
		[SMBFieldDescription("Upgrade")]
		public long upgrde;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}