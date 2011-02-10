using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class reqinf : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Client                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Attention                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("attion")]
		[SMBFieldDescription("Attention")]
		public string attion;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Division                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

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
		[SMBFieldName("subdte")]
		[SMBFieldDescription("Date")]
		public DateTime subdte;

		/// <summary>
		/// RFI #                           
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("rfinum")]
		[SMBFieldDescription("RFI #")]
		public string rfinum;

		/// <summary>
		/// RFI Type                        
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("rfityp")]
		[SMBFieldDescription("RFI Type")]
		public long rfityp;

		/// <summary>
		/// Required                        
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("reqdte")]
		[SMBFieldDescription("Required")]
		public DateTime reqdte;

		/// <summary>
		/// Request by                      
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("reqsby")]
		[SMBFieldDescription("Request by")]
		public long reqsby;

		/// <summary>
		/// Answered by                     
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("ansrby")]
		[SMBFieldDescription("Answered by")]
		public string ansrby;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Returned                        
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("retdte")]
		[SMBFieldDescription("Returned")]
		public DateTime retdte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Requested                       
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("reqinf")]
		[SMBFieldDescription("Requested")]
		public string _reqinf;

		/// <summary>
		/// Supplied                        
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("retinf")]
		[SMBFieldDescription("Supplied")]
		public string retinf;

		/// <summary>
		/// Entered                         
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Schedule Change                 
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("possch")]
		[SMBFieldDescription("Schedule Change")]
		public long possch;

		/// <summary>
		/// Change Order                    
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("poschg")]
		[SMBFieldDescription("Change Order")]
		public long poschg;

		/// <summary>
		/// Plan Change                     
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("plnchg")]
		[SMBFieldDescription("Plan Change")]
		public long plnchg;

		/// <summary>
		/// User Def Check 1                
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("usrck1")]
		[SMBFieldDescription("User Def Check 1")]
		public long usrck1;

		/// <summary>
		/// User Def Check 2                
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("usrck2")]
		[SMBFieldDescription("User Def Check 2")]
		public long usrck2;

		/// <summary>
		/// Address1                        
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address1")]
		public string addrs1;

		/// <summary>
		/// Address2                        
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}