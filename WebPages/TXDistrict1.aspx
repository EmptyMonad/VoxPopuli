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
            <button id="upvote" runat="server" class="upvotebutton"></button>
            <button id="Bill1" runat="server" class="billbutton"></button>
                <h2 id="bill-name1" class="bname"><asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>&nbsp;John</h2>
                <p id="BillID1" class="bID"><asp:Label ID="Label2" runat="server" Text="ID: "></asp:Label> 12726</p>
                <p id="Link1" class="blink"><asp:Label ID="Label3" runat="server" Text="Link: "></asp:Label></p>
                <p id="result1" class="bresult"><asp:Label ID="Label4" runat="server" Text="Result: "></asp:Label></p>
                <p id="repvote1" class="bvote"><asp:Label ID="Label5" runat="server" Text="Rep. Vote: "></asp:Label></p>
              


            <button id="Bill2" runat="server" class="billbutton"></button>
                <h2 id="bill-name2" class="bname"><asp:Label ID="Label6" runat="server" Text="Name: "></asp:Label>name</h2>
                <p id="BillID2" class="bID"><asp:Label ID="Label7" runat="server" Text="ID: "></asp:Label>ID</p>
                <p id="Link2" class="blink"><asp:Label ID="Label8" runat="server" Text="Link: "></asp:Label>link<a></a></p>
                <p id="result2" class="bresult"><asp:Label ID="Label9" runat="server" Text="Result: "></asp:Label>result</p>
                <p id="repvote2" class="bvote"><asp:Label ID="Label10" runat="server" Text="Rep. Vote: "></asp:Label>vote</p>

            <button id="Bill3" runat="server" class="billbutton"></button>
                <h2 id="bill-name3" class="bname"><asp:Label ID="Label11" runat="server" Text="Name: "></asp:Label>name</h2>
                <p id="BillID3" class="bID"><asp:Label ID="Label12" runat="server" Text="ID: "></asp:Label>ID</p>
                <p id="Link3" class="blink"><asp:Label ID="Label13" runat="server" Text="link: "></asp:Label>link<a></a></p>
                <p id="result3" class="bresult"><asp:Label ID="Label14" runat="server" Text="Result: "></asp:Label>result</p>
                <p id="repvote3" class="bvote"><asp:Label ID="Label15" runat="server" Text="Rep. Vote: "></asp:Label>vote</p>

            <button id="Bill4" runat="server" class="billbutton"></button>
                <h2 id="bill-name4" class="bname"><asp:Label ID="Label16" runat="server" Text="Name: "></asp:Label>name</h2>
                <p id="BillID4" class="bID"><asp:Label ID="Label17" runat="server" Text="ID: "></asp:Label>ID</p>
                <p id="Link4" class="blink"><asp:Label ID="Label18" runat="server" Text="link: "></asp:Label>link<a></a></p>
                <p id="result4" class="bresult"><asp:Label ID="Label19" runat="server" Text="Result: "></asp:Label>result</p>
                <p id="repvote4" class="bvote"><asp:Label ID="Label20" runat="server" Text="Rep. Vote: "></asp:Label>vote</p>

            <button id="Bill5" runat="server" class="billbutton"></button>
                <h2 id="bill-name5" class="bname"><asp:Label ID="Label21" runat="server" Text="Name: "></asp:Label>name</h2>
                <p id="BillID5" class="bID"><asp:Label ID="Label22" runat="server" Text="ID: "></asp:Label>ID</p>
                <p id="Link5" class="blink"><asp:Label ID="Label23" runat="server" Text="Link: "></asp:Label>link<a></a></p>
                <p id="result5" class="bresult"><asp:Label ID="Label24" runat="server" Text="Result: "></asp:Label>result</p>
                <p id="repvote5" class="bvote"><asp:Label ID="Label25" runat="server" Text="Rep. Vote: "></asp:Label>vote</p>

            <button id="Bill6" runat="server" class="billbutton"></button>
                <h2 id="bill-name6" class="bname"><asp:Label ID="Label26" runat="server" Text="Name: "></asp:Label>name</h2>
                <p id="BillID6" class="bID"><asp:Label ID="Label27" runat="server" Text="ID: "></asp:Label>ID</p>
                <p id="Link6" class="blink"><asp:Label ID="Label28" runat="server" Text="Link: "></asp:Label>link<a></a></p>
                <p id="result6" class="bresult"><asp:Label ID="Label29" runat="server" Text="Result: "></asp:Label>result</p>
                <p id="repvote" class="bvote"><asp:Label ID="Label30" runat="server" Text="Vote: "></asp:Label>vote</p>




        </div>
    </form>
    <script src="../JavaScript/leaflet-sidebar.js"></script>
    <!-- <asp:SqlDataSource ID="VoxPopuliDB" runat="server" ConnectionString="<%$ ConnectionStrings:VoxPopuli_ConnectionString %>" SelectCommand="SELECT * FROM [congress2]"></asp:SqlDataSource> -->
    </body>
</html>
