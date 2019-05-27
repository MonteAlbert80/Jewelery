<html>
<head><title>Thanks page</title>
</head>

<body background="images/Fiesta%20Bkgrd.jpg">
<table width="100%" ID="Table1">
  <tr>
    <td width="18%"><B><img border="0" src="images/TheBlueTopaz.gif" width="120" height="62"></B></td>
<!--#include virtual="/scripts/connection.asp"-->
<%
if len(Session("User")) > 0 then
%>
    <td width="82%" align="right">
      <B>Personal</B>:&nbsp;&nbsp;
<a href = "profile.asp">Profile</a>
      &nbsp;&nbsp;&nbsp;&nbsp; 


<a href = "add.asp?item=0">View Cart</a>

      &nbsp;&nbsp;&nbsp;&nbsp; 


<a href = "main.asp?id=guest" target = "_top" >Log Out</a> 

      &nbsp;</td>
<%
set rs1=Con.Execute("Select * from customer where id='" & Session("User") & "'")
usr=rs1("name") & " " & rs1("last_name")
else
usr="Guest"
end if%>
  </tr>
</table>
<HR>

<%

if Request.Form("ccn") = "" or Request.Form("ccname") = "" or Request.Form("ccexp") = ""  then
Response.Redirect "checkout.asp?id=" & Request.QueryString("id") & " " 
Response.End

end if

%>

<BR><BR><BR><BR><BR><BR><BR><BR>

<Center>

Thank you <B><%=usr%></B>  for your visit.
<BR><BR><BR>
<a href = "main.asp?id=<%=Request.QueryString("id")%>"  target = "_top">Back To Main Page</a>

<BR><BR><BR><BR><BR><BR><BR><BR>


<HR>

<Address>
<%
Que = "SELECT add,email from owner"
set RS = Con.Execute(Que)

Response.Write RS("add") & "<BR>"

%>

<a href = "mailto:<%=RS("email")%>">Contact us</a>

</Address>

</Center>

<%
RS.Close
Set RS=Nothing

Con.Close
Set Con=Nothing

%>

</body>
</html>