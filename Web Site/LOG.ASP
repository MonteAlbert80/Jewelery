<%@ LANGUAGE="VbScript"%>

<html>
<head><title>try</title></head>
<body link = "Blue" Alink = "Brown" Vlink = "Green" >


<% if Request.QueryString("id") = "guest" then   %>

<form method = "POST" action = "logme.asp" name = "login"  target = "_top">


<a href = "signup.asp" target = "mainp">sign me up </a>
<BR>
 
<B>Login Id   </B>    &nbsp;

<input type ="text"  name = "lid" size = "10">

<BR> 

<B>Password</B>    

<input type ="password" name = "pass" size = "10">


 &nbsp;

<input type = "submit" value = "submit" name = "b">  

</form>

<%else%>

<B> Welcome <%=Request.QueryString("id")%>

<BR>
<a href = "main.asp?id=guest" target = "_top">Log Out</a>
<BR>


<form name = "check_status" method = "POST" target = "mainp"  action = "status.asp?id=<%=Request.QueryString("id")%>">
Order Number:
<input type = "Text" name = "order" size = "7">
<input type = "SUBMIT" value = "Status">
</FORM>

<BR>

<%end if%>

<div align = "center">

<B> Category: </B> <br>

<!--#include virtual="/scripts/connection.asp"--><% 

sid = Request.QueryString("id")


'Query = "SELECT category from item"

Query = "SELECT name from category"

set RS = Con.Execute(Query)

While Not RS.EOF
%>

<a href = "display.asp?cat=<%=Server.URLEncode(RS("name"))%>&id=<%=sid%>"  target = "mainp">
<%= RS("name")%> </a>

<BR>

<%
RS.MoveNext
WEND

RS.Close
Set RS=Nothing
%>


<BR><BR>

<B>Other Features:</B>

<BR>

<a href = "post.asp?id=<%=Request.QueryString("id")%>" target = "mainp">
Post your Item(s)
</a>

<BR>

<a href = "view.asp?id=<%=Request.QueryString("id")%>&p=0" target = "mainp">
View Posted Item(s)
</a>

<%
Quer = "SELECT * from rlink"

set RS = Con.Execute(Quer)

if not RS.EOF then
%>

<B>
<BR><BR>
Related Links:<BR>


<%
While Not RS.EOF
%>

<a href = "<%=RS("link")%>">
<%=RS("name")%> </a>

<BR>

<%
RS.MoveNext
WEND
end if
%>

</B>

<%
RS.Close
Set RS=Nothing

Con.Close
Set Con = Nothing
%>

</B>
</body>
</html>