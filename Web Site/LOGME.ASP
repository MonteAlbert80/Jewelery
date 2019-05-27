<!--#include virtual="/scripts/connection.asp"-->
<%
dim logid,pwds


logid = trim(Request.form("lid"))
pwds = trim(Request.form("pass"))

Query = "select name from customer where id = '" & logid & "' and pwd = '" & pwds & "' "
Set RS = Con.Execute(Query)

if RS.EOF then
Response.Write "Wrong Login ID or Password"  
else
Response.Redirect "main.asp?id=" & logid & "" 
Response.End
end if

Con.Close

Set Con = Nothing

%>


<html>
<head><title>login page</title>
</head>
<body >

<form method="POST" action="main.asp?id=guest">
<input type="submit" value="Back To Main">
</form>

</body>
</html>