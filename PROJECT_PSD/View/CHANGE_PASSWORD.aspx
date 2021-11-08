<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CHANGE_PASSWORD.aspx.cs" Inherits="PROJECT_PSD.View.CHANGE_PASSWORD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>CHANGE PASSWORD PAGE</p>
    </div>
    <br />
    <div>
        <a href="HOME.aspx" style="margin-right: 30px">HOME</a>
        <a href="PROFILE.aspx">PROFILE</a>
    </div>
    
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Old Password: "></asp:Label>
            <asp:TextBox ID="oldPasswordTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="New Password: "></asp:Label>
            <asp:TextBox ID="newPasswordTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Confirm Password: "></asp:Label>
            <asp:TextBox ID="confirmPasswordTxt" runat="server"></asp:TextBox>
        </div>
        <br />
        <br />
        <br />
        <div>
            <asp:Button ID="changePassword" runat="server" Text="CHANGE PASSWORD" OnClick="changePassword_Click" />
        </div>
        <div>
            <asp:Label ID="messageLbl" ForeColor="Red" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
