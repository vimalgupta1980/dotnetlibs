using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class assemb : smbtable {
		/// <summary>
		/// Assembly#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Assembly#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("asmnme")]
		[SMBFieldDescription("Description")]
		public string asmnme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("asmunt")]
		[SMBFieldDescription("Unit")]
		public string asmunt;

		/// <summary>
		/// Formula                         
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("asmfrm")]
		[SMBFieldDescription("Formula")]
		public string asmfrm;

		/// <summary>
		/// Assembly Class                  
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("asmcls")]
		[SMBFieldDescription("Assembly Class")]
		public long asmcls;

		/// <summary>
		/// Total Cost                      
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("ttlcst")]
		[SMBFieldDescription("Total Cost")]
		public decimal ttlcst;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Last Edit                       
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("lstedt")]
		[SMBFieldDescription("Last Edit")]
		public DateTime lstedt;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Material Cost                   
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("matcst")]
		[SMBFieldDescription("Material Cost")]
		public decimal matcst;

		/// <summary>
		/// Material Markup                 
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("matmrk")]
		[SMBFieldDescription("Material Markup")]
		public decimal matmrk;

		/// <summary>
		/// Material Sell                   
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("matsel")]
		[SMBFieldDescription("Material Sell")]
		public decimal matsel;

		/// <summary>
		/// Labor Cost                      
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("labcst")]
		[SMBFieldDescription("Labor Cost")]
		public decimal labcst;

		/// <summary>
		/// Labor Markup                    
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("labmrk")]
		[SMBFieldDescription("Labor Markup")]
		public decimal labmrk;

		/// <summary>
		/// Labor Sell                      
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("labsel")]
		[SMBFieldDescription("Labor Sell")]
		public decimal labsel;

		/// <summary>
		/// Equipment Cost                  
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("eqpcst")]
		[SMBFieldDescription("Equipment Cost")]
		public decimal eqpcst;

		/// <summary>
		/// Equipment Markup                
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("eqpmrk")]
		[SMBFieldDescription("Equipment Markup")]
		public decimal eqpmrk;

		/// <summary>
		/// Equipment Sell                  
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("eqpsel")]
		[SMBFieldDescription("Equipment Sell")]
		public decimal eqpsel;

		/// <summary>
		/// Subcontract Cost                
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("subcst")]
		[SMBFieldDescription("Subcontract Cost")]
		public decimal subcst;

		/// <summary>
		/// Subcontract Markup              
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("submrk")]
		[SMBFieldDescription("Subcontract Markup")]
		public decimal submrk;

		/// <summary>
		/// Subcontract Sell                
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("subsel")]
		[SMBFieldDescription("Subcontract Sell")]
		public decimal subsel;

		/// <summary>
		/// Other Cost                      
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("othcst")]
		[SMBFieldDescription("Other Cost")]
		public decimal othcst;

		/// <summary>
		/// Other Markup                    
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("othmrk")]
		[SMBFieldDescription("Other Markup")]
		public decimal othmrk;

		/// <summary>
		/// Other Sell                      
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("othsel")]
		[SMBFieldDescription("Other Sell")]
		public decimal othsel;

		/// <summary>
		/// Cost Type 6 Cost                
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("tp6cst")]
		[SMBFieldDescription("Cost Type 6 Cost")]
		public decimal tp6cst;

		/// <summary>
		/// Cost Type 6 Markup              
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("tp6mrk")]
		[SMBFieldDescription("Cost Type 6 Markup")]
		public decimal tp6mrk;

		/// <summary>
		/// Cost Type 6 Sell                
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("tp6sel")]
		[SMBFieldDescription("Cost Type 6 Sell")]
		public decimal tp6sel;

		/// <summary>
		/// Cost Type 7 Cost                
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("tp7cst")]
		[SMBFieldDescription("Cost Type 7 Cost")]
		public decimal tp7cst;

		/// <summary>
		/// Cost Type 7 Markup              
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("tp7mrk")]
		[SMBFieldDescription("Cost Type 7 Markup")]
		public decimal tp7mrk;

		/// <summary>
		/// Cost Type 7 Sell                
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("tp7sel")]
		[SMBFieldDescription("Cost Type 7 Sell")]
		public decimal tp7sel;

		/// <summary>
		/// Cost Type 8 Cost                
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("tp8cst")]
		[SMBFieldDescription("Cost Type 8 Cost")]
		public decimal tp8cst;

		/// <summary>
		/// Cost Type 8 Markup              
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("tp8mrk")]
		[SMBFieldDescription("Cost Type 8 Markup")]
		public decimal tp8mrk;

		/// <summary>
		/// Cost Type 8 Sell                
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("tp8sel")]
		[SMBFieldDescription("Cost Type 8 Sell")]
		public decimal tp8sel;

		/// <summary>
		/// Cost Type 9 Cost                
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("tp9cst")]
		[SMBFieldDescription("Cost Type 9 Cost")]
		public decimal tp9cst;

		/// <summary>
		/// Cost Type 9 Markup              
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("tp9mrk")]
		[SMBFieldDescription("Cost Type 9 Markup")]
		public decimal tp9mrk;

		/// <summary>
		/// Cost Type 9 Sell                
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("tp9sel")]
		[SMBFieldDescription("Cost Type 9 Sell")]
		public decimal tp9sel;

		/// <summary>
		/// Travel Time                     
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("tvltim")]
		[SMBFieldDescription("Travel Time")]
		public long tvltim;

		/// <summary>
		/// Travel Cost                     
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("tvlcst")]
		[SMBFieldDescription("Travel Cost")]
		public decimal tvlcst;

		/// <summary>
		/// Travel Markup                   
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("tvlmrk")]
		[SMBFieldDescription("Travel Markup")]
		public decimal tvlmrk;

		/// <summary>
		/// Travel Sell                     
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("tvlsel")]
		[SMBFieldDescription("Travel Sell")]
		public decimal tvlsel;

		/// <summary>
		/// Technician Time                 
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("tchtim")]
		[SMBFieldDescription("Technician Time")]
		public long tchtim;

		/// <summary>
		/// Technician Cost                 
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("tchcst")]
		[SMBFieldDescription("Technician Cost")]
		public decimal tchcst;

		/// <summary>
		/// Technician Markup               
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("tchmrk")]
		[SMBFieldDescription("Technician Markup")]
		public decimal tchmrk;

		/// <summary>
		/// Technician Sell                 
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("tchsel")]
		[SMBFieldDescription("Technician Sell")]
		public decimal tchsel;

		/// <summary>
		/// Assistant Time                  
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("asttim")]
		[SMBFieldDescription("Assistant Time")]
		public long asttim;

		/// <summary>
		/// Assistant Cost                  
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("astcst")]
		[SMBFieldDescription("Assistant Cost")]
		public decimal astcst;

		/// <summary>
		/// Assistant Markup                
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("astmrk")]
		[SMBFieldDescription("Assistant Markup")]
		public decimal astmrk;

		/// <summary>
		/// Assistant Sell                  
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("astsel")]
		[SMBFieldDescription("Assistant Sell")]
		public decimal astsel;

		/// <summary>
		/// Misc Cost                       
		/// </summary>
		[ColumnOrder(490)]
		[SMBFieldName("msccst")]
		[SMBFieldDescription("Misc Cost")]
		public decimal msccst;

		/// <summary>
		/// Misc Markup                     
		/// </summary>
		[ColumnOrder(500)]
		[SMBFieldName("mscmrk")]
		[SMBFieldDescription("Misc Markup")]
		public decimal mscmrk;

		/// <summary>
		/// Misc Sell                       
		/// </summary>
		[ColumnOrder(510)]
		[SMBFieldName("mscsel")]
		[SMBFieldDescription("Misc Sell")]
		public decimal mscsel;

		/// <summary>
		/// Overhead Cost                   
		/// </summary>
		[ColumnOrder(520)]
		[SMBFieldName("ovhcst")]
		[SMBFieldDescription("Overhead Cost")]
		public decimal ovhcst;

		/// <summary>
		/// Overhead Markup                 
		/// </summary>
		[ColumnOrder(530)]
		[SMBFieldName("ovhmrk")]
		[SMBFieldDescription("Overhead Markup")]
		public decimal ovhmrk;

		/// <summary>
		/// Overhead Sell                   
		/// </summary>
		[ColumnOrder(540)]
		[SMBFieldName("ovhsel")]
		[SMBFieldDescription("Overhead Sell")]
		public decimal ovhsel;

		/// <summary>
		/// Primary Time                    
		/// </summary>
		[ColumnOrder(550)]
		[SMBFieldName("prmtim")]
		[SMBFieldDescription("Primary Time")]
		public long prmtim;

		/// <summary>
		/// Primary Cost                    
		/// </summary>
		[ColumnOrder(560)]
		[SMBFieldName("prmcst")]
		[SMBFieldDescription("Primary Cost")]
		public decimal prmcst;

		/// <summary>
		/// Primary Sell                    
		/// </summary>
		[ColumnOrder(570)]
		[SMBFieldName("prmsel")]
		[SMBFieldDescription("Primary Sell")]
		public decimal prmsel;

		/// <summary>
		/// Add-on Time                     
		/// </summary>
		[ColumnOrder(580)]
		[SMBFieldName("addtim")]
		[SMBFieldDescription("Add-on Time")]
		public long addtim;

		/// <summary>
		/// Add-on Cost                     
		/// </summary>
		[ColumnOrder(590)]
		[SMBFieldName("addcst")]
		[SMBFieldDescription("Add-on Cost")]
		public decimal addcst;

		/// <summary>
		/// Add-on Sell                     
		/// </summary>
		[ColumnOrder(600)]
		[SMBFieldName("addsel")]
		[SMBFieldDescription("Add-on Sell")]
		public decimal addsel;

		/// <summary>
		/// Primary Contract Sell           
		/// </summary>
		[ColumnOrder(610)]
		[SMBFieldName("cpmsel")]
		[SMBFieldDescription("Primary Contract Sell")]
		public decimal cpmsel;

		/// <summary>
		/// Add on Contract Sell            
		/// </summary>
		[ColumnOrder(620)]
		[SMBFieldName("cadsel")]
		[SMBFieldDescription("Add on Contract Sell")]
		public decimal cadsel;

		/// <summary>
		/// Contract Disc                   
		/// </summary>
		[ColumnOrder(630)]
		[SMBFieldName("condsc")]
		[SMBFieldDescription("Contract Disc")]
		public decimal condsc;

		/// <summary>
		/// Print in Book                   
		/// </summary>
		[ColumnOrder(640)]
		[SMBFieldName("pntbok")]
		[SMBFieldDescription("Print in Book")]
		public long pntbok;

		/// <summary>
		/// Print Parts                     
		/// </summary>
		[ColumnOrder(650)]
		[SMBFieldName("pntprt")]
		[SMBFieldDescription("Print Parts")]
		public long pntprt;

		/// <summary>
		/// Taxable                         
		/// </summary>
		[ColumnOrder(660)]
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable")]
		public long taxabl;

	}
}