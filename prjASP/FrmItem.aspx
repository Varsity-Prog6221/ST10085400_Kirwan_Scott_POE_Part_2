<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmItem.aspx.vb" Inherits="prjASP.Frm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Item Form </h2>
            <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox >
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox >
            <asp:DropDownList ID="cmbCategory" runat="server"></asp:DropDownList>
            <asp:Button ID="txtSubmit" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
