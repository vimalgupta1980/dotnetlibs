using System;

namespace SMB.Tables {
	public class cmpany : smbtable {
		/// <summary>
		/// Company Name                    
		/// </summary>
		[SMBFieldName("cmpnme")]
		[SMBFieldDescription("Company Name")]
		public string cmpnme;

		/// <summary>
		/// Company Address1                
		/// </summary>
		[SMBFieldName("cmpad1")]
		[SMBFieldDescription("Company Address1")]
		public string cmpad1;

		/// <summary>
		/// Company Address2                
		/// </summary>
		[SMBFieldName("cmpad2")]
		[SMBFieldDescription("Company Address2")]
		public string cmpad2;

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
		/// License#                        
		/// </summary>
		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		/// <summary>
		/// Federal Tax Id#                 
		/// </summary>
		[SMBFieldName("fedtax")]
		[SMBFieldDescription("Federal Tax Id#")]
		public string fedtax;

		/// <summary>
		/// State Tax Id#                   
		/// </summary>
		[SMBFieldName("stetax")]
		[SMBFieldDescription("State Tax Id#")]
		public string stetax;

		/// <summary>
		/// Resale#                         
		/// </summary>
		[SMBFieldName("rslnum")]
		[SMBFieldDescription("Resale#")]
		public string rslnum;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Fax#                            
		/// </summary>
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

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
		/// Archive Folder                  
		/// </summary>
		[SMBFieldName("archiv")]
		[SMBFieldDescription("Archive Folder")]
		public string archiv;

		/// <summary>
		/// Email                           
		/// </summary>
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		/// <summary>
		/// Recur. Trans. Group             
		/// </summary>
		[SMBFieldName("rccgrp")]
		[SMBFieldDescription("Recur. Trans. Group")]
		public long rccgrp;

		/// <summary>
		/// Account#                        
		/// </summary>
		[SMBFieldName("bnkact")]
		[SMBFieldDescription("Account#")]
		public string bnkact;

		/// <summary>
		/// Routing#                        
		/// </summary>
		[SMBFieldName("rtnmbr")]
		[SMBFieldDescription("Routing#")]
		public string rtnmbr;

		/// <summary>
		/// Account Type                    
		/// </summary>
		[SMBFieldName("acttyp")]
		[SMBFieldDescription("Account Type")]
		public long acttyp;

		/// <summary>
		/// Last Batch#                     
		/// </summary>
		[SMBFieldName("lstbch")]
		[SMBFieldDescription("Last Batch#")]
		public long lstbch;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Company Database Version (old)  
		/// </summary>
		[SMBFieldName("vrsion")]
		[SMBFieldDescription("Company Database Version (old)")]
		public string vrsion;

		/// <summary>
		/// Include Optional Hard Return    
		/// </summary>
		[SMBFieldName("hrdrtn")]
		[SMBFieldDescription("Include Optional Hard Return")]
		public long hrdrtn;

		/// <summary>
		/// Include Company Debit Line      
		/// </summary>
		[SMBFieldName("cmpdbt")]
		[SMBFieldDescription("Include Company Debit Line")]
		public long cmpdbt;

		/// <summary>
		/// Include Optional \"9\" Fill       
		/// </summary>
		[SMBFieldName("filbch")]
		[SMBFieldDescription("Include Optional \"9\" Fill")]
		public long filbch;

		/// <summary>
		/// Email Server                    
		/// </summary>
		[SMBFieldName("emlsvr")]
		[SMBFieldDescription("Email Server")]
		public string emlsvr;

		/// <summary>
		/// Port #                          
		/// </summary>
		[SMBFieldName("svrprt")]
		[SMBFieldDescription("Port #")]
		public long svrprt;

		/// <summary>
		/// Phone Dial Out                  
		/// </summary>
		[SMBFieldName("dilout")]
		[SMBFieldDescription("Phone Dial Out")]
		public string dilout;

		/// <summary>
		/// Company Database Version        
		/// </summary>
		[SMBFieldName("vernum")]
		[SMBFieldDescription("Company Database Version")]
		public string vernum;

		/// <summary>
		/// Copy Company In Progress        
		/// </summary>
		[SMBFieldName("docopy")]
		[SMBFieldDescription("Copy Company In Progress")]
		public string docopy;

		/// <summary>
		/// Answered Dashboard Security     
		/// </summary>
		[SMBFieldName("dshbrd")]
		[SMBFieldDescription("Answered Dashboard Security")]
		public string dshbrd;

		/// <summary>
		/// Require Email  Authentication   
		/// </summary>
		[SMBFieldName("reqaut")]
		[SMBFieldDescription("Require Email  Authentication")]
		public long reqaut;

		/// <summary>
		/// Answered Number RFPs by Job     
		/// </summary>
		[SMBFieldName("rfpnum")]
		[SMBFieldDescription("Answered Number RFPs by Job")]
		public long rfpnum;

		/// <summary>
		/// Answered Number RFIs by Job     
		/// </summary>
		[SMBFieldName("rfinum")]
		[SMBFieldDescription("Answered Number RFIs by Job")]
		public long rfinum;

		/// <summary>
		/// Subcontract Record Cutoff       
		/// </summary>
		[SMBFieldName("ctcrec")]
		[SMBFieldDescription("Subcontract Record Cutoff")]
		public long ctcrec;

		/// <summary>
		/// Origin Bank Name                
		/// </summary>
		[SMBFieldName("orgbnk")]
		[SMBFieldDescription("Origin Bank Name")]
		public string orgbnk;

		/// <summary>
		/// Destination Bank Name           
		/// </summary>
		[SMBFieldName("dstbnk")]
		[SMBFieldDescription("Destination Bank Name")]
		public string dstbnk;

		/// <summary>
		/// Optional Bank Routing#          
		/// </summary>
		[SMBFieldName("optrtg")]
		[SMBFieldDescription("Optional Bank Routing#")]
		public string optrtg;

		/// <summary>
		/// ID Code Designator (ICD)        
		/// </summary>
		[SMBFieldName("idcode")]
		[SMBFieldDescription("ID Code Designator (ICD)")]
		public long idcode;

		/// <summary>
		/// ACH Origin Name option          
		/// </summary>
		[SMBFieldName("orgnme")]
		[SMBFieldDescription("ACH Origin Name option")]
		public long orgnme;

		/// <summary>
		/// ACH Destination Name option     
		/// </summary>
		[SMBFieldName("dstnme")]
		[SMBFieldDescription("ACH Destination Name option")]
		public long dstnme;

		/// <summary>
		/// ACH Origin Routing# option      
		/// </summary>
		[SMBFieldName("orgrtg")]
		[SMBFieldDescription("ACH Origin Routing# option")]
		public long orgrtg;

		/// <summary>
		/// ACH Destination Routing# option 
		/// </summary>
		[SMBFieldName("dstrtg")]
		[SMBFieldDescription("ACH Destination Routing# option")]
		public long dstrtg;

	}
}