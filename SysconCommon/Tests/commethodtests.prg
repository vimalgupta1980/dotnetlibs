mbdir = [q:\mb7\maiuri\]

syscon = CREATEOBJECT("Syscon.MasterBuilder")
? "Testing " + syscon.ToString()

CLOSE TABLES

syscon.SetMBDir(mbdir)
jobs = syscon.SelectJobsByGUI()

IF jobs != null THEN 
	? [Selected ] + ALLTRIM(STR(ALEN(jobs))) + [ jobs.]
ELSE
	? "No Jobs Selected."
ENDIF

* select the employees and their social security numbers
USE (mbdir + [employ]) SHARED IN 0
SELECT ALLTRIM(fstnme) + ' ' + ALLTRIM(lstnme) as name, socsec as socsec FROM employ INTO CURSOR employees

SELECT employees
BROWSE