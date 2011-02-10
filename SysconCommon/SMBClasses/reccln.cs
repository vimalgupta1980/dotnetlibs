using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class reccln : smbtable {
		/// <summary>
		/// Client#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client#")]
		public long recnum;

		/// <summary>
		/// Short Name                      
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("shtnme")]
		[SMBFieldDescription("Short Name")]
		public string shtnme;

		/// <summary>
		/// Long Name                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("clnnme")]
		[SMBFieldDescription("Long Name")]
		public string clnnme;

		/// <summary>
		/// Greeting                        
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("grting")]
		[SMBFieldDescription("Greeting")]
		public string grting;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Bill Address 1                  
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("bilad1")]
		[SMBFieldDescription("Bill Address 1")]
		public string bilad1;

		/// <summary>
		/// Bill Address 2                  
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("bilad2")]
		[SMBFieldDescription("Bill Address 2")]
		public string bilad2;

		/// <summary>
		/// Bill City                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("bilcty")]
		[SMBFieldDescription("Bill City")]
		public string bilcty;

		/// <summary>
		/// Bill State                      
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("bilste")]
		[SMBFieldDescription("Bill State")]
		public string bilste;

		/// <summary>
		/// Bill Zip                        
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("bilzip")]
		[SMBFieldDescription("Bill Zip")]
		public string bilzip;

		/// <summary>
		/// Ship Address 1                  
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("shpad1")]
		[SMBFieldDescription("Ship Address 1")]
		public string shpad1;

		/// <summary>
		/// Ship Address 2                  
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("shpad2")]
		[SMBFieldDescription("Ship Address 2")]
		public string shpad2;

		/// <summary>
		/// Ship City                       
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("shpcty")]
		[SMBFieldDescription("Ship City")]
		public string shpcty;

		/// <summary>
		/// Ship State                      
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("shpste")]
		[SMBFieldDescription("Ship State")]
		public string shpste;

		/// <summary>
		/// Ship Zip                        
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("shpzip")]
		[SMBFieldDescription("Ship Zip")]
		public string shpzip;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// User Def3                       
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("usrdf3")]
		[SMBFieldDescription("User Def3")]
		public string usrdf3;

		/// <summary>
		/// User Def4                       
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("usrdf4")]
		[SMBFieldDescription("User Def4")]
		public string usrdf4;

		/// <summary>
		/// User Def5                       
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("usrdf5")]
		[SMBFieldDescription("User Def5")]
		public string usrdf5;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("usrdf6")]
		[SMBFieldDescription("User Defined")]
		public long usrdf6;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("usrdf7")]
		[SMBFieldDescription("User Defined")]
		public long usrdf7;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("usrdf8")]
		[SMBFieldDescription("User Defined")]
		public long usrdf8;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("usrdf9")]
		[SMBFieldDescription("User Defined")]
		public long usrdf9;

		/// <summary>
		/// Contact 1                       
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact 1")]
		public string contct;

		/// <summary>
		/// Contact 2                       
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("contc2")]
		[SMBFieldDescription("Contact 2")]
		public string contc2;

		/// <summary>
		/// Contact 3                       
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("contc3")]
		[SMBFieldDescription("Contact 3")]
		public string contc3;

		/// <summary>
		/// Contact 1 Desc.                 
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("cntds1")]
		[SMBFieldDescription("Contact 1 Desc.")]
		public string cntds1;

		/// <summary>
		/// Contact 2 Desc.                 
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("cntds2")]
		[SMBFieldDescription("Contact 2 Desc.")]
		public string cntds2;

		/// <summary>
		/// Contact 3 Desc.                 
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("cntds3")]
		[SMBFieldDescription("Contact 3 Desc.")]
		public string cntds3;

		/// <summary>
		/// Phone 1                         
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone 1")]
		public string phnnum;

		/// <summary>
		/// Phone 2                         
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("phn002")]
		[SMBFieldDescription("Phone 2")]
		public string phn002;

		/// <summary>
		/// Phone 3                         
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("phn003")]
		[SMBFieldDescription("Phone 3")]
		public string phn003;

		/// <summary>
		/// Phone Ext. 1                    
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("phnext")]
		[SMBFieldDescription("Phone Ext. 1")]
		public string phnext;

		/// <summary>
		/// Phone Ext. 2                    
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("phext2")]
		[SMBFieldDescription("Phone Ext. 2")]
		public string phext2;

		/// <summary>
		/// Phone Ext. 3                    
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("phext3")]
		[SMBFieldDescription("Phone Ext. 3")]
		public string phext3;

		/// <summary>
		/// Fax 1                           
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax 1")]
		public string faxnum;

		/// <summary>
		/// Fax 2                           
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("fax002")]
		[SMBFieldDescription("Fax 2")]
		public string fax002;

		/// <summary>
		/// Fax 3                           
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("fax003")]
		[SMBFieldDescription("Fax 3")]
		public string fax003;

		/// <summary>
		/// Cell 1                          
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell 1")]
		public string cllphn;

		/// <summary>
		/// Cell 2                          
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("cell02")]
		[SMBFieldDescription("Cell 2")]
		public string cell02;

		/// <summary>
		/// Cell 3                          
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("cell03")]
		[SMBFieldDescription("Cell 3")]
		public string cell03;

		/// <summary>
		/// Pager 1                         
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("pagnum")]
		[SMBFieldDescription("Pager 1")]
		public string pagnum;

		/// <summary>
		/// Pager 2                         
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("pagr02")]
		[SMBFieldDescription("Pager 2")]
		public string pagr02;

		/// <summary>
		/// Pager 3                         
		/// </summary>
		[ColumnOrder(490)]
		[SMBFieldName("pagr03")]
		[SMBFieldDescription("Pager 3")]
		public string pagr03;

		/// <summary>
		/// Email 1                         
		/// </summary>
		[ColumnOrder(500)]
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email 1")]
		public string e_mail;

		/// <summary>
		/// Email 2                         
		/// </summary>
		[ColumnOrder(510)]
		[SMBFieldName("email2")]
		[SMBFieldDescription("Email 2")]
		public string email2;

		/// <summary>
		/// Email 3                         
		/// </summary>
		[ColumnOrder(520)]
		[SMBFieldName("email3")]
		[SMBFieldDescription("Email 3")]
		public string email3;

		/// <summary>
		/// Received                        
		/// </summary>
		[ColumnOrder(530)]
		[SMBFieldName("dtercv")]
		[SMBFieldDescription("Received")]
		public DateTime dtercv;

		/// <summary>
		/// Salesperson                     
		/// </summary>
		[ColumnOrder(540)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Salesperson")]
		public long empnum;

		/// <summary>
		/// Manager                         
		/// </summary>
		[ColumnOrder(550)]
		[SMBFieldName("mannum")]
		[SMBFieldDescription("Manager")]
		public long mannum;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[ColumnOrder(560)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Contact                         
		/// </summary>
		[ColumnOrder(570)]
		[SMBFieldName("lstctc")]
		[SMBFieldDescription("Contact")]
		public DateTime lstctc;

		/// <summary>
		/// Call Back                       
		/// </summary>
		[ColumnOrder(580)]
		[SMBFieldName("cllbck")]
		[SMBFieldDescription("Call Back")]
		public DateTime cllbck;

		/// <summary>
		/// Mail Piece                      
		/// </summary>
		[ColumnOrder(590)]
		[SMBFieldName("lstmal")]
		[SMBFieldDescription("Mail Piece")]
		public string lstmal;

		/// <summary>
		/// Date Mailed                     
		/// </summary>
		[ColumnOrder(600)]
		[SMBFieldName("lstdte")]
		[SMBFieldDescription("Date Mailed")]
		public DateTime lstdte;

		/// <summary>
		/// Purchase                        
		/// </summary>
		[ColumnOrder(610)]
		[SMBFieldName("pchdte")]
		[SMBFieldDescription("Purchase")]
		public DateTime pchdte;

		/// <summary>
		/// Reference                       
		/// </summary>
		[ColumnOrder(620)]
		[SMBFieldName("refdte")]
		[SMBFieldDescription("Reference")]
		public DateTime refdte;

		/// <summary>
		/// Product                         
		/// </summary>
		[ColumnOrder(630)]
		[SMBFieldName("prdnum")]
		[SMBFieldDescription("Product")]
		public long prdnum;

		/// <summary>
		/// Disc Rate                       
		/// </summary>
		[ColumnOrder(640)]
		[SMBFieldName("dscrte")]
		[SMBFieldDescription("Disc Rate")]
		public decimal dscrte;

		/// <summary>
		/// Finance                         
		/// </summary>
		[ColumnOrder(650)]
		[SMBFieldName("finrte")]
		[SMBFieldDescription("Finance")]
		public decimal finrte;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(660)]
		[SMBFieldName("ledsrc")]
		[SMBFieldDescription("Source")]
		public long ledsrc;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(670)]
		[SMBFieldName("clntyp")]
		[SMBFieldDescription("Type")]
		public long clntyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(680)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Mail List                       
		/// </summary>
		[ColumnOrder(690)]
		[SMBFieldName("mallst")]
		[SMBFieldDescription("Mail List")]
		public long mallst;

		/// <summary>
		/// Area                            
		/// </summary>
		[ColumnOrder(700)]
		[SMBFieldName("region")]
		[SMBFieldDescription("Area")]
		public long region;

		/// <summary>
		/// Size                            
		/// </summary>
		[ColumnOrder(710)]
		[SMBFieldName("cmpsze")]
		[SMBFieldDescription("Size")]
		public long cmpsze;

		/// <summary>
		/// Contract                        
		/// </summary>
		[ColumnOrder(720)]
		[SMBFieldName("srvcon")]
		[SMBFieldDescription("Contract")]
		public long srvcon;

		/// <summary>
		/// Expiration                      
		/// </summary>
		[ColumnOrder(730)]
		[SMBFieldName("srvexp")]
		[SMBFieldDescription("Expiration")]
		public DateTime srvexp;

		/// <summary>
		/// Discount                        
		/// </summary>
		[ColumnOrder(740)]
		[SMBFieldName("clndsc")]
		[SMBFieldDescription("Discount")]
		public decimal clndsc;

		/// <summary>
		/// Beg Balance                     
		/// </summary>
		[ColumnOrder(750)]
		[SMBFieldName("begbal")]
		[SMBFieldDescription("Beg Balance")]
		public decimal begbal;

		/// <summary>
		/// End Balance                     
		/// </summary>
		[ColumnOrder(760)]
		[SMBFieldName("endbal")]
		[SMBFieldDescription("End Balance")]
		public decimal endbal;

		/// <summary>
		/// Map Location                    
		/// </summary>
		[ColumnOrder(770)]
		[SMBFieldName("maploc")]
		[SMBFieldDescription("Map Location")]
		public string maploc;

		/// <summary>
		/// Cross Street                    
		/// </summary>
		[ColumnOrder(780)]
		[SMBFieldName("crsstr")]
		[SMBFieldDescription("Cross Street")]
		public string crsstr;

		/// <summary>
		/// Billing Basis                   
		/// </summary>
		[ColumnOrder(790)]
		[SMBFieldName("bilbas")]
		[SMBFieldDescription("Billing Basis")]
		public long bilbas;

		/// <summary>
		/// PO#                             
		/// </summary>
		[ColumnOrder(800)]
		[SMBFieldName("pchnum")]
		[SMBFieldDescription("PO#")]
		public string pchnum;

		/// <summary>
		/// Sales Tax Resale Exempt#        
		/// </summary>
		[ColumnOrder(810)]
		[SMBFieldName("exmnum")]
		[SMBFieldDescription("Sales Tax Resale Exempt#")]
		public string exmnum;

		/// <summary>
		/// Credit Card #                   
		/// </summary>
		[ColumnOrder(820)]
		[SMBFieldName("crdnum")]
		[SMBFieldDescription("Credit Card #")]
		public string crdnum;

		/// <summary>
		/// Expiration                      
		/// </summary>
		[ColumnOrder(830)]
		[SMBFieldName("expdte")]
		[SMBFieldDescription("Expiration")]
		public DateTime expdte;

		/// <summary>
		/// Cardholder Name                 
		/// </summary>
		[ColumnOrder(840)]
		[SMBFieldName("crdnme")]
		[SMBFieldDescription("Cardholder Name")]
		public string crdnme;

		/// <summary>
		/// Credit Card Type                
		/// </summary>
		[ColumnOrder(850)]
		[SMBFieldName("crdtyp")]
		[SMBFieldDescription("Credit Card Type")]
		public string crdtyp;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(860)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}