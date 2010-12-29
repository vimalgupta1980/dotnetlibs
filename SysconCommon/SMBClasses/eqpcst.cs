using System;

namespace SMB.Tables {
	public class eqpcst : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

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
		/// Entry Date                      
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
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
		/// Oper Equip                      
		/// </summary>
		[SMBFieldName("opreqp")]
		[SMBFieldDescription("Oper Equip")]
		public long opreqp;

		/// <summary>
		/// Employee                        
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Payroll Record                  
		/// </summary>
		[SMBFieldName("payrec")]
		[SMBFieldDescription("Payroll Record")]
		public long payrec;

		/// <summary>
		/// Pay Type                        
		/// </summary>
		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public long paytyp;

		/// <summary>
		/// Labor Hours                     
		/// </summary>
		[SMBFieldName("csthrs")]
		[SMBFieldDescription("Labor Hours")]
		public decimal csthrs;

		/// <summary>
		/// Type                            
		/// </summary>
		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Type")]
		public long eqptyp;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("eqpqty")]
		[SMBFieldDescription("Quantity")]
		public decimal eqpqty;

		/// <summary>
		/// Cost                            
		/// </summary>
		[SMBFieldName("cstamt")]
		[SMBFieldDescription("Cost")]
		public decimal cstamt;

		/// <summary>
		/// Gross Wage                      
		/// </summary>
		[SMBFieldName("grswge")]
		[SMBFieldDescription("Gross Wage")]
		public decimal grswge;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public long eqpunt;

		/// <summary>
		/// Username                        
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("Username")]
		public string usrnme;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}