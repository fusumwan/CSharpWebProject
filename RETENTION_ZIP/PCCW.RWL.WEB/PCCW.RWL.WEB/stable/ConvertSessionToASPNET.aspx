<TITLE>Convert Session To ASPNET</TITLE>
<%@ Page language="c#" %>
<script runat=server>
private void Page_Load(object sender, System.EventArgs e)
{
for(int i=0;i<Request.Form.Count;i++)
{
Session[Request.Form.GetKey(i)]=Request.Form[i].ToString();
}
Server.Transfer(Session["DestPage"].ToString(),true);
}
</script>