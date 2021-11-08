<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VIEW_CART.aspx.cs" Inherits="PROJECT_PSD.View.VIEW_CART" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>VIEW CART PAGE</p>
    </div>
    <br />
    <div>
        <a href="HOME.aspx" style="margin-right: 30px">HOME</a>
        <a href="VIEW_MEDICINE.aspx">VIEW MEDICINE</a>
    </div>
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvCart" runat="server" OnRowDeleting="gvCart_RowDeleting">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="true" DeleteText="DELETE" />
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <div>
            <asp:Label ID="grandTotalLbl" runat="server" Text="Grand Total: "></asp:Label>
            <asp:Label ID="grandTotalTxt" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <br />
        <div>
            <asp:Label ID="messageLbl" runat="server" ForeColor="Red" Text=""></asp:Label>
        </div>
        <br />
        <br />
        <br />
        <div>
            <asp:Button ID="checkOut" runat="server" Text="CHECK OUT" OnClick="checkOut_Click" />
        </div>
    </form>
    
    <br />
    <br />
    
</body>
</html>
