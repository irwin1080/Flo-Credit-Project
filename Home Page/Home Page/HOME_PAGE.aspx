<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGE.Master" AutoEventWireup="true" CodeBehind="HOME_PAGE.aspx.cs" Inherits="Home_Page.HOME_PAGE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="row align-items-center justify-content-center"> 
     <div id="carouselExample" class="carousel" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#carouselExample" data-slide-to="0" class="active"> </li>
            <li data-target="#carouselExample" data-slide-to="1"> </li>
            <li data-target="#carouselExample" data-slide-to="2"> </li>
            <li data-target="#carouselExample" data-slide-to="3"> </li>
        </ol>

        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="Images/card.jpg" />
            </div>
                <div class="carousel-item">
                <img src="Images/card 2.jpg" />
            </div>
                <div class="carousel-item">
                 <img src="Images/card 3.jpg" />
            </div>
                <div class="carousel-item">
                <img src="Images/card 4.jpg" />
            </div>
        </div>
    </div>
   </div>
</asp:Content>
