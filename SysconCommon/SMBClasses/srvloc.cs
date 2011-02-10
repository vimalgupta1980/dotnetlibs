using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srvloc : smbtable {
		/// <summary>
		/// Client#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client#")]
		public long recnum;

		/// <summary>
		/// Location#                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location#")]
		public long locnum;

		/// <summary>
		/// Name                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("locnme")]
		[SMBFieldDescription("Name")]
		public string locnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Contact                         
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

		/// <summary>
		/// Area                            
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("srvgeo")]
		[SMBFieldDescription("Area")]
		public long srvgeo;

		/// <summary>
		/// Map Locate                      
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("maploc")]
		[SMBFieldDescription("Map Locate")]
		public string maploc;

		/// <summary>
		/// Cross Street                    
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("crsstr")]
		[SMBFieldDescription("Cross Street")]
		public string crsstr;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}