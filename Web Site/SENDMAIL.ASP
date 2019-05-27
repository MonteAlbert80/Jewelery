<html>
<head><title>mail page</title>
</head>
<body >

<Form name = "mailform" action = "confirm.asp?em=<%=Request.QueryString("em")%>&id=<%=Request.QueryString("id")%>" Method = "POST" >

To: &nbsp

<%=Request.QueryString("em")%>

<BR>
<BR>

From: &nbsp

<input type = "TEXT" name = "from" size = "30">

<BR>

Subject: &nbsp

<input type = "TEXT" name = "subj" size = "30">

<BR>
<BR>

Message: 
<BR>
<textarea name = "msg" cols = 40 rows = 8>
</textarea>

<BR><BR>
<input type = "submit" value = "Send" name = "smail">
&nbsp &nbsp 
<input type = "Reset" value = "Reset" name = "res">

</Form>

<form method = "POST" action = "sign.asp?id=<%=Request.QueryString("id")%>">
<Center><input type="submit" value="Back To Home"></Center>
</form>


</body>
</html>