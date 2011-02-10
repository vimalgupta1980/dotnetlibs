using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class acpinv : smbtable {
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
		/// Order#                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Order#")]
		public string pchord;

		/// <summary>
		/// Contract#                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("ctcnum")]
		[SMBFieldDescription("Contract#")]
		public string ctcnum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Date")]
		public DateTime invdte;

		/// <summary>
		/// Due Date                        
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("duedte")]
		[SMBFieldDescription("Due Date")]
		public DateTime duedte;

		/// <summary>
		/// Reference#                      
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("refnum")]
		[SMBFieldDescription("Reference#")]
		public string refnum;

		/// <summary>
		/// Disc Date                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("dscdte")]
		[SMBFieldDescription("Disc Date")]
		public DateTime dscdte;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("invtyp")]
		[SMBFieldDescription("Type")]
		public long invtyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// 2nd Payee                       
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("payee2")]
		[SMBFieldDescription("2nd Payee")]
		public string payee2;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Discount                        
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("dscavl")]
		[SMBFieldDescription("Discount")]
		public decimal dscavl;

		/// <summary>
		/// Retention                       
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		/// <summary>
		/// Set to Pay                      
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("setpay")]
		[SMBFieldDescription("Set to Pay")]
		public decimal setpay;

		/// <summary>
		/// Paid                            
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("amtpad")]
		[SMBFieldDescription("Paid")]
		public decimal amtpad;

		/// <summary>
		/// Disc/Credit                     
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Disc/Credit")]
		public decimal dsctkn;

		/// <summary>
		/// Invoice Total                   
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		/// <summary>
		/// Variance                        
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("adjust")]
		[SMBFieldDescription("Variance")]
		public decimal adjust;

		/// <summary>
		/// Freight                         
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("freigh")]
		[SMBFieldDescription("Freight")]
		public decimal freigh;

		/// <summary>
		/// Total Paid                      
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("ttlpad")]
		[SMBFieldDescription("Total Paid")]
		public decimal ttlpad;

		/// <summary>
		/// Invoice Balance                 
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("invbal")]
		[SMBFieldDescription("Invoice Balance")]
		public decimal invbal;

		/// <summary>
		/// Invoice Net                     
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("invnet")]
		[SMBFieldDescription("Invoice Net")]
		public decimal invnet;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Batch#                          
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("btcnum")]
		[SMBFieldDescription("Batch#")]
		public long btcnum;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Shipping#                       
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("shpnum")]
		[SMBFieldDescription("Shipping#")]
		public string shpnum;

		/// <summary>
		/// Work Comp                       
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("cmpamt")]
		[SMBFieldDescription("Work Comp")]
		public decimal cmpamt;

		/// <summary>
		/// 'Use Tax' Rate                  
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("usetax")]
		[SMBFieldDescription("'Use Tax' Rate")]
		public decimal usetax;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}