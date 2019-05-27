<%@ Language=VBScript %>

<% Response.Expires = 0 %>
<script language="VBScript">
sub validate()
	if document.profile_form.id.value="" then
			msgbox "You must select an id"
			document.profile_form.pwd1.focus
	else
		if document.profile_form.pwd1.value="" then
				msgbox "You must select a passward"
				document.profile_form.pwd1.focus
		else
			if document.profile_form.pwd1.value=document.profile_form.pwd2.value then
				document.profile_form.submit
			else
				msgbox "Confirmed passward doesn't match with the entered passward"
				document.profile_form.pwd2.focus
			end if
		end if
	end if
end sub
</script>
<html>
<head><title>login page</title>
</head>
<body background="images/Fiesta%20Bkgrd.jpg">
<!--#include virtual="/scripts/connection.asp"-->
<%

if Request.Form("filled")="Yes" then
	Query="Select Count(*) as c from customer where id='" & Request.Form("id") & "'"
	set rs1=Con.Execute(Query)
	if rs1("c")=0 then
		c=Request.Form("subs")
		if c="" then c="0"
		Query="Insert into customer values('" & Request.Form("fname") & "','" & Request.Form("lname") & _
		"','" & Request.Form("add") & "','" & Request.Form("city") & "','" & Request.Form("country") & _
		"','" & Request.Form("pcode") & "','" & Request.Form("email") & "','" & Request.Form("id") & _
		"','" & Request.Form("pwd1") & "'," & c & ")"
		Con.Execute(Query)
		Session("User") = request.form("id")
		response.redirect("sign.asp")
	else
%>
<Font color=red>Someone is already registered with this ID</Font>
<%
	end if
end if
%>

<Form name = "profile_form" method = "POST" action = "signup.asp">
<DIV Align = "Right" style="width: 697; height: 28">
<table border="0" width="100%">
  <tr>
    <td width="19%"><B><img border="0" src="images/TheBlueTopaz.gif" width="120" height="62"></B></td>
    <td width="81%">

    </td>
  </tr>
</table>

</DIV>
<HR>
<p align=center>To Apply your new settings, click FINISHED else CANCEL.</p>
<input type=hidden name="filled" value="Yes">
<table width=100%>
<tr>
<td width=50% align=right>Choose a Login ID:</td>
<td width=50% align=left><input type = "text"  name = "id" size = "20" value = "<%=Request.Form("id")%>"></td>
</tr>
</table>
<HR>
<table width=100%>
<tr>
<td width=50% align=right>First Name:</td>
<td width=50% align=left><input type = "text"  name = "fname" size = "20" value = "<%=Request.Form("fname")%>"></td>
</tr>
<tr>
<td width=50% align=right>Last Name:</td>
<td width=50% align=left><input type = "text"  name = "lname" size = "20" value = "<%=Request.Form("lname")%>"></td>
</tr>
</table>
<HR>
<table width=100%>
<tr>
<td width=50% align=right>Address:</td>
<td width=50% align=left><input type = "text"  name = "add" size = "30" value = "<%=Request.Form("add")%>">
</tr>
<tr>
<td width=50% align=right>City:</td>
<td width=50% align=left><input type = "text"  name = "city" size = "15" value = "<%=Request.Form("city")%>">
</tr>
<tr>
<td width=50% align=right>Country:</td>
<td width=50% align=left><input type = "text"  name = "country" size = "20" value = "<%=Request.Form("country")%>">
</tr>
<tr>
<td width=50% align=right>Postal Code:</td>
<td width=50% align=left><input type = "text"  name = "pcode" size = "10" value = "<%=Request.Form("pcode")%>">
</tr>
</table>
<HR>
<table width=100%>
<tr>
<td width=50% align=right>Email:</td>
<td width=50% align=left><input type = "text"  name = "email" size = "25" value = "<%=Request.Form("email")%>">
</tr>
<tr>
<td width=50% align=right>Select a Password:</td>
<td width=50% align=left><input type = "password"  name = "pwd1" size = "20">
</tr>
<tr>
<td width=50% align=right>Confirm the Password:</td>
<td width=50% align=left><input type = "password"  name = "pwd2" size = "20">
</tr>
<%
if Request.Form("subs") = "1" then
c = "checked"
else
c = ""
end if
%>
<tr>
<td colspan=2 align=center>
<input type = "checkbox"  name = "subs" value=1 <%=c%>>
Subscribed for Newsletter Service:
</td>
</tr>
</table>
<% PreviousPage = Request.ServerVariables("HTTP_REFERER") %>
<HR>
<table width=100%>
<tr>
<td width=50% align=right><input type="button" name = "B" value = "Save" onclick="validate"></td>
<td width=50% align=left>
<input type="button" name = "C" value = "Cancel" onclick="history.back">
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

<input type = "hidden"  name = "page" size = "20" value = "<%=PreviousPage%>">
</form>
<%
Con.Close
Set Con = Nothing
%>

</body>
</html>