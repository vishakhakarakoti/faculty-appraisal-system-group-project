<%@ Control Language="C#" AutoEventWireup="true" CodeFile="coursedet.ascx.cs" Inherits="coursedet" %>
<tr>
<td><asp:TextBox ID="txtcod" runat="server" Width="80" Text=""> </asp:TextBox></td>
<td><asp:TextBox ID="txtcol" runat="server" Width="50" Text="0"></asp:TextBox></td>
<td><asp:TextBox ID="txtcot" runat="server" Width="50" Text="0"></asp:TextBox></td>
<td><asp:TextBox ID="txtcop" runat="server" Width="50" Text="0"  ></asp:TextBox></td>
<td><asp:TextBox ID="txtltp" runat="server" Width="50"  Enabled="false"></asp:TextBox></td>
<td><asp:TextBox ID="txtnof" runat="server" Width="80" OnTextChanged="add" AutoPostBack="true"></asp:TextBox></td>
<td><asp:TextBox ID="txtcoa" runat="server" Width="50" Enabled="false" ></asp:TextBox></td>
<td><asp:TextBox ID="txtcob" runat="server" Width="50"></asp:TextBox></td>
<td><table><tr><td><asp:TextBox ID="txtcc1" runat="server" Width="50"></asp:TextBox></td>
<td><asp:TextBox ID="txtcc2" runat="server" Width="50"></asp:TextBox></tr></table></td>
<td><asp:TextBox ID="txtrst" runat="server" Width="50"></asp:TextBox></td>
<td><asp:TextBox ID="txtlpt" runat="server" Width="80"></asp:TextBox></td>
<asp:HiddenField ID="term" runat="Server"  />

</tr>
