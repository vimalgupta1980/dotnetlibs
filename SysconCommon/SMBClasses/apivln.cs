using System;

namespace SMB.Tables {
	public class apivln : smbtable {
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
		/// Part#                           
		/// </summary>
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("prtdsc")]
		[SMBFieldDescription("Description")]
		public string prtdsc;

		/// <summary>
		/// Alpha Part#                     
		/// </summary>
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("linqty")]
		[SMBFieldDescription("Quantity")]
		public decimal linqty;

		/// <summary>
		/// Price                           
		/// </summary>
		[SMBFieldName("linprc")]
		[SMBFieldDescription("Price")]
		public decimal linprc;

		/// <summary>
		/// Total                           
		/// </summary>
		[SMBFieldName("extttl")]
		[SMBFieldDescription("Total")]
		public decimal extttl;

		/// <summary>
		/// Account                         
		/// </summary>
		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account")]
		public long actnum;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public long subact;

		/// <summary>
		/// Location                        
		/// </summary>
		[SMBFieldName("invloc")]
		[SMBFieldDescription("Location")]
		public long invloc;

		/// <summary>
		/// Part Serial#                    
		/// </summary>
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Part Serial#")]
		public string sernum;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Subcontract Line Reference #    
		/// </summary>
		[SMBFieldName("linref")]
		[SMBFieldDescription("Subcontract Line Reference #")]
		public string linref;

	}
}