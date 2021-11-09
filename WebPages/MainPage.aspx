<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="MapProject.WebPages.MainPage" %>


<!DOCTYPE html>

<html>
<head runat="server">

    <!-- This is the space used for api access and the hosted version
        of leaflet -->
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet"> <!-- Font for the Sidebar -->


    <link rel="stylesheet" href="https://unpkg.com/leaflet@1.7.1/dist/leaflet.css"
          integrity="sha512-xodZBNTC5n17Xt2atTPuE1HxjVMSvLVW9ocqUKLsCC5CXdbqCmblAshOMAS6/keqq/sMZMZ19scR4PsZChSR7A=="
          crossorigin="" /> <!-- Leaflet CSS CDN -->
    
    <script src="https://unpkg.com/leaflet@1.7.1/dist/leaflet.js"
            integrity="sha512-XQoYMqMTK8LvdxXYG3nZ448hOEQiglfqkJs1NOQV44cWnUrBc8PkAOcXy20w0vlaXaVUearIOBhiXZ5V3ynxwA=="
            crossorigin=""></script>  <!-- CDN for Leaflet Javascript Code -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-csv/0.71/jquery.csv-0.71.min.js"></script> <!-- CDN for JQuery -->

    <!-- End api section -->

    
    <link rel="stylesheet" href="../CSS/MainPage.css" /> <!-- Link to the stylesheet for the MainPage-->
    <link rel="stylesheet" href="../CSS/sidebar.css" />
    <title></title>
</head>
    <body>
    <form id="form1" runat="server">
    <div id="sidebar" class="sidebar collapsed">
        <!-- Nav tabs -->
        <div class="sidebar-tabs">
            <ul role="tablist">
                <li><a href="#profile" role="tab"><i class="fa fa-user"></i></a></li>
            </ul>

            <ul role="tablist">
                <li><a href="#settings" role="tab"><i class="fa fa-gear"></i></a></li>
            </ul>
        </div>

        <!-- Tab panes -->
        <div class="sidebar-content">

            
            <div class="sidebar-pane" id="profile" runat="server">
                <h1 class="sidebar-header" id="RepTitle" runat="server" >Representative Information<span class="sidebar-close"><i class="fa fa-caret-left"></i></span></h1>
                <div id ="repphoto"><img src="\Photos\30-307416_profile-icon-png-image-free-download-searchpng-employee.png" /></div>
            </div>

            <div class="sidebar-pane" id="messages">
                <h1 class="sidebar-header">Messages<span class="sidebar-close"><i class="fa fa-caret-left"></i></span></h1>
            </div>

            <div class="sidebar-pane" id="settings">
                <h1 class="sidebar-header">Settings<span class="sidebar-close"><i class="fa fa-caret-left"></i></span></h1>
            </div>
        </div>
        <div id="mapid" class="sidebar-map"></div>
        <asp:Button ID="hbtn" runat="server" OnClientClick="Javascript:call();"/>

        <!-- Link to the Javascript for the main page -->
        <script src="../JavaScript/leaflet-sidebar.js"></script>
        <script src="../JavaScript/MainPageMap.js"></script>

        
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VoxPopuliConnectionString2 %>" SelectCommand="SELECT * FROM [VotingInformation]"></asp:SqlDataSource>
            <asp:Button ID="btn" runat="server" style="display:none;" OnClick="btn_Click" autopostback="false" />
        </form>
        
    </body>
</html>
