<!--#include virtual="/scripts/connection.asp"-->
<%


Query = "Select count(*) as c from customer where id='" & request.form("lid") & "' and pwd='" & request.form("pass") & "'"
set RS = Con.Execute(Query)

if RS("c")>0 then
	Session("User") = request.form("lid")
	response.redirect("sign.asp")
else
	response.redirect("login.asp?pwd=invalid")
end if
%>
