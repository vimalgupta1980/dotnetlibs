using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class timmat : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Wage Rate                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("emptbl")]
		[SMBFieldDescription("Wage Rate")]
		public long emptbl;

		/// <summary>
		/// Equipment Rate                  
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("eqptbl")]
		[SMBFieldDescription("Equipment Rate")]
		public long eqptbl;

		/// <summary>
		/// Material Hidden                 
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("mtrhdn")]
		[SMBFieldDescription("Material Hidden")]
		public decimal mtrhdn;

		/// <summary>
		/// Material Shown                  
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("mtrshw")]
		[SMBFieldDescription("Material Shown")]
		public decimal mtrshw;

		/// <summary>
		/// Material Overhead               
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("mtrovh")]
		[SMBFieldDescription("Material Overhead")]
		public decimal mtrovh;

		/// <summary>
		/// Material Profit                 
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("mtrpft")]
		[SMBFieldDescription("Material Profit")]
		public decimal mtrpft;

		/// <summary>
		/// Labor Hidden                    
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("labhdn")]
		[SMBFieldDescription("Labor Hidden")]
		public decimal labhdn;

		/// <summary>
		/// Labor Shown                     
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("labshw")]
		[SMBFieldDescription("Labor Shown")]
		public decimal labshw;

		/// <summary>
		/// Labor Overhead                  
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("labovh")]
		[SMBFieldDescription("Labor Overhead")]
		public decimal labovh;

		/// <summary>
		/// Labor Profit                    
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("labpft")]
		[SMBFieldDescription("Labor Profit")]
		public decimal labpft;

		/// <summary>
		/// Equipment Hidden                
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("eqphdn")]
		[SMBFieldDescription("Equipment Hidden")]
		public decimal eqphdn;

		/// <summary>
		/// Equipment Shown                 
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("eqpshw")]
		[SMBFieldDescription("Equipment Shown")]
		public decimal eqpshw;

		/// <summary>
		/// Equipment Overhead              
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("eqpovh")]
		[SMBFieldDescription("Equipment Overhead")]
		public decimal eqpovh;

		/// <summary>
		/// Equipment Profit                
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("eqppft")]
		[SMBFieldDescription("Equipment Profit")]
		public decimal eqppft;

		/// <summary>
		/// Subcontract Hidden              
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("subhdn")]
		[SMBFieldDescription("Subcontract Hidden")]
		public decimal subhdn;

		/// <summary>
		/// Subcontract Shown               
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("subshw")]
		[SMBFieldDescription("Subcontract Shown")]
		public decimal subshw;

		/// <summary>
		/// Subcontract Overhead            
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("subovh")]
		[SMBFieldDescription("Subcontract Overhead")]
		public decimal subovh;

		/// <summary>
		/// Subcontract Profit              
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("subpft")]
		[SMBFieldDescription("Subcontract Profit")]
		public decimal subpft;

		/// <summary>
		/// Other Hidden                    
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("otrhdn")]
		[SMBFieldDescription("Other Hidden")]
		public decimal otrhdn;

		/// <summary>
		/// Other Shown                     
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("otrshw")]
		[SMBFieldDescription("Other Shown")]
		public decimal otrshw;

		/// <summary>
		/// Other Overhead                  
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("otrovh")]
		[SMBFieldDescription("Other Overhead")]
		public decimal otrovh;

		/// <summary>
		/// Other Profit                    
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("otrpft")]
		[SMBFieldDescription("Other Profit")]
		public decimal otrpft;

		/// <summary>
		/// User Def Type 6                 
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("cs6hdn")]
		[SMBFieldDescription("User Def Type 6")]
		public decimal cs6hdn;

		/// <summary>
		/// User Def Type 6 Shown           
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("cs6shw")]
		[SMBFieldDescription("User Def Type 6 Shown")]
		public decimal cs6shw;

		/// <summary>
		/// User Def Type 6 Overhead        
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("cs6ovh")]
		[SMBFieldDescription("User Def Type 6 Overhead")]
		public decimal cs6ovh;

		/// <summary>
		/// User Def Type 6 Profit          
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("cs6pft")]
		[SMBFieldDescription("User Def Type 6 Profit")]
		public decimal cs6pft;

		/// <summary>
		/// User Def Type 7                 
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("cs7hdn")]
		[SMBFieldDescription("User Def Type 7")]
		public decimal cs7hdn;

		/// <summary>
		/// User Def Type 7 Shown           
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("cs7shw")]
		[SMBFieldDescription("User Def Type 7 Shown")]
		public decimal cs7shw;

		/// <summary>
		/// User Def Type 7 Overhead        
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("cs7ovh")]
		[SMBFieldDescription("User Def Type 7 Overhead")]
		public decimal cs7ovh;

		/// <summary>
		/// User Def Type 7 Profit          
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("cs7pft")]
		[SMBFieldDescription("User Def Type 7 Profit")]
		public decimal cs7pft;

		/// <summary>
		/// User Def Type 8                 
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("cs8hdn")]
		[SMBFieldDescription("User Def Type 8")]
		public decimal cs8hdn;

		/// <summary>
		/// User Def Type 8 Shown           
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("cs8shw")]
		[SMBFieldDescription("User Def Type 8 Shown")]
		public decimal cs8shw;

		/// <summary>
		/// User Def Type 8 Overhead        
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("cs8ovh")]
		[SMBFieldDescription("User Def Type 8 Overhead")]
		public decimal cs8ovh;

		/// <summary>
		/// User Def Type 8 Profit          
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("cs8pft")]
		[SMBFieldDescription("User Def Type 8 Profit")]
		public decimal cs8pft;

		/// <summary>
		/// User Def Type 9                 
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("cs9hdn")]
		[SMBFieldDescription("User Def Type 9")]
		public decimal cs9hdn;

		/// <summary>
		/// User Def Type 9 Shown           
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("cs9shw")]
		[SMBFieldDescription("User Def Type 9 Shown")]
		public decimal cs9shw;

		/// <summary>
		/// User Def Type 9 Overhead        
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("cs9ovh")]
		[SMBFieldDescription("User Def Type 9 Overhead")]
		public decimal cs9ovh;

		/// <summary>
		/// User Def Type 9 Profit          
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("cs9pft")]
		[SMBFieldDescription("User Def Type 9 Profit")]
		public decimal cs9pft;

		/// <summary>
		/// Calculated                      
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("clcsts")]
		[SMBFieldDescription("Calculated")]
		public long clcsts;

		/// <summary>
		/// Invoice Date                    
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Invoice Date")]
		public DateTime invdte;

		/// <summary>
		/// Invoice Total                   
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		/// <summary>
		/// Taxable Amount                  
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("subjct")]
		[SMBFieldDescription("Taxable Amount")]
		public decimal subjct;

		/// <summary>
		/// Sales Tax Amount                
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax Amount")]
		public decimal slstax;

		/// <summary>
		/// Tax Details                     
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("taxdtl")]
		[SMBFieldDescription("Tax Details")]
		public string taxdtl;

		/// <summary>
		/// Job Phase                       
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("jobphs")]
		[SMBFieldDescription("Job Phase")]
		public long jobphs;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Income Account                  
		/// </summary>
		[ColumnOrder(490)]
		[SMBFieldName("incact")]
		[SMBFieldDescription("Income Account")]
		public long incact;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[ColumnOrder(500)]
		[SMBFieldName("incsub")]
		[SMBFieldDescription("Subaccount")]
		public long incsub;

	}
}