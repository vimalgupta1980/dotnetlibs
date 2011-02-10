using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class pchord : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Order#                          
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("ordnum")]
		[SMBFieldDescription("Order#")]
		public string ordnum;

		/// <summary>
		/// Order Date                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("orddte")]
		[SMBFieldDescription("Order Date")]
		public DateTime orddte;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Attention                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("attion")]
		[SMBFieldDescription("Attention")]
		public string attion;

		/// <summary>
		/// Ordered by                      
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("odrdby")]
		[SMBFieldDescription("Ordered by")]
		public long odrdby;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("eqpmnt")]
		[SMBFieldDescription("Equipment")]
		public long eqpmnt;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Document #                      
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("docnum")]
		[SMBFieldDescription("Document #")]
		public string docnum;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("docsrc")]
		[SMBFieldDescription("Source")]
		public long docsrc;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Approved                        
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Scheduled                       
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Scheduled")]
		public DateTime schdte;

		/// <summary>
		/// Delivery                        
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("deldte")]
		[SMBFieldDescription("Delivery")]
		public DateTime deldte;

		/// <summary>
		/// Via                             
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("delvia")]
		[SMBFieldDescription("Via")]
		public string delvia;

		/// <summary>
		/// PO Type                         
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("ordtyp")]
		[SMBFieldDescription("PO Type")]
		public long ordtyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Received                        
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("rcvdte")]
		[SMBFieldDescription("Received")]
		public decimal rcvdte;

		/// <summary>
		/// Current                         
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("currnt")]
		[SMBFieldDescription("Current")]
		public decimal currnt;

		/// <summary>
		/// Canceled                        
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("cancel")]
		[SMBFieldDescription("Canceled")]
		public decimal cancel;

		/// <summary>
		/// Subtotal                        
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("subttl")]
		[SMBFieldDescription("Subtotal")]
		public decimal subttl;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("pchttl")]
		[SMBFieldDescription("Total")]
		public decimal pchttl;

		/// <summary>
		/// Balance                         
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("pchbal")]
		[SMBFieldDescription("Balance")]
		public decimal pchbal;

		/// <summary>
		/// Entered                         
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Task                            
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task")]
		public decimal tsknum;

		/// <summary>
		/// Issued Date                     
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("issdat")]
		[SMBFieldDescription("Issued Date")]
		public DateTime issdat;

		/// <summary>
		/// Issued Batch#                   
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("issbch")]
		[SMBFieldDescription("Issued Batch#")]
		public long issbch;

	}
}