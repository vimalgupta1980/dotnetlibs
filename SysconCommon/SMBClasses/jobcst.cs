using System;

namespace SMB.Tables {
	public class jobcst : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Work Order#                     
		/// </summary>
		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Work Order#")]
		public string wrkord;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		/// <summary>
		/// EntDate                         
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("EntDate")]
		public DateTime entdte;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public long actprd;

		/// <summary>
		/// Source                          
		/// </summary>
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Billing Status                  
		/// </summary>
		[SMBFieldName("bllsts")]
		[SMBFieldDescription("Billing Status")]
		public long bllsts;

		/// <summary>
		/// Phase                           
		/// </summary>
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Employee                        
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Payroll#                        
		/// </summary>
		[SMBFieldName("payrec")]
		[SMBFieldDescription("Payroll#")]
		public long payrec;

		/// <summary>
		/// Pay Type                        
		/// </summary>
		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public long paytyp;

		/// <summary>
		/// Hours                           
		/// </summary>
		[SMBFieldName("csthrs")]
		[SMBFieldDescription("Hours")]
		public decimal csthrs;

		/// <summary>
		/// Cost                            
		/// </summary>
		[SMBFieldName("cstamt")]
		[SMBFieldDescription("Cost")]
		public decimal cstamt;

		/// <summary>
		/// Billing Quantity                
		/// </summary>
		[SMBFieldName("blgqty")]
		[SMBFieldDescription("Billing Quantity")]
		public decimal blgqty;

		/// <summary>
		/// Billing Amount                  
		/// </summary>
		[SMBFieldName("blgamt")]
		[SMBFieldDescription("Billing Amount")]
		public decimal blgamt;

		/// <summary>
		/// Pieces                          
		/// </summary>
		[SMBFieldName("pieces")]
		[SMBFieldDescription("Pieces")]
		public decimal pieces;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Equipment Unit                  
		/// </summary>
		[SMBFieldName("blgunt")]
		[SMBFieldDescription("Equipment Unit")]
		public long blgunt;

		/// <summary>
		/// Type                            
		/// </summary>
		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Type")]
		public long eqptyp;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public long eqpunt;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("eqpqty")]
		[SMBFieldDescription("Quantity")]
		public decimal eqpqty;

		/// <summary>
		/// Gross Wage                      
		/// </summary>
		[SMBFieldName("grswge")]
		[SMBFieldDescription("Gross Wage")]
		public decimal grswge;

		/// <summary>
		/// Override                        
		/// </summary>
		[SMBFieldName("ovrrde")]
		[SMBFieldDescription("Override")]
		public long ovrrde;

		/// <summary>
		/// Billing Total                   
		/// </summary>
		[SMBFieldName("blgttl")]
		[SMBFieldDescription("Billing Total")]
		public decimal blgttl;

		/// <summary>
		/// In Process                      
		/// </summary>
		[SMBFieldName("active")]
		[SMBFieldDescription("In Process")]
		public long active;

		/// <summary>
		/// Invoice Rec#                    
		/// </summary>
		[SMBFieldName("acrinv")]
		[SMBFieldDescription("Invoice Rec#")]
		public long acrinv;

		/// <summary>
		/// Shown M/U                       
		/// </summary>
		[SMBFieldName("shwamt")]
		[SMBFieldDescription("Shown M/U")]
		public decimal shwamt;

		/// <summary>
		/// O/H Amount                      
		/// </summary>
		[SMBFieldName("ovhamt")]
		[SMBFieldDescription("O/H Amount")]
		public decimal ovhamt;

		/// <summary>
		/// Profit Amount                   
		/// </summary>
		[SMBFieldName("pftamt")]
		[SMBFieldDescription("Profit Amount")]
		public decimal pftamt;

		/// <summary>
		/// Subject to Sales Tax            
		/// </summary>
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Subject to Sales Tax")]
		public long taxabl;

		/// <summary>
		/// User Name                       
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}