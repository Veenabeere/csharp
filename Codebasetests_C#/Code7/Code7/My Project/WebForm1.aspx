<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Code7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Validator Page</h1>
            <label for="txtName">Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <!-- Repeat similar sections for other input fields (Family Name, Address, City, Zip Code, Phone, Email) -->
            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
        </div>
    </form>
</body>
</html>
