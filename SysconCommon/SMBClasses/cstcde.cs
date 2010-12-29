using System;

namespace SMB.Tables {
	public class cstcde : smbtable {
		/// <summary>
		/// Cost Code#                      
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Cost Code#")]
		public decimal recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("cdenme")]
		[SMBFieldDescription("Description")]
		public string cdenme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Division                        
		/// </summary>
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

		/// <summary>
		/// Comp Code1                      
		/// </summary>
		[SMBFieldName("cmpcde")]
		[SMBFieldDescription("Comp Code1")]
		public long cmpcde;

		/// <summary>
		/// Wage Max                        
		/// </summary>
		[SMBFieldName("maxwge")]
		[SMBFieldDescription("Wage Max")]
		public decimal maxwge;

		/// <summary>
		/// Comp Code2                      
		/// </summary>
		[SMBFieldName("cmpcd2")]
		[SMBFieldDescription("Comp Code2")]
		public long cmpcd2;

		/// <summary>
		/// Department                      
		/// </summary>
		[SMBFieldName("dptnum")]
		[SMBFieldDescription("Department")]
		public long dptnum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}