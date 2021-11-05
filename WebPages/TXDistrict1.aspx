<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TXDistrict1.aspx.cs" Inherits="VoxPopuli.WebPages.TXDistrict1" %>

<!DOCTYPE html>
 <meta name="viewport" content="width=device-width, initial-scale=1.0"> 
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <!-- CSS for the RepPage -->
    <link rel="stylesheet" href="../CSS/RepPage.css" />
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/gh/Turbo87/sidebar-v2@v0.4.0/css/leaflet-sidebar.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 runat="server">Representative of </h1>

        <div id="RepInfo" class="Rep-Top">
            <!-- Image of the representative, default image used in case of error -->
            <asp:Image ID="RepPicture" ImageUrl="~/Photos/default_picture.png" runat="server" />
            <p id="RepNameHolder" runat="server">John Doe</p>
            <h2 id="twitterHandle" runat="server"></h2>
            <h3 runat="server" id="Office"></h3>
        </div>
        <div id="Bills" class="Scroll">
            <button id="Bill1" runat="server"></button>
                <p id="bill1-text">Hello there jnjdnjdnjdnjdnjdnjdnjdndjksndkjsndkjnskdnskjndkjsnjksndkjsndkjnskjdnskjdnkjsndkjsndjk</p>
            <button id="Bill2" runat="server"></button>
                <p id="bill2-text">hellothere2</p>
            <button id="Bill3" runat="server"></button>
                <p id="bill3-text">hi</p>
            <button id="Bill4" runat="server"></button>
                <p id="bill4-text">hi</p>
            <button id="Bill5" runat="server"></button>
                <p id="bill5-text">hi</p>
            <button id="Bill6" runat="server"></button>
                <p id="bill6-text">hi</p>


        </div>
    </form>
    <script src="../JavaScript/leaflet-sidebar.js"></script>
    <asp:SqlDataSource ID="VoxPopuliDB" runat="server" ConnectionString="<%$ ConnectionStrings:VoxPopuli_ConnectionString %>" SelectCommand="SELECT * FROM [congress2]"></asp:SqlDataSource>
    </body>
</html>
