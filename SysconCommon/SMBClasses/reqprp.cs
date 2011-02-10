using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class reqprp : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Request#                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("reqnum")]
		[SMBFieldDescription("Request#")]
		public string reqnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("reqdte")]
		[SMBFieldDescription("Date")]
		public DateTime reqdte;

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
		/// Request by                      
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Request by")]
		public long empnum;

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
		/// Description                     
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Approved                        
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Delivery                        
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("deldte")]
		[SMBFieldDescription("Delivery")]
		public DateTime deldte;

		/// <summary>
		/// Via                             
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("delvia")]
		[SMBFieldDescription("Via")]
		public string delvia;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("reqtyp")]
		[SMBFieldDescription("Type")]
		public long reqtyp;

		/// <summary>
		/// Address1                        
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address1")]
		public string addrs1;

		/// <summary>
		/// Address2                        
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Entered                         
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Subtotal                        
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("subttl")]
		[SMBFieldDescription("Subtotal")]
		public decimal subttl;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("reqttl")]
		[SMBFieldDescription("Total")]
		public decimal reqttl;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Prices Rec'd                    
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("prcrcv")]
		[SMBFieldDescription("Prices Rec'd")]
		public DateTime prcrcv;

		/// <summary>
		/// Prices Expire                   
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("prcexp")]
		[SMBFieldDescription("Prices Expire")]
		public DateTime prcexp;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}