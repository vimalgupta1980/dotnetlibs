using System;

namespace SMB.Tables {
	public class employ : smbtable {
        public override string ToString()
        {
            return fstnme.Trim() + " " + lstnme.Trim();
        }

		[SMBFieldName("recnum")]
		[SMBFieldDescription("Employee#")]
		public int recnum;

		[SMBFieldName("lstnme")]
		[SMBFieldDescription("Last Name")]
		public string lstnme;

		[SMBFieldName("fstnme")]
		[SMBFieldDescription("First Name")]
		public string fstnme;

		[SMBFieldName("midini")]
		[SMBFieldDescription("M.I.")]
		public string midini;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address")]
		public string addrs1;

		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
		public string addrs2;

		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		[SMBFieldName("pagnum")]
		[SMBFieldDescription("Pager#")]
		public string pagnum;

		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell#")]
		public string cllphn;

		[SMBFieldName("homnum")]
		[SMBFieldDescription("Home#")]
		public string homnum;

		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		[SMBFieldName("socsec")]
		[SMBFieldDescription("Soc Sec#")]
		public string socsec;

		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public int eqpnum;

		[SMBFieldName("dtebth")]
		[SMBFieldDescription("Birth Date")]
		public DateTime dtebth;

		[SMBFieldName("dtehre")]
		[SMBFieldDescription("Hire Date")]
		public DateTime dtehre;

		[SMBFieldName("dteina")]
		[SMBFieldDescription("Inactive")]
		public DateTime dteina;

		[SMBFieldName("lstrse")]
		[SMBFieldDescription("Last Raise")]
		public DateTime lstrse;

		[SMBFieldName("gender")]
		[SMBFieldDescription("Gender")]
		public int gender;

		[SMBFieldName("mrtsts")]
		[SMBFieldDescription("Marital")]
		public int mrtsts;

		[SMBFieldName("hertge")]
		[SMBFieldDescription("Heritage")]
		public int hertge;

		[SMBFieldName("paypst")]
		[SMBFieldDescription("Position")]
		public int paypst;

		[SMBFieldName("wrkcmp")]
		[SMBFieldDescription("Comp Code")]
		public int wrkcmp;

		[SMBFieldName("empcmp")]
		[SMBFieldDescription("Always Use Emp Comp Code")]
		public int empcmp;

		[SMBFieldName("crtrpt")]
		[SMBFieldDescription("No Certified Reporting")]
		public int crtrpt;

		[SMBFieldName("taxste")]
		[SMBFieldDescription("Tax State")]
		public string taxste;

		[SMBFieldName("payprd")]
		[SMBFieldDescription("Pay Period")]
		public int payprd;

		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public int paygrp;

		[SMBFieldName("payrt1")]
		[SMBFieldDescription("Standard Regular Rate")]
		public decimal payrt1;

		[SMBFieldName("payrt2")]
		[SMBFieldDescription("Standard Overtime Rate")]
		public decimal payrt2;

		[SMBFieldName("payrt3")]
		[SMBFieldDescription("Standard Premium Rate")]
		public decimal payrt3;

		[SMBFieldName("salary")]
		[SMBFieldDescription("Salary")]
		public decimal salary;

		[SMBFieldName("advdue")]
		[SMBFieldDescription("Advances Due")]
		public decimal advdue;

		[SMBFieldName("accsck")]
		[SMBFieldDescription("Accrued Sick")]
		public decimal accsck;

		[SMBFieldName("sckrte")]
		[SMBFieldDescription("Sick Rate")]
		public decimal sckrte;

		[SMBFieldName("sckmth")]
		[SMBFieldDescription("Sick Method")]
		public int sckmth;

		[SMBFieldName("accvac")]
		[SMBFieldDescription("Accrued Vacation")]
		public decimal accvac;

		[SMBFieldName("vacrte")]
		[SMBFieldDescription("Vacation Rate")]
		public decimal vacrte;

		[SMBFieldName("vacmth")]
		[SMBFieldDescription("Vacation Method")]
		public int vacmth;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("loctax")]
		[SMBFieldDescription("Payroll Locale")]
		public int loctax;

		[SMBFieldName("uninum")]
		[SMBFieldDescription("Union")]
		public int uninum;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("qt1grs")]
		[SMBFieldDescription("Qtr1 Gross")]
		public decimal qt1grs;

		[SMBFieldName("qt2grs")]
		[SMBFieldDescription("Qtr2 Gross")]
		public decimal qt2grs;

		[SMBFieldName("qt3grs")]
		[SMBFieldDescription("Qtr3 Gross")]
		public decimal qt3grs;

		[SMBFieldName("qt4grs")]
		[SMBFieldDescription("Qtr4 Gross")]
		public decimal qt4grs;

		[SMBFieldName("qt1fic")]
		[SMBFieldDescription("Qtr1 FICA Wge")]
		public decimal qt1fic;

		[SMBFieldName("qt2fic")]
		[SMBFieldDescription("Qtr2 FICA Wge")]
		public decimal qt2fic;

		[SMBFieldName("qt3fic")]
		[SMBFieldDescription("Qtr3 FICA Wge")]
		public decimal qt3fic;

		[SMBFieldName("qt4fic")]
		[SMBFieldDescription("Qtr4 FICA Wge")]
		public decimal qt4fic;

		[SMBFieldName("qt1med")]
		[SMBFieldDescription("Qtr1 Med Wge")]
		public decimal qt1med;

		[SMBFieldName("qt2med")]
		[SMBFieldDescription("Qtr2 Med Wge")]
		public decimal qt2med;

		[SMBFieldName("qt3med")]
		[SMBFieldDescription("Qtr3 Med Wge")]
		public decimal qt3med;

		[SMBFieldName("qt4med")]
		[SMBFieldDescription("Qtr4 Med Wge")]
		public decimal qt4med;

		[SMBFieldName("i9verf")]
		[SMBFieldDescription("I-9 Verification")]
		public int i9verf;

		[SMBFieldName("exmovr")]
		[SMBFieldDescription("Exempt from Overtime")]
		public int exmovr;

		[SMBFieldName("emptyp")]
		[SMBFieldDescription("Emp. Type")]
		public int emptyp;

		[SMBFieldName("comisn")]
		[SMBFieldDescription("Commission%")]
		public decimal comisn;

		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account Number")]
		public string actnum;

		[SMBFieldName("rtnmbr")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmbr;

		[SMBFieldName("prente")]
		[SMBFieldDescription("Prenote Status")]
		public int prente;

		[SMBFieldName("acttyp")]
		[SMBFieldDescription("Account Type")]
		public int acttyp;

		[SMBFieldName("depamt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal depamt;

		[SMBFieldName("actnm2")]
		[SMBFieldDescription("Account Number")]
		public string actnm2;

		[SMBFieldName("rtnmb2")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmb2;

		[SMBFieldName("prent2")]
		[SMBFieldDescription("Prenote Status")]
		public int prent2;

		[SMBFieldName("acttp2")]
		[SMBFieldDescription("Account Type")]
		public int acttp2;

		[SMBFieldName("dp2amt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal dp2amt;

		[SMBFieldName("actnm3")]
		[SMBFieldDescription("Account Number")]
		public string actnm3;

		[SMBFieldName("rtnmb3")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmb3;

		[SMBFieldName("prent3")]
		[SMBFieldDescription("Prenote Status")]
		public int prent3;

		[SMBFieldName("acttp3")]
		[SMBFieldDescription("Account Type")]
		public int acttp3;

		[SMBFieldName("dp3amt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal dp3amt;

		[SMBFieldName("actnm4")]
		[SMBFieldDescription("Account Number")]
		public string actnm4;

		[SMBFieldName("rtnmb4")]
		[SMBFieldDescription("R/T Number")]
		public string rtnmb4;

		[SMBFieldName("prent4")]
		[SMBFieldDescription("Prenote Status")]
		public int prent4;

		[SMBFieldName("acttp4")]
		[SMBFieldDescription("Account Type")]
		public int acttp4;

		[SMBFieldName("dp4amt")]
		[SMBFieldDescription("Deposit Amount")]
		public decimal dp4amt;

		[SMBFieldName("dirdep")]
		[SMBFieldDescription("Use Direct Deposit")]
		public int dirdep;

		[SMBFieldName("retchk")]
		[SMBFieldDescription("Mark \"Retirement Plan\" on W-2")]
		public int retchk;

		[SMBFieldName("fullst")]
		[SMBFieldDescription("Last, First, MI")]
		public string fullst;

		[SMBFieldName("fulfst")]
		[SMBFieldDescription("First, MI, Last")]
		public string fulfst;

		[SMBFieldName("rtetyp")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public int rtetyp;

		[SMBFieldName("rtetp2")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public int rtetp2;

		[SMBFieldName("rtetp3")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public int rtetp3;

		[SMBFieldName("rtetp4")]
		[SMBFieldDescription("Direct Dep. Rate Type")]
		public int rtetp4;

		[SMBFieldName("sckchk")]
		[SMBFieldDescription("Mark W2 Third-Party Sick Pay")]
		public int sckchk;

		[SMBFieldName("htglst")]
		[SMBFieldDescription("Heritage List Updated Flag")]
		public int htglst;

		[SMBFieldName("hiract")]
		[SMBFieldDescription("Eligible Under HIRE Act")]
		public int hiract;

	}
}