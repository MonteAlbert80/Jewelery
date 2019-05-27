<script language="VBScript">
sub validate()
	dim price, sign
	price=document.search_form.price.value
	if price="" then
		document.search_form.submit
	else
		sign=left(price, 1)
		if sign<>">" and sign<>"<" and sign<>"=" then price="=" & price
		if isNumeric(mid(price, 2)) then
			document.search_form.price.value=price
			document.search_form.submit
		else
			msgbox "Price should be a number and may contains <, > and = signs only"
			document.search_form.price.focus
		end if
	end if
end sub
</script>
<html>
<head><title>Search Results with Catagory='<%=Request.Form("cat")%>' and Price<%=Request.Form("price")%></title></head>
<body background="images/Fiesta%20Bkgrd.jpg">
<table border="0" width="100%">
  <tr>
    <td width="19%"><B><img border="0" src="images/TheBlueTopaz.gif" width="120" height="62"></B></td>
    <td width="81%" align="right">
<% if len(Session("User")) > 0 then %>
    <B>Personal</B>: &nbsp
    <a href = "profile.asp">Profile</a>
&nbsp &nbsp 
<a href = "add.asp?item=0">View Cart</a>
&nbsp &nbsp 
<a href = "main.asp" target = "_top" >Log Out</a> 
<%else%>
<a href="LOGIN.ASP">Sign In</a>
<%end if%>
    </td>
  </tr>
</table>
<hr>
<form name = "search_form" method = "POST" action ="result.asp" >
Search by:&nbsp;&nbsp; 
Category 
<select name = "cat">
<option></option>
<!--#include virtual="/scripts/connection.asp"-->
<% 
Query = "SELECT distinct category from item"

set RS1 = Con.Execute(Query)

while not RS1.EOF
%>
<option><%=RS1("category")%></option>
<%
RS1.MoveNext
wend
%>
</select>
Price $ <input type = "TEXT" name = "price" size = "10">
<input type = "Button" name = "searchb" value ="GO" onclick="call(validate())">
</form>
<B>Hint: </B>In case of Price Search, you can use ">" , "<" and "=" (default) 
<hr>
<%
Query = "SELECT category,code,image_path,description from item"
if Request.Form("cat")<>"" or Request.Form("price")<>"" then
	Query=Query & " where"
	if Request.Form("cat")<>"" then Query = Query & " category='" & Request.Form("cat") & "'"
	if Request.Form("cat")<>"" and Request.Form("price")<>"" then Query=Query & " and"
	if Request.Form("price")<>"" then Query = Query & " price" & Request.Form("price")
end if

set RS = Con.Execute(Query)

while not RS.EOF
%>
<b>
Category:</b> &nbsp<%=RS("category")%> <BR><BR>
<a href = "detail.asp?item=<%=RS("code")%>"><img src="images/<%=RS("image_path")%>" align=Left ></a>
<%=RS("description")%> 

<BR>
<a href = "detail.asp?item=<%=RS("code")%>">
More Details
</a>
<BR Clear = "ALL">
<BR>
<%
RS.MoveNext
Wend 

RS.close
Set RS= Nothing
%>

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
RS.close
Set RS= Nothing

Con.Close
Set Con = Nothing
%>


</body>
</html>


