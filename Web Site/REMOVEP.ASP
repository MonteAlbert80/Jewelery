<!--#include virtual="/scripts/connection.asp"-->
<%

Query = "Delete * from post where number = " & Request.QueryString("it") & " "

Con.Execute Query

'Query2 = "Update post set (number = number-1) where number > " & Request.QueryString("it") & " " 
'Con.Execute Query2

'Response.Write Request.QueryString("id")

Response.Redirect "view.asp?id=" & Request.QueryString("id") & "&p=0"

Con.Close
Set Con=Nothing
%>

<html>
<head><title>login page</title>
</head>
<body >




</body>
</html>