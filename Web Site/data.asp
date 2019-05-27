<!--#include virtual="/scripts/connection.asp"-->
<% 
Query = "SELECT * from customer"
set rs=con.execute(Query)
%>
<table border=1>
<tr>
<% for i=0 to 9 %>
<td><%=rs(i).name%></td>
<% next %>
</tr>
<% while not rs.eof %>
<tr>
<% for i=0 to 9 %>
<td><%=rs(i).value%></td>
<% next %>
</tr>
<% rs.movenext
wend %>
</table>
