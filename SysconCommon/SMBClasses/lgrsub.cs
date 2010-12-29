using System;

namespace SMB.Tables {
	public class lgrsub : smbtable {
		/// <summary>
		/// Subaccount#                     
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Subaccount#")]
		public long recnum;

		/// <summary>
		/// Short Name                      
		/// </summary>
		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		/// <summary>
		/// Long Name                       
		/// </summary>
		[SMBFieldName("lngnme")]
		[SMBFieldDescription("Long Name")]
		public string lngnme;

		/// <summary>
		/// Control Acct                    
		/// </summary>
		[SMBFieldName("ctract")]
		[SMBFieldDescription("Control Acct")]
		public long ctract;

		/// <summary>
		/// Beg Balance                     
		/// </summary>
		[SMBFieldName("begbal")]
		[SMBFieldDescription("Beg Balance")]
		public decimal begbal;

		/// <summary>
		/// End Balance                     
		/// </summary>
		[SMBFieldName("endbal")]
		[SMBFieldDescription("End Balance")]
		public decimal endbal;

		/// <summary>
		/// Budget 1                        
		/// </summary>
		[SMBFieldName("actbd1")]
		[SMBFieldDescription("Budget 1")]
		public decimal actbd1;

		/// <summary>
		/// Budget 2                        
		/// </summary>
		[SMBFieldName("actbd2")]
		[SMBFieldDescription("Budget 2")]
		public decimal actbd2;

		/// <summary>
		/// Budget 3                        
		/// </summary>
		[SMBFieldName("actbd3")]
		[SMBFieldDescription("Budget 3")]
		public decimal actbd3;

		/// <summary>
		/// Budget 4                        
		/// </summary>
		[SMBFieldName("actbd4")]
		[SMBFieldDescription("Budget 4")]
		public decimal actbd4;

		/// <summary>
		/// Budget 5                        
		/// </summary>
		[SMBFieldName("actbd5")]
		[SMBFieldDescription("Budget 5")]
		public decimal actbd5;

		/// <summary>
		/// Budget 6                        
		/// </summary>
		[SMBFieldName("actbd6")]
		[SMBFieldDescription("Budget 6")]
		public decimal actbd6;

		/// <summary>
		/// Budget 7                        
		/// </summary>
		[SMBFieldName("actbd7")]
		[SMBFieldDescription("Budget 7")]
		public decimal actbd7;

		/// <summary>
		/// Budget 8                        
		/// </summary>
		[SMBFieldName("actbd8")]
		[SMBFieldDescription("Budget 8")]
		public decimal actbd8;

		/// <summary>
		/// Budget 9                        
		/// </summary>
		[SMBFieldName("actbd9")]
		[SMBFieldDescription("Budget 9")]
		public decimal actbd9;

		/// <summary>
		/// Budget 10                       
		/// </summary>
		[SMBFieldName("actb10")]
		[SMBFieldDescription("Budget 10")]
		public decimal actb10;

		/// <summary>
		/// Budget 11                       
		/// </summary>
		[SMBFieldName("actb11")]
		[SMBFieldDescription("Budget 11")]
		public decimal actb11;

		/// <summary>
		/// Budget 12                       
		/// </summary>
		[SMBFieldName("actb12")]
		[SMBFieldDescription("Budget 12")]
		public decimal actb12;

		/// <summary>
		/// LastYear 1                      
		/// </summary>
		[SMBFieldName("actyt1")]
		[SMBFieldDescription("LastYear 1")]
		public decimal actyt1;

		/// <summary>
		/// LastYear2                       
		/// </summary>
		[SMBFieldName("actyt2")]
		[SMBFieldDescription("LastYear2")]
		public decimal actyt2;

		/// <summary>
		/// Last Year 3                     
		/// </summary>
		[SMBFieldName("actyt3")]
		[SMBFieldDescription("Last Year 3")]
		public decimal actyt3;

		/// <summary>
		/// Last Year 4                     
		/// </summary>
		[SMBFieldName("actyt4")]
		[SMBFieldDescription("Last Year 4")]
		public decimal actyt4;

		/// <summary>
		/// Last Year 5                     
		/// </summary>
		[SMBFieldName("actyt5")]
		[SMBFieldDescription("Last Year 5")]
		public decimal actyt5;

		/// <summary>
		/// Last Year 6                     
		/// </summary>
		[SMBFieldName("actyt6")]
		[SMBFieldDescription("Last Year 6")]
		public decimal actyt6;

		/// <summary>
		/// Last Year 7                     
		/// </summary>
		[SMBFieldName("actyt7")]
		[SMBFieldDescription("Last Year 7")]
		public decimal actyt7;

		/// <summary>
		/// Last Year 8                     
		/// </summary>
		[SMBFieldName("actyt8")]
		[SMBFieldDescription("Last Year 8")]
		public decimal actyt8;

		/// <summary>
		/// Last Year 9                     
		/// </summary>
		[SMBFieldName("actyt9")]
		[SMBFieldDescription("Last Year 9")]
		public decimal actyt9;

		/// <summary>
		/// Last Year 10                    
		/// </summary>
		[SMBFieldName("acty10")]
		[SMBFieldDescription("Last Year 10")]
		public decimal acty10;

		/// <summary>
		/// Last Year 11                    
		/// </summary>
		[SMBFieldName("acty11")]
		[SMBFieldDescription("Last Year 11")]
		public decimal acty11;

		/// <summary>
		/// Last Year 12                    
		/// </summary>
		[SMBFieldName("acty12")]
		[SMBFieldDescription("Last Year 12")]
		public decimal acty12;

		/// <summary>
		/// Period 1                        
		/// </summary>
		[SMBFieldName("actpr1")]
		[SMBFieldDescription("Period 1")]
		public decimal actpr1;

		/// <summary>
		/// Period 2                        
		/// </summary>
		[SMBFieldName("actpr2")]
		[SMBFieldDescription("Period 2")]
		public decimal actpr2;

		/// <summary>
		/// Period 3                        
		/// </summary>
		[SMBFieldName("actpr3")]
		[SMBFieldDescription("Period 3")]
		public decimal actpr3;

		/// <summary>
		/// Period 4                        
		/// </summary>
		[SMBFieldName("actpr4")]
		[SMBFieldDescription("Period 4")]
		public decimal actpr4;

		/// <summary>
		/// Period 5                        
		/// </summary>
		[SMBFieldName("actpr5")]
		[SMBFieldDescription("Period 5")]
		public decimal actpr5;

		/// <summary>
		/// Period 6                        
		/// </summary>
		[SMBFieldName("actpr6")]
		[SMBFieldDescription("Period 6")]
		public decimal actpr6;

		/// <summary>
		/// Period 7                        
		/// </summary>
		[SMBFieldName("actpr7")]
		[SMBFieldDescription("Period 7")]
		public decimal actpr7;

		/// <summary>
		/// Period 8                        
		/// </summary>
		[SMBFieldName("actpr8")]
		[SMBFieldDescription("Period 8")]
		public decimal actpr8;

		/// <summary>
		/// Period 9                        
		/// </summary>
		[SMBFieldName("actpr9")]
		[SMBFieldDescription("Period 9")]
		public decimal actpr9;

		/// <summary>
		/// Period 10                       
		/// </summary>
		[SMBFieldName("actp10")]
		[SMBFieldDescription("Period 10")]
		public decimal actp10;

		/// <summary>
		/// Period 11                       
		/// </summary>
		[SMBFieldName("actp11")]
		[SMBFieldDescription("Period 11")]
		public decimal actp11;

		/// <summary>
		/// Period 12                       
		/// </summary>
		[SMBFieldName("actp12")]
		[SMBFieldDescription("Period 12")]
		public decimal actp12;

		/// <summary>
		/// Starting Balance                
		/// </summary>
		[SMBFieldName("strbal")]
		[SMBFieldDescription("Starting Balance")]
		public decimal strbal;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}