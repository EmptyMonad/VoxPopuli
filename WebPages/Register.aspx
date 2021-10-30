<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" UnobtrusiveValidationMode="None" Inherits="VoxPopuli.WebPages.Register" %>

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
            <asp:Label ID="lblEmailExist" runat="server" ForeColor="Red" Text="*An Account Already Exists With This Email" Visible="False"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtboxEmail" ErrorMessage="*Required" ForeColor="Red">*Required</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtboxPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtboxPassword" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*Required</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password: "></asp:Label>
            <asp:TextBox ID="txtboxConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="cvPassword" runat="server" ControlToCompare="txtboxPassword" ControlToValidate="txtboxConfirmPassword" ErrorMessage="*Passwords Do Not Match!" ForeColor="Red"></asp:CompareValidator>
            <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ControlToValidate="txtboxConfirmPassword" ErrorMessage="RequiredFieldValidator" ForeColor="Red" Display="Dynamic">*Required</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <br />
            <asp:Label ID="lblPasswordReq" runat="server" ForeColor="Red" Text="*Password does not meet requirements. Password must be at least 8 characters, contain an uppercase letter, a lowercase letter, and a digit." Visible="False"></asp:Label>
            <br />
            <asp:Label ID="lblUserReq" runat="server" ForeColor="Red" Text="*Username does not meet requirements. Username must be longer than 5 characters, must not exceed 20 characters, and must not contain any spaces. " Visible="False"></asp:Label>
            <br />
            <asp:Label ID="lblEmailReq" runat="server" ForeColor="Red" Text="*Email Format Invalid" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="lblTest" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VoxPopuli_ConnectionString %>" SelectCommand="SELECT * FROM [VP_Users]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>

        </div>
    </form>
</body>
</html>
