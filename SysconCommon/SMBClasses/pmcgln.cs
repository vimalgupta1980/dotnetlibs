using System;

namespace SMB.Tables {
	public class pmcgln : smbtable {
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
		/// Estimated                       
		/// </summary>
		[SMBFieldName("estamt")]
		[SMBFieldDescription("Estimated")]
		public decimal estamt;

		/// <summary>
		/// O/H Rate                        
		/// </summary>
		[SMBFieldName("ovhmrk")]
		[SMBFieldDescription("O/H Rate")]
		public decimal ovhmrk;

		/// <summary>
		/// Profit Rate                     
		/// </summary>
		[SMBFieldName("pftmrk")]
		[SMBFieldDescription("Profit Rate")]
		public decimal pftmrk;

		/// <summary>
		/// Requested                       
		/// </summary>
		[SMBFieldName("reqprc")]
		[SMBFieldDescription("Requested")]
		public decimal reqprc;

		/// <summary>
		/// Approved                        
		/// </summary>
		[SMBFieldName("aprprc")]
		[SMBFieldDescription("Approved")]
		public decimal aprprc;

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

	}
}