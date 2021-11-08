<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PROFILE.aspx.cs" Inherits="PROJECT_PSD.View.PROFILE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>PROFILE PAGE</p>
    </div>
    <br />
    <div>
        <a href="HOME.aspx">HOME</a>
    </div>
    <br />
    <br />
    <form id="form1" runat="server">
        <br />
        <div>
            <asp:Button ID="updateProfileBtn" runat="server" Text="UPDATE PROFILE" OnClick="updateProfileBtn_Click" />
            <asp:Button ID="changePasswordBtn" runat="server" Text="CHANGE PASSWORD" OnClick="changePasswordBtn_Click" />
        </div>
        <br />
        <br />
        <br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
            <asp:Label ID="usernameValue" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
            <asp:Label ID="nameValue" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Gender: "></asp:Label>
            <asp:Label ID="genderValue" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Phone Number: "></asp:Label>
            <asp:Label ID="phoneNumberValue" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Address: "></asp:Label>
            <asp:Label ID="addressValue" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
