using System;

namespace SMB.Tables {
	public class lgrsub : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Subaccount#")]
		public int recnum;

		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		[SMBFieldName("lngnme")]
		[SMBFieldDescription("Long Name")]
		public string lngnme;

		[SMBFieldName("ctract")]
		[SMBFieldDescription("Control Acct")]
		public int ctract;

		[SMBFieldName("begbal")]
		[SMBFieldDescription("Beg Balance")]
		public decimal begbal;

		[SMBFieldName("endbal")]
		[SMBFieldDescription("End Balance")]
		public decimal endbal;

		[SMBFieldName("actbd1")]
		[SMBFieldDescription("Budget 1")]
		public decimal actbd1;

		[SMBFieldName("actbd2")]
		[SMBFieldDescription("Budget 2")]
		public decimal actbd2;

		[SMBFieldName("actbd3")]
		[SMBFieldDescription("Budget 3")]
		public decimal actbd3;

		[SMBFieldName("actbd4")]
		[SMBFieldDescription("Budget 4")]
		public decimal actbd4;

		[SMBFieldName("actbd5")]
		[SMBFieldDescription("Budget 5")]
		public decimal actbd5;

		[SMBFieldName("actbd6")]
		[SMBFieldDescription("Budget 6")]
		public decimal actbd6;

		[SMBFieldName("actbd7")]
		[SMBFieldDescription("Budget 7")]
		public decimal actbd7;

		[SMBFieldName("actbd8")]
		[SMBFieldDescription("Budget 8")]
		public decimal actbd8;

		[SMBFieldName("actbd9")]
		[SMBFieldDescription("Budget 9")]
		public decimal actbd9;

		[SMBFieldName("actb10")]
		[SMBFieldDescription("Budget 10")]
		public decimal actb10;

		[SMBFieldName("actb11")]
		[SMBFieldDescription("Budget 11")]
		public decimal actb11;

		[SMBFieldName("actb12")]
		[SMBFieldDescription("Budget 12")]
		public decimal actb12;

		[SMBFieldName("actyt1")]
		[SMBFieldDescription("LastYear 1")]
		public decimal actyt1;

		[SMBFieldName("actyt2")]
		[SMBFieldDescription("LastYear2")]
		public decimal actyt2;

		[SMBFieldName("actyt3")]
		[SMBFieldDescription("Last Year 3")]
		public decimal actyt3;

		[SMBFieldName("actyt4")]
		[SMBFieldDescription("Last Year 4")]
		public decimal actyt4;

		[SMBFieldName("actyt5")]
		[SMBFieldDescription("Last Year 5")]
		public decimal actyt5;

		[SMBFieldName("actyt6")]
		[SMBFieldDescription("Last Year 6")]
		public decimal actyt6;

		[SMBFieldName("actyt7")]
		[SMBFieldDescription("Last Year 7")]
		public decimal actyt7;

		[SMBFieldName("actyt8")]
		[SMBFieldDescription("Last Year 8")]
		public decimal actyt8;

		[SMBFieldName("actyt9")]
		[SMBFieldDescription("Last Year 9")]
		public decimal actyt9;

		[SMBFieldName("acty10")]
		[SMBFieldDescription("Last Year 10")]
		public decimal acty10;

		[SMBFieldName("acty11")]
		[SMBFieldDescription("Last Year 11")]
		public decimal acty11;

		[SMBFieldName("acty12")]
		[SMBFieldDescription("Last Year 12")]
		public decimal acty12;

		[SMBFieldName("actpr1")]
		[SMBFieldDescription("Period 1")]
		public decimal actpr1;

		[SMBFieldName("actpr2")]
		[SMBFieldDescription("Period 2")]
		public decimal actpr2;

		[SMBFieldName("actpr3")]
		[SMBFieldDescription("Period 3")]
		public decimal actpr3;

		[SMBFieldName("actpr4")]
		[SMBFieldDescription("Period 4")]
		public decimal actpr4;

		[SMBFieldName("actpr5")]
		[SMBFieldDescription("Period 5")]
		public decimal actpr5;

		[SMBFieldName("actpr6")]
		[SMBFieldDescription("Period 6")]
		public decimal actpr6;

		[SMBFieldName("actpr7")]
		[SMBFieldDescription("Period 7")]
		public decimal actpr7;

		[SMBFieldName("actpr8")]
		[SMBFieldDescription("Period 8")]
		public decimal actpr8;

		[SMBFieldName("actpr9")]
		[SMBFieldDescription("Period 9")]
		public decimal actpr9;

		[SMBFieldName("actp10")]
		[SMBFieldDescription("Period 10")]
		public decimal actp10;

		[SMBFieldName("actp11")]
		[SMBFieldDescription("Period 11")]
		public decimal actp11;

		[SMBFieldName("actp12")]
		[SMBFieldDescription("Period 12")]
		public decimal actp12;

		[SMBFieldName("strbal")]
		[SMBFieldDescription("Starting Balance")]
		public decimal strbal;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}