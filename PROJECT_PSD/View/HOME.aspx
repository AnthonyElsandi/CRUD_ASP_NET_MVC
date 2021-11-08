<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HOME.aspx.cs" Inherits="PROJECT_PSD.View.HOME" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <p>HOME PAGE</p>
    </div>
    <br />
    <div>
        <h1>
            <asp:Label ID="usernameLbl" ForeColor="#660066" runat="server" Text=""></asp:Label>
        </h1>
    </div>
    <br />
    <br />
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="viewCartBtn" hidden="" runat="server" Text="VIEW CART" OnClick="viewCartBtn_Click"/>
        </div>
        <div>
            <asp:Button ID="viewTransactionHistoryBtn" hidden="" runat="server" Text="VIEW TRANSACTION HISTORY" OnClick="viewTransactionHistoryBtn_Click"/>
        </div>
        <div>
            <asp:Button ID="insertMedicineBtn" hidden="" runat="server" Text="INSERT MEDICINE" OnClick="insertMedicineBtn_Click"/>
        </div>
        <div>
            <asp:Button ID="viewUsersBtn" hidden="" runat="server" Text="VIEW USERS" OnClick="viewUsersBtn_Click"/>
        </div>
        <div>
            <asp:Button ID="viewTransactionReportBtn" hidden="" runat="server" Text="VIEW TRANSACTION REPORT" OnClick="viewTransactionReportBtn_Click"/>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="VIEW MEDICINES" OnClick="viewMedicinesBtn_Click"/>
        </div>
        <div>
            <asp:Button ID="viewProfileBtn" runat="server" Text="VIEW PROFILE" OnClick="viewProfileBtn_Click"/>
        </div>
        <br />
        <br />
        <br />
        <br />
        <div>
            <asp:Button ID="logoutBtn" runat="server" Text="LOG OUT" OnClick="logoutBtn_Click" />
        </div>
    </form>
</body>
</html>
