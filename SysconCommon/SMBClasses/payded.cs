using System;

namespace SMB.Tables {
	public class payded : smbtable {
		/// <summary>
		/// Calculation#                    
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Calculation#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("clcnme")]
		[SMBFieldDescription("Description")]
		public string clcnme;

		/// <summary>
		/// Default Rate                    
		/// </summary>
		[SMBFieldName("dftrte")]
		[SMBFieldDescription("Default Rate")]
		public decimal dftrte;

		/// <summary>
		/// Default Max                     
		/// </summary>
		[SMBFieldName("dftmax")]
		[SMBFieldDescription("Default Max")]
		public decimal dftmax;

		/// <summary>
		/// Job Acct                        
		/// </summary>
		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Job Acct")]
		public long dbtact;

		/// <summary>
		/// Shop Acct                       
		/// </summary>
		[SMBFieldName("dbtshp")]
		[SMBFieldDescription("Shop Acct")]
		public long dbtshp;

		/// <summary>
		/// Ovh  Acct                       
		/// </summary>
		[SMBFieldName("dbtovh")]
		[SMBFieldDescription("Ovh  Acct")]
		public long dbtovh;

		/// <summary>
		/// Admin Acct                      
		/// </summary>
		[SMBFieldName("dbtadm")]
		[SMBFieldDescription("Admin Acct")]
		public long dbtadm;

		/// <summary>
		/// Credit Acct                     
		/// </summary>
		[SMBFieldName("crdact")]
		[SMBFieldDescription("Credit Acct")]
		public long crdact;

		/// <summary>
		/// Credit Subaccount               
		/// </summary>
		[SMBFieldName("crdsub")]
		[SMBFieldDescription("Credit Subaccount")]
		public long crdsub;

		/// <summary>
		/// Tax State                       
		/// </summary>
		[SMBFieldName("taxste")]
		[SMBFieldDescription("Tax State")]
		public string taxste;

		/// <summary>
		/// Tax Locale                      
		/// </summary>
		[SMBFieldName("taxloc")]
		[SMBFieldDescription("Tax Locale")]
		public long taxloc;

		/// <summary>
		/// Tax Type                        
		/// </summary>
		[SMBFieldName("taxtyp")]
		[SMBFieldDescription("Tax Type")]
		public long taxtyp;

		/// <summary>
		/// Calc Type                       
		/// </summary>
		[SMBFieldName("clctyp")]
		[SMBFieldDescription("Calc Type")]
		public long clctyp;

		/// <summary>
		/// Calc Method                     
		/// </summary>
		[SMBFieldName("clcmth")]
		[SMBFieldDescription("Calc Method")]
		public long clcmth;

		/// <summary>
		/// Based On                        
		/// </summary>
		[SMBFieldName("bsdded")]
		[SMBFieldDescription("Based On")]
		public long bsdded;

		/// <summary>
		/// Max Type                        
		/// </summary>
		[SMBFieldName("maxtyp")]
		[SMBFieldDescription("Max Type")]
		public long maxtyp;

		/// <summary>
		/// Union                           
		/// </summary>
		[SMBFieldName("uninum")]
		[SMBFieldDescription("Union")]
		public long uninum;

		/// <summary>
		/// Benefit                         
		/// </summary>
		[SMBFieldName("bnftyp")]
		[SMBFieldDescription("Benefit")]
		public long bnftyp;

		/// <summary>
		/// SSC Tax                         
		/// </summary>
		[SMBFieldName("ssctax")]
		[SMBFieldDescription("SSC Tax")]
		public long ssctax;

		/// <summary>
		/// Med Tax                         
		/// </summary>
		[SMBFieldName("medcre")]
		[SMBFieldDescription("Med Tax")]
		public long medcre;

		/// <summary>
		/// Fed Tax                         
		/// </summary>
		[SMBFieldName("fedtax")]
		[SMBFieldDescription("Fed Tax")]
		public long fedtax;

		/// <summary>
		/// FUTA Tax                        
		/// </summary>
		[SMBFieldName("ftatax")]
		[SMBFieldDescription("FUTA Tax")]
		public long ftatax;

		/// <summary>
		/// State Tax                       
		/// </summary>
		[SMBFieldName("stetax")]
		[SMBFieldDescription("State Tax")]
		public long stetax;

		/// <summary>
		/// SUI Tax                         
		/// </summary>
		[SMBFieldName("steunp")]
		[SMBFieldDescription("SUI Tax")]
		public long steunp;

		/// <summary>
		/// SDI Tax                         
		/// </summary>
		[SMBFieldName("stedsb")]
		[SMBFieldDescription("SDI Tax")]
		public long stedsb;

		/// <summary>
		/// Wk Comp                         
		/// </summary>
		[SMBFieldName("wkrcmp")]
		[SMBFieldDescription("Wk Comp")]
		public long wkrcmp;

		/// <summary>
		/// Liability                       
		/// </summary>
		[SMBFieldName("libins")]
		[SMBFieldDescription("Liability")]
		public long libins;

		/// <summary>
		/// Local Tax                       
		/// </summary>
		[SMBFieldName("loctax")]
		[SMBFieldDescription("Local Tax")]
		public long loctax;

		/// <summary>
		/// Paygroup                        
		/// </summary>
		[SMBFieldName("benovr")]
		[SMBFieldDescription("Paygroup")]
		public long benovr;

		/// <summary>
		/// Display                         
		/// </summary>
		[SMBFieldName("dspchk")]
		[SMBFieldDescription("Display")]
		public long dspchk;

		/// <summary>
		/// Emp# for Cr Sub                 
		/// </summary>
		[SMBFieldName("empsub")]
		[SMBFieldDescription("Emp# for Cr Sub")]
		public long empsub;

		/// <summary>
		/// Exemption Amount                
		/// </summary>
		[SMBFieldName("exmdol")]
		[SMBFieldDescription("Exemption Amount")]
		public decimal exmdol;

		/// <summary>
		/// Additional Exemp.               
		/// </summary>
		[SMBFieldName("addexm")]
		[SMBFieldDescription("Additional Exemp.")]
		public decimal addexm;

		/// <summary>
		/// Default Active                  
		/// </summary>
		[SMBFieldName("dftact")]
		[SMBFieldDescription("Default Active")]
		public long dftact;

		/// <summary>
		/// Disposable Income               
		/// </summary>
		[SMBFieldName("dspinc")]
		[SMBFieldDescription("Disposable Income")]
		public long dspinc;

		/// <summary>
		/// W-2 Box                         
		/// </summary>
		[SMBFieldName("w2_box")]
		[SMBFieldDescription("W-2 Box")]
		public long w2_box;

		/// <summary>
		/// W-2 Code                        
		/// </summary>
		[SMBFieldName("w2_cde")]
		[SMBFieldDescription("W-2 Code")]
		public string w2_cde;

		/// <summary>
		/// Aatrix Tax Type                 
		/// </summary>
		[SMBFieldName("aatrix")]
		[SMBFieldDescription("Aatrix Tax Type")]
		public long aatrix;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}