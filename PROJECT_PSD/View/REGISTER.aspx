<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="REGISTER.aspx.cs" Inherits="PROJECT_PSD.View.REGISTER" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>REGISTER PAGE</p>
    </div>
    <br />
    <div>
        <a href="LOGIN.aspx">Login</a>
    </div>
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="passwordTxt" runat="server" type="password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Confirm Password: "></asp:Label>
            <asp:TextBox ID="confirmPasswordTxt" type="password" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label7" runat="server" Text="Gender: "></asp:Label>
            <asp:DropDownList ID="dropDownListGender" runat="server">
                <asp:ListItem value="Male">  
                    Male
                </asp:ListItem>
                <asp:ListItem value="Female">  
                    Female  
                </asp:ListItem>  
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Phone Number: "></asp:Label>
            <asp:TextBox ID="phoneNumberTxt" type="number" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Address: "></asp:Label>
            <asp:TextBox ID="addressTxt" runat="server"></asp:TextBox>
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />
            <br />
            <asp:Label ID="messageLbl" Text="" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
