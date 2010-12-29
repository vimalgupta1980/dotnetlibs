using System;

namespace SMB.Tables {
	public class reccln : smbtable {
		/// <summary>
		/// Client#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client#")]
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
		[SMBFieldName("clnnme")]
		[SMBFieldDescription("Long Name")]
		public string clnnme;

		/// <summary>
		/// Greeting                        
		/// </summary>
		[SMBFieldName("grting")]
		[SMBFieldDescription("Greeting")]
		public string grting;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
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
		/// Bill Address 1                  
		/// </summary>
		[SMBFieldName("bilad1")]
		[SMBFieldDescription("Bill Address 1")]
		public string bilad1;

		/// <summary>
		/// Bill Address 2                  
		/// </summary>
		[SMBFieldName("bilad2")]
		[SMBFieldDescription("Bill Address 2")]
		public string bilad2;

		/// <summary>
		/// Bill City                       
		/// </summary>
		[SMBFieldName("bilcty")]
		[SMBFieldDescription("Bill City")]
		public string bilcty;

		/// <summary>
		/// Bill State                      
		/// </summary>
		[SMBFieldName("bilste")]
		[SMBFieldDescription("Bill State")]
		public string bilste;

		/// <summary>
		/// Bill Zip                        
		/// </summary>
		[SMBFieldName("bilzip")]
		[SMBFieldDescription("Bill Zip")]
		public string bilzip;

		/// <summary>
		/// Ship Address 1                  
		/// </summary>
		[SMBFieldName("shpad1")]
		[SMBFieldDescription("Ship Address 1")]
		public string shpad1;

		/// <summary>
		/// Ship Address 2                  
		/// </summary>
		[SMBFieldName("shpad2")]
		[SMBFieldDescription("Ship Address 2")]
		public string shpad2;

		/// <summary>
		/// Ship City                       
		/// </summary>
		[SMBFieldName("shpcty")]
		[SMBFieldDescription("Ship City")]
		public string shpcty;

		/// <summary>
		/// Ship State                      
		/// </summary>
		[SMBFieldName("shpste")]
		[SMBFieldDescription("Ship State")]
		public string shpste;

		/// <summary>
		/// Ship Zip                        
		/// </summary>
		[SMBFieldName("shpzip")]
		[SMBFieldDescription("Ship Zip")]
		public string shpzip;

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
		/// User Def3                       
		/// </summary>
		[SMBFieldName("usrdf3")]
		[SMBFieldDescription("User Def3")]
		public string usrdf3;

		/// <summary>
		/// User Def4                       
		/// </summary>
		[SMBFieldName("usrdf4")]
		[SMBFieldDescription("User Def4")]
		public string usrdf4;

		/// <summary>
		/// User Def5                       
		/// </summary>
		[SMBFieldName("usrdf5")]
		[SMBFieldDescription("User Def5")]
		public string usrdf5;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf6")]
		[SMBFieldDescription("User Defined")]
		public long usrdf6;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf7")]
		[SMBFieldDescription("User Defined")]
		public long usrdf7;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf8")]
		[SMBFieldDescription("User Defined")]
		public long usrdf8;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf9")]
		[SMBFieldDescription("User Defined")]
		public long usrdf9;

		/// <summary>
		/// Contact 1                       
		/// </summary>
		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact 1")]
		public string contct;

		/// <summary>
		/// Contact 2                       
		/// </summary>
		[SMBFieldName("contc2")]
		[SMBFieldDescription("Contact 2")]
		public string contc2;

		/// <summary>
		/// Contact 3                       
		/// </summary>
		[SMBFieldName("contc3")]
		[SMBFieldDescription("Contact 3")]
		public string contc3;

		/// <summary>
		/// Contact 1 Desc.                 
		/// </summary>
		[SMBFieldName("cntds1")]
		[SMBFieldDescription("Contact 1 Desc.")]
		public string cntds1;

		/// <summary>
		/// Contact 2 Desc.                 
		/// </summary>
		[SMBFieldName("cntds2")]
		[SMBFieldDescription("Contact 2 Desc.")]
		public string cntds2;

		/// <summary>
		/// Contact 3 Desc.                 
		/// </summary>
		[SMBFieldName("cntds3")]
		[SMBFieldDescription("Contact 3 Desc.")]
		public string cntds3;

		/// <summary>
		/// Phone 1                         
		/// </summary>
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone 1")]
		public string phnnum;

		/// <summary>
		/// Phone 2                         
		/// </summary>
		[SMBFieldName("phn002")]
		[SMBFieldDescription("Phone 2")]
		public string phn002;

		/// <summary>
		/// Phone 3                         
		/// </summary>
		[SMBFieldName("phn003")]
		[SMBFieldDescription("Phone 3")]
		public string phn003;

		/// <summary>
		/// Phone Ext. 1                    
		/// </summary>
		[SMBFieldName("phnext")]
		[SMBFieldDescription("Phone Ext. 1")]
		public string phnext;

		/// <summary>
		/// Phone Ext. 2                    
		/// </summary>
		[SMBFieldName("phext2")]
		[SMBFieldDescription("Phone Ext. 2")]
		public string phext2;

		/// <summary>
		/// Phone Ext. 3                    
		/// </summary>
		[SMBFieldName("phext3")]
		[SMBFieldDescription("Phone Ext. 3")]
		public string phext3;

		/// <summary>
		/// Fax 1                           
		/// </summary>
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax 1")]
		public string faxnum;

		/// <summary>
		/// Fax 2                           
		/// </summary>
		[SMBFieldName("fax002")]
		[SMBFieldDescription("Fax 2")]
		public string fax002;

		/// <summary>
		/// Fax 3                           
		/// </summary>
		[SMBFieldName("fax003")]
		[SMBFieldDescription("Fax 3")]
		public string fax003;

		/// <summary>
		/// Cell 1                          
		/// </summary>
		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell 1")]
		public string cllphn;

		/// <summary>
		/// Cell 2                          
		/// </summary>
		[SMBFieldName("cell02")]
		[SMBFieldDescription("Cell 2")]
		public string cell02;

		/// <summary>
		/// Cell 3                          
		/// </summary>
		[SMBFieldName("cell03")]
		[SMBFieldDescription("Cell 3")]
		public string cell03;

		/// <summary>
		/// Pager 1                         
		/// </summary>
		[SMBFieldName("pagnum")]
		[SMBFieldDescription("Pager 1")]
		public string pagnum;

		/// <summary>
		/// Pager 2                         
		/// </summary>
		[SMBFieldName("pagr02")]
		[SMBFieldDescription("Pager 2")]
		public string pagr02;

		/// <summary>
		/// Pager 3                         
		/// </summary>
		[SMBFieldName("pagr03")]
		[SMBFieldDescription("Pager 3")]
		public string pagr03;

		/// <summary>
		/// Email 1                         
		/// </summary>
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email 1")]
		public string e_mail;

		/// <summary>
		/// Email 2                         
		/// </summary>
		[SMBFieldName("email2")]
		[SMBFieldDescription("Email 2")]
		public string email2;

		/// <summary>
		/// Email 3                         
		/// </summary>
		[SMBFieldName("email3")]
		[SMBFieldDescription("Email 3")]
		public string email3;

		/// <summary>
		/// Received                        
		/// </summary>
		[SMBFieldName("dtercv")]
		[SMBFieldDescription("Received")]
		public DateTime dtercv;

		/// <summary>
		/// Salesperson                     
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Salesperson")]
		public long empnum;

		/// <summary>
		/// Manager                         
		/// </summary>
		[SMBFieldName("mannum")]
		[SMBFieldDescription("Manager")]
		public long mannum;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Contact                         
		/// </summary>
		[SMBFieldName("lstctc")]
		[SMBFieldDescription("Contact")]
		public DateTime lstctc;

		/// <summary>
		/// Call Back                       
		/// </summary>
		[SMBFieldName("cllbck")]
		[SMBFieldDescription("Call Back")]
		public DateTime cllbck;

		/// <summary>
		/// Mail Piece                      
		/// </summary>
		[SMBFieldName("lstmal")]
		[SMBFieldDescription("Mail Piece")]
		public string lstmal;

		/// <summary>
		/// Date Mailed                     
		/// </summary>
		[SMBFieldName("lstdte")]
		[SMBFieldDescription("Date Mailed")]
		public DateTime lstdte;

		/// <summary>
		/// Purchase                        
		/// </summary>
		[SMBFieldName("pchdte")]
		[SMBFieldDescription("Purchase")]
		public DateTime pchdte;

		/// <summary>
		/// Reference                       
		/// </summary>
		[SMBFieldName("refdte")]
		[SMBFieldDescription("Reference")]
		public DateTime refdte;

		/// <summary>
		/// Product                         
		/// </summary>
		[SMBFieldName("prdnum")]
		[SMBFieldDescription("Product")]
		public long prdnum;

		/// <summary>
		/// Disc Rate                       
		/// </summary>
		[SMBFieldName("dscrte")]
		[SMBFieldDescription("Disc Rate")]
		public decimal dscrte;

		/// <summary>
		/// Finance                         
		/// </summary>
		[SMBFieldName("finrte")]
		[SMBFieldDescription("Finance")]
		public decimal finrte;

		/// <summary>
		/// Source                          
		/// </summary>
		[SMBFieldName("ledsrc")]
		[SMBFieldDescription("Source")]
		public long ledsrc;

		/// <summary>
		/// Type                            
		/// </summary>
		[SMBFieldName("clntyp")]
		[SMBFieldDescription("Type")]
		public long clntyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Mail List                       
		/// </summary>
		[SMBFieldName("mallst")]
		[SMBFieldDescription("Mail List")]
		public long mallst;

		/// <summary>
		/// Area                            
		/// </summary>
		[SMBFieldName("region")]
		[SMBFieldDescription("Area")]
		public long region;

		/// <summary>
		/// Size                            
		/// </summary>
		[SMBFieldName("cmpsze")]
		[SMBFieldDescription("Size")]
		public long cmpsze;

		/// <summary>
		/// Contract                        
		/// </summary>
		[SMBFieldName("srvcon")]
		[SMBFieldDescription("Contract")]
		public long srvcon;

		/// <summary>
		/// Expiration                      
		/// </summary>
		[SMBFieldName("srvexp")]
		[SMBFieldDescription("Expiration")]
		public DateTime srvexp;

		/// <summary>
		/// Discount                        
		/// </summary>
		[SMBFieldName("clndsc")]
		[SMBFieldDescription("Discount")]
		public decimal clndsc;

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
		/// Map Location                    
		/// </summary>
		[SMBFieldName("maploc")]
		[SMBFieldDescription("Map Location")]
		public string maploc;

		/// <summary>
		/// Cross Street                    
		/// </summary>
		[SMBFieldName("crsstr")]
		[SMBFieldDescription("Cross Street")]
		public string crsstr;

		/// <summary>
		/// Billing Basis                   
		/// </summary>
		[SMBFieldName("bilbas")]
		[SMBFieldDescription("Billing Basis")]
		public long bilbas;

		/// <summary>
		/// PO#                             
		/// </summary>
		[SMBFieldName("pchnum")]
		[SMBFieldDescription("PO#")]
		public string pchnum;

		/// <summary>
		/// Sales Tax Resale Exempt#        
		/// </summary>
		[SMBFieldName("exmnum")]
		[SMBFieldDescription("Sales Tax Resale Exempt#")]
		public string exmnum;

		/// <summary>
		/// Credit Card #                   
		/// </summary>
		[SMBFieldName("crdnum")]
		[SMBFieldDescription("Credit Card #")]
		public string crdnum;

		/// <summary>
		/// Expiration                      
		/// </summary>
		[SMBFieldName("expdte")]
		[SMBFieldDescription("Expiration")]
		public DateTime expdte;

		/// <summary>
		/// Cardholder Name                 
		/// </summary>
		[SMBFieldName("crdnme")]
		[SMBFieldDescription("Cardholder Name")]
		public string crdnme;

		/// <summary>
		/// Credit Card Type                
		/// </summary>
		[SMBFieldName("crdtyp")]
		[SMBFieldDescription("Credit Card Type")]
		public string crdtyp;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}