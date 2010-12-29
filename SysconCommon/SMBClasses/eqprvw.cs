using System;

namespace SMB.Tables {
	public class eqprvw : smbtable {
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
		/// Entered Date                    
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered Date")]
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
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpmnt")]
		[SMBFieldDescription("Equipment")]
		public long eqpmnt;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public long eqpunt;

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
		/// Revenue                         
		/// </summary>
		[SMBFieldName("rvnamt")]
		[SMBFieldDescription("Revenue")]
		public decimal rvnamt;

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

		/// <summary>
		/// User                            
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

	}
}