using System;

namespace SMB.Tables {
	public class invhst : smbtable {
		/// <summary>
		/// Record Number                   
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record Number")]
		public long recnum;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Part                            
		/// </summary>
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part")]
		public long prtnum;

		/// <summary>
		/// Location                        
		/// </summary>
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

		/// <summary>
		/// Trans Source                    
		/// </summary>
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Trans Source")]
		public long srcnum;

		/// <summary>
		/// Trans Record#                   
		/// </summary>
		[SMBFieldName("trnrec")]
		[SMBFieldDescription("Trans Record#")]
		public long trnrec;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		/// <summary>
		/// Trans Date                      
		/// </summary>
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Trans Date")]
		public DateTime trndte;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public long actprd;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		/// <summary>
		/// Price                           
		/// </summary>
		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Price")]
		public decimal prtprc;

		/// <summary>
		/// Total                           
		/// </summary>
		[SMBFieldName("extprc")]
		[SMBFieldDescription("Total")]
		public decimal extprc;

	}
}