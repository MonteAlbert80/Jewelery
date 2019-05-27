<html>
<head><title>try</title></head>
<body>



<DIV Align = "Right">

<%if Request.QueryString("id") <> "guest" then
%>
<B>Personal</B>: &nbsp
<a href = "profile.asp?id=<%=Request.QueryString("id")%>">Profile</a>
&nbsp &nbsp 


<a href = "add.asp?item=0&id=<%=Request.QueryString("id")%>"  >View Cart</a>

&nbsp &nbsp 


<a href = "main.asp?id=guest" target = "_top" >Log Out</a> 

<%end if%>

</DIV>


<br><br>

<!--#include virtual="/scripts/connection.asp"-->
<% 



cat = Request.QueryString("cat")
%>

Category: &nbsp <B><%=cat%></B>

<BR><HR><BR>

<%
Query = "SELECT * from item  where category = '" & cat & "' "

set RS = Con.Execute(Query)

while not RS.EOF
%>

<img src=<%=RS("image_path")%>  align=Left> 
<%=RS("description")%> 


<br Clear = "ALL"><BR>
<a href = "detail.asp?item=<%=Server.URLEncode(RS("code"))%>&id=<%=Request.QueryString("id")%>">
For more details
</a>

<BR><BR><BR>




<%
RS.MoveNext
Wend 

RS.Close
Set RS = Nothing
%>

<CENTER>
<form method = "POST" action = "sign.asp?id=<%=Request.QueryString("id")%>">
<input type = "submit" value = "Back To Main">
</form>
</CENTER>


<CENTER>
<HR>
<Address>
<%
Que = "SELECT add,email from owner"
set RS = Con.Execute(Que)

Response.Write RS("add") & "<BR>"

%>

<a href = "mailto:<%=RS("email")%>">Contact us</a>

</Address>

</CENTER>


<%
RS.close
Set RS = Nothing

Con.Close
Set Con = Nothing
%>



</body>
</html>