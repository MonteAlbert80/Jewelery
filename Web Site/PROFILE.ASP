<% Response.Expires = 0 %>
<script language="VBScript">
sub validate()
	if document.profile_form.pwd1="" then
		document.profile_form.submit
	else
		if document.profile_form.pwd1=document.profile_form.pwd2 then
			document.profile_form.submit
		else
			msgbox "Confirmed new passward doesn't match with the new passward"
			document.profile_form.pwd2.focus
		end if
	end if
end sub
</script>
<html>
<head><title>login page</title>
</head>
<body background="images/Fiesta%20Bkgrd.jpg">
<Form name = "profile_form" method = "POST" action = "cngprofile.asp">
<!--#include virtual="/scripts/connection.asp"-->
    <%

Query = "Select * from customer where id='" & Session("User") & "' "

SET RS = Con.Execute(Query)

%>
<DIV Align = "Right" style="width: 697; height: 28">
<table border="0" width="100%">
  <tr>
    <td width="19%"><B><img border="0" src="images/TheBlueTopaz.gif" width="120" height="62"></B></td>
    <td width="81%">
      <p align="right"><b><%=Session("User")%></b>'s Profile.
&nbsp &nbsp 

<a href = "add.asp?item=0"  >View Cart</a>

&nbsp &nbsp 


<a href = "main.asp?id=guest" target = "_top" >Log Out</a> 

    </td>
  </tr>
</table>

</DIV>
<HR>
<p align=center>You can modify your profile, except for your Login ID.</p>
<p align=center>To Apply your new settings, click FINISHED else CANCEL.</p>
<HR>
<table width=100%>
<tr>
<td width=50% align=right>First Name:</td>
<td width=50% align=left><input type = "text"  name = "fname" size = "20" value = "<%=RS("name")%>"></td>
</tr>
<tr>
<td width=50% align=right>Last Name:</td>
<td width=50% align=left><input type = "text"  name = "lname" size = "20" value = "<%=RS("last_name")%>"></td>
</tr>
</table>
<HR>
<table width=100%>
<tr>
<td width=50% align=right>Address:</td>
<td width=50% align=left><input type = "text"  name = "add" size = "30" value = "<%=RS("address")%>">
</tr>
<tr>
<td width=50% align=right>City:</td>
<td width=50% align=left><input type = "text"  name = "city" size = "15" value = "<%=RS("city")%>">
</tr>
<tr>
<td width=50% align=right>Country:</td>
<td width=50% align=left><input type = "text"  name = "country" size = "20" value = "<%=RS("country")%>">
</tr>
<tr>
<td width=50% align=right>Postal Code:</td>
<td width=50% align=left><input type = "text"  name = "pcode" size = "10" value = "<%=RS("pcode")%>">
</tr>
</table>
<HR>
<table width=100%>
<tr>
<td width=50% align=right>Email:</td>
<td width=50% align=left><input type = "text"  name = "email" size = "25" value = "<%=RS("email")%>">
</tr>
<tr>
<td width=50% align=right>Old Password:</td>
<td width=50% align=left><input type = "password"  name = "pwdo" size = "20">
</tr>
<tr>
<td width=50% align=right>New Password:</td>
<td width=50% align=left><input type = "password"  name = "pwd1" size = "20">
</tr>
<tr>
<td width=50% align=right>Confirm New Password:</td>
<td width=50% align=left><input type = "password"  name = "pwd2" size = "20">
</tr>
<%
dim c
if RS("subscribe") = 1 then
c = "checked"
else
c = ""
end if
%>
<tr>
<td colspan=2 align=center>
<input type = "checkbox"  name = "subs" <%=c%>>
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