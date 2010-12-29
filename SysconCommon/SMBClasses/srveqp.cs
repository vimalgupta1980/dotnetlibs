using System;

namespace SMB.Tables {
	public class srveqp : smbtable {
		/// <summary>
		/// Client#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client#")]
		public long recnum;

		/// <summary>
		/// Equipment#                      
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment#")]
		public long eqpnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("eqpnme")]
		[SMBFieldDescription("Description")]
		public string eqpnme;

		/// <summary>
		/// Manufacturer                    
		/// </summary>
		[SMBFieldName("manfct")]
		[SMBFieldDescription("Manufacturer")]
		public string manfct;

		/// <summary>
		/// Man Part#                       
		/// </summary>
		[SMBFieldName("eqpmdl")]
		[SMBFieldDescription("Man Part#")]
		public string eqpmdl;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		/// <summary>
		/// Client Location                 
		/// </summary>
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Client Location")]
		public long locnum;

		/// <summary>
		/// Site Location                   
		/// </summary>
		[SMBFieldName("sitloc")]
		[SMBFieldDescription("Site Location")]
		public string sitloc;

		/// <summary>
		/// Installed Date                  
		/// </summary>
		[SMBFieldName("istdte")]
		[SMBFieldDescription("Installed Date")]
		public DateTime istdte;

		/// <summary>
		/// In Service Date                 
		/// </summary>
		[SMBFieldName("isvdte")]
		[SMBFieldDescription("In Service Date")]
		public DateTime isvdte;

		/// <summary>
		/// OEM Warranty Exp                
		/// </summary>
		[SMBFieldName("oemexp")]
		[SMBFieldDescription("OEM Warranty Exp")]
		public DateTime oemexp;

		/// <summary>
		/// Last Service                    
		/// </summary>
		[SMBFieldName("lstsrv")]
		[SMBFieldDescription("Last Service")]
		public DateTime lstsrv;

		/// <summary>
		/// Next Serv                       
		/// </summary>
		[SMBFieldName("nxtsrv")]
		[SMBFieldDescription("Next Serv")]
		public DateTime nxtsrv;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}