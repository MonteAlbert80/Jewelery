<html>
<head><title>login page</title>
</head>
<body >


<DIV Align = "Right">

<%if Request.QueryString("id") <> "guest" then
%>
<B>Personal</B>: &nbsp
<a href = "profile.asp?id=<%=Request.QueryString("id")%>">Profile</a>
&nbsp &nbsp 

<%end if%>

<a href = "add.asp?item=0&id=<%=Request.QueryString("id")%>"  >View Cart</a>

&nbsp &nbsp 

<%if Request.QueryString("id") <> "guest" then
%>
<a href = "main.asp?id=guest" target = "_top" >Log Out</a> 

<%end if%>

</DIV>


</body>
</html>