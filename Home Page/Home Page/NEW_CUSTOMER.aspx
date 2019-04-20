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

             <asp:Label ID="lblStreet1" runat="server" Text="Street Address 1"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox>
            <br />   <br /> 

              <asp:Label ID="lblStreet2" runat="server" Text="Street Address 2"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtStreet2" runat="server"></asp:TextBox>
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

            <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />   <br /> 

             <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
             <br />   <br /> 
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />   <br /> 

            <asp:Button ID="btnRegister" runat="server" Text="Register" />
        </div>
 
</asp:Content>
