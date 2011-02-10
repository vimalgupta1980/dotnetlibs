using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class unprln : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Bid Item                        
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("biditm")]
		[SMBFieldDescription("Bid Item")]
		public long biditm;

		/// <summary>
		/// Item Code                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("numunt")]
		[SMBFieldDescription("Quantity")]
		public decimal numunt;

		/// <summary>
		/// Unit Price                      
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("cstunt")]
		[SMBFieldDescription("Unit Price")]
		public decimal cstunt;

		/// <summary>
		/// Total Price                     
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("ttlcst")]
		[SMBFieldDescription("Total Price")]
		public decimal ttlcst;

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

		/// <summary>
		/// Orig Quantity                   
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("untorg")]
		[SMBFieldDescription("Orig Quantity")]
		public decimal untorg;

		/// <summary>
		/// Orig Unit Price                 
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("cstorg")]
		[SMBFieldDescription("Orig Unit Price")]
		public decimal cstorg;

		/// <summary>
		/// Orig Total Price                
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("ttlorg")]
		[SMBFieldDescription("Orig Total Price")]
		public decimal ttlorg;

	}
}