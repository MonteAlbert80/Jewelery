<html>
<head><title>Check out page</title>
</head>
<body background="images/Fiesta%20Bkgrd.jpg">
<table width="100%">
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
<table width=100% height=70%>
<tr>
<td colspan=2 align=center>
<B>Dear <%=usr%>!</B>
</td>
</tr>
<tr>
<td colspan=2 align=center>
You have opted to check out. You have already viewed your Cart.
<br>
Please Fill up the form below to confirm your order. Make sure to give the correct information.
</td>
</tr>
<form name = "CC"  method = "POST" action = "thank.asp"  target = "mainp">

<tr>
<td width=50% align=right>
Credit Card #:
</td>
<td width=50% align=left>
<input type = "text" name = "ccn" size = "15">
</td>
<tr>
<td width=50% align=right>
Name of the Card Holder:
</td>
<td width=50% align=left>
<input type = "text" name = "ccname" size = "15">
</td>
<tr>
<td width=50% align=right>
Expiry Date:
</td>
<td width=50% align=left>
<input type = "text" name = "ccexp" size = "7">
</td>
<tr>
<td width=50% align=right>
<input type="submit" value = "Place Order" >
</td>
<td width=50% align=left>
<input type = "Reset" value = "Clear All Fields" >
</td>
</tr>
</form>
<tr>
<td colspan=2 align=center>
<form method = "POST" action = "<%=Request.ServerVariables("HTTP_REFERER")%>" >
<input type="submit" value="Back To Your Cart">
</form>
</td>
</tr>
</table>

<HR>
<CENTER>

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

RS.Close
Set RS=Nothing

Con.Close
Set Con=Nothing
%>



</body>
</html>