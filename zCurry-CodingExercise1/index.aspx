<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <br />
            1. Enter a word into this text box.<br />
            2. Click "Add" to add this word to the table. <br />
            <asp:GridView ID="GridView1" runat="server" ShowHeader="False"></asp:GridView>
            <br />
            <div id="secondSection" runat="server" Visible="False" >
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Remove" OnClick="Button2_Click" />
                <br />
                1. Enter a word into this text box.<br />
                2. Click "Remove" to remove this word from the table. <br />        
            </div>

        </div>
    </form>
</body>
</html>
