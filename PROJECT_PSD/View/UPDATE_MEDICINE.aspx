<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UPDATE_MEDICINE.aspx.cs" Inherits="PROJECT_PSD.View.UPDATE_MEDICINE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>UPDATE MEDICINE PAGE</p>
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
            <asp:Label ID="Label1" runat="server" Text="Medicine Name: "></asp:Label>
            <asp:TextBox ID="medicineNameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Medicine Description: "></asp:Label>
            <asp:TextBox ID="medicineDescTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Medicine Stock: "></asp:Label>
            <asp:TextBox ID="medicineStockTxt" type="number" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Medicine Price: "></asp:Label>
            <asp:TextBox ID="medicinePriceTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="updateBtn" runat="server" Text="UPDATE MEDICINE" OnClick="updateBtn_Click" />
        </div>
        <div>
            <asp:Label ID="messageLbl" ForeColor="Red" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
