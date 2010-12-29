using System;

namespace SMB.Tables {
	public class invtln : smbtable {
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
		/// Part                            
		/// </summary>
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part")]
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
		[SMBFieldName("invqty")]
		[SMBFieldDescription("Quantity")]
		public decimal invqty;

		/// <summary>
		/// Cost                            
		/// </summary>
		[SMBFieldName("invcst")]
		[SMBFieldDescription("Cost")]
		public decimal invcst;

		/// <summary>
		/// Total                           
		/// </summary>
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Total")]
		public decimal invttl;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[SMBFieldName("serial")]
		[SMBFieldDescription("Serial#")]
		public string serial;

		/// <summary>
		/// Source                          
		/// </summary>
		[SMBFieldName("invloc")]
		[SMBFieldDescription("Source")]
		public long invloc;

		/// <summary>
		/// Account                         
		/// </summary>
		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Account")]
		public long dbtact;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[SMBFieldName("dbtsub")]
		[SMBFieldDescription("Subaccount")]
		public long dbtsub;

		/// <summary>
		/// Destination                     
		/// </summary>
		[SMBFieldName("dstloc")]
		[SMBFieldDescription("Destination")]
		public long dstloc;

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