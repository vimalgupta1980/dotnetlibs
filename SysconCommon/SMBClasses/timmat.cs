using System;

namespace SMB.Tables {
	public class timmat : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Wage Rate                       
		/// </summary>
		[SMBFieldName("emptbl")]
		[SMBFieldDescription("Wage Rate")]
		public long emptbl;

		/// <summary>
		/// Equipment Rate                  
		/// </summary>
		[SMBFieldName("eqptbl")]
		[SMBFieldDescription("Equipment Rate")]
		public long eqptbl;

		/// <summary>
		/// Material Hidden                 
		/// </summary>
		[SMBFieldName("mtrhdn")]
		[SMBFieldDescription("Material Hidden")]
		public decimal mtrhdn;

		/// <summary>
		/// Material Shown                  
		/// </summary>
		[SMBFieldName("mtrshw")]
		[SMBFieldDescription("Material Shown")]
		public decimal mtrshw;

		/// <summary>
		/// Material Overhead               
		/// </summary>
		[SMBFieldName("mtrovh")]
		[SMBFieldDescription("Material Overhead")]
		public decimal mtrovh;

		/// <summary>
		/// Material Profit                 
		/// </summary>
		[SMBFieldName("mtrpft")]
		[SMBFieldDescription("Material Profit")]
		public decimal mtrpft;

		/// <summary>
		/// Labor Hidden                    
		/// </summary>
		[SMBFieldName("labhdn")]
		[SMBFieldDescription("Labor Hidden")]
		public decimal labhdn;

		/// <summary>
		/// Labor Shown                     
		/// </summary>
		[SMBFieldName("labshw")]
		[SMBFieldDescription("Labor Shown")]
		public decimal labshw;

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
		/// Equipment Hidden                
		/// </summary>
		[SMBFieldName("eqphdn")]
		[SMBFieldDescription("Equipment Hidden")]
		public decimal eqphdn;

		/// <summary>
		/// Equipment Shown                 
		/// </summary>
		[SMBFieldName("eqpshw")]
		[SMBFieldDescription("Equipment Shown")]
		public decimal eqpshw;

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
		/// Subcontract Hidden              
		/// </summary>
		[SMBFieldName("subhdn")]
		[SMBFieldDescription("Subcontract Hidden")]
		public decimal subhdn;

		/// <summary>
		/// Subcontract Shown               
		/// </summary>
		[SMBFieldName("subshw")]
		[SMBFieldDescription("Subcontract Shown")]
		public decimal subshw;

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
		/// Other Hidden                    
		/// </summary>
		[SMBFieldName("otrhdn")]
		[SMBFieldDescription("Other Hidden")]
		public decimal otrhdn;

		/// <summary>
		/// Other Shown                     
		/// </summary>
		[SMBFieldName("otrshw")]
		[SMBFieldDescription("Other Shown")]
		public decimal otrshw;

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
		/// User Def Type 6                 
		/// </summary>
		[SMBFieldName("cs6hdn")]
		[SMBFieldDescription("User Def Type 6")]
		public decimal cs6hdn;

		/// <summary>
		/// User Def Type 6 Shown           
		/// </summary>
		[SMBFieldName("cs6shw")]
		[SMBFieldDescription("User Def Type 6 Shown")]
		public decimal cs6shw;

		/// <summary>
		/// User Def Type 6 Overhead        
		/// </summary>
		[SMBFieldName("cs6ovh")]
		[SMBFieldDescription("User Def Type 6 Overhead")]
		public decimal cs6ovh;

		/// <summary>
		/// User Def Type 6 Profit          
		/// </summary>
		[SMBFieldName("cs6pft")]
		[SMBFieldDescription("User Def Type 6 Profit")]
		public decimal cs6pft;

		/// <summary>
		/// User Def Type 7                 
		/// </summary>
		[SMBFieldName("cs7hdn")]
		[SMBFieldDescription("User Def Type 7")]
		public decimal cs7hdn;

		/// <summary>
		/// User Def Type 7 Shown           
		/// </summary>
		[SMBFieldName("cs7shw")]
		[SMBFieldDescription("User Def Type 7 Shown")]
		public decimal cs7shw;

		/// <summary>
		/// User Def Type 7 Overhead        
		/// </summary>
		[SMBFieldName("cs7ovh")]
		[SMBFieldDescription("User Def Type 7 Overhead")]
		public decimal cs7ovh;

		/// <summary>
		/// User Def Type 7 Profit          
		/// </summary>
		[SMBFieldName("cs7pft")]
		[SMBFieldDescription("User Def Type 7 Profit")]
		public decimal cs7pft;

		/// <summary>
		/// User Def Type 8                 
		/// </summary>
		[SMBFieldName("cs8hdn")]
		[SMBFieldDescription("User Def Type 8")]
		public decimal cs8hdn;

		/// <summary>
		/// User Def Type 8 Shown           
		/// </summary>
		[SMBFieldName("cs8shw")]
		[SMBFieldDescription("User Def Type 8 Shown")]
		public decimal cs8shw;

		/// <summary>
		/// User Def Type 8 Overhead        
		/// </summary>
		[SMBFieldName("cs8ovh")]
		[SMBFieldDescription("User Def Type 8 Overhead")]
		public decimal cs8ovh;

		/// <summary>
		/// User Def Type 8 Profit          
		/// </summary>
		[SMBFieldName("cs8pft")]
		[SMBFieldDescription("User Def Type 8 Profit")]
		public decimal cs8pft;

		/// <summary>
		/// User Def Type 9                 
		/// </summary>
		[SMBFieldName("cs9hdn")]
		[SMBFieldDescription("User Def Type 9")]
		public decimal cs9hdn;

		/// <summary>
		/// User Def Type 9 Shown           
		/// </summary>
		[SMBFieldName("cs9shw")]
		[SMBFieldDescription("User Def Type 9 Shown")]
		public decimal cs9shw;

		/// <summary>
		/// User Def Type 9 Overhead        
		/// </summary>
		[SMBFieldName("cs9ovh")]
		[SMBFieldDescription("User Def Type 9 Overhead")]
		public decimal cs9ovh;

		/// <summary>
		/// User Def Type 9 Profit          
		/// </summary>
		[SMBFieldName("cs9pft")]
		[SMBFieldDescription("User Def Type 9 Profit")]
		public decimal cs9pft;

		/// <summary>
		/// Calculated                      
		/// </summary>
		[SMBFieldName("clcsts")]
		[SMBFieldDescription("Calculated")]
		public long clcsts;

		/// <summary>
		/// Invoice Date                    
		/// </summary>
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Invoice Date")]
		public DateTime invdte;

		/// <summary>
		/// Invoice Total                   
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		/// <summary>
		/// Taxable Amount                  
		/// </summary>
		[SMBFieldName("subjct")]
		[SMBFieldDescription("Taxable Amount")]
		public decimal subjct;

		/// <summary>
		/// Sales Tax Amount                
		/// </summary>
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax Amount")]
		public decimal slstax;

		/// <summary>
		/// Tax Details                     
		/// </summary>
		[SMBFieldName("taxdtl")]
		[SMBFieldDescription("Tax Details")]
		public string taxdtl;

		/// <summary>
		/// Job Phase                       
		/// </summary>
		[SMBFieldName("jobphs")]
		[SMBFieldDescription("Job Phase")]
		public long jobphs;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

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

	}
}