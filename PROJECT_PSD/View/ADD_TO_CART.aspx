<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ADD_TO_CART.aspx.cs" Inherits="PROJECT_PSD.View.ADD_TO_CART" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>ADD TO CART PAGE</p>
    </div>
    <br />
    <br />
    <div>
        <a href="HOME.aspx" style="margin-right: 30px">HOME</a>
        <a href="VIEW_MEDICINE.aspx">VIEW MEDICINE</a>
    </div>
    
    <br />
    <br />
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Medicine Name: "></asp:Label>
            <asp:Label ID="medicineNameTxt" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Medicine Desc: "></asp:Label>
            <asp:Label ID="medicineDescTxt" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Medicine Current Stock: "></asp:Label>
            <asp:Label ID="medicineStockTxt" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Medicine Price: "></asp:Label>
            <asp:Label ID="medicinePriceTxt" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <br />
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Input quantity: "></asp:Label>
            <asp:TextBox ID="inputQuantityTxt" type="number" runat="server"></asp:TextBox>
            <asp:Button ID="addToCart" runat="server" Text="Add To Cart" OnClick="addToCart_Click" />
        </div>
        <asp:Label ID="messageLbl" ForeColor="Red" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
