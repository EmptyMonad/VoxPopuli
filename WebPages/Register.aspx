<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="VoxPopuli.WebPages.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="txtboxUsername" runat="server"></asp:TextBox>
            <asp:Label ID="lblUsernameExist" runat="server" ForeColor="Red" Text="*Username Already Taken" Visible="False"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtboxUsername" Display="Dynamic" ErrorMessage="*Required" ForeColor="Red">*Required</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtboxEmail" runat="server" TextMode="Email"></asp:TextBox>
            <asp:Label ID="lbEmailExist" runat="server" ForeColor="Red" Text="*An Account Already Exists With This Email" Visible="False"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtboxEmail" ErrorMessage="*Required" ForeColor="Red">*Required</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtboxPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtboxPassword" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*Required</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password: "></asp:Label>
            <asp:TextBox ID="txtboxConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ControlToValidate="txtboxConfirmPassword" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*Required</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" />
        </div>
    </form>
</body>
</html>

        </div>
    </form>
</body>
</html>
