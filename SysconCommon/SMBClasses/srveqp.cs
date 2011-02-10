using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srveqp : smbtable {
		/// <summary>
		/// Client#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client#")]
		public long recnum;

		/// <summary>
		/// Equipment#                      
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment#")]
		public long eqpnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("eqpnme")]
		[SMBFieldDescription("Description")]
		public string eqpnme;

		/// <summary>
		/// Manufacturer                    
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("manfct")]
		[SMBFieldDescription("Manufacturer")]
		public string manfct;

		/// <summary>
		/// Man Part#                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("eqpmdl")]
		[SMBFieldDescription("Man Part#")]
		public string eqpmdl;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		/// <summary>
		/// Client Location                 
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Client Location")]
		public long locnum;

		/// <summary>
		/// Site Location                   
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("sitloc")]
		[SMBFieldDescription("Site Location")]
		public string sitloc;

		/// <summary>
		/// Installed Date                  
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("istdte")]
		[SMBFieldDescription("Installed Date")]
		public DateTime istdte;

		/// <summary>
		/// In Service Date                 
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("isvdte")]
		[SMBFieldDescription("In Service Date")]
		public DateTime isvdte;

		/// <summary>
		/// OEM Warranty Exp                
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("oemexp")]
		[SMBFieldDescription("OEM Warranty Exp")]
		public DateTime oemexp;

		/// <summary>
		/// Last Service                    
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("lstsrv")]
		[SMBFieldDescription("Last Service")]
		public DateTime lstsrv;

		/// <summary>
		/// Next Serv                       
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("nxtsrv")]
		[SMBFieldDescription("Next Serv")]
		public DateTime nxtsrv;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}