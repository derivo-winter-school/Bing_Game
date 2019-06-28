<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateBingoCard.aspx.cs" Inherits="ProjectSearch.GenerateBingoCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:DataGrid ID="NewDataGrid" runat="server" AutoGenerateColumns="true" ShowHeader="false" ItemStyle-Width="75px"></asp:DataGrid>
        <br />
         <asp:DataGrid ID="grid2" runat="server" AutoGenerateColumns="true" ShowHeader="false" ItemStyle-Width="300px"></asp:DataGrid>

         <br />
         <asp:DataGrid ID="grid3" runat="server" AutoGenerateColumns="true" ShowHeader="false" ItemStyle-Width="300px"></asp:DataGrid>

        <br />
         <asp:DataGrid ID="grid4" runat="server" AutoGenerateColumns="true" ShowHeader="false" ItemStyle-Width="300px"></asp:DataGrid>

        <br />
         <asp:DataGrid ID="grid5" runat="server" AutoGenerateColumns="true" ShowHeader="false" ItemStyle-Width="300px"></asp:DataGrid>

        <br />
         <asp:DataGrid ID="grid6" runat="server" AutoGenerateColumns="true" ShowHeader="false" ItemStyle-Width="300px"></asp:DataGrid>

        <div>
        </div>
    </form>
</body>
</html>
