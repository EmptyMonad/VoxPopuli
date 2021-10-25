<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="MapProject.WebPages.MainPage" %>

<!DOCTYPE html>

<html>
<head runat="server">


    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet">
          

    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js"></script>

    <link rel="stylesheet" href="../CSS/sidebar.css">

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
    <div id="sidebar" class="sidebar collapsed">
        <!-- Nav tabs -->
        <div class="sidebar-tabs">
            <ul role="tablist">
                <li><a href="#home" role="tab"><i class="fa fa-bars"></i></a></li>
                <li><a href="#profile" role="tab"><i class="fa fa-user"></i></a></li>
            </ul>

            <ul role="tablist">
                <li><a href="#settings" role="tab"><i class="fa fa-gear"></i></a></li>
            </ul>
        </div>

        <!-- Tab panes -->
        <div class="sidebar-content">
            <div class="sidebar-pane" id="home">
                <h1 class="sidebar-header">
                    sidebar-v2
                    <span class="sidebar-close"><i class="fa fa-caret-left"></i></span>
                </h1>

                <p>A responsive sidebar for mapping libraries like <a href="http://leafletjs.com/">Leaflet</a> or <a href="http://openlayers.org/">OpenLayers</a>.</p>

            </div>

            <div class="sidebar-pane" id="profile">
                <h1 class="sidebar-header">Profile<span class="sidebar-close"><i class="fa fa-caret-left"></i></span></h1>
                <img src="../Pictures/example-Image.png" id="RepImage" />
                <p id="RepName">Example Name</p>
                <div class="w3-bar w3-black">
                    <button class="w3-bar-item w3-button" onclick="openCity('About')">About</button>
                    <button class="w3-bar-item w3-button" onclick="openCity('Bills')">Bills</button>
                </div>
           
               <div id="About" class="city">
                   <span onclick="this.parentElement.style.display='none'"
                    class="w3-button w3-display-topright">X</span>
                  <h2>About</h2>
                <p id="polAbout"></p>
                </div>

                <div id="Bills" class="city" style="display:none">
                  <h2>Bills</h2>
                  <p id="polBills"></p>
                </div>
           </div>
         
            
            </div>
         

            <div class="sidebar-pane" id="settings">
                <h1 class="sidebar-header">Settings<span class="sidebar-close"><i class="fa fa-caret-left"></i></span></h1>
            </div>
        </div>
        <div id="mapid" class="sidebar-map"></div>
        <!-- Link to the Javascript for the main page -->
        <script src="../JavaScript/leaflet-sidebar.js"></script>
        <script src="../JavaScript/MainPageMap.js"></script>
    <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [congress2]"></asp:SqlDataSource>
    </body>
</html>
