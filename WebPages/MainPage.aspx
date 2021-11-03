<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="MapProject.WebPages.MainPage" %>


<!DOCTYPE html>

<html>
<head runat="server">

    <!-- This is the space used for api access and the hosted version
        of leaflet -->
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet">

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/gh/Turbo87/sidebar-v2@v0.4.0/css/leaflet-sidebar.css">

    <link rel="stylesheet" href="https://unpkg.com/leaflet@1.7.1/dist/leaflet.css"
          integrity="sha512-xodZBNTC5n17Xt2atTPuE1HxjVMSvLVW9ocqUKLsCC5CXdbqCmblAshOMAS6/keqq/sMZMZ19scR4PsZChSR7A=="
          crossorigin="" />

    <script src="https://unpkg.com/leaflet@1.7.1/dist/leaflet.js"
            integrity="sha512-XQoYMqMTK8LvdxXYG3nZ448hOEQiglfqkJs1NOQV44cWnUrBc8PkAOcXy20w0vlaXaVUearIOBhiXZ5V3ynxwA=="
            crossorigin=""></script>
    <!-- End api section -->

    <!-- Link to the stylesheet for the MainPage-->
    <link rel="stylesheet" href="../CSS/MainPage.css" />
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
                <div class="w3-bar w3-black">
                    <button class="w3-bar-item w3-button" onclick="openblock('About')">About</button>
                    <button class="w3-bar-item w3-button" onclick="openblock('Bills')">Bills</button>
                </div>
           
               <div id="About" class="Tabs">
                   <span onclick="this.parentElement.style.display='none'"
                    class="w3-button w3-display-topright"></span>
                  <h2>About</h2>
                <p id="polAbout"></p>
                </div>

                <div id="Bills" class="Tabs" style="display:none">
                  <h2>Bills</h2>
                  <p id="polBills"></p>
                </div>
           
         
            </div>

            <div class="sidebar-pane" id="messages">
                <h1 class="sidebar-header">Messages<span class="sidebar-close"><i class="fa fa-caret-left"></i></span></h1>
            </div>

            <div class="sidebar-pane" id="settings">
                <h1 class="sidebar-header">Settings<span class="sidebar-close"><i class="fa fa-caret-left"></i></span></h1>
            </div>
        </div>
    </div>
        <div id="mapid" class="sidebar-map"></div>
        <!-- Link to the Javascript for the main page -->
        <script src="../JavaScript/leaflet-sidebar.js"></script>
        <script src="../JavaScript/MainPageMap.js"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString2 %>" SelectCommand="SELECT * FROM [congress2]"></asp:SqlDataSource>
            <asp:Button ID="btn" runat="server" style="display:none;" autopostback="false" />
        </form>
        
    </body>
</html>
