<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepPage.aspx.cs" Inherits="VoxPopuli.WebPages.RepPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"> 
    <!-- CSS for the RepPage -->
    <link rel="stylesheet" href="../CSS/RepPage.css" />
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/gh/Turbo87/sidebar-v2@v0.4.0/css/leaflet-sidebar.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Representative of </h1>

        <div id="RepInfo" class="Rep-Top">
            <!-- Image of the representative, default image used in case of error -->
            <image src="\Photos\default_picture.png" id="RepImage" runat="server"></image>
            <p id="RepName" runat="server">John Doe</p>
            <p id="twitter">@person</p>
            <p id="Office"></p>
        </div>
        <div id="Bills" class="Scroll">
            <button id="Bill1"></button>
                <p id="bill1-text">Hello there jnjdnjdnjdnjdnjdnjdnjdndjksndkjsndkjnskdnskjndkjsnjksndkjsndkjnskjdnskjdnkjsndkjsndjk</p>
            <button id="Bill2"></button>
                <p id="bill2-text">hellothere2</p>
            <button id="Bill3"></button>
                <p id="bill3-text">hi</p>
            <button id="Bill4"></button>
                <p id="bill4-text">hi</p>
            <button id="Bill5"></button>
                <p id="bill5-text">hi</p>
            <button id="Bill6"></button>
                <p id="bill6-text">hi</p>


        </div>
    </form>
    <script src="../JavaScript/leaflet-sidebar.js"></script>
</body>
</html>
