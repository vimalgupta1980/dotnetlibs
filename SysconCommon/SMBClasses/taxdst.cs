using System;

namespace SMB.Tables {
	public class taxdst : smbtable {
		/// <summary>
		/// District#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("District#")]
		public long recnum;

		/// <summary>
		/// District Name                   
		/// </summary>
		[SMBFieldName("dstnme")]
		[SMBFieldDescription("District Name")]
		public string dstnme;

		/// <summary>
		/// Tax Entity 1                    
		/// </summary>
		[SMBFieldName("entty1")]
		[SMBFieldDescription("Tax Entity 1")]
		public long entty1;

		/// <summary>
		/// Tax Entity 2                    
		/// </summary>
		[SMBFieldName("entty2")]
		[SMBFieldDescription("Tax Entity 2")]
		public long entty2;

		/// <summary>
		/// Tax Entity 3                    
		/// </summary>
		[SMBFieldName("entty3")]
		[SMBFieldDescription("Tax Entity 3")]
		public long entty3;

		/// <summary>
		/// Tax Entity 4                    
		/// </summary>
		[SMBFieldName("entty4")]
		[SMBFieldDescription("Tax Entity 4")]
		public long entty4;

		/// <summary>
		/// Tax Entity 5                    
		/// </summary>
		[SMBFieldName("entty5")]
		[SMBFieldDescription("Tax Entity 5")]
		public long entty5;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}