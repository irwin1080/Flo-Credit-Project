<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New Customer.aspx.cs" Inherits="Home_Page.New_Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInstructions" runat="server" Text="Please fill out the fields below to register for an account. "></asp:Label>
             <br />   <br /> 
            
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            <br />   <br /> 
            
            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
             <br />   <br /> 

            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
             <br />   <br /> 

            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
             <br />   <br /> 

             <asp:Label ID="lblStreet" runat="server" Text="Street Address"></asp:Label>
             <br />   <br /> 

             <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
             <br />   <br /> 

             <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
             <br />   <br /> 

            <asp:Label ID="lblSSN" runat="server" Text="Social Security Number"></asp:Label>
             <br />   <br /> 

            <asp:Label ID="lblAnnualIncome" runat="server" Text="Annual Income"></asp:Label>
             <br />   <br /> 
        </div>
    </form>
</body>
</html>
