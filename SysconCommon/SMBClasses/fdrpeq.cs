using System;

namespace SMB.Tables {
	public class fdrpeq : smbtable {
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
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

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
		/// Unit                            
		/// </summary>
		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public long eqpunt;

		/// <summary>
		/// Operated                        
		/// </summary>
		[SMBFieldName("oprtim")]
		[SMBFieldDescription("Operated")]
		public decimal oprtim;

		/// <summary>
		/// Standby                         
		/// </summary>
		[SMBFieldName("stdtim")]
		[SMBFieldDescription("Standby")]
		public decimal stdtim;

		/// <summary>
		/// Idle                            
		/// </summary>
		[SMBFieldName("idltim")]
		[SMBFieldDescription("Idle")]
		public decimal idltim;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}