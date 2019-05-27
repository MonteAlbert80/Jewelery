<html>
<head><title>login page</title>
</head>
<body >
<%
dim i 
i = Request.QueryString("id") 

if i <> "guest" then 
%>


<DIV Align = "Right">


<B>Personal</B>: &nbsp
<a href = "profile.asp?id=<%=Request.QueryString("id")%>">Profile</a>
&nbsp &nbsp 


<a href = "add.asp?item=0&id=<%=Request.QueryString("id")%>"  >View Cart</a>

&nbsp &nbsp 


<a href = "main.asp?id=guest" target = "_top" >Log Out</a> 



</DIV>



<BR>

Please Fill up the Form:


<FORM name = "postform" action = "view.asp?id=<%=i%>&p=1" method="POST">

Name : <input name="pname" size = "15"  >
<BR>

Email:
&nbsp;
<input name="pemail" size = "15"  >
<BR>

Description:&nbsp;
<BR>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<TEXTAREA  name="pdes" cols = 40 rows = 8 >
</TEXTAREA>

<BR>
<BR>

<input type = "SUBMIT" value = "SUBMIT" name = "b">
<input type = "Reset" value = "RESET"  name = "r">

</FORM>

<%
else 'if guest
Response.Write "First Log yourself On."
%>
<form name="fback" action="sign.asp?id=<%=Request.QueryString("id")%>" method="POST">
<Center><input type="submit" value="Back To Main" ></Center>
</form>
<%
Response.End
end if ''not guest end
%>

<form name="fback" action="sign.asp?id=<%=Request.QueryString("id")%>" method="POST">
<Center><input type="submit" value="Back To Main" ></Center>
</form>


<HR>
<CENTER>

<Address>
<!--#include virtual="/scripts/connection.asp"--><%


Que = "SELECT add,email from owner"
set RS = Con.Execute(Que)

Response.Write RS("add") & "<BR>"

%>

<a href = "mailto:<%=RS("email")%>">Contact us</a>

</Address>

</CENTER>


<%
RS.Close
Set RS = Nothing

Con.Close
Set Con = Nothing

%>
</body>
</html>