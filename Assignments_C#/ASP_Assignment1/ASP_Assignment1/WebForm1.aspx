<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_Assignment1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Select a Bike Model:</h1>
            <asp:DropDownList ID="Dogs" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Dogss">
                <asp:ListItem Text="Select Your Fav Dog" Value="0" />
                <asp:ListItem Text="German shepherd" Value="German shepherd" />
                <asp:ListItem Text="Poodle" Value="Poodle"  />
                <asp:ListItem Text="Maltese" Value="Maltese"  />
                <asp:ListItem Text="chowchow" Value="chowchow"  />

            </asp:DropDownList>
            <br /><br />

            <asp:Image ID="DogImage"  runat="server" ImageUrl="Images/default.jpeg" Width="200" Height="200" />

            <br /><br />

            <asp:Button ID="button" runat="server" Text="Show Cost" OnClick="ShowCost" />
            <br /><br />

            <asp:Label ID="Cost" runat="server" Text="" />
        </div>
    </form>
</body>
</html>
