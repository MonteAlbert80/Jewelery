<%
dim name,lname,add,city,cnt,pc,em,pwd1,pwd2,s,msg,from

name = Request.Form("fname")
lname = Request.Form("lname")
add = Request.Form("add")
city = Request.Form("city")
cnt = Request.Form("country")
pc = Request.Form("pcode")
em = Request.Form("email")
pwd1 = Request.Form("pwd1")
pwd2 = Request.Form("pwd2")
s = Request.Form("subs")
from = Request.Form("page")

if NOT name <> "" then

msg = msg & "* first name missing <br> "

end if

if NOT lname <> "" then

msg = msg & "* last name missing <br> "

end if

if NOT add <> "" then

msg = msg & "* address field missing <br> "

end if

if NOT city <> "" then

msg = msg & "* specify your city name <br> "

end if

if NOT cnt <> "" then

msg = msg & "* specify your country name <br> "

end if

if NOT pc <> "" then

msg = msg & "* postal code missing <br> "

end if

if NOT em <> "" then

msg = msg & "* enter your email address <br> "

end if

'if pwd1 <> "" and pwd2 <> "" then

if pwd1 = "" and pwd2 <> "" then

msg = msg & "* passwords doesnot matches <br> "

end if

if pwd2 = "" and pwd1 <> "" then

msg = msg & "* passwords doesnot matches <br> "

end if

if pwd1 <> "" and len(pwd1) < 4 then

msg = msg & "* password should be atleast 4 character long <br> "

end if

if pwd1 <> pwd2 then

msg = msg & "* passwords doesnot matches <br> "

end if

'end if

if pc <> ""  AND not isnumeric(pc) then

msg = msg & "* enter a valid postal code <br>"
end if

if instr(em,"@") = 0  or  instr(em,".") = 0 then

msg = msg & "* enter a valid email address <br> "

end if


%>




<html>
<head><title>login page</title>
</head>
<body >

<%

if msg <> "" then

Response.Write "Your Profile has not been modified bcoz of following error(s):<BR><BR>"

Response.Write msg

'Previous = Request.ServerVariables("HTTP_REFERER")
   
%>

<form method = "POST" action = "<%=from%>">
<input type="submit" value = "BACK" > 
</form>

<%
Response.end
else
%>
<!--#include virtual="/scripts/connection.asp"-->
<%

dim i

if s = "on" then
i = 1
else
i = 0
end if

'Response.Write pwd2

if pwd1 = "" and pwd2 = "" then
Query = "Update customer set name='" & name & "', last_name='" & lname & "', address='" & add & "', city='" & city & "', country='" & cnt & "', pcode=" & pc & ", email='" & em & "', subscribe=" & i & " where id='" & Request.QueryString("id") & "' "

else
Query = "Update customer Set name='" & name & "', last_name='" & lname & "', address='" & add & "',city='" & city & "', country='" & cnt & "', pcode=" & pc & ", email ='" & em & "', pwd='" & pwd1 & "', subscribe=" & s & " where id ='" & Request.QueryString("id") & "' "
end if

Con.Execute Query

end if

Con.Close
Set Con = Nothing

Response.Write Request.QueryString("id") & ", Your Profile has been successfuly modified."
%>


<CENTER>
<form method = "POST" action = "<%=from%>">

<input type = "Submit" value = "BACK">

</form>
</CENTER>

</body>
</html>