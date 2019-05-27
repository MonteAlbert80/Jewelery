<%
Dim Con
Set Con = Server.CreateObject("ADODB.Connection")
Con.ConnectionString = "DSN=JewelerySQLDSN"
Con.Open
%>
