using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class payded : smbtable {
		/// <summary>
		/// Calculation#                    
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Calculation#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("clcnme")]
		[SMBFieldDescription("Description")]
		public string clcnme;

		/// <summary>
		/// Default Rate                    
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dftrte")]
		[SMBFieldDescription("Default Rate")]
		public decimal dftrte;

		/// <summary>
		/// Default Max                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dftmax")]
		[SMBFieldDescription("Default Max")]
		public decimal dftmax;

		/// <summary>
		/// Job Acct                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Job Acct")]
		public long dbtact;

		/// <summary>
		/// Shop Acct                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dbtshp")]
		[SMBFieldDescription("Shop Acct")]
		public long dbtshp;

		/// <summary>
		/// Ovh  Acct                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("dbtovh")]
		[SMBFieldDescription("Ovh  Acct")]
		public long dbtovh;

		/// <summary>
		/// Admin Acct                      
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("dbtadm")]
		[SMBFieldDescription("Admin Acct")]
		public long dbtadm;

		/// <summary>
		/// Credit Acct                     
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("crdact")]
		[SMBFieldDescription("Credit Acct")]
		public long crdact;

		/// <summary>
		/// Credit Subaccount               
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("crdsub")]
		[SMBFieldDescription("Credit Subaccount")]
		public long crdsub;

		/// <summary>
		/// Tax State                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("taxste")]
		[SMBFieldDescription("Tax State")]
		public string taxste;

		/// <summary>
		/// Tax Locale                      
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("taxloc")]
		[SMBFieldDescription("Tax Locale")]
		public long taxloc;

		/// <summary>
		/// Tax Type                        
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("taxtyp")]
		[SMBFieldDescription("Tax Type")]
		public long taxtyp;

		/// <summary>
		/// Calc Type                       
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("clctyp")]
		[SMBFieldDescription("Calc Type")]
		public long clctyp;

		/// <summary>
		/// Calc Method                     
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("clcmth")]
		[SMBFieldDescription("Calc Method")]
		public long clcmth;

		/// <summary>
		/// Based On                        
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("bsdded")]
		[SMBFieldDescription("Based On")]
		public long bsdded;

		/// <summary>
		/// Max Type                        
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("maxtyp")]
		[SMBFieldDescription("Max Type")]
		public long maxtyp;

		/// <summary>
		/// Union                           
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("uninum")]
		[SMBFieldDescription("Union")]
		public long uninum;

		/// <summary>
		/// Benefit                         
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("bnftyp")]
		[SMBFieldDescription("Benefit")]
		public long bnftyp;

		/// <summary>
		/// SSC Tax                         
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("ssctax")]
		[SMBFieldDescription("SSC Tax")]
		public long ssctax;

		/// <summary>
		/// Med Tax                         
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("medcre")]
		[SMBFieldDescription("Med Tax")]
		public long medcre;

		/// <summary>
		/// Fed Tax                         
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("fedtax")]
		[SMBFieldDescription("Fed Tax")]
		public long fedtax;

		/// <summary>
		/// FUTA Tax                        
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("ftatax")]
		[SMBFieldDescription("FUTA Tax")]
		public long ftatax;

		/// <summary>
		/// State Tax                       
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("stetax")]
		[SMBFieldDescription("State Tax")]
		public long stetax;

		/// <summary>
		/// SUI Tax                         
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("steunp")]
		[SMBFieldDescription("SUI Tax")]
		public long steunp;

		/// <summary>
		/// SDI Tax                         
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("stedsb")]
		[SMBFieldDescription("SDI Tax")]
		public long stedsb;

		/// <summary>
		/// Wk Comp                         
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("wkrcmp")]
		[SMBFieldDescription("Wk Comp")]
		public long wkrcmp;

		/// <summary>
		/// Liability                       
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("libins")]
		[SMBFieldDescription("Liability")]
		public long libins;

		/// <summary>
		/// Local Tax                       
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("loctax")]
		[SMBFieldDescription("Local Tax")]
		public long loctax;

		/// <summary>
		/// Paygroup                        
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("benovr")]
		[SMBFieldDescription("Paygroup")]
		public long benovr;

		/// <summary>
		/// Display                         
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("dspchk")]
		[SMBFieldDescription("Display")]
		public long dspchk;

		/// <summary>
		/// Emp# for Cr Sub                 
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("empsub")]
		[SMBFieldDescription("Emp# for Cr Sub")]
		public long empsub;

		/// <summary>
		/// Exemption Amount                
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("exmdol")]
		[SMBFieldDescription("Exemption Amount")]
		public decimal exmdol;

		/// <summary>
		/// Additional Exemp.               
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("addexm")]
		[SMBFieldDescription("Additional Exemp.")]
		public decimal addexm;

		/// <summary>
		/// Default Active                  
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("dftact")]
		[SMBFieldDescription("Default Active")]
		public long dftact;

		/// <summary>
		/// Disposable Income               
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("dspinc")]
		[SMBFieldDescription("Disposable Income")]
		public long dspinc;

		/// <summary>
		/// W-2 Box                         
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("w2_box")]
		[SMBFieldDescription("W-2 Box")]
		public long w2_box;

		/// <summary>
		/// W-2 Code                        
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("w2_cde")]
		[SMBFieldDescription("W-2 Code")]
		public string w2_cde;

		/// <summary>
		/// Aatrix Tax Type                 
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("aatrix")]
		[SMBFieldDescription("Aatrix Tax Type")]
		public long aatrix;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}