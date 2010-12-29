using System;

namespace SMB.Tables {
	public class ptotkf : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Material Overhead               
		/// </summary>
		[SMBFieldName("matovh")]
		[SMBFieldDescription("Material Overhead")]
		public decimal matovh;

		/// <summary>
		/// Material Profit                 
		/// </summary>
		[SMBFieldName("matpft")]
		[SMBFieldDescription("Material Profit")]
		public decimal matpft;

		/// <summary>
		/// Labor Overhead                  
		/// </summary>
		[SMBFieldName("labovh")]
		[SMBFieldDescription("Labor Overhead")]
		public decimal labovh;

		/// <summary>
		/// Labor Profit                    
		/// </summary>
		[SMBFieldName("labpft")]
		[SMBFieldDescription("Labor Profit")]
		public decimal labpft;

		/// <summary>
		/// Equipment Overhead              
		/// </summary>
		[SMBFieldName("eqpovh")]
		[SMBFieldDescription("Equipment Overhead")]
		public decimal eqpovh;

		/// <summary>
		/// Equipment Profit                
		/// </summary>
		[SMBFieldName("eqppft")]
		[SMBFieldDescription("Equipment Profit")]
		public decimal eqppft;

		/// <summary>
		/// Subcontract Overhead            
		/// </summary>
		[SMBFieldName("subovh")]
		[SMBFieldDescription("Subcontract Overhead")]
		public decimal subovh;

		/// <summary>
		/// Subcontract Profit              
		/// </summary>
		[SMBFieldName("subpft")]
		[SMBFieldDescription("Subcontract Profit")]
		public decimal subpft;

		/// <summary>
		/// Other Overhead                  
		/// </summary>
		[SMBFieldName("otrovh")]
		[SMBFieldDescription("Other Overhead")]
		public decimal otrovh;

		/// <summary>
		/// Other Profit                    
		/// </summary>
		[SMBFieldName("otrpft")]
		[SMBFieldDescription("Other Profit")]
		public decimal otrpft;

		/// <summary>
		/// User Def Type 6  Overhead       
		/// </summary>
		[SMBFieldName("cs6ovh")]
		[SMBFieldDescription("User Def Type 6  Overhead")]
		public decimal cs6ovh;

		/// <summary>
		/// User Def Type 6  Profit         
		/// </summary>
		[SMBFieldName("cs6pft")]
		[SMBFieldDescription("User Def Type 6  Profit")]
		public decimal cs6pft;

		/// <summary>
		/// User Def Type 7  Overhead       
		/// </summary>
		[SMBFieldName("cs7ovh")]
		[SMBFieldDescription("User Def Type 7  Overhead")]
		public decimal cs7ovh;

		/// <summary>
		/// User Def Type 7  Profit         
		/// </summary>
		[SMBFieldName("cs7pft")]
		[SMBFieldDescription("User Def Type 7  Profit")]
		public decimal cs7pft;

		/// <summary>
		/// User Def Type 8  Overhead       
		/// </summary>
		[SMBFieldName("cs8ovh")]
		[SMBFieldDescription("User Def Type 8  Overhead")]
		public decimal cs8ovh;

		/// <summary>
		/// User Def Type 8  Profit         
		/// </summary>
		[SMBFieldName("cs8pft")]
		[SMBFieldDescription("User Def Type 8  Profit")]
		public decimal cs8pft;

		/// <summary>
		/// User Def Type 9  Overhead       
		/// </summary>
		[SMBFieldName("cs9ovh")]
		[SMBFieldDescription("User Def Type 9  Overhead")]
		public decimal cs9ovh;

		/// <summary>
		/// User Def Type 9  Profit         
		/// </summary>
		[SMBFieldName("cs9pft")]
		[SMBFieldDescription("User Def Type 9  Profit")]
		public decimal cs9pft;

		/// <summary>
		/// Last Edit                       
		/// </summary>
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Last Edit")]
		public DateTime edtdte;

		/// <summary>
		/// User                            
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Part Price                      
		/// </summary>
		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Part Price")]
		public long prtprc;

		/// <summary>
		/// Payroll Subject Percent         
		/// </summary>
		[SMBFieldName("paysbj")]
		[SMBFieldDescription("Payroll Subject Percent")]
		public decimal paysbj;

		/// <summary>
		/// Subcontract Subject Percent     
		/// </summary>
		[SMBFieldName("subsbj")]
		[SMBFieldDescription("Subcontract Subject Percent")]
		public decimal subsbj;

		/// <summary>
		/// Bid Subject Percent             
		/// </summary>
		[SMBFieldName("bidsbj")]
		[SMBFieldDescription("Bid Subject Percent")]
		public decimal bidsbj;

		/// <summary>
		/// Tax Subject Percent             
		/// </summary>
		[SMBFieldName("taxsbj")]
		[SMBFieldDescription("Tax Subject Percent")]
		public decimal taxsbj;

		/// <summary>
		/// Bonding Limit 1                 
		/// </summary>
		[SMBFieldName("bndlt1")]
		[SMBFieldDescription("Bonding Limit 1")]
		public long bndlt1;

		/// <summary>
		/// Bonding Limit 2                 
		/// </summary>
		[SMBFieldName("bndlt2")]
		[SMBFieldDescription("Bonding Limit 2")]
		public long bndlt2;

		/// <summary>
		/// Bonding Limit 3                 
		/// </summary>
		[SMBFieldName("bndlt3")]
		[SMBFieldDescription("Bonding Limit 3")]
		public long bndlt3;

		/// <summary>
		/// Payroll Rate                    
		/// </summary>
		[SMBFieldName("payrte")]
		[SMBFieldDescription("Payroll Rate")]
		public decimal payrte;

		/// <summary>
		/// Subcontract Rate                
		/// </summary>
		[SMBFieldName("subrte")]
		[SMBFieldDescription("Subcontract Rate")]
		public decimal subrte;

		/// <summary>
		/// Bid Rate                        
		/// </summary>
		[SMBFieldName("bidrte")]
		[SMBFieldDescription("Bid Rate")]
		public decimal bidrte;

		/// <summary>
		/// Tax Rate                        
		/// </summary>
		[SMBFieldName("taxrte")]
		[SMBFieldDescription("Tax Rate")]
		public decimal taxrte;

		/// <summary>
		/// Limit 1 Rate                    
		/// </summary>
		[SMBFieldName("lt1rte")]
		[SMBFieldDescription("Limit 1 Rate")]
		public decimal lt1rte;

		/// <summary>
		/// Limit 2 Rate                    
		/// </summary>
		[SMBFieldName("lt2rte")]
		[SMBFieldDescription("Limit 2 Rate")]
		public decimal lt2rte;

		/// <summary>
		/// Limit 3 Rate                    
		/// </summary>
		[SMBFieldName("lt3rte")]
		[SMBFieldDescription("Limit 3 Rate")]
		public decimal lt3rte;

		/// <summary>
		/// Payroll Summary Amount          
		/// </summary>
		[SMBFieldName("payamt")]
		[SMBFieldDescription("Payroll Summary Amount")]
		public decimal payamt;

		/// <summary>
		/// Subcontract Summary Amount      
		/// </summary>
		[SMBFieldName("subamt")]
		[SMBFieldDescription("Subcontract Summary Amount")]
		public decimal subamt;

		/// <summary>
		/// Bid Summary Amount              
		/// </summary>
		[SMBFieldName("bidamt")]
		[SMBFieldDescription("Bid Summary Amount")]
		public decimal bidamt;

		/// <summary>
		/// Tax Summary Amount              
		/// </summary>
		[SMBFieldName("taxamt")]
		[SMBFieldDescription("Tax Summary Amount")]
		public decimal taxamt;

		/// <summary>
		/// Limit 1 Summary Amount          
		/// </summary>
		[SMBFieldName("lt1amt")]
		[SMBFieldDescription("Limit 1 Summary Amount")]
		public decimal lt1amt;

		/// <summary>
		/// Limit 2 Summary Amount          
		/// </summary>
		[SMBFieldName("lt2amt")]
		[SMBFieldDescription("Limit 2 Summary Amount")]
		public decimal lt2amt;

		/// <summary>
		/// Limit 3 Summary Amount          
		/// </summary>
		[SMBFieldName("lt3amt")]
		[SMBFieldDescription("Limit 3 Summary Amount")]
		public decimal lt3amt;

		/// <summary>
		/// Insurance Cost Type             
		/// </summary>
		[SMBFieldName("instyp")]
		[SMBFieldDescription("Insurance Cost Type")]
		public long instyp;

		/// <summary>
		/// Insurance Cost Code             
		/// </summary>
		[SMBFieldName("inscde")]
		[SMBFieldDescription("Insurance Cost Code")]
		public decimal inscde;

		/// <summary>
		/// Tax Cost Type                   
		/// </summary>
		[SMBFieldName("taxtyp")]
		[SMBFieldDescription("Tax Cost Type")]
		public long taxtyp;

		/// <summary>
		/// Tax Cost Code                   
		/// </summary>
		[SMBFieldName("taxcde")]
		[SMBFieldDescription("Tax Cost Code")]
		public decimal taxcde;

		/// <summary>
		/// Bonding Cost Type               
		/// </summary>
		[SMBFieldName("bndtyp")]
		[SMBFieldDescription("Bonding Cost Type")]
		public long bndtyp;

		/// <summary>
		/// Bonding Cost Code               
		/// </summary>
		[SMBFieldName("bndcde")]
		[SMBFieldDescription("Bonding Cost Code")]
		public decimal bndcde;

		/// <summary>
		/// Insurance Include in Budget     
		/// </summary>
		[SMBFieldName("insinc")]
		[SMBFieldDescription("Insurance Include in Budget")]
		public long insinc;

		/// <summary>
		/// Tax Include in Budget           
		/// </summary>
		[SMBFieldName("taxinc")]
		[SMBFieldDescription("Tax Include in Budget")]
		public long taxinc;

		/// <summary>
		/// Bonding Include in Budget       
		/// </summary>
		[SMBFieldName("bndinc")]
		[SMBFieldDescription("Bonding Include in Budget")]
		public long bndinc;

		/// <summary>
		/// Insurance Bid Item              
		/// </summary>
		[SMBFieldName("insitm")]
		[SMBFieldDescription("Insurance Bid Item")]
		public long insitm;

		/// <summary>
		/// Insurance Phase                 
		/// </summary>
		[SMBFieldName("insphs")]
		[SMBFieldDescription("Insurance Phase")]
		public long insphs;

		/// <summary>
		/// Tax Bid Item                    
		/// </summary>
		[SMBFieldName("taxitm")]
		[SMBFieldDescription("Tax Bid Item")]
		public long taxitm;

		/// <summary>
		/// Tax Phase                       
		/// </summary>
		[SMBFieldName("taxphs")]
		[SMBFieldDescription("Tax Phase")]
		public long taxphs;

		/// <summary>
		/// Bonding Bid Item                
		/// </summary>
		[SMBFieldName("bnditm")]
		[SMBFieldDescription("Bonding Bid Item")]
		public long bnditm;

		/// <summary>
		/// Bonding Phase                   
		/// </summary>
		[SMBFieldName("bndphs")]
		[SMBFieldDescription("Bonding Phase")]
		public long bndphs;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Current Editor                  
		/// </summary>
		[SMBFieldName("edtnme")]
		[SMBFieldDescription("Current Editor")]
		public string edtnme;

		/// <summary>
		/// Margin/Markup Option            
		/// </summary>
		[SMBFieldName("mrgmrk")]
		[SMBFieldDescription("Margin/Markup Option")]
		public long mrgmrk;

		/// <summary>
		/// Gross Margin Override           
		/// </summary>
		[SMBFieldName("mrgovr")]
		[SMBFieldDescription("Gross Margin Override")]
		public decimal mrgovr;

		/// <summary>
		/// Markup %                        
		/// </summary>
		[SMBFieldName("mrkrte")]
		[SMBFieldDescription("Markup %")]
		public decimal mrkrte;

		/// <summary>
		/// Dollar Markup                   
		/// </summary>
		[SMBFieldName("mrkdlr")]
		[SMBFieldDescription("Dollar Markup")]
		public decimal mrkdlr;

		/// <summary>
		/// Bid Amount                      
		/// </summary>
		[SMBFieldName("bidovr")]
		[SMBFieldDescription("Bid Amount")]
		public decimal bidovr;

		/// <summary>
		/// Lock Bid Amount                 
		/// </summary>
		[SMBFieldName("lckbid")]
		[SMBFieldDescription("Lock Bid Amount")]
		public long lckbid;

		/// <summary>
		/// Work Order Exports              
		/// </summary>
		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Work Order Exports")]
		public string wrkord;

	}
}