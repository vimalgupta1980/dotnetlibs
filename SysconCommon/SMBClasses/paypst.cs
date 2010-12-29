using System;

namespace SMB.Tables {
	public class paypst : smbtable {
		/// <summary>
		/// Position#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Position#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("pstnme")]
		[SMBFieldDescription("Description")]
		public string pstnme;

		/// <summary>
		/// Job Wages                       
		/// </summary>
		[SMBFieldName("jobact")]
		[SMBFieldDescription("Job Wages")]
		public long jobact;

		/// <summary>
		/// Equip/Shop Wages                
		/// </summary>
		[SMBFieldName("eqpact")]
		[SMBFieldDescription("Equip/Shop Wages")]
		public long eqpact;

		/// <summary>
		/// Other Wages                     
		/// </summary>
		[SMBFieldName("othact")]
		[SMBFieldDescription("Other Wages")]
		public long othact;

		/// <summary>
		/// Department                      
		/// </summary>
		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public long dptmnt;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}