USE [c:\mb7\sample company\fldlib] SHARED AGAIN IN 0
SET SAFETY OFF

CREATE TABLE [Blank Tables\syscon_jobtyp] ( ;
	recnum n(3) NOT NULL UNIQUE, ;
	istimmat n(1) NOT NULL ;
)
	
CREATE TABLE [Blank Tables\syscon_cstcde] ( ;
	recnum n(15,3) NOT NULL UNIQUE, ;
	unbillable n(1) NOT NULL ;
)

CLOSE TABLES