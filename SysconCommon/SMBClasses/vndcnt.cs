using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class vndcnt : smbtable {
		/// <summary>
		/// Vendor#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Contact Name                    
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("cntnme")]
		[SMBFieldDescription("Contact Name")]
		public string cntnme;

		/// <summary>
		/// Job Title                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("jobttl")]
		[SMBFieldDescription("Job Title")]
		public string jobttl;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Extension                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("phnext")]
		[SMBFieldDescription("Extension")]
		public string phnext;

		/// <summary>
		/// Email                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		/// <summary>
		/// Cell Phone#                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell Phone#")]
		public string cllphn;

		/// <summary>
		/// Fax#                            
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		/// <summary>
		/// Other#                          
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("othphn")]
		[SMBFieldDescription("Other#")]
		public string othphn;

		/// <summary>
		/// Other Description               
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("othdsc")]
		[SMBFieldDescription("Other Description")]
		public string othdsc;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Line Reference                  
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("linref")]
		[SMBFieldDescription("Line Reference")]
		public string linref;

		/// <summary>
		/// Outllook ID                     
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("msolid")]
		[SMBFieldDescription("Outllook ID")]
		public string msolid;

	}
}