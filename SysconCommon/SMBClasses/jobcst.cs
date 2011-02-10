using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class jobcst : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Work Order#                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Work Order#")]
		public string wrkord;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		/// <summary>
		/// EntDate                         
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("EntDate")]
		public DateTime entdte;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public long actprd;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Billing Status                  
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("bllsts")]
		[SMBFieldDescription("Billing Status")]
		public long bllsts;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Employee                        
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Payroll#                        
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("payrec")]
		[SMBFieldDescription("Payroll#")]
		public long payrec;

		/// <summary>
		/// Pay Type                        
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public long paytyp;

		/// <summary>
		/// Hours                           
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("csthrs")]
		[SMBFieldDescription("Hours")]
		public decimal csthrs;

		/// <summary>
		/// Cost                            
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("cstamt")]
		[SMBFieldDescription("Cost")]
		public decimal cstamt;

		/// <summary>
		/// Billing Quantity                
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("blgqty")]
		[SMBFieldDescription("Billing Quantity")]
		public decimal blgqty;

		/// <summary>
		/// Billing Amount                  
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("blgamt")]
		[SMBFieldDescription("Billing Amount")]
		public decimal blgamt;

		/// <summary>
		/// Pieces                          
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("pieces")]
		[SMBFieldDescription("Pieces")]
		public decimal pieces;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Equipment Unit                  
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("blgunt")]
		[SMBFieldDescription("Equipment Unit")]
		public long blgunt;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Type")]
		public long eqptyp;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public long eqpunt;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("eqpqty")]
		[SMBFieldDescription("Quantity")]
		public decimal eqpqty;

		/// <summary>
		/// Gross Wage                      
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("grswge")]
		[SMBFieldDescription("Gross Wage")]
		public decimal grswge;

		/// <summary>
		/// Override                        
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("ovrrde")]
		[SMBFieldDescription("Override")]
		public long ovrrde;

		/// <summary>
		/// Billing Total                   
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("blgttl")]
		[SMBFieldDescription("Billing Total")]
		public decimal blgttl;

		/// <summary>
		/// In Process                      
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("active")]
		[SMBFieldDescription("In Process")]
		public long active;

		/// <summary>
		/// Invoice Rec#                    
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("acrinv")]
		[SMBFieldDescription("Invoice Rec#")]
		public long acrinv;

		/// <summary>
		/// Shown M/U                       
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("shwamt")]
		[SMBFieldDescription("Shown M/U")]
		public decimal shwamt;

		/// <summary>
		/// O/H Amount                      
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("ovhamt")]
		[SMBFieldDescription("O/H Amount")]
		public decimal ovhamt;

		/// <summary>
		/// Profit Amount                   
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("pftamt")]
		[SMBFieldDescription("Profit Amount")]
		public decimal pftamt;

		/// <summary>
		/// Subject to Sales Tax            
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Subject to Sales Tax")]
		public long taxabl;

		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}