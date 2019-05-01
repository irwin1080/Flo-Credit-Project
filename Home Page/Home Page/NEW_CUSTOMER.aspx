<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGE.Master" AutoEventWireup="true" CodeBehind="NEW_CUSTOMER.aspx.cs" Inherits="Home_Page.NEW_CUSTOMER" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
        <div>
            <asp:Label ID="lblInstructions" runat="server" Text="Please fill out the fields below to register for an account. " BorderStyle="None"></asp:Label>
             <br />   <br /> 
          
            
         <table class="table table-active" style="background-color: #FFFFFF"> 
            <thead style="border-top-style: none"> 
                <tr style="background-color: #FFFFFF"> 
                    <td>
                         <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label> 
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ForeColor="Red">*</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
           <br />   <br /> 
            
           <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ForeColor="Red">*</asp:RequiredFieldValidator> 
           <br />   <br /> 
           <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
           <br />   <br /> 

           <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDOB" ForeColor="Red">* (mm/dd/yyyy)</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
           <br />   <br /> 

           <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ForeColor="Red">*</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
           <br />   <br /> 

           <asp:Label ID="lblStreet1" runat="server" Text="Street Address 1"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtStreet1" ForeColor="Red">*</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox>
           <br />   <br /> 

           <asp:Label ID="lblStreet2" runat="server" Text="Street Address 2"></asp:Label>
           <br />   <br /> 
           <asp:TextBox ID="txtStreet2" runat="server" ></asp:TextBox>
           <br />   <br /> 
          
           <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCity" ForeColor="Red">*</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
           <br />   <br /> 
                    </td>
                    <td> 
            

           <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtState" ForeColor="Red">* XX</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
           <br />   <br /> 

           <asp:Label ID="lblZipCode" runat="server" Text="ZipCode"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtZipCode" ForeColor="Red">* XXXXX</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
           <br />   <br />

           <asp:Label ID="lblSSN" runat="server" Text="Social Security Number"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtSSN" ForeColor="Red">* ###-##-####</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtSSN" runat="server"></asp:TextBox>
           <br />   <br /> 
            
           <asp:Label ID="lblAnnualIncome" runat="server" Text="Annual Income"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtAnnualIncome" ForeColor="Red">*</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtAnnualIncome" runat="server"></asp:TextBox>
           <br />   <br /> 

           <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtUserName" ForeColor="Red">*</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
           <br />   <br /> 

           <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtPassword" ForeColor="Red">*</asp:RequiredFieldValidator>
           <br />   <br /> 
           <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
           
                        
           <br />   <br /> 
           <br />   <br /> 
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                    </td>
                </tr>
            </thead>
         </table>
          
          
          
           
        </div>
 
</asp:Content>
