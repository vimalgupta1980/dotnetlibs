using System;

namespace SMB.Tables {
	public class tmemln : smbtable {
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
		/// Employee                        
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Pay Rate1                       
		/// </summary>
		[SMBFieldName("rate01")]
		[SMBFieldDescription("Pay Rate1")]
		public decimal rate01;

		/// <summary>
		/// Pay Rate2                       
		/// </summary>
		[SMBFieldName("rate02")]
		[SMBFieldDescription("Pay Rate2")]
		public decimal rate02;

		/// <summary>
		/// Pay Rate3                       
		/// </summary>
		[SMBFieldName("rate03")]
		[SMBFieldDescription("Pay Rate3")]
		public decimal rate03;

		/// <summary>
		/// Minimum Hrs                     
		/// </summary>
		[SMBFieldName("minhrs")]
		[SMBFieldDescription("Minimum Hrs")]
		public decimal minhrs;

	}
}