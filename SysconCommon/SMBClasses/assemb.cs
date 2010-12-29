using System;

namespace SMB.Tables {
	public class assemb : smbtable {
		/// <summary>
		/// Assembly#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Assembly#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("asmnme")]
		[SMBFieldDescription("Description")]
		public string asmnme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("asmunt")]
		[SMBFieldDescription("Unit")]
		public string asmunt;

		/// <summary>
		/// Formula                         
		/// </summary>
		[SMBFieldName("asmfrm")]
		[SMBFieldDescription("Formula")]
		public string asmfrm;

		/// <summary>
		/// Assembly Class                  
		/// </summary>
		[SMBFieldName("asmcls")]
		[SMBFieldDescription("Assembly Class")]
		public long asmcls;

		/// <summary>
		/// Total Cost                      
		/// </summary>
		[SMBFieldName("ttlcst")]
		[SMBFieldDescription("Total Cost")]
		public decimal ttlcst;

		/// <summary>
		/// User                            
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Last Edit                       
		/// </summary>
		[SMBFieldName("lstedt")]
		[SMBFieldDescription("Last Edit")]
		public DateTime lstedt;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Material Cost                   
		/// </summary>
		[SMBFieldName("matcst")]
		[SMBFieldDescription("Material Cost")]
		public decimal matcst;

		/// <summary>
		/// Material Markup                 
		/// </summary>
		[SMBFieldName("matmrk")]
		[SMBFieldDescription("Material Markup")]
		public decimal matmrk;

		/// <summary>
		/// Material Sell                   
		/// </summary>
		[SMBFieldName("matsel")]
		[SMBFieldDescription("Material Sell")]
		public decimal matsel;

		/// <summary>
		/// Labor Cost                      
		/// </summary>
		[SMBFieldName("labcst")]
		[SMBFieldDescription("Labor Cost")]
		public decimal labcst;

		/// <summary>
		/// Labor Markup                    
		/// </summary>
		[SMBFieldName("labmrk")]
		[SMBFieldDescription("Labor Markup")]
		public decimal labmrk;

		/// <summary>
		/// Labor Sell                      
		/// </summary>
		[SMBFieldName("labsel")]
		[SMBFieldDescription("Labor Sell")]
		public decimal labsel;

		/// <summary>
		/// Equipment Cost                  
		/// </summary>
		[SMBFieldName("eqpcst")]
		[SMBFieldDescription("Equipment Cost")]
		public decimal eqpcst;

		/// <summary>
		/// Equipment Markup                
		/// </summary>
		[SMBFieldName("eqpmrk")]
		[SMBFieldDescription("Equipment Markup")]
		public decimal eqpmrk;

		/// <summary>
		/// Equipment Sell                  
		/// </summary>
		[SMBFieldName("eqpsel")]
		[SMBFieldDescription("Equipment Sell")]
		public decimal eqpsel;

		/// <summary>
		/// Subcontract Cost                
		/// </summary>
		[SMBFieldName("subcst")]
		[SMBFieldDescription("Subcontract Cost")]
		public decimal subcst;

		/// <summary>
		/// Subcontract Markup              
		/// </summary>
		[SMBFieldName("submrk")]
		[SMBFieldDescription("Subcontract Markup")]
		public decimal submrk;

		/// <summary>
		/// Subcontract Sell                
		/// </summary>
		[SMBFieldName("subsel")]
		[SMBFieldDescription("Subcontract Sell")]
		public decimal subsel;

		/// <summary>
		/// Other Cost                      
		/// </summary>
		[SMBFieldName("othcst")]
		[SMBFieldDescription("Other Cost")]
		public decimal othcst;

		/// <summary>
		/// Other Markup                    
		/// </summary>
		[SMBFieldName("othmrk")]
		[SMBFieldDescription("Other Markup")]
		public decimal othmrk;

		/// <summary>
		/// Other Sell                      
		/// </summary>
		[SMBFieldName("othsel")]
		[SMBFieldDescription("Other Sell")]
		public decimal othsel;

		/// <summary>
		/// Cost Type 6 Cost                
		/// </summary>
		[SMBFieldName("tp6cst")]
		[SMBFieldDescription("Cost Type 6 Cost")]
		public decimal tp6cst;

		/// <summary>
		/// Cost Type 6 Markup              
		/// </summary>
		[SMBFieldName("tp6mrk")]
		[SMBFieldDescription("Cost Type 6 Markup")]
		public decimal tp6mrk;

		/// <summary>
		/// Cost Type 6 Sell                
		/// </summary>
		[SMBFieldName("tp6sel")]
		[SMBFieldDescription("Cost Type 6 Sell")]
		public decimal tp6sel;

		/// <summary>
		/// Cost Type 7 Cost                
		/// </summary>
		[SMBFieldName("tp7cst")]
		[SMBFieldDescription("Cost Type 7 Cost")]
		public decimal tp7cst;

		/// <summary>
		/// Cost Type 7 Markup              
		/// </summary>
		[SMBFieldName("tp7mrk")]
		[SMBFieldDescription("Cost Type 7 Markup")]
		public decimal tp7mrk;

		/// <summary>
		/// Cost Type 7 Sell                
		/// </summary>
		[SMBFieldName("tp7sel")]
		[SMBFieldDescription("Cost Type 7 Sell")]
		public decimal tp7sel;

		/// <summary>
		/// Cost Type 8 Cost                
		/// </summary>
		[SMBFieldName("tp8cst")]
		[SMBFieldDescription("Cost Type 8 Cost")]
		public decimal tp8cst;

		/// <summary>
		/// Cost Type 8 Markup              
		/// </summary>
		[SMBFieldName("tp8mrk")]
		[SMBFieldDescription("Cost Type 8 Markup")]
		public decimal tp8mrk;

		/// <summary>
		/// Cost Type 8 Sell                
		/// </summary>
		[SMBFieldName("tp8sel")]
		[SMBFieldDescription("Cost Type 8 Sell")]
		public decimal tp8sel;

		/// <summary>
		/// Cost Type 9 Cost                
		/// </summary>
		[SMBFieldName("tp9cst")]
		[SMBFieldDescription("Cost Type 9 Cost")]
		public decimal tp9cst;

		/// <summary>
		/// Cost Type 9 Markup              
		/// </summary>
		[SMBFieldName("tp9mrk")]
		[SMBFieldDescription("Cost Type 9 Markup")]
		public decimal tp9mrk;

		/// <summary>
		/// Cost Type 9 Sell                
		/// </summary>
		[SMBFieldName("tp9sel")]
		[SMBFieldDescription("Cost Type 9 Sell")]
		public decimal tp9sel;

		/// <summary>
		/// Travel Time                     
		/// </summary>
		[SMBFieldName("tvltim")]
		[SMBFieldDescription("Travel Time")]
		public long tvltim;

		/// <summary>
		/// Travel Cost                     
		/// </summary>
		[SMBFieldName("tvlcst")]
		[SMBFieldDescription("Travel Cost")]
		public decimal tvlcst;

		/// <summary>
		/// Travel Markup                   
		/// </summary>
		[SMBFieldName("tvlmrk")]
		[SMBFieldDescription("Travel Markup")]
		public decimal tvlmrk;

		/// <summary>
		/// Travel Sell                     
		/// </summary>
		[SMBFieldName("tvlsel")]
		[SMBFieldDescription("Travel Sell")]
		public decimal tvlsel;

		/// <summary>
		/// Technician Time                 
		/// </summary>
		[SMBFieldName("tchtim")]
		[SMBFieldDescription("Technician Time")]
		public long tchtim;

		/// <summary>
		/// Technician Cost                 
		/// </summary>
		[SMBFieldName("tchcst")]
		[SMBFieldDescription("Technician Cost")]
		public decimal tchcst;

		/// <summary>
		/// Technician Markup               
		/// </summary>
		[SMBFieldName("tchmrk")]
		[SMBFieldDescription("Technician Markup")]
		public decimal tchmrk;

		/// <summary>
		/// Technician Sell                 
		/// </summary>
		[SMBFieldName("tchsel")]
		[SMBFieldDescription("Technician Sell")]
		public decimal tchsel;

		/// <summary>
		/// Assistant Time                  
		/// </summary>
		[SMBFieldName("asttim")]
		[SMBFieldDescription("Assistant Time")]
		public long asttim;

		/// <summary>
		/// Assistant Cost                  
		/// </summary>
		[SMBFieldName("astcst")]
		[SMBFieldDescription("Assistant Cost")]
		public decimal astcst;

		/// <summary>
		/// Assistant Markup                
		/// </summary>
		[SMBFieldName("astmrk")]
		[SMBFieldDescription("Assistant Markup")]
		public decimal astmrk;

		/// <summary>
		/// Assistant Sell                  
		/// </summary>
		[SMBFieldName("astsel")]
		[SMBFieldDescription("Assistant Sell")]
		public decimal astsel;

		/// <summary>
		/// Misc Cost                       
		/// </summary>
		[SMBFieldName("msccst")]
		[SMBFieldDescription("Misc Cost")]
		public decimal msccst;

		/// <summary>
		/// Misc Markup                     
		/// </summary>
		[SMBFieldName("mscmrk")]
		[SMBFieldDescription("Misc Markup")]
		public decimal mscmrk;

		/// <summary>
		/// Misc Sell                       
		/// </summary>
		[SMBFieldName("mscsel")]
		[SMBFieldDescription("Misc Sell")]
		public decimal mscsel;

		/// <summary>
		/// Overhead Cost                   
		/// </summary>
		[SMBFieldName("ovhcst")]
		[SMBFieldDescription("Overhead Cost")]
		public decimal ovhcst;

		/// <summary>
		/// Overhead Markup                 
		/// </summary>
		[SMBFieldName("ovhmrk")]
		[SMBFieldDescription("Overhead Markup")]
		public decimal ovhmrk;

		/// <summary>
		/// Overhead Sell                   
		/// </summary>
		[SMBFieldName("ovhsel")]
		[SMBFieldDescription("Overhead Sell")]
		public decimal ovhsel;

		/// <summary>
		/// Primary Time                    
		/// </summary>
		[SMBFieldName("prmtim")]
		[SMBFieldDescription("Primary Time")]
		public long prmtim;

		/// <summary>
		/// Primary Cost                    
		/// </summary>
		[SMBFieldName("prmcst")]
		[SMBFieldDescription("Primary Cost")]
		public decimal prmcst;

		/// <summary>
		/// Primary Sell                    
		/// </summary>
		[SMBFieldName("prmsel")]
		[SMBFieldDescription("Primary Sell")]
		public decimal prmsel;

		/// <summary>
		/// Add-on Time                     
		/// </summary>
		[SMBFieldName("addtim")]
		[SMBFieldDescription("Add-on Time")]
		public long addtim;

		/// <summary>
		/// Add-on Cost                     
		/// </summary>
		[SMBFieldName("addcst")]
		[SMBFieldDescription("Add-on Cost")]
		public decimal addcst;

		/// <summary>
		/// Add-on Sell                     
		/// </summary>
		[SMBFieldName("addsel")]
		[SMBFieldDescription("Add-on Sell")]
		public decimal addsel;

		/// <summary>
		/// Primary Contract Sell           
		/// </summary>
		[SMBFieldName("cpmsel")]
		[SMBFieldDescription("Primary Contract Sell")]
		public decimal cpmsel;

		/// <summary>
		/// Add on Contract Sell            
		/// </summary>
		[SMBFieldName("cadsel")]
		[SMBFieldDescription("Add on Contract Sell")]
		public decimal cadsel;

		/// <summary>
		/// Contract Disc                   
		/// </summary>
		[SMBFieldName("condsc")]
		[SMBFieldDescription("Contract Disc")]
		public decimal condsc;

		/// <summary>
		/// Print in Book                   
		/// </summary>
		[SMBFieldName("pntbok")]
		[SMBFieldDescription("Print in Book")]
		public long pntbok;

		/// <summary>
		/// Print Parts                     
		/// </summary>
		[SMBFieldName("pntprt")]
		[SMBFieldDescription("Print Parts")]
		public long pntprt;

		/// <summary>
		/// Taxable                         
		/// </summary>
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable")]
		public long taxabl;

	}
}