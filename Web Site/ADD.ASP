
<% Response.Expires = 0 %>
<!--#include virtual="/scripts/connection.asp"-->
<% 

i = Request.queryString("id")

' Response.Write i
'''''''''''''''''''''''1

if i <> "guest" then

Dim icode,iname,iqty,iprice,idis


icode = Request.queryString("item")

''''''''''''''''''''''''''''''''''''''''''''''''''''''


'PreviousPage = Request.ServerVariables("HTTP_REFERER")
'Response.write PreviousPage




'''''''''''''''''''''''''''''''2
if icode <> 0 then

Query = "select * from cart where id = '" & icode & "' "

set RS = Con.Execute(Query) 

'''''''''''''''''''''''''3
if RS.EOF then

RS.Close

Query1 = "select name,quantity,price,discount from item where code = '" & icode & "' "

set RS = Con.Execute(Query1) 

iqty =  CInt(Request.form("qty"))

if iqty <= RS("quantity") then

iname = RS("name")

iprice = RS("price")

idis =   RS("discount")

RS.Close

Query2 = "insert into cart(id,qty,price,name,discount) values('" & icode & "'," & iqty & ",'" & iprice & "','" & iname & "','" & idis & "' )"

Con.Execute Query2

 else
 RS.Close
 Response.Redirect " " & Request.ServerVariables("HTTP_REFERER") & " "

 end if

else
RS.Close
end if
'''''''''''''''''''''''''3 close
end if
'''''''''''''''' 2 close

Con.Close

Set Con = Nothing

else

Response.Write "First Log Yourself.....then you will be able to add item(s) to your Cart"
Response.End

end if

'''''''''''''''''''''1 close

%>




<html>
<head><title>Your Cart contains:</title>
</head>
<body background="images/Fiesta%20Bkgrd.jpg">
<table border="0" width="100%" ID="Table1">
  <tr>
    <td width="19%"><B><img border="0" src="images/TheBlueTopaz.gif" width="120" height="62"></B></td>
    <td width="81%" align="right">
<% if len(Session("User")) > 0 then %>
    <B>Personal</B>: &nbsp
    <a href = "profile.asp">Profile</a>
&nbsp &nbsp 
<a href = "main.asp" target = "_top" >Log Out</a> 
<%else%>
<a href="LOGIN.ASP">Sign In</a>
<%end if%>
    </td>
  </tr>
</table>
<hr>


<%if Request.QueryString("id") <> "guest" then

dim amt 
amt = 0
end if
%>
<BR><BR>

<% 



Query = "SELECT * from cart"

set RS1 = Con.Execute(Query)

if RS1.EOF then
Response.Write "<CENTER><B>Your Cart is Empty</B></CENTER><BR><BR><BR><BR><BR><BR> "
else


%>

<center>
<table width = "20%" border = "1">

<B>Your Cart contains following items right now: </B>

<BR><BR>

<th nowrap >item code</th><th>name</th><th>quantity</th><th nowrap>price (per piece)</th><th nowrap>discount (per piece)</th><th nowrap >discounted price (per piece)</th> <th nowrap >&nbsp</th>

<%
While Not RS1.EOF
%>

<tr>

<TD>
<%= RS1("id") %>
</TD>

<TD>
<%= RS1("name") %>
</TD>


<TD>
<%= RS1("qty") %>
</TD>


<TD>
<%= RS1("price") %>
</TD>


<TD>
<%= RS1("discount") %> %
</TD>

<%
if RS1("discount") > 0 then
discountp = RS1("price") - (RS1("price")*RS1("discount"))/100
else
discountp = RS1("price")
end if
%>

<TD>
<%= discountp %> 
</TD>

<TD>

<BR>

<form method = "POST" action="remove.asp?remove=<%=Server.URLEncode(RS1("id"))%>&id=<%=Request.QueryString("id")%>">
<input type = "submit" value = "Remove">
</form>

</TD>




</tr>


<%

amt = amt + RS1("qty")*discountp

RS1.MoveNext
WEND

%>

</table>
</center>

<BR>

<p align=center> Price to pay:  <B> Rs. <%=amt%> </B></p>

<BR>

<CENTER>

<form method = "POST" action="checkout.asp?id=<%=i%>">
<input type = "submit" value = "Check Out">
</form>

</CENTER>
<%
end if
%>






<%
RS1.Close
Set RS1 = Nothing
%>

<CENTER>
<form method = "POST" action="sign.asp?id=<%=i%>" >
<input type = "submit" value = "Back To Main">
</form>
</CENTER>

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
SET RS=Nothing

Con.Close
Set Con = Nothing
%>




<br>


</body>
</html>