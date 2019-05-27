<!--#include virtual="/scripts/connection.asp"-->
<%


icode = Request.queryString("remove")

Query = "Delete * from cart where id = '" & icode & "' "

Con.Execute Query

Con.Close

Set Con = Nothing

Response.Redirect "add.asp?item=0&id=" & Request.QueryString("id") & " "

Response.End

%>



<html>
<head><title>login page</title>
</head>
<body >

Item has been removed from your Cart..........

</body>
</html>