<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TXDistrict1.aspx.cs" Inherits="VoxPopuli.WebPages.TXDistrict1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 id="RepNameHolder" runat ="server">Rep Name</h1>
        <h1>District Number</h1>
        <div>
            <h2 id="twitterHandle" runat="server">Twitter Handle: </h2>
            <h2>Facebook Handle: </h2>
        </div>
    <asp:SqlDataSource ID="VoxPopuliDB" runat="server" ConnectionString="<%$ ConnectionStrings:VoxPopuli_ConnectionString %>" SelectCommand="SELECT * FROM [congress2]"></asp:SqlDataSource>
    </form>
    </body>
</html>
