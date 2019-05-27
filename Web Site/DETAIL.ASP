<html>
<head><title>login page</title>
</head>
<body background="images/Fiesta%20Bkgrd.jpg">

<table width="100%">
  <tr>
    <td width="18%"><B><img border="0" src="images/TheBlueTopaz.gif" width="120" height="62"></B></td>
<%if len(Session("User")) > 0 then
%>
    <td width="82%" align="right">
      <B>Personal</B>:&nbsp;&nbsp;
<a href = "profile.asp">Profile</a>
      &nbsp;&nbsp;&nbsp;&nbsp; 


<a href = "add.asp?item=0"  >View Cart</a>

      &nbsp;&nbsp;&nbsp;&nbsp; 


<a href = "main.asp?id=guest" target = "_top" >Log Out</a> 

      &nbsp;</td>
<%end if%>
  </tr>
</table>

<!--#include virtual="/scripts/connection.asp"-->
<% 

icode = Request.QueryString("item")
Query = "SELECT * from item where code = '" & icode & "' "

set RS = Con.Execute(Query)

%>

<HR>

<table height=70% width=100%>
<tr>
<td width=25%></td>
<td width=25%>
<b>
Category:</b> &nbsp;&nbsp;&nbsp;&nbsp; <%=RS("category")%>
</td>
<td width=25% rowspan=6 align=center><img src="images/<%=RS("image_path")%>"> </td>
<td width=25%></td>
</tr>
<tr>
<td width=25%></td>
<td width=25%>
<%=RS("description")%> 

</tr>

<tr>
<td width=25%></td>
<td width=25%>
<b>
Item Code:</b>  &nbsp;&nbsp;&nbsp;<%=RS("code")%>
</tr>

<tr>
<td width=25%></td>
<td width=25%>
<b>
Price:</b>     &nbsp &nbsp &nbsp &nbsp;&nbsp;&nbsp;&nbsp; $<%=RS("Price")%> 
</tr>

<tr>
<td width=25%></td>
<td width=25%>
<b>
Discount:</b>  &nbsp;&nbsp;&nbsp;&nbsp; <%=RS("discount")%>% 
</tr>

<tr>
<td width=25%></td>
<td width=25%>
<b>
Availability:</b> &nbsp <Font Color = "RED">
<%
if RS("quantity") <= 0 then
%>
Currently Not in Stock
<%
else
%>
Available
<%
end if
%>

</Font>

</tr>
<td width=25%></td>
</tr>
<%
if RS("quantity") > 0 then
%>
<tr>
<td colspan=4 align=center>
<form name = "qform" method="POST" action = "add.asp?item=<%=Server.URLEncode(RS("code"))%>" color=Red>

Quantity: <input type = "TEXT" name = "qty" size = "5" value = "1">

<input type="submit" value="Add To Cart">

</form>
</td>
</tr>
<%
end if
%>
<tr>
<td colspan=4 align=center>
<Form name="more" action="display.asp?cat=<%=RS("category")%>" method="post" >
<input type="SUBMIT" value="Complete <%=RS("category")%> Catalogue">
</form>

<%
RS.close
Set RS = Nothing
%>
<tr>
<td colspan=4 align=center>
<form name = "bform" method="POST" action = "sign.asp">

<input type="submit" value="Back To Home">

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




<BR>


<%
RS.close
Set RS = Nothing

Con.Close
Set Con = Nothing
%>

</body>
</html>