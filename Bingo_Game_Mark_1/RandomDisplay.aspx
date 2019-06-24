<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomDisplay.aspx.cs" Inherits="Bingo_Game_Mark_1.RandomDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 273px;
            width: 287px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Bingo
        </div>
        <p>
            <asp:Label ID="lbldisplay" runat="server"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtText" runat="server" Height="32px" Width="218px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAnswer" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="display" runat="server" OnClick="display_Click" Text="Display" />
        </p>
        <asp:Button ID="DisplayArray" runat="server" OnClick="DisplayArray_Click" Text="Display Card" Width="117px" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="412px" TextMode="MultiLine" Width="311px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
