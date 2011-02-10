using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class invtln : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Part                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part")]
		public long prtnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("prtdsc")]
		[SMBFieldDescription("Description")]
		public string prtdsc;

		/// <summary>
		/// Alpha Part#                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("invqty")]
		[SMBFieldDescription("Quantity")]
		public decimal invqty;

		/// <summary>
		/// Cost                            
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("invcst")]
		[SMBFieldDescription("Cost")]
		public decimal invcst;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Total")]
		public decimal invttl;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("serial")]
		[SMBFieldDescription("Serial#")]
		public string serial;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("invloc")]
		[SMBFieldDescription("Source")]
		public long invloc;

		/// <summary>
		/// Account                         
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Account")]
		public long dbtact;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("dbtsub")]
		[SMBFieldDescription("Subaccount")]
		public long dbtsub;

		/// <summary>
		/// Destination                     
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("dstloc")]
		[SMBFieldDescription("Destination")]
		public long dstloc;

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