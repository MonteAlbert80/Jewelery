<%Response.Expires = 0%>

<%
dim i , posted

i = Request.QueryString("id")
posted = Request.QueryString("p")

if i <> "guest" and posted <> 0 then

Dim name,email,des

name = Request.Form("pname")
email = Request.Form("pemail")
des = Request.Form("pdes")

if name = "" or email = "" or des = "" or instr(email,"@") = 0 or instr(email,".") = 0 then
Response.Write "Go Back and Fill the Form Completely"
Response.End 
else
%>
<!--#include virtual="/scripts/connection.asp"-->
<%

Query2 = "Select * from post where id = '" & i & "' and name = '" & name & "' and email = '" & email & "' and description = '" & des & "' " 

'Response.Write Query2

SET RS = Con.Execute(Query2)

if RS.EOF then

RS.Close
SET RS = Nothing

Query3 = "Select number from post"

SET RS1 = Con.Execute(Query3)

dim num

num  = 1

if not RS1.EOF then
while not RS1.EOF 
'num = num + 1
num = RS1("number")
RS1.Movenext
wend
num = num+1
end if

RS1.Close
Set RS1 = Nothing

'Query = "Insert into post(number,id,name,email,description) values(" & num & ",'" & i & "','" & name & "','" & email & "','" & des & "')"
Query="Insert into post values('" & num & "','" & i & "','" & name & "','" & email & "','" & des & "')"

Con.Execute Query
'end if
else

RS.Close
Set RS = Nothing
end if

end if


end if
%>


<html>
<head><title>View page</title>
</head>
<body >

<%
if posted = 0 then
%>
    <!--#include virtual="/scripts/connection.asp"-->
<%
end if

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


<%
Query1 = "Select * from post" 

Set RS = Con.Execute(Query1)

if RS.EOF then
%>
NO ITEM TO VIEW............
<%
Response.End

else

Dim count
count = 1
%>
<B> 
Following Items are Posted by our Members
</B>

<BR><BR><HR>

<%
While not RS.EOF 
%>
Number <%=count%>: 


<%

if Request.QueryString("id") = RS("id") then
%>


<Div align = "Right">
<Form action = "removep.asp?it=<%=Server.URLEncode(RS("number"))%>&id=<%=Request.QueryString("id")%>" method="POST" name="removep">
<input type="submit" value="Remove">
</Form>
</Div>
<%
else
%>
<BR><BR>
<%
end if 
%>

By: 
&nbsp;  
<%=RS("name")%>
<BR>
Login Id:
&nbsp;
<%=RS("id")%>
<BR>
Description: 
&nbsp;&nbsp;
<%=RS("description")%>
<BR>

Email: <%=RS("email")%>

<BR>

<form name = "sendmail2" action = "mailto:<%=RS("email")%>" method = "POST">
<input type = "submit" value = "Mail To Seller" name = "button1" >
</form>


<BR>
<HR>

<%
count = count + 1
RS.MoveNext
Wend
end if 


RS.Close
SET RS = Nothing
else

Response.Write "First Log On Yourself."
%>

<form name="fback" action="sign.asp?id=<%=Request.QueryString("id")%>" method="POST">
<Center><input type="submit" value="Back To Main" ></Center>
</form>

<%
Response.End 
end if
%>

<form name="fback" action="sign.asp?id=<%=Request.QueryString("id")%>" method="POST">
<Center><input type="submit" value="Back To Main" ></Center>
</form>


<BR><BR>

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
SET RS = Nothing

Con.Close
Set Con = Nothing
%>




</body>
</html>