using System;

namespace SMB.Tables {
	public class cmpany : smbtable {
		[SMBFieldName("cmpnme")]
		[SMBFieldDescription("Company Name")]
		public string cmpnme;

		[SMBFieldName("cmpad1")]
		[SMBFieldDescription("Company Address1")]
		public string cmpad1;

		[SMBFieldName("cmpad2")]
		[SMBFieldDescription("Company Address2")]
		public string cmpad2;

		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		[SMBFieldName("fedtax")]
		[SMBFieldDescription("Federal Tax Id#")]
		public string fedtax;

		[SMBFieldName("stetax")]
		[SMBFieldDescription("State Tax Id#")]
		public string stetax;

		[SMBFieldName("rslnum")]
		[SMBFieldDescription("Resale#")]
		public string rslnum;

		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("archiv")]
		[SMBFieldDescription("Archive Folder")]
		public string archiv;

		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		[SMBFieldName("rccgrp")]
		[SMBFieldDescription("Recur. Trans. Group")]
		public int rccgrp;

		[SMBFieldName("bnkact")]
		[SMBFieldDescription("Account#")]
		public string bnkact;

		[SMBFieldName("rtnmbr")]
		[SMBFieldDescription("Routing#")]
		public string rtnmbr;

		[SMBFieldName("acttyp")]
		[SMBFieldDescription("Account Type")]
		public int acttyp;

		[SMBFieldName("lstbch")]
		[SMBFieldDescription("Last Batch#")]
		public int lstbch;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("vrsion")]
		[SMBFieldDescription("Company Database Version (old)")]
		public string vrsion;

		[SMBFieldName("hrdrtn")]
		[SMBFieldDescription("Include Optional Hard Return")]
		public int hrdrtn;

		[SMBFieldName("cmpdbt")]
		[SMBFieldDescription("Include Company Debit Line")]
		public int cmpdbt;

		[SMBFieldName("filbch")]
		[SMBFieldDescription("Include Optional \"9\" Fill")]
		public int filbch;

		[SMBFieldName("emlsvr")]
		[SMBFieldDescription("Email Server")]
		public string emlsvr;

		[SMBFieldName("svrprt")]
		[SMBFieldDescription("Port #")]
		public int svrprt;

		[SMBFieldName("dilout")]
		[SMBFieldDescription("Phone Dial Out")]
		public string dilout;

		[SMBFieldName("vernum")]
		[SMBFieldDescription("Company Database Version")]
		public string vernum;

		[SMBFieldName("docopy")]
		[SMBFieldDescription("Copy Company In Progress")]
		public string docopy;

		[SMBFieldName("dshbrd")]
		[SMBFieldDescription("Answered Dashboard Security")]
		public string dshbrd;

		[SMBFieldName("reqaut")]
		[SMBFieldDescription("Require Email  Authentication")]
		public int reqaut;

		[SMBFieldName("rfpnum")]
		[SMBFieldDescription("Answered Number RFPs by Job")]
		public int rfpnum;

		[SMBFieldName("rfinum")]
		[SMBFieldDescription("Answered Number RFIs by Job")]
		public int rfinum;

		[SMBFieldName("ctcrec")]
		[SMBFieldDescription("Subcontract Record Cutoff")]
		public int ctcrec;

		[SMBFieldName("orgbnk")]
		[SMBFieldDescription("Origin Bank Name")]
		public string orgbnk;

		[SMBFieldName("dstbnk")]
		[SMBFieldDescription("Destination Bank Name")]
		public string dstbnk;

		[SMBFieldName("optrtg")]
		[SMBFieldDescription("Optional Bank Routing#")]
		public string optrtg;

		[SMBFieldName("idcode")]
		[SMBFieldDescription("ID Code Designator (ICD)")]
		public int idcode;

		[SMBFieldName("orgnme")]
		[SMBFieldDescription("ACH Origin Name option")]
		public int orgnme;

		[SMBFieldName("dstnme")]
		[SMBFieldDescription("ACH Destination Name option")]
		public int dstnme;

		[SMBFieldName("orgrtg")]
		[SMBFieldDescription("ACH Origin Routing# option")]
		public int orgrtg;

		[SMBFieldName("dstrtg")]
		[SMBFieldDescription("ACH Destination Routing# option")]
		public int dstrtg;

	}
}