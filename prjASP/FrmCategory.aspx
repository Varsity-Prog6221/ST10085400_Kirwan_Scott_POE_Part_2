<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmCategory.aspx.vb" Inherits="prjASP.Frm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Category Form</h2> <br />
            <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox> <br />
            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat ="server" Text="Button" /> <br />
            <asp:GridView ID="dgvCategory" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
