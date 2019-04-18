<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGE.Master" AutoEventWireup="true" CodeBehind="NEW_CUSTOMER.aspx.cs" Inherits="Home_Page.NEW_CUSTOMER" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
        <div>
            <asp:Label ID="lblInstructions" runat="server" Text="Please fill out the fields below to register for an account. "></asp:Label>
             <br />   <br /> 
            
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            <br />   <br /> 
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />   <br /> 
            
            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />   <br /> 

            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            <br />   <br /> 

            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />   <br /> 

             <asp:Label ID="lblStreet" runat="server" Text="Street Address"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
            <br />   <br /> 

             <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <br />   <br /> 

             <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            <br />   <br /> 

            <asp:Label ID="lblSSN" runat="server" Text="Social Security Number"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtSSN" runat="server"></asp:TextBox>
            <br />   <br /> 

            <asp:Label ID="lblAnnualIncome" runat="server" Text="Annual Income"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtAnnualIncome" runat="server"></asp:TextBox>
            <br />   <br /> 
            <asp:Button ID="btnLogin" runat="server" Text="Login" />
        </div>
 
</asp:Content>
