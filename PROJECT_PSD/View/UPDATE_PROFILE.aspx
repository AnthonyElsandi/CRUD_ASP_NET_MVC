<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UPDATE_PROFILE.aspx.cs" Inherits="PROJECT_PSD.View.UPDATE_PROFILE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>UPDATE PROFILE PAGE</p>
    </div>
    <br />
    <div>
        <a style="margin-right: 30px" href="HOME.aspx">HOME</a>
        <a href="PROFILE.aspx">PROFILE</a>
    </div>

    <br />
    <br />
    <br />

    <form id="form1" runat="server">
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
            <asp:Button ID="updateBtn" runat="server" Text="UPDATE" OnClick="updateBtn_Click" />
        </div>
        <div>
            <asp:Label ID="messageLbl" ForeColor="Red" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
