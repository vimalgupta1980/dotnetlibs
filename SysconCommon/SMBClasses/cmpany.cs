using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class cmpany : smbtable {
		/// <summary>
		/// Company Name                    
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("cmpnme")]
		[SMBFieldDescription("Company Name")]
		public string cmpnme;

		/// <summary>
		/// Company Address1                
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("cmpad1")]
		[SMBFieldDescription("Company Address1")]
		public string cmpad1;

		/// <summary>
		/// Company Address2                
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("cmpad2")]
		[SMBFieldDescription("Company Address2")]
		public string cmpad2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// License#                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

		/// <summary>
		/// Federal Tax Id#                 
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("fedtax")]
		[SMBFieldDescription("Federal Tax Id#")]
		public string fedtax;

		/// <summary>
		/// State Tax Id#                   
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("stetax")]
		[SMBFieldDescription("State Tax Id#")]
		public string stetax;

		/// <summary>
		/// Resale#                         
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("rslnum")]
		[SMBFieldDescription("Resale#")]
		public string rslnum;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Fax#                            
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Archive Folder                  
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("archiv")]
		[SMBFieldDescription("Archive Folder")]
		public string archiv;

		/// <summary>
		/// Email                           
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		/// <summary>
		/// Recur. Trans. Group             
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("rccgrp")]
		[SMBFieldDescription("Recur. Trans. Group")]
		public long rccgrp;

		/// <summary>
		/// Account#                        
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("bnkact")]
		[SMBFieldDescription("Account#")]
		public string bnkact;

		/// <summary>
		/// Routing#                        
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("rtnmbr")]
		[SMBFieldDescription("Routing#")]
		public string rtnmbr;

		/// <summary>
		/// Account Type                    
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("acttyp")]
		[SMBFieldDescription("Account Type")]
		public long acttyp;

		/// <summary>
		/// Last Batch#                     
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("lstbch")]
		[SMBFieldDescription("Last Batch#")]
		public long lstbch;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Company Database Version (old)  
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("vrsion")]
		[SMBFieldDescription("Company Database Version (old)")]
		public string vrsion;

		/// <summary>
		/// Include Optional Hard Return    
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("hrdrtn")]
		[SMBFieldDescription("Include Optional Hard Return")]
		public long hrdrtn;

		/// <summary>
		/// Include Company Debit Line      
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("cmpdbt")]
		[SMBFieldDescription("Include Company Debit Line")]
		public long cmpdbt;

		/// <summary>
		/// Include Optional \"9\" Fill       
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("filbch")]
		[SMBFieldDescription("Include Optional \"9\" Fill")]
		public long filbch;

		/// <summary>
		/// Email Server                    
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("emlsvr")]
		[SMBFieldDescription("Email Server")]
		public string emlsvr;

		/// <summary>
		/// Port #                          
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("svrprt")]
		[SMBFieldDescription("Port #")]
		public long svrprt;

		/// <summary>
		/// Phone Dial Out                  
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("dilout")]
		[SMBFieldDescription("Phone Dial Out")]
		public string dilout;

		/// <summary>
		/// Company Database Version        
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("vernum")]
		[SMBFieldDescription("Company Database Version")]
		public string vernum;

		/// <summary>
		/// Copy Company In Progress        
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("docopy")]
		[SMBFieldDescription("Copy Company In Progress")]
		public string docopy;

		/// <summary>
		/// Answered Dashboard Security     
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("dshbrd")]
		[SMBFieldDescription("Answered Dashboard Security")]
		public string dshbrd;

		/// <summary>
		/// Require Email  Authentication   
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("reqaut")]
		[SMBFieldDescription("Require Email  Authentication")]
		public long reqaut;

		/// <summary>
		/// Answered Number RFPs by Job     
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("rfpnum")]
		[SMBFieldDescription("Answered Number RFPs by Job")]
		public long rfpnum;

		/// <summary>
		/// Answered Number RFIs by Job     
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("rfinum")]
		[SMBFieldDescription("Answered Number RFIs by Job")]
		public long rfinum;

		/// <summary>
		/// Subcontract Record Cutoff       
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("ctcrec")]
		[SMBFieldDescription("Subcontract Record Cutoff")]
		public long ctcrec;

		/// <summary>
		/// Origin Bank Name                
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("orgbnk")]
		[SMBFieldDescription("Origin Bank Name")]
		public string orgbnk;

		/// <summary>
		/// Destination Bank Name           
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("dstbnk")]
		[SMBFieldDescription("Destination Bank Name")]
		public string dstbnk;

		/// <summary>
		/// Optional Bank Routing#          
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("optrtg")]
		[SMBFieldDescription("Optional Bank Routing#")]
		public string optrtg;

		/// <summary>
		/// ID Code Designator (ICD)        
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("idcode")]
		[SMBFieldDescription("ID Code Designator (ICD)")]
		public long idcode;

		/// <summary>
		/// ACH Origin Name option          
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("orgnme")]
		[SMBFieldDescription("ACH Origin Name option")]
		public long orgnme;

		/// <summary>
		/// ACH Destination Name option     
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("dstnme")]
		[SMBFieldDescription("ACH Destination Name option")]
		public long dstnme;

		/// <summary>
		/// ACH Origin Routing# option      
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("orgrtg")]
		[SMBFieldDescription("ACH Origin Routing# option")]
		public long orgrtg;

		/// <summary>
		/// ACH Destination Routing# option 
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("dstrtg")]
		[SMBFieldDescription("ACH Destination Routing# option")]
		public long dstrtg;

	}
}