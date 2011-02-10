using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class artxdt : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Tax Entity                      
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("taxent")]
		[SMBFieldDescription("Tax Entity")]
		public long taxent;

		/// <summary>
		/// Subject to Tax                  
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("sbjtax")]
		[SMBFieldDescription("Subject to Tax")]
		public decimal sbjtax;

		/// <summary>
		/// Tax Rate                        
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("taxrte")]
		[SMBFieldDescription("Tax Rate")]
		public decimal taxrte;

		/// <summary>
		/// Tax Amount                      
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("taxamt")]
		[SMBFieldDescription("Tax Amount")]
		public decimal taxamt;

	}
}