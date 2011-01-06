using System;

namespace SMB.Tables {
	public partial class employ : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Employee#")]
		public long recnum;

		/// <summary>
		/// Last Name                       
		/// </summary>
		[SMBFieldName("lstnme")]
		[SMBFieldDescription("Last Name")]
		public string lstnme;

		/// <summary>
		/// First Name                      
		/// </summary>
		[SMBFieldName("fstnme")]
		[SMBFieldDescription("First Name")]
		public string fstnme;

		/// <summary>
		/// M.I.                            
		/// </summary>
		[SMBFieldName("midini")]
		[SMBFieldDescription("M.I.")]
		public string midini;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Address                         
		/// </summary>
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address")]
		public string addrs1;

		/// <summary>
		/// Address2                        
		/// </summary>
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Pager#                          
		/// </summary>
		[SMBFieldName("pagnum")]
		[SMBFieldDescription("Pager#")]
		public string pagnum;

		/// <summary>
		/// Fax#                            
		/// </summary>
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		/// <summary>
		/// Cell#                           
		/// </summary>
		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell#")]
		public string cllphn;

		/// <summary>
		/// Home#                           
		/// </summary>
		[SMBFieldName("homnum")]
		[SMBFieldDescription("Home#")]
		public string homnum;

		/// <summary>
		/// Email                           
		/// </summary>
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		/// <summary>
		/// Soc Sec#                        
		/// </summary>
		[SMBFieldName("socsec")]
		[SMBFieldDescription("Soc Sec#")]
		public string socsec;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Birth Date                      
		/// </summary>
		[SMBFieldName("dtebth")]
		[SMBFieldDescription("Birth Date")]
		public DateTime dtebth;

		/// <summary>
		/// Hire Date                       
		/// </summary>
		[SMBFieldName("dtehre")]
		[SMBFieldDescription("Hire Date")]
		public DateTime dtehre;

		/// <summary>
		/// Inactive                        
		/// </summary>
		[SMBFieldName("dteina")]
		[SMBFieldDescription("Inactive")]
		public DateTime dteina;

		/// <summary>
		/// Last Raise                      
		/// </summary>
		[SMBFieldName("lstrse")]
		[SMBFieldDescription("Last Raise")]
		public DateTime lstrse;

		/// <summary>
		/// Gender                          
		/// </summary>
		[SMBFieldName("gender")]
		[SMBFieldDescription("Gender")]
		public long gender;

		/// <summary>
		/// Marital                         
		/// </summary>
		[SMBFieldName("mrtsts")]
		[SMBFieldDescription("Marital")]
		public long mrtsts;

		/// <summary>
		/// Heritage                        
		/// </summary>
		[SMBFieldName("hertge")]
		[SMBFieldDescription("Heritage")]
		public long hertge;

		/// <summary>
		/// Position                        
		/// </summary>
		[SMBFieldName("paypst")]
		[SMBFieldDescription("Position")]
		public long paypst;

		/// <summary>
		/// Comp Code                       
		/// </summary>
		[SMBFieldName("wrkcmp")]
		[SMBFieldDescription("Comp Code")]
		public long wrkcmp;

		/// <summary>
		/// Always Use Emp Comp Code        
		/// </summary>
		[SMBFieldName("empcmp")]
		[SMBFieldDescription("Always Use Emp Comp Code")]
		public long empcmp;

		/// <summary>
		/// No Certified Reporting          
		/// </summary>
		[SMBFieldName("crtrpt")]
		[SMBFieldDescription("No Certified Reporting")]
		public long crtrpt;

		/// <summary>
		/// Tax State                       
		/// </summary>
		[SMBFieldName("taxste")]
		[SMBFieldDescription("Tax State")]
		public string taxste;

		/// <summary>
		/// Pay Period                      
		/// </summary>
		[SMBFieldName("payprd")]
		[SMBFieldDescription("Pay Period")]
		public long payprd;

		/// <summary>
		/// Paygroup                        
		/// </summary>
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public long paygrp;

		/// <summary>
		/// Standard Regular Rate           
		/// </summary>
		[SMBFieldName("payrt1")]
		[SMBFieldDescription("Standard Regular Rate")]
		public decimal payrt1;

		/// <summary>
		/// Standard Overtime Rate          
		/// </summary>
		[SMBFieldName("payrt2")]
		[SMBFieldDescription("Standard Overtime Rate")]
		public decimal payrt2;

		/// <summary>
		/// Standard Premium Rate           
		/// </summary>
		[SMBFieldName("payrt3")]
		[SMBFieldDescription("Standard Premium Rate")]
		public decimal payrt3;

		/// <summary>
		/// Salary                          
		/// </summary>
		[SMBFieldName("salary")]
		[SMBFieldDescription("Salary")]
		public decimal salary;

		/// <summary>
		/// Advances Due                    
		/// </summary>
		[SMBFieldName("advdue")]
		[SMBFieldDescription("Advances Due")]
		public decimal advdue;

		/// <summary>
		/// Accrued Sick                    
		/// </summary>
		[SMBFieldName("accsck")]
		[SMBFieldDescription("Accrued Sick")]
		public decimal accsck;

		/// <summary>
		/// Sick Rate                       
		/// </summary>
		[SMBFieldName("sckrte")]
		[SMBFieldDescription("Sick Rate")]
		public decimal sckrte;

		/// <summary>
		/// Sick Method                     
		/// </summary>
		[SMBFieldName("sckmth")]
		[SMBFieldDescription("Sick Method")]
		public long sckmth;

		/// <summary>
		/// Accrued Vacation                
		/// </summary>
		[SMBFieldName("accvac")]
		[SMBFieldDescription("Accrued Vacation")]
		public decimal accvac;

		/// <summary>
		/// Vacation Rate                   
		/// </summary>
		[SMBFieldName("vacrte")]
		[SMBFieldDescription("Vacation Rate")]
		public decimal vacrte;

		/// <summary>
		/// Vacation Method                 
		/// </summary>
		[SMBFieldName("vacmth")]
		[SMBFieldDescription("Vacation Method")]
		public long vacmth;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Payroll Locale                  
		/// </summary>
		[SMBFieldName("loctax")]
		[SMBFieldDescription("Payroll Locale")]
		public long loctax;

		/// <summary>
		/// Union                           
		/// </summary>
		[SMBFieldName("uninum")]
		[SMBFieldDescription("Union")]
		public long uninum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Qtr1 Gross                      
		/// </summary>
		[SMBFieldName("qt1grs")]
		[SMBFieldDescription("Qtr1 Gross")]
		public decimal qt1grs;

		/// <summary>
		/// Qtr2 Gross                      
		/// </summary>
		[SMBFieldName("qt2grs")]
		[SMBFieldDescription("Qtr2 Gross")]
		public decimal qt2grs;

		/// <summary>
		/// Qtr3 Gross                      
		/// </summary>
		[SMBFieldName("qt3grs")]
		[SMBFieldDescription("Qtr3 Gross")]
		public decimal qt3grs;

		/// <summary>
		/// Qtr4 Gross                      
		/// </summary>
		[SMBFieldName("qt4grs")]
		[SMBFieldDescription("Qtr4 Gross")]
		public decimal qt4grs;

		/// <summary>
		/// Qtr1 FICA Wge                   
		/// </summary>
		[SMBFieldName("qt1fic")]
		[SMBFieldDescription("Qtr1 FICA Wge")]
		public decimal qt1fic;

		/// <summary>
		/// Qtr2 FICA Wge                   
		/// </summary>
		[SMBFieldName("qt2fic")]
		[SMBFieldDescription("Qtr2 FICA Wge")]
		public decimal qt2fic;

		/// <summary>
		/// Qtr3 FICA Wge                   
		/// </summary>
		[SMBFieldName("qt3fic")]
		[SMBFieldDescription("Qtr3 FICA Wge")]
		public decimal qt3fic;

		/// <summary>
		/// Qtr4 FICA Wge                   
		/// </summary>
		[SMBFieldName("qt4fic")]
		[SMBFieldDescription("Qtr4 FICA Wge")]
		public decimal qt4fic;

		/// <summary>
		/// Qtr1 Med Wge                    
		/// </summary>
		[SMBFieldName("qt1med")]
		[SMBFieldDescription("Qtr1 Med Wge")]
		public decimal qt1med;

		/// <summary>
		/// Qtr2 Med Wge                    
		/// </summary>
		[SMBFieldName("qt2med")]
		[SMBFieldDescription("Qtr2 Med Wge")]
		public decimal qt2med;

		/// <summary>
		/// Qtr3 Med Wge                    
		/// </summary>
		[SMBFieldName("qt3med")]
		[SMBFieldDescription("Qtr3 Med Wge")]
		public decimal qt3med;

		/// <summary>
		/// Qtr4 Med Wge                    
		/// </summary>
		[SMBFieldName("qt4med")]
		[SMBFieldDescription("Qtr4 Med Wge")]
		public decimal qt4med;

		/// <summary>
		/// I-9 Verification                
		/// </summary>
		[SMBFieldName("i9verf")]
		[SMBFieldDescription("I-9 Verification")]
		public long i9verf;

		/// <summary>
		/// Exempt from Overtime            
		/// </summary>
		[SMBFieldName("exmovr")]
		[SMBFieldDescription("Exempt from Overtime")]
		public long exmovr;

		/// <summary>
		/// Emp. Type                       
		/// </summary>
		[SMBFieldName("emptyp")]
		[SMBFieldDescription("Emp. Type")]
		public long emptyp;

		/// <summary>
		/// Commission%                     
		/// </summary>
		[SMBFieldName("comisn")]
		[SMBFieldDescription("Commission%")]
		public decimal comisn;

		/// <summary>
		/// Account Number                  
		/// </summary>
		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account Number")]
		public string actnum;

		/// <summary>
		/// R/T Number                      
		/// </summary>
		[SMBFieldName("rtnmbr")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmbr;

		/// <summary>
		/// Prenote Status                  
		/// </summary>
		[SMBFieldName("prente")]
		[SMBFieldDescription("Prenote Status")]
		public long prente;

		/// <summary>
		/// Account Type                    
		/// </summary>
		[SMBFieldName("acttyp")]
		[SMBFieldDescription("Account Type")]
		public long acttyp;

		/// <summary>
		/// Deposit Amount                  
		/// </summary>
		[SMBFieldName("depamt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal depamt;

		/// <summary>
		/// Account Number                  
		/// </summary>
		[SMBFieldName("actnm2")]
		[SMBFieldDescription("Account Number")]
		public string actnm2;

		/// <summary>
		/// R/T Number                      
		/// </summary>
		[SMBFieldName("rtnmb2")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmb2;

		/// <summary>
		/// Prenote Status                  
		/// </summary>
		[SMBFieldName("prent2")]
		[SMBFieldDescription("Prenote Status")]
		public long prent2;

		/// <summary>
		/// Account Type                    
		/// </summary>
		[SMBFieldName("acttp2")]
		[SMBFieldDescription("Account Type")]
		public long acttp2;

		/// <summary>
		/// Deposit Amount                  
		/// </summary>
		[SMBFieldName("dp2amt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal dp2amt;

		/// <summary>
		/// Account Number                  
		/// </summary>
		[SMBFieldName("actnm3")]
		[SMBFieldDescription("Account Number")]
		public string actnm3;

		/// <summary>
		/// R/T Number                      
		/// </summary>
		[SMBFieldName("rtnmb3")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmb3;

		/// <summary>
		/// Prenote Status                  
		/// </summary>
		[SMBFieldName("prent3")]
		[SMBFieldDescription("Prenote Status")]
		public long prent3;

		/// <summary>
		/// Account Type                    
		/// </summary>
		[SMBFieldName("acttp3")]
		[SMBFieldDescription("Account Type")]
		public long acttp3;

		/// <summary>
		/// Deposit Amount                  
		/// </summary>
		[SMBFieldName("dp3amt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal dp3amt;

		/// <summary>
		/// Account Number                  
		/// </summary>
		[SMBFieldName("actnm4")]
		[SMBFieldDescription("Account Number")]
		public string actnm4;

		/// <summary>
		/// R/T Number                      
		/// </summary>
		[SMBFieldName("rtnmb4")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmb4;

		/// <summary>
		/// Prenote Status                  
		/// </summary>
		[SMBFieldName("prent4")]
		[SMBFieldDescription("Prenote Status")]
		public long prent4;

		/// <summary>
		/// Account Type                    
		/// </summary>
		[SMBFieldName("acttp4")]
		[SMBFieldDescription("Account Type")]
		public long acttp4;

		/// <summary>
		/// Deposit Amount                  
		/// </summary>
		[SMBFieldName("dp4amt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal dp4amt;

		/// <summary>
		/// Use Direct Deposit              
		/// </summary>
		[SMBFieldName("dirdep")]
		[SMBFieldDescription("Use Direct Deposit")]
		public long dirdep;

		/// <summary>
		/// Mark \"Retirement Plan\" on W-2   
		/// </summary>
		[SMBFieldName("retchk")]
		[SMBFieldDescription("Mark \"Retirement Plan\" on W-2")]
		public long retchk;

		/// <summary>
		/// Last, First, MI                 
		/// </summary>
		[SMBFieldName("fullst")]
		[SMBFieldDescription("Last, First, MI")]
		public string fullst;

		/// <summary>
		/// First, MI, Last                 
		/// </summary>
		[SMBFieldName("fulfst")]
		[SMBFieldDescription("First, MI, Last")]
		public string fulfst;

		/// <summary>
		/// Direct Dep. Rate Type           
		/// </summary>
		[SMBFieldName("rtetyp")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public long rtetyp;

		/// <summary>
		/// Direct Dep. Rate Type           
		/// </summary>
		[SMBFieldName("rtetp2")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public long rtetp2;

		/// <summary>
		/// Direct Dep. Rate Type           
		/// </summary>
		[SMBFieldName("rtetp3")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public long rtetp3;

		/// <summary>
		/// Direct Dep. Rate Type           
		/// </summary>
		[SMBFieldName("rtetp4")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public long rtetp4;

		/// <summary>
		/// Mark W2 Third-Party Sick Pay    
		/// </summary>
		[SMBFieldName("sckchk")]
		[SMBFieldDescription("Mark W2 Third-Party Sick Pay")]
		public long sckchk;

		/// <summary>
		/// Heritage List Updated Flag      
		/// </summary>
		[SMBFieldName("htglst")]
		[SMBFieldDescription("Heritage List Updated Flag")]
		public long htglst;

		/// <summary>
		/// Eligible Under HIRE Act         
		/// </summary>
		[SMBFieldName("hiract")]
		[SMBFieldDescription("Eligible Under HIRE Act")]
		public long hiract;

	}
}