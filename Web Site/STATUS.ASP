<!--#include virtual="/scripts/connection.asp"-->
<%@ Language=VBScript 

dim ordern,uid,msg

uid = Request.QueryString("id")
ordern = trim(Request.Form("order"))


Query = "SELECT status from order_info where number = '" & ordern & "' and user_id = '" & uid & "' "

set RS = Con.Execute(Query)

if  NOT  RS.EOF then

msg = "The Order number &nbsp" &  ordern  & " &nbsp has been " & RS("status")

Response.Write msg

else

msg = "The Order Number you entered does not exist"

Response.Write msg

end if

%>
<html>
	<head>
		<title>login page</title>
	</head>
	<body>
		<BR>
		<BR>
		<BR>
		<CENTER>
			<FORM  method = "POST" action = "main.asp?id=<%=uid%>" target = "_top" >
				<input type="SUBMIT" value="Main Page">
			</FORM>
		</CENTER>
	</body>
</html>
