using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class acrinv : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Invoice#                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("invnum")]
		[SMBFieldDescription("Invoice#")]
		public string invnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Date")]
		public DateTime invdte;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Tax Dist                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax Dist")]
		public long taxdst;

		/// <summary>
		/// Client PO#                      
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("duedte")]
		[SMBFieldDescription("Due Date")]
		public DateTime duedte;

		/// <summary>
		/// Reference#                      
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("refnum")]
		[SMBFieldDescription("Reference#")]
		public string refnum;

		/// <summary>
		/// Disc Date                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("dscdte")]
		[SMBFieldDescription("Disc Date")]
		public DateTime dscdte;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("invtyp")]
		[SMBFieldDescription("Type")]
		public long invtyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Disc Avail                      
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Disc Avail")]
		public decimal dscavl;

		/// <summary>
		/// Retention                       
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// Paid                            
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid")]
		public decimal amtpad;

		/// <summary>
		/// Disc/Credit                     
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Disc/Credit")]
		public decimal dsctkn;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Total")]
		public decimal invttl;

		/// <summary>
		/// Balance                         
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("invbal")]
		[SMBFieldDescription("Balance")]
		public decimal invbal;

		/// <summary>
		/// Net Due                         
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("invnet")]
		[SMBFieldDescription("Net Due")]
		public decimal invnet;

		/// <summary>
		/// Taxable Total                   
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable Total")]
		public decimal taxabl;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Non-Tax                         
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("nontax")]
		[SMBFieldDescription("Non-Tax")]
		public decimal nontax;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Total Paid                      
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("ttlpad")]
		[SMBFieldDescription("Total Paid")]
		public decimal ttlpad;

		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}