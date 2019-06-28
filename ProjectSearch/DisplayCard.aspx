<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayCard.aspx.cs" Inherits="ProjectSearch.DisplayCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


         <asp:GridView ID="NewDataGrid" runat="server" AutoGenerateColumns="true" ShowHeader="false" Width="450px"></asp:GridView>
        
        <br />

         <asp:GridView ID="grid2" runat="server" AutoGenerateColumns="true" ShowHeader="false" Width="450px"></asp:GridView>

         <br />
         <asp:GridView ID="grid3" runat="server" AutoGenerateColumns="true" ShowHeader="false" Width="450px"></asp:GridView>

        <br />
         <asp:GridView ID="grid4" runat="server" AutoGenerateColumns="true" ShowHeader="false" Width="450px"></asp:GridView>

        <br />
         <asp:GridView ID="grid5" runat="server" AutoGenerateColumns="true" ShowHeader="false" Width="450px"></asp:GridView>
         
        <br />
         <asp:GridView ID="grid6" runat="server" AutoGenerateColumns="true" ShowHeader="false" Width="450px"></asp:GridView>





        <hr />


        <br />
        <br />

        <p>
           
        </p>

  <p>
            <asp:TextBox ID="randonum" runat="server"></asp:TextBox>
        </p>

          <p>
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </p>

        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
         <p>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
         <p>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
         <p>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </p>
      
        <p>
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
         </p>




        <p>
            <asp:Button ID="nextBtn" runat="server" Text="Start Game" OnClick="nextBtn_Click" />

        </p>
    </form>
</body>
</html>
