using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class invalc : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Ticket#                         
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Ticket#")]
		public string trnnum;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Order#                          
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("cstord")]
		[SMBFieldDescription("Order#")]
		public string cstord;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("aprdte")]
		[SMBFieldDescription("Approved")]
		public DateTime aprdte;

		/// <summary>
		/// Delivered                       
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("deldte")]
		[SMBFieldDescription("Delivered")]
		public DateTime deldte;

		/// <summary>
		/// Invoiced                        
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Invoiced")]
		public DateTime invdte;

		/// <summary>
		/// Delivery Via                    
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("delvia")]
		[SMBFieldDescription("Delivery Via")]
		public string delvia;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}