using System;

namespace SMB.Tables {
	public class srvloc : smbtable {
		/// <summary>
		/// Client#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client#")]
		public long recnum;

		/// <summary>
		/// Location#                       
		/// </summary>
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location#")]
		public long locnum;

		/// <summary>
		/// Name                            
		/// </summary>
		[SMBFieldName("locnme")]
		[SMBFieldDescription("Name")]
		public string locnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Contact                         
		/// </summary>
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

		/// <summary>
		/// Area                            
		/// </summary>
		[SMBFieldName("srvgeo")]
		[SMBFieldDescription("Area")]
		public long srvgeo;

		/// <summary>
		/// Map Locate                      
		/// </summary>
		[SMBFieldName("maploc")]
		[SMBFieldDescription("Map Locate")]
		public string maploc;

		/// <summary>
		/// Cross Street                    
		/// </summary>
		[SMBFieldName("crsstr")]
		[SMBFieldDescription("Cross Street")]
		public string crsstr;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

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