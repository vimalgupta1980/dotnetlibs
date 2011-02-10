using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class coresp : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Division                        
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Client                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Attention                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("attion")]
		[SMBFieldDescription("Attention")]
		public string attion;

		/// <summary>
		/// Address1                        
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address1")]
		public string addrs1;

		/// <summary>
		/// Address2                        
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("cortyp")]
		[SMBFieldDescription("Type")]
		public long cortyp;

		/// <summary>
		/// Sent                            
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("sntdte")]
		[SMBFieldDescription("Sent")]
		public DateTime sntdte;

		/// <summary>
		/// Received                        
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("recdte")]
		[SMBFieldDescription("Received")]
		public DateTime recdte;

		/// <summary>
		/// Sent by                         
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Sent by")]
		public long empnum;

		/// <summary>
		/// Sent Via                        
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("sntvia")]
		[SMBFieldDescription("Sent Via")]
		public string sntvia;

		/// <summary>
		/// Text                            
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("cortxt")]
		[SMBFieldDescription("Text")]
		public string cortxt;

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
		/// Hot List                        
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}