<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VIEW_MEDICINE.aspx.cs" Inherits="PROJECT_PSD.View.VIEW_MEDICINE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>VIEW MEDICINE PAGE</p>
    </div>
    <br />
    <div>
        <a href="HOME.aspx">HOME</a>
    </div>
    <br />
    <br />
    <form id="form1" runat="server">
        <asp:Button ID="insertMedicine" runat="server" Text="INSERT MEDICINE" OnClick="insertMedicine_Click" />
        <br />
        <br />
        <br />
        <br />
        <div>
            <asp:TextBox ID="searchTxt" runat="server"></asp:TextBox>
            <asp:Button ID="searchBtn" runat="server" Text="SEARCH" OnClick="searchBtn_Click" />
        </div>
        <div>
            Medicine:
            <br />

            <asp:GridView ID="gvAdmin" runat="server" OnRowDeleting="gvAdmin_RowDeleting" OnSelectedIndexChanged="gvAdmin_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="true" DeleteText="DELETE"/>
                </Columns>
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="UPDATE" ShowSelectButton="true"/>
                </Columns>
            </asp:GridView>

            <asp:GridView ID="gvMember" runat="server" OnSelectedIndexChanged="gvMember_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="ADD TO CART" ShowSelectButton="true"/>
                </Columns>
            </asp:GridView>

            <asp:Label ID="messageLbl" ForeColor="Red" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
