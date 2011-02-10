using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class pmcgln : smbtable {
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
		/// Description                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Estimated                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("estamt")]
		[SMBFieldDescription("Estimated")]
		public decimal estamt;

		/// <summary>
		/// O/H Rate                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("ovhmrk")]
		[SMBFieldDescription("O/H Rate")]
		public decimal ovhmrk;

		/// <summary>
		/// Profit Rate                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("pftmrk")]
		[SMBFieldDescription("Profit Rate")]
		public decimal pftmrk;

		/// <summary>
		/// Requested                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("reqprc")]
		[SMBFieldDescription("Requested")]
		public decimal reqprc;

		/// <summary>
		/// Approved                        
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("aprprc")]
		[SMBFieldDescription("Approved")]
		public decimal aprprc;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}