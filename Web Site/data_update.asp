<!--#include virtual="/scripts/connection.asp"-->
<% 
Query = "SELECT * from item"
set rs=con.execute(Query)
while not rs.eof
rs("image_path").value="images" & mid(rs("image_path").value, 28)
rs.movenext
wend
%>