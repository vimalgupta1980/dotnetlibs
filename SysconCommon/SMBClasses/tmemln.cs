using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class tmemln : smbtable {
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
		/// Employee                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Pay Rate1                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("rate01")]
		[SMBFieldDescription("Pay Rate1")]
		public decimal rate01;

		/// <summary>
		/// Pay Rate2                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("rate02")]
		[SMBFieldDescription("Pay Rate2")]
		public decimal rate02;

		/// <summary>
		/// Pay Rate3                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("rate03")]
		[SMBFieldDescription("Pay Rate3")]
		public decimal rate03;

		/// <summary>
		/// Minimum Hrs                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("minhrs")]
		[SMBFieldDescription("Minimum Hrs")]
		public decimal minhrs;

	}
}