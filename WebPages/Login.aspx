<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" UnobtrusiveValidationMode="None" Inherits="VoxPopuli.WebPages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUsername" runat="server" placeholder="Username or Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="*Required" ControlToValidate="txtUsername" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Required" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblInvalid" runat="server" Text="Incorrect Username/Email or Password" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <br />
            <asp:Label ID="lblRegister" runat="server" Text="Don't have an account?"></asp:Label>
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" PostBackUrl="~/WebPages/Register.aspx" />
            <br />
            <asp:SqlDataSource ID="VoxPopuliDB" runat="server" ConnectionString="<%$ ConnectionStrings:VoxPopuli_ConnectionString %>" SelectCommand="SELECT * FROM [VP_Users]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
