using System;

namespace SMB.Tables {
	public class pclsln : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Item#                           
		/// </summary>
		[SMBFieldName("itemnu")]
		[SMBFieldDescription("Item#")]
		public string itemnu;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Location                        
		/// </summary>
		[SMBFieldName("locion")]
		[SMBFieldDescription("Location")]
		public string locion;

		/// <summary>
		/// Division                        
		/// </summary>
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Contact                         
		/// </summary>
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

		/// <summary>
		/// Discovered                      
		/// </summary>
		[SMBFieldName("dscdte")]
		[SMBFieldDescription("Discovered")]
		public DateTime dscdte;

		/// <summary>
		/// Notified                        
		/// </summary>
		[SMBFieldName("notdte")]
		[SMBFieldDescription("Notified")]
		public DateTime notdte;

		/// <summary>
		/// Scheduled                       
		/// </summary>
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Scheduled")]
		public DateTime schdte;

		/// <summary>
		/// Completed                       
		/// </summary>
		[SMBFieldName("cmpdte")]
		[SMBFieldDescription("Completed")]
		public DateTime cmpdte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Value                           
		/// </summary>
		[SMBFieldName("appval")]
		[SMBFieldDescription("Value")]
		public decimal appval;

		/// <summary>
		/// Bill To                         
		/// </summary>
		[SMBFieldName("billto")]
		[SMBFieldDescription("Bill To")]
		public long billto;

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