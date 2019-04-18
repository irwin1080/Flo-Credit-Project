<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGE.Master" AutoEventWireup="true" CodeBehind="LOGIN_PAGE.aspx.cs" Inherits="Home_Page.LOGIN_PAGE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div>
            <asp:Label ID="Label3" runat="server" Text="Enter User ID"></asp:Label>
            <br />
            <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Enter Password"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login"/>
            <br />  
            <br />
            <asp:Label ID="lblLoginMsg" runat="server" Text=" "></asp:Label>
        </div>

</asp:Content>
