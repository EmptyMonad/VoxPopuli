<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="MapProject.WebPages.MainPage" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <!-- This is the space used for api access and the hosted version
        of leaflet -->
    <link rel="stylesheet" href="https://unpkg.com/leaflet@1.7.1/dist/leaflet.css"
          integrity="sha512-xodZBNTC5n17Xt2atTPuE1HxjVMSvLVW9ocqUKLsCC5CXdbqCmblAshOMAS6/keqq/sMZMZ19scR4PsZChSR7A=="
          crossorigin="" />

    <script src="https://unpkg.com/leaflet@1.7.1/dist/leaflet.js"
            integrity="sha512-XQoYMqMTK8LvdxXYG3nZ448hOEQiglfqkJs1NOQV44cWnUrBc8PkAOcXy20w0vlaXaVUearIOBhiXZ5V3ynxwA=="
            crossorigin="">
    </script>
    <!-- End api section -->

    <!-- Link to the stylesheet for the MainPage-->
    <link rel="stylesheet" href="../CSS/MainPage.css" />
    <title></title>
</head>
<body>
        <div id="mapid">
            <!-- Map Content -->
        </div>
        <!-- Link to the Javascript for the main page -->
        <script src="../JavaScript/MainPageMap.js"></script>
</body>
</html>
