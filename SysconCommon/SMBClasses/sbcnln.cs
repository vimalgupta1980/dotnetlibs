using System;

namespace SMB.Tables {
	public class sbcnln : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

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
		/// Original Contract               
		/// </summary>
		[SMBFieldName("amount")]
		[SMBFieldDescription("Original Contract")]
		public decimal amount;

		/// <summary>
		/// Changes                         
		/// </summary>
		[SMBFieldName("change")]
		[SMBFieldDescription("Changes")]
		public decimal change;

		/// <summary>
		/// New Contract                    
		/// </summary>
		[SMBFieldName("cntrct")]
		[SMBFieldDescription("New Contract")]
		public decimal cntrct;

		/// <summary>
		/// Invoiced                        
		/// </summary>
		[SMBFieldName("billed")]
		[SMBFieldDescription("Invoiced")]
		public decimal billed;

		/// <summary>
		/// Remaining                       
		/// </summary>
		[SMBFieldName("remain")]
		[SMBFieldDescription("Remaining")]
		public decimal remain;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Subcontract Line Reference #    
		/// </summary>
		[SMBFieldName("linref")]
		[SMBFieldDescription("Subcontract Line Reference #")]
		public string linref;

	}
}