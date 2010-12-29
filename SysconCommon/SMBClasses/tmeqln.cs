using System;

namespace SMB.Tables {
	public class tmeqln : smbtable {
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
		/// Equipment Type                  
		/// </summary>
		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Equipment Type")]
		public long eqptyp;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Operated                        
		/// </summary>
		[SMBFieldName("oprrte")]
		[SMBFieldDescription("Operated")]
		public decimal oprrte;

		/// <summary>
		/// Standby                         
		/// </summary>
		[SMBFieldName("stdrte")]
		[SMBFieldDescription("Standby")]
		public decimal stdrte;

		/// <summary>
		/// Idle                            
		/// </summary>
		[SMBFieldName("idlrte")]
		[SMBFieldDescription("Idle")]
		public decimal idlrte;

		/// <summary>
		/// Minimum Hrs                     
		/// </summary>
		[SMBFieldName("minhrs")]
		[SMBFieldDescription("Minimum Hrs")]
		public decimal minhrs;

	}
}