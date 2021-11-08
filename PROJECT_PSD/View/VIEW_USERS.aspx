<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VIEW_USERS.aspx.cs" Inherits="PROJECT_PSD.View.VIEW_USERS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>VIEW USERS PAGE</p>
    </div>
    <br />
    <div>
        <a href="HOME.aspx" style="margin-right: 30px">HOME</a>
    </div>

    <br />
    <br />
    <br />

    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvUser" runat="server" OnRowDeleting="gvUser_RowDeleting">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="true"/>
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <div>
            <asp:Label ID="messageLbl" ForeColor="Red" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>