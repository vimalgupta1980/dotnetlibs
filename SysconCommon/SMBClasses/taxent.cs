using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class taxent : smbtable {
		/// <summary>
		/// Tax Entity#                     
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Tax Entity#")]
		public long recnum;

		/// <summary>
		/// Entity Name                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("entnme")]
		[SMBFieldDescription("Entity Name")]
		public string entnme;

		/// <summary>
		/// Remit To                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("paynme")]
		[SMBFieldDescription("Remit To")]
		public string paynme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Tax Rate                        
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("taxrt1")]
		[SMBFieldDescription("Tax Rate")]
		public decimal taxrt1;

		/// <summary>
		/// Billing Limit                   
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("limit1")]
		[SMBFieldDescription("Billing Limit")]
		public decimal limit1;

		/// <summary>
		/// Limit Type                      
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("lmtyp1")]
		[SMBFieldDescription("Limit Type")]
		public long lmtyp1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}