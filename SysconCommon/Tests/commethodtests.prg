syscon = CREATEOBJECT("Syscon.MasterBuilder")
syscon.smartSelectSMBDirByGUI()
* syscon.SetSMBDir("q:\mb7\maiuri")

CLOSE TABLES

progInfo = syscon.GetProgramInfo()
? "Config File: " + progInfo.ConfigFile
? "SMB Directory: " + progInfo.SMBDir
? "Major Version: " + ALLTRIM(STR(progInfo.DataVersion.Major))
? "Minor Version: " + ALLTRIM(STR(progInfo.DataVersion.Minor))
? "Version String: " + ALLTRIM(progInfo.DataVersion.ToString())
? ""

USE (progInfo.SMBDir + "\employ.dbf") SHARED IN 0

SELECT * FROM employ INTO CURSOR employees READWRITE nofilter

IF progInfo.DataVersion.Major >= 17 THEN

	? "Unencrypting sensitive employee information..."
	
	* unencrypt the sensitive information
	UPDATE employees SET ;
		socsec = IIF(isblank(socsec), socsec, syscon.omDecryptEx(socsec)), ;
		actnum = IIF(isblank(actnum), actnum, syscon.omDecryptEx(actnum)), ;
		actnm2 = IIF(isblank(actnm2), actnm2, syscon.omDecryptEx(actnm2)), ;
		actnm3 = IIF(isblank(actnm3), actnm3, syscon.omDecryptEx(actnm3)), ;
		actnm4 = IIF(isblank(actnm4), actnm4, syscon.omDecryptEx(actnm4))
		
ENDIF

SELECT employees
BROWSE