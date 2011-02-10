using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class eqprvw : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		/// <summary>
		/// Entered Date                    
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered Date")]
		public DateTime entdte;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public long actprd;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("eqpmnt")]
		[SMBFieldDescription("Equipment")]
		public long eqpmnt;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public long eqpunt;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Type")]
		public long eqptyp;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("eqpqty")]
		[SMBFieldDescription("Quantity")]
		public decimal eqpqty;

		/// <summary>
		/// Revenue                         
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("rvnamt")]
		[SMBFieldDescription("Revenue")]
		public decimal rvnamt;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

	}
}