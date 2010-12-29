using System;

namespace SMB.Tables {
	public class wkrcmp : smbtable {
		/// <summary>
		/// Code#                           
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Code#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("cdenme")]
		[SMBFieldDescription("Description")]
		public string cdenme;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("taxste")]
		[SMBFieldDescription("State")]
		public string taxste;

		/// <summary>
		/// Employer %                      
		/// </summary>
		[SMBFieldName("pctrte")]
		[SMBFieldDescription("Employer %")]
		public decimal pctrte;

		/// <summary>
		/// Employee Hrly                   
		/// </summary>
		[SMBFieldName("emehrs")]
		[SMBFieldDescription("Employee Hrly")]
		public decimal emehrs;

		/// <summary>
		/// Employer Hrly                   
		/// </summary>
		[SMBFieldName("emrhrs")]
		[SMBFieldDescription("Employer Hrly")]
		public decimal emrhrs;

		/// <summary>
		/// Liability                       
		/// </summary>
		[SMBFieldName("libins")]
		[SMBFieldDescription("Liability")]
		public decimal libins;

		/// <summary>
		/// Exper Mod                       
		/// </summary>
		[SMBFieldName("expmod")]
		[SMBFieldDescription("Exper Mod")]
		public decimal expmod;

		/// <summary>
		/// Add Exper Mod                   
		/// </summary>
		[SMBFieldName("addmod")]
		[SMBFieldDescription("Add Exper Mod")]
		public decimal addmod;

		/// <summary>
		/// Maximum Wage                    
		/// </summary>
		[SMBFieldName("maxwge")]
		[SMBFieldDescription("Maximum Wage")]
		public decimal maxwge;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}