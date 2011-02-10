using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class invhst : smbtable {
		/// <summary>
		/// Record Number                   
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record Number")]
		public long recnum;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Part                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part")]
		public long prtnum;

		/// <summary>
		/// Location                        
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

		/// <summary>
		/// Trans Source                    
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Trans Source")]
		public long srcnum;

		/// <summary>
		/// Trans Record#                   
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("trnrec")]
		[SMBFieldDescription("Trans Record#")]
		public long trnrec;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		/// <summary>
		/// Trans Date                      
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Trans Date")]
		public DateTime trndte;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public long actprd;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		/// <summary>
		/// Price                           
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Price")]
		public decimal prtprc;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("extprc")]
		[SMBFieldDescription("Total")]
		public decimal extprc;

	}
}