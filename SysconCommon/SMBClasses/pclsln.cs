using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class pclsln : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Item#                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("itemnu")]
		[SMBFieldDescription("Item#")]
		public string itemnu;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Location                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("locion")]
		[SMBFieldDescription("Location")]
		public string locion;

		/// <summary>
		/// Division                        
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Contact                         
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

		/// <summary>
		/// Discovered                      
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("dscdte")]
		[SMBFieldDescription("Discovered")]
		public DateTime dscdte;

		/// <summary>
		/// Notified                        
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("notdte")]
		[SMBFieldDescription("Notified")]
		public DateTime notdte;

		/// <summary>
		/// Scheduled                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Scheduled")]
		public DateTime schdte;

		/// <summary>
		/// Completed                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("cmpdte")]
		[SMBFieldDescription("Completed")]
		public DateTime cmpdte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Value                           
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("appval")]
		[SMBFieldDescription("Value")]
		public decimal appval;

		/// <summary>
		/// Bill To                         
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("billto")]
		[SMBFieldDescription("Bill To")]
		public long billto;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}