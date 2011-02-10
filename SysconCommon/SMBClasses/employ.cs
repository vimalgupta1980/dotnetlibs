using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class employ : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Employee#")]
		public long recnum;

		/// <summary>
		/// Last Name                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("lstnme")]
		[SMBFieldDescription("Last Name")]
		public string lstnme;

		/// <summary>
		/// First Name                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("fstnme")]
		[SMBFieldDescription("First Name")]
		public string fstnme;

		/// <summary>
		/// M.I.                            
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("midini")]
		[SMBFieldDescription("M.I.")]
		public string midini;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Address                         
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address")]
		public string addrs1;

		/// <summary>
		/// Address2                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Pager#                          
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("pagnum")]
		[SMBFieldDescription("Pager#")]
		public string pagnum;

		/// <summary>
		/// Fax#                            
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		/// <summary>
		/// Cell#                           
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell#")]
		public string cllphn;

		/// <summary>
		/// Home#                           
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("homnum")]
		[SMBFieldDescription("Home#")]
		public string homnum;

		/// <summary>
		/// Email                           
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		/// <summary>
		/// Soc Sec#                        
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("socsec")]
		[SMBFieldDescription("Soc Sec#")]
		public string socsec;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Birth Date                      
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("dtebth")]
		[SMBFieldDescription("Birth Date")]
		public DateTime dtebth;

		/// <summary>
		/// Hire Date                       
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("dtehre")]
		[SMBFieldDescription("Hire Date")]
		public DateTime dtehre;

		/// <summary>
		/// Inactive                        
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("dteina")]
		[SMBFieldDescription("Inactive")]
		public DateTime dteina;

		/// <summary>
		/// Last Raise                      
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("lstrse")]
		[SMBFieldDescription("Last Raise")]
		public DateTime lstrse;

		/// <summary>
		/// Gender                          
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("gender")]
		[SMBFieldDescription("Gender")]
		public long gender;

		/// <summary>
		/// Marital                         
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("mrtsts")]
		[SMBFieldDescription("Marital")]
		public long mrtsts;

		/// <summary>
		/// Heritage                        
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("hertge")]
		[SMBFieldDescription("Heritage")]
		public long hertge;

		/// <summary>
		/// Position                        
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("paypst")]
		[SMBFieldDescription("Position")]
		public long paypst;

		/// <summary>
		/// Comp Code                       
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("wrkcmp")]
		[SMBFieldDescription("Comp Code")]
		public long wrkcmp;

		/// <summary>
		/// Always Use Emp Comp Code        
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("empcmp")]
		[SMBFieldDescription("Always Use Emp Comp Code")]
		public long empcmp;

		/// <summary>
		/// No Certified Reporting          
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("crtrpt")]
		[SMBFieldDescription("No Certified Reporting")]
		public long crtrpt;

		/// <summary>
		/// Tax State                       
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("taxste")]
		[SMBFieldDescription("Tax State")]
		public string taxste;

		/// <summary>
		/// Pay Period                      
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("payprd")]
		[SMBFieldDescription("Pay Period")]
		public long payprd;

		/// <summary>
		/// Paygroup                        
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public long paygrp;

		/// <summary>
		/// Standard Regular Rate           
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("payrt1")]
		[SMBFieldDescription("Standard Regular Rate")]
		public decimal payrt1;

		/// <summary>
		/// Standard Overtime Rate          
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("payrt2")]
		[SMBFieldDescription("Standard Overtime Rate")]
		public decimal payrt2;

		/// <summary>
		/// Standard Premium Rate           
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("payrt3")]
		[SMBFieldDescription("Standard Premium Rate")]
		public decimal payrt3;

		/// <summary>
		/// Salary                          
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("salary")]
		[SMBFieldDescription("Salary")]
		public decimal salary;

		/// <summary>
		/// Advances Due                    
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("advdue")]
		[SMBFieldDescription("Advances Due")]
		public decimal advdue;

		/// <summary>
		/// Accrued Sick                    
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("accsck")]
		[SMBFieldDescription("Accrued Sick")]
		public decimal accsck;

		/// <summary>
		/// Sick Rate                       
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("sckrte")]
		[SMBFieldDescription("Sick Rate")]
		public decimal sckrte;

		/// <summary>
		/// Sick Method                     
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("sckmth")]
		[SMBFieldDescription("Sick Method")]
		public long sckmth;

		/// <summary>
		/// Accrued Vacation                
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("accvac")]
		[SMBFieldDescription("Accrued Vacation")]
		public decimal accvac;

		/// <summary>
		/// Vacation Rate                   
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("vacrte")]
		[SMBFieldDescription("Vacation Rate")]
		public decimal vacrte;

		/// <summary>
		/// Vacation Method                 
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("vacmth")]
		[SMBFieldDescription("Vacation Method")]
		public long vacmth;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Payroll Locale                  
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("loctax")]
		[SMBFieldDescription("Payroll Locale")]
		public long loctax;

		/// <summary>
		/// Union                           
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("uninum")]
		[SMBFieldDescription("Union")]
		public long uninum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Qtr1 Gross                      
		/// </summary>
		[ColumnOrder(490)]
		[SMBFieldName("qt1grs")]
		[SMBFieldDescription("Qtr1 Gross")]
		public decimal qt1grs;

		/// <summary>
		/// Qtr2 Gross                      
		/// </summary>
		[ColumnOrder(500)]
		[SMBFieldName("qt2grs")]
		[SMBFieldDescription("Qtr2 Gross")]
		public decimal qt2grs;

		/// <summary>
		/// Qtr3 Gross                      
		/// </summary>
		[ColumnOrder(510)]
		[SMBFieldName("qt3grs")]
		[SMBFieldDescription("Qtr3 Gross")]
		public decimal qt3grs;

		/// <summary>
		/// Qtr4 Gross                      
		/// </summary>
		[ColumnOrder(520)]
		[SMBFieldName("qt4grs")]
		[SMBFieldDescription("Qtr4 Gross")]
		public decimal qt4grs;

		/// <summary>
		/// Qtr1 FICA Wge                   
		/// </summary>
		[ColumnOrder(530)]
		[SMBFieldName("qt1fic")]
		[SMBFieldDescription("Qtr1 FICA Wge")]
		public decimal qt1fic;

		/// <summary>
		/// Qtr2 FICA Wge                   
		/// </summary>
		[ColumnOrder(540)]
		[SMBFieldName("qt2fic")]
		[SMBFieldDescription("Qtr2 FICA Wge")]
		public decimal qt2fic;

		/// <summary>
		/// Qtr3 FICA Wge                   
		/// </summary>
		[ColumnOrder(550)]
		[SMBFieldName("qt3fic")]
		[SMBFieldDescription("Qtr3 FICA Wge")]
		public decimal qt3fic;

		/// <summary>
		/// Qtr4 FICA Wge                   
		/// </summary>
		[ColumnOrder(560)]
		[SMBFieldName("qt4fic")]
		[SMBFieldDescription("Qtr4 FICA Wge")]
		public decimal qt4fic;

		/// <summary>
		/// Qtr1 Med Wge                    
		/// </summary>
		[ColumnOrder(570)]
		[SMBFieldName("qt1med")]
		[SMBFieldDescription("Qtr1 Med Wge")]
		public decimal qt1med;

		/// <summary>
		/// Qtr2 Med Wge                    
		/// </summary>
		[ColumnOrder(580)]
		[SMBFieldName("qt2med")]
		[SMBFieldDescription("Qtr2 Med Wge")]
		public decimal qt2med;

		/// <summary>
		/// Qtr3 Med Wge                    
		/// </summary>
		[ColumnOrder(590)]
		[SMBFieldName("qt3med")]
		[SMBFieldDescription("Qtr3 Med Wge")]
		public decimal qt3med;

		/// <summary>
		/// Qtr4 Med Wge                    
		/// </summary>
		[ColumnOrder(600)]
		[SMBFieldName("qt4med")]
		[SMBFieldDescription("Qtr4 Med Wge")]
		public decimal qt4med;

		/// <summary>
		/// I-9 Verification                
		/// </summary>
		[ColumnOrder(610)]
		[SMBFieldName("i9verf")]
		[SMBFieldDescription("I-9 Verification")]
		public long i9verf;

		/// <summary>
		/// Exempt from Overtime            
		/// </summary>
		[ColumnOrder(620)]
		[SMBFieldName("exmovr")]
		[SMBFieldDescription("Exempt from Overtime")]
		public long exmovr;

		/// <summary>
		/// Emp. Type                       
		/// </summary>
		[ColumnOrder(630)]
		[SMBFieldName("emptyp")]
		[SMBFieldDescription("Emp. Type")]
		public long emptyp;

		/// <summary>
		/// Commission%                     
		/// </summary>
		[ColumnOrder(640)]
		[SMBFieldName("comisn")]
		[SMBFieldDescription("Commission%")]
		public decimal comisn;

		/// <summary>
		/// Account Number                  
		/// </summary>
		[ColumnOrder(650)]
		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account Number")]
		public string actnum;

		/// <summary>
		/// R/T Number                      
		/// </summary>
		[ColumnOrder(660)]
		[SMBFieldName("rtnmbr")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmbr;

		/// <summary>
		/// Prenote Status                  
		/// </summary>
		[ColumnOrder(670)]
		[SMBFieldName("prente")]
		[SMBFieldDescription("Prenote Status")]
		public long prente;

		/// <summary>
		/// Account Type                    
		/// </summary>
		[ColumnOrder(680)]
		[SMBFieldName("acttyp")]
		[SMBFieldDescription("Account Type")]
		public long acttyp;

		/// <summary>
		/// Deposit Amount                  
		/// </summary>
		[ColumnOrder(690)]
		[SMBFieldName("depamt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal depamt;

		/// <summary>
		/// Account Number                  
		/// </summary>
		[ColumnOrder(700)]
		[SMBFieldName("actnm2")]
		[SMBFieldDescription("Account Number")]
		public string actnm2;

		/// <summary>
		/// R/T Number                      
		/// </summary>
		[ColumnOrder(710)]
		[SMBFieldName("rtnmb2")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmb2;

		/// <summary>
		/// Prenote Status                  
		/// </summary>
		[ColumnOrder(720)]
		[SMBFieldName("prent2")]
		[SMBFieldDescription("Prenote Status")]
		public long prent2;

		/// <summary>
		/// Account Type                    
		/// </summary>
		[ColumnOrder(730)]
		[SMBFieldName("acttp2")]
		[SMBFieldDescription("Account Type")]
		public long acttp2;

		/// <summary>
		/// Deposit Amount                  
		/// </summary>
		[ColumnOrder(740)]
		[SMBFieldName("dp2amt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal dp2amt;

		/// <summary>
		/// Account Number                  
		/// </summary>
		[ColumnOrder(750)]
		[SMBFieldName("actnm3")]
		[SMBFieldDescription("Account Number")]
		public string actnm3;

		/// <summary>
		/// R/T Number                      
		/// </summary>
		[ColumnOrder(760)]
		[SMBFieldName("rtnmb3")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmb3;

		/// <summary>
		/// Prenote Status                  
		/// </summary>
		[ColumnOrder(770)]
		[SMBFieldName("prent3")]
		[SMBFieldDescription("Prenote Status")]
		public long prent3;

		/// <summary>
		/// Account Type                    
		/// </summary>
		[ColumnOrder(780)]
		[SMBFieldName("acttp3")]
		[SMBFieldDescription("Account Type")]
		public long acttp3;

		/// <summary>
		/// Deposit Amount                  
		/// </summary>
		[ColumnOrder(790)]
		[SMBFieldName("dp3amt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal dp3amt;

		/// <summary>
		/// Account Number                  
		/// </summary>
		[ColumnOrder(800)]
		[SMBFieldName("actnm4")]
		[SMBFieldDescription("Account Number")]
		public string actnm4;

		/// <summary>
		/// R/T Number                      
		/// </summary>
		[ColumnOrder(810)]
		[SMBFieldName("rtnmb4")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmb4;

		/// <summary>
		/// Prenote Status                  
		/// </summary>
		[ColumnOrder(820)]
		[SMBFieldName("prent4")]
		[SMBFieldDescription("Prenote Status")]
		public long prent4;

		/// <summary>
		/// Account Type                    
		/// </summary>
		[ColumnOrder(830)]
		[SMBFieldName("acttp4")]
		[SMBFieldDescription("Account Type")]
		public long acttp4;

		/// <summary>
		/// Deposit Amount                  
		/// </summary>
		[ColumnOrder(840)]
		[SMBFieldName("dp4amt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal dp4amt;

		/// <summary>
		/// Use Direct Deposit              
		/// </summary>
		[ColumnOrder(850)]
		[SMBFieldName("dirdep")]
		[SMBFieldDescription("Use Direct Deposit")]
		public long dirdep;

		/// <summary>
		/// Mark \"Retirement Plan\" on W-2   
		/// </summary>
		[ColumnOrder(860)]
		[SMBFieldName("retchk")]
		[SMBFieldDescription("Mark \"Retirement Plan\" on W-2")]
		public long retchk;

		/// <summary>
		/// Last, First, MI                 
		/// </summary>
		[ColumnOrder(870)]
		[SMBFieldName("fullst")]
		[SMBFieldDescription("Last, First, MI")]
		public string fullst;

		/// <summary>
		/// First, MI, Last                 
		/// </summary>
		[ColumnOrder(880)]
		[SMBFieldName("fulfst")]
		[SMBFieldDescription("First, MI, Last")]
		public string fulfst;

		/// <summary>
		/// Direct Dep. Rate Type           
		/// </summary>
		[ColumnOrder(890)]
		[SMBFieldName("rtetyp")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public long rtetyp;

		/// <summary>
		/// Direct Dep. Rate Type           
		/// </summary>
		[ColumnOrder(900)]
		[SMBFieldName("rtetp2")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public long rtetp2;

		/// <summary>
		/// Direct Dep. Rate Type           
		/// </summary>
		[ColumnOrder(910)]
		[SMBFieldName("rtetp3")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public long rtetp3;

		/// <summary>
		/// Direct Dep. Rate Type           
		/// </summary>
		[ColumnOrder(920)]
		[SMBFieldName("rtetp4")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public long rtetp4;

		/// <summary>
		/// Mark W2 Third-Party Sick Pay    
		/// </summary>
		[ColumnOrder(930)]
		[SMBFieldName("sckchk")]
		[SMBFieldDescription("Mark W2 Third-Party Sick Pay")]
		public long sckchk;

		/// <summary>
		/// Heritage List Updated Flag      
		/// </summary>
		[ColumnOrder(940)]
		[SMBFieldName("htglst")]
		[SMBFieldDescription("Heritage List Updated Flag")]
		public long htglst;

		/// <summary>
		/// Eligible Under HIRE Act         
		/// </summary>
		[ColumnOrder(950)]
		[SMBFieldName("hiract")]
		[SMBFieldDescription("Eligible Under HIRE Act")]
		public long hiract;

	}
}