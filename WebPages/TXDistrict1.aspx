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

        <div id="RepInfo" class="Rep-Top">
            <!-- Image of the representative, default image used in case of error -->
            <asp:Image ID="RepPicture" ImageUrl="~/Images/louieg.jpg" runat="server" />
            <p id="RepNameHolder" runat="server">John Doe</p>
            <h2 id="twitterHandle" runat="server"></h2>
        </div>
        <div id="Bills" class="Scroll">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
            <asp:Imagebutton ID="upvote1" runat="server" cssclass="upvotebutton"  onclick="button_clicked"  ImageUrl= "~/Images/upvote-png-clear.png"/>
            <asp:Imagebutton id="downvote1" runat="server" class="downvotebutton" onclick="button_clicked"  ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:imagebutton id="Bill1" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png" PostBackUrl="google.com"></asp:imagebutton>
                <h2 id="billname1" class="bname" runat="server"></h2>
                <p id="BillID1" class="bID" runat="server"></p>
                <p id="result1" class="bresult" runat="server"></p>
                <p id="repvote1" class="bvote" runat="server"></p>
              

            <asp:Imagebutton id="upvote2" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" MaintainScrollPositionOnPostBack="true" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="downvote2" runat="server" class="downvotebutton" type="button" onclick="button_clicked" MaintainScrollPositionOnPostBack="true" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill2" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
                <h2 id="billname2" class="bname" runat="server"><asp:Label ID="Label6" runat="server" Text="Name: "></asp:Label>name</h2>
                <p id="BillID2" class="bID" runat="server"><asp:Label ID="Label7" runat="server" Text="ID: "></asp:Label>ID</p>
                <p id="Link2" class="blink" runat="server"><asp:Label ID="Label8" runat="server" Text="Link: "></asp:Label>link<a></a></p>
                <p id="result2" class="bresult" runat="server"><asp:Label ID="Label9" runat="server" Text="Result: "></asp:Label>result</p>
                <p id="repvote2" class="bvote" runat="server"><asp:Label ID="Label10" runat="server" Text="Rep. Vote: "></asp:Label>vote</p>

            <asp:Imagebutton id="upvote3" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="downvote3" runat="server" class="downvotebutton" type="button" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill3" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
                <h2 id="billname3" class="bname" runat="server" ><asp:Label ID="Label11" runat="server" Text="Name: "></asp:Label>name</h2>
                <p id="BillID3" class="bID" runat="server"><asp:Label ID="Label12" runat="server" Text="ID: "></asp:Label>ID</p>
                <p id="result3" class="bresult" runat="server"><asp:Label ID="Label14" runat="server" Text="Result: "></asp:Label>result</p>
                <p id="repvote3" class="bvote" runat="server"><asp:Label ID="Label15" runat="server" Text="Rep. Vote: "></asp:Label>vote</p>

            <asp:Imagebutton id="upvote4" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="downvote4" runat="server" class="downvotebutton" type="button" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill4" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
                <h2 id="billname4" class="bname"><asp:Label ID="Label16" runat="server" Text="Name: "></asp:Label>name</h2>
                <p id="BillID4" class="bID"><asp:Label ID="Label17" runat="server" Text="ID: "></asp:Label>ID</p>
                <p id="Link4" class="blink"><asp:Label ID="Label18" runat="server" Text="link: "></asp:Label>link<a></a></p>
                <p id="result4" class="bresult"><asp:Label ID="Label19" runat="server" Text="Result: "></asp:Label>result</p>
                <p id="repvote4" class="bvote"><asp:Label ID="Label20" runat="server" Text="Rep. Vote: "></asp:Label>vote</p>

            <asp:Imagebutton id="upvote5" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="downvote5" runat="server" class="downvotebutton" type="button" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill5" runat="server" class="billbutton" ImageUrl="~/Images/bill-default.png" ></asp:Imagebutton>
                <h2 id="billname5" class="bname"><asp:Label ID="Label21" runat="server" Text="Name: "></asp:Label>name</h2>
                <p id="BillID5" class="bID"><asp:Label ID="Label22" runat="server" Text="ID: "></asp:Label>ID</p>
                <p id="Link5" class="blink"><asp:Label ID="Label23" runat="server" Text="Link: "></asp:Label>link<a></a></p>
                <p id="result5" class="bresult"><asp:Label ID="Label24" runat="server" Text="Result: "></asp:Label>result</p>
                <p id="repvote5" class="bvote"><asp:Label ID="Label25" runat="server" Text="Rep. Vote: "></asp:Label>vote</p>

            <asp:Imagebutton id="upvote6" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png" ></asp:Imagebutton>
            <asp:Imagebutton id="downvote6" runat="server" class="downvotebutton" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill6" runat="server" class="billbutton" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
                <h2 id="billname6" class="bname"><asp:Label ID="Label26" runat="server" Text="Name: "></asp:Label>name</h2>
                <p id="BillID6" class="bID"><asp:Label ID="Label27" runat="server" Text="ID: "></asp:Label>ID</p>
                <p id="Link6" class="blink"><asp:Label ID="Label28" runat="server" Text="Link: "></asp:Label>link<a></a></p>
                <p id="result6" class="bresult"><asp:Label ID="Label29" runat="server" Text="Result: "></asp:Label>result</p>
                <p id="repvote" class="bvote"><asp:Label ID="Label30" runat="server" Text="RepVote: "></asp:Label>vote</p>


        </ContentTemplate>
        </asp:UpdatePanel>
        </div>
    </form>
    <script src="../JavaScript/leaflet-sidebar.js"></script>
    <asp:SqlDataSource ID="VoxPopuliDB" runat="server" ConnectionString="<%$ ConnectionStrings:VoxPopuli_ConnectionString %>" SelectCommand="SELECT * FROM [congress2]"></asp:SqlDataSource>
    </body>
</html>
