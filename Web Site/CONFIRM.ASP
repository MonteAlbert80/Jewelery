<%
dim mto,mfrom,msub,mmsg

mto = Request.QueryString("em")

mfrom = trim(Request.Form("from"))

msub = trim(Request.Form("subj"))

mmsg = trim(Request.Form("msg"))

if mfrom <> ""  and instr(mfrom,"@") <> 0 and instr(mfrom,".") <> 0 then

Dim mail 

SET mail = Server.CreateObject("CDONTS.Newmail")

mail.From = mfrom

mail.To = mto

mail.Subject = msub

mail.Body = mmsg

mail.Send

SET mail = Nothing


else

Response.Redirect("sendmail.asp?em=" & mto & "&id=" & Request.QueryString("id") & " ")
Response.end
end if

%>

<html>
<head><title>login page</title>
</head>
<body >





</body>
</html>