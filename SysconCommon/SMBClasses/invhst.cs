using System;

namespace SMB.Tables {
	public class invhst : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record Number")]
		public int recnum;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public int lgrrec;

		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part")]
		public int prtnum;

		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public int locnum;

		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Trans Source")]
		public int srcnum;

		[SMBFieldName("trnrec")]
		[SMBFieldDescription("Trans Record#")]
		public int trnrec;

		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		[SMBFieldName("trndte")]
		[SMBFieldDescription("Trans Date")]
		public DateTime trndte;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public int actprd;

		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Price")]
		public decimal prtprc;

		[SMBFieldName("extprc")]
		[SMBFieldDescription("Total")]
		public decimal extprc;

	}
}