<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGIN.aspx.cs" Inherits="PROJECT_PSD.View.LOGIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>LOGIN PAGE</p>
    </div>
    <br />
    <div>
        <a href="REGISTER.aspx">REGISTER</a>
    </div>
    <br />
    <br />
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="passwordTxt" type="password" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:CheckBox ID="rememberMeChk" runat="server" Text="Remember me"/>
        </div>
        <br />
        <br />
        <br />
        <div>
            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
            <br />
            <asp:Label ID="messageLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
