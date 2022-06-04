<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmItem.aspx.cs" Inherits="prjWEB.frmItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Item Form</h2>
            <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox> <br />
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox> <br />
            <asp:DropDownList ID="cbmCategory" runat="server"></asp:DropDownList> <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
