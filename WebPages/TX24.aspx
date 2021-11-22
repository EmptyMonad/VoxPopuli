<%@ Page Title="" Language="C#" MasterPageFile="~/WebPages/RepMaster.Master" AutoEventWireup="true" CodeBehind="TX24.aspx.cs" Inherits="VoxPopuli.WebPages.TX24" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <!-- CSS for the RepPage -->
    <link rel="stylesheet" href="../CSS/RepPage.css" />
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/gh/Turbo87/sidebar-v2@v0.4.0/css/leaflet-sidebar.css"/>
    <script src="../JavaScript/RepPage.js" ></script>
    <title></title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div id="PageTitle" class="DTitle">
        <h1 id="DistrictTitle" runat="server"></h1>
    </div>
     <div id="RepInfo" class="Rep-Top">
            <!-- Image of the representative, default image used in case of error -->
            <asp:Image ID="RepPicture" ImageUrl="~/Images/default_picture.png" runat="server" />
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
              

            <asp:Imagebutton id="upvote2" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="downvote2" runat="server" class="downvotebutton" type="button" onclick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill2" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
                <h2 id="billname2" class="bname" runat="server"></h2>
                <p id="BillID2" class="bID" runat="server"></p>
                <p id="result2" class="bresult" runat="server"></p>
                <p id="repvote2" class="bvote" runat="server"></p>

            <asp:Imagebutton id="upvote3" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="downvote3" runat="server" class="downvotebutton" type="button" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill3" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
            <h2 id="billname3" class="bname" runat="server"></h2>
                <p id="BillID3" class="bID" runat="server"></p>
                <p id="result3" class="bresult" runat="server"></p>
                <p id="repvote3" class="bvote" runat="server"></p>

            <asp:Imagebutton id="upvote4" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="downvote4" runat="server" class="downvotebutton" type="button" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill4" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
             <h2 id="billname4" class="bname" runat="server"></h2>
                <p id="BillID4" class="bID" runat="server"></p>
                <p id="result4" class="bresult" runat="server"></p>
                <p id="repvote4" class="bvote" runat="server"></p>

            <asp:Imagebutton id="upvote5" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="downvote5" runat="server" class="downvotebutton" type="button" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill5" runat="server" class="billbutton" ImageUrl="~/Images/bill-default.png" ></asp:Imagebutton>
               <h2 id="billname5" class="bname" runat="server"></h2>
                <p id="BillID5" class="bID" runat="server"></p>
                <p id="result5" class="bresult" runat="server"></p>
                <p id="repvote5" class="bvote" runat="server"></p>

            <asp:Imagebutton id="upvote6" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png" ></asp:Imagebutton>
            <asp:Imagebutton id="downvote6" runat="server" class="downvotebutton" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill6" runat="server" class="billbutton" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
           <h2 id="billname6" class="bname" runat="server"></h2>
                <p id="BillID6" class="bID" runat="server"></p>
                <p id="result6" class="bresult" runat="server"></p>
                <p id="repvote6" class="bvote" runat="server"></p>

              <asp:Imagebutton id="upvote7" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png" ></asp:Imagebutton>
            <asp:Imagebutton id="downvote7" runat="server" class="downvotebutton" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Bill7" runat="server" class="billbutton" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
           <h2 id="billname7" class="bname" runat="server"></h2>
                <p id="BillID7" class="bID" runat="server"></p>
                <p id="result7" class="bresult" runat="server"></p>
                <p id="repvote7" class="bvote" runat="server"></p>

       <asp:Imagebutton id='upvote8' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> 
       <asp:Imagebutton id='downvote8' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton>
       <asp:Imagebutton id='Bill8' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname8' class='bname' runat='server'></h2> <p id='BillID8' class='bID' runat='server'></p> <p id='result8' class='bresult' runat='server'></p> <p id='repvote8' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote9' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote9' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill9' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname9' class='bname' runat='server'></h2> <p id='BillID9' class='bID' runat='server'></p> <p id='result9' class='bresult' runat='server'></p> <p id='repvote9' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote10' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote10' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill10' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname10' class='bname' runat='server'></h2> <p id='BillID10' class='bID' runat='server'></p> <p id='result10' class='bresult' runat='server'></p> <p id='repvote10' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote11' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote11' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill11' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname11' class='bname' runat='server'></h2> <p id='BillID11' class='bID' runat='server'></p> <p id='result11' class='bresult' runat='server'></p> <p id='repvote11' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote12' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote12' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill12' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname12' class='bname' runat='server'></h2> <p id='BillID12' class='bID' runat='server'></p> <p id='result12' class='bresult' runat='server'></p> <p id='repvote12' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote13' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote13' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill13' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname13' class='bname' runat='server'></h2> <p id='BillID13' class='bID' runat='server'></p> <p id='result13' class='bresult' runat='server'></p> <p id='repvote13' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote14' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote14' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill14' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname14' class='bname' runat='server'></h2> <p id='BillID14' class='bID' runat='server'></p> <p id='result14' class='bresult' runat='server'></p> <p id='repvote14' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote15' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote15' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill15' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname15' class='bname' runat='server'></h2> <p id='BillID15' class='bID' runat='server'></p> <p id='result15' class='bresult' runat='server'></p> <p id='repvote15' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote16' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote16' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill16' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname16' class='bname' runat='server'></h2> <p id='BillID16' class='bID' runat='server'></p> <p id='result16' class='bresult' runat='server'></p> <p id='repvote16' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote17' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote17' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill17' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname17' class='bname' runat='server'></h2> <p id='BillID17' class='bID' runat='server'></p> <p id='result17' class='bresult' runat='server'></p> <p id='repvote17' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote18' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote18' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill18' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname18' class='bname' runat='server'></h2> <p id='BillID18' class='bID' runat='server'></p> <p id='result18' class='bresult' runat='server'></p> <p id='repvote18' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote19' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote19' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill19' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname19' class='bname' runat='server'></h2> <p id='BillID19' class='bID' runat='server'></p> <p id='result19' class='bresult' runat='server'></p> <p id='repvote19' class='bvote' runat='server'></p>
<asp:Imagebutton id='upvote20' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='downvote20' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Bill20' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='billname20' class='bname' runat='server'></h2> <p id='BillID20' class='bID' runat='server'></p> <p id='result20' class='bresult' runat='server'></p> <p id='repvote20' class='bvote' runat='server'></p>


        </ContentTemplate>
        </asp:UpdatePanel>
        </div>
    <asp:SqlDataSource ID="VoxPopuliDB" runat="server" ConnectionString="<%$ ConnectionStrings:VoxPopuli_ConnectionString %>" SelectCommand="SELECT * FROM [Bill3]"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
       <!-- CSS for the RepPage -->
    <link rel="stylesheet" href="../CSS/RepPage.css" />
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/gh/Turbo87/sidebar-v2@v0.4.0/css/leaflet-sidebar.css"/>
    <script src="../JavaScript/RepPage.js" ></script>
    <title></title>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
     <div id="PageTitle" class="DTitle">
        <h1 id="H1" runat="server"></h1>
    </div>
     <div id="RepInfo" class="Rep-Top">
            <!-- Image of the representative, default image used in case of error -->
            <asp:Image ID="Image1" ImageUrl="~/Images/default_picture.png" runat="server" />
            <p id="P1" runat="server">John Doe</p>
            <h2 id="H2" runat="server"></h2>
        </div>
        <div id="Bills" class="Scroll">
            <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
            <asp:Imagebutton ID="Imagebutton1" runat="server" cssclass="upvotebutton"  onclick="button_clicked"  ImageUrl= "~/Images/upvote-png-clear.png"/>
            <asp:Imagebutton id="Imagebutton2" runat="server" class="downvotebutton" onclick="button_clicked"  ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:imagebutton id="Imagebutton3" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png" PostBackUrl="google.com"></asp:imagebutton>
                <h2 id="H3" class="bname" runat="server"></h2>
                <p id="P2" class="bID" runat="server"></p>
                <p id="P3" class="bresult" runat="server"></p>
                <p id="P4" class="bvote" runat="server"></p>
              

            <asp:Imagebutton id="Imagebutton4" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton5" runat="server" class="downvotebutton" type="button" onclick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton6" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
                <h2 id="H4" class="bname" runat="server"></h2>
                <p id="P5" class="bID" runat="server"></p>
                <p id="P6" class="bresult" runat="server"></p>
                <p id="P7" class="bvote" runat="server"></p>

            <asp:Imagebutton id="Imagebutton7" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton8" runat="server" class="downvotebutton" type="button" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton9" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
            <h2 id="H5" class="bname" runat="server"></h2>
                <p id="P8" class="bID" runat="server"></p>
                <p id="P9" class="bresult" runat="server"></p>
                <p id="P10" class="bvote" runat="server"></p>

            <asp:Imagebutton id="Imagebutton10" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton11" runat="server" class="downvotebutton" type="button" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton12" runat="server" class="billbutton" type="button" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
             <h2 id="H6" class="bname" runat="server"></h2>
                <p id="P11" class="bID" runat="server"></p>
                <p id="P12" class="bresult" runat="server"></p>
                <p id="P13" class="bvote" runat="server"></p>

            <asp:Imagebutton id="Imagebutton13" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton14" runat="server" class="downvotebutton" type="button" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton15" runat="server" class="billbutton" ImageUrl="~/Images/bill-default.png" ></asp:Imagebutton>
               <h2 id="H7" class="bname" runat="server"></h2>
                <p id="P14" class="bID" runat="server"></p>
                <p id="P15" class="bresult" runat="server"></p>
                <p id="P16" class="bvote" runat="server"></p>

            <asp:Imagebutton id="Imagebutton16" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png" ></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton17" runat="server" class="downvotebutton" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton18" runat="server" class="billbutton" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
           <h2 id="H8" class="bname" runat="server"></h2>
                <p id="P17" class="bID" runat="server"></p>
                <p id="P18" class="bresult" runat="server"></p>
                <p id="P19" class="bvote" runat="server"></p>

              <asp:Imagebutton id="Imagebutton19" runat="server" class="upvotebutton" type="button" OnClick="button_clicked" ImageUrl= "~/Images/upvote-png-clear.png" ></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton20" runat="server" class="downvotebutton" OnClick="button_clicked" ImageUrl="~/Images/downvote-clear.png"></asp:Imagebutton>
            <asp:Imagebutton id="Imagebutton21" runat="server" class="billbutton" ImageUrl="~/Images/bill-default.png"></asp:Imagebutton>
           <h2 id="H9" class="bname" runat="server"></h2>
                <p id="P20" class="bID" runat="server"></p>
                <p id="P21" class="bresult" runat="server"></p>
                <p id="P22" class="bvote" runat="server"></p>

       <asp:Imagebutton id='Imagebutton22' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> 
       <asp:Imagebutton id='Imagebutton23' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton>
       <asp:Imagebutton id='Imagebutton24' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H10' class='bname' runat='server'></h2> <p id='P23' class='bID' runat='server'></p> <p id='P24' class='bresult' runat='server'></p> <p id='P25' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton25' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton26' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton27' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H11' class='bname' runat='server'></h2> <p id='P26' class='bID' runat='server'></p> <p id='P27' class='bresult' runat='server'></p> <p id='P28' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton28' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton29' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton30' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H12' class='bname' runat='server'></h2> <p id='P29' class='bID' runat='server'></p> <p id='P30' class='bresult' runat='server'></p> <p id='P31' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton31' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton32' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton33' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H13' class='bname' runat='server'></h2> <p id='P32' class='bID' runat='server'></p> <p id='P33' class='bresult' runat='server'></p> <p id='P34' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton34' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton35' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton36' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H14' class='bname' runat='server'></h2> <p id='P35' class='bID' runat='server'></p> <p id='P36' class='bresult' runat='server'></p> <p id='P37' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton37' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton38' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton39' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H15' class='bname' runat='server'></h2> <p id='P38' class='bID' runat='server'></p> <p id='P39' class='bresult' runat='server'></p> <p id='P40' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton40' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton41' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton42' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H16' class='bname' runat='server'></h2> <p id='P41' class='bID' runat='server'></p> <p id='P42' class='bresult' runat='server'></p> <p id='P43' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton43' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton44' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton45' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H17' class='bname' runat='server'></h2> <p id='P44' class='bID' runat='server'></p> <p id='P45' class='bresult' runat='server'></p> <p id='P46' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton46' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton47' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton48' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H18' class='bname' runat='server'></h2> <p id='P47' class='bID' runat='server'></p> <p id='P48' class='bresult' runat='server'></p> <p id='P49' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton49' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton50' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton51' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H19' class='bname' runat='server'></h2> <p id='P50' class='bID' runat='server'></p> <p id='P51' class='bresult' runat='server'></p> <p id='P52' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton52' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton53' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton54' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H20' class='bname' runat='server'></h2> <p id='P53' class='bID' runat='server'></p> <p id='P54' class='bresult' runat='server'></p> <p id='P55' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton55' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton56' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton57' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H21' class='bname' runat='server'></h2> <p id='P56' class='bID' runat='server'></p> <p id='P57' class='bresult' runat='server'></p> <p id='P58' class='bvote' runat='server'></p>
<asp:Imagebutton id='Imagebutton58' runat='server' class='upvotebutton' type='button' OnClick='button_clicked' ImageUrl= '~/Images/upvote-png-clear.png' ></asp:Imagebutton> <asp:Imagebutton id='Imagebutton59' runat='server' class='downvotebutton' OnClick='button_clicked' ImageUrl='~/Images/downvote-clear.png'></asp:Imagebutton> <asp:Imagebutton id='Imagebutton60' runat='server' class='billbutton' ImageUrl='~/Images/bill-default.png'></asp:Imagebutton> <h2 id='H22' class='bname' runat='server'></h2> <p id='P59' class='bID' runat='server'></p> <p id='P60' class='bresult' runat='server'></p> <p id='P61' class='bvote' runat='server'></p>


        </ContentTemplate>
        </asp:UpdatePanel>
        </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VoxPopuli_ConnectionString %>" SelectCommand="SELECT * FROM [Bill3]"></asp:SqlDataSource>
</asp:Content>
