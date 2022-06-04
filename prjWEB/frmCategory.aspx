<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCategory.aspx.cs" Inherits="prjWEB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Category Form</h2>
            <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox> <br />
            <asp:Button ID="btnSubmit" OnCLick="btnSubmit_Click" runat="server" Text="Button" /> <br />
            <asp:GridView ID="dgvView" runat="server"></asp:GridView> <br />
        </div>
    </form>
</body>
</html>
