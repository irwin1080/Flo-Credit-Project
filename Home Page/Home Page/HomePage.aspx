<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Home_Page.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
     <%-- Required metatags --%>
    <meta charset ="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" /> 
    
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous"/>

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js"> </script>


    <title>Flo Credit</title>
</head>
<body>
    <div class="row align-items-center justify-content-center"> 
        <img src="Images/Flo Credit Logo.png" height ="200 " width ="500 " />
    </div> 

    <form id="form1" >
        <div>
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                <a class="navbar-brand" href="#">Home</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle Navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="navbar-collapse collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto"> 
                        <li class="nav-item active">
                            <a class ="nav-link" href="#">Login</a>
                        </li>
                         <li class="nav-item active">
                            <a class ="nav-link" href="#">Apply</a>
                        </li>
                        <li class="nav-item active">
                            <a class ="nav-link" href="#">Products</a>
                        </li>
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" >
                                Services 
                            </a>
                            <div class="dropdown-menu"> 
                                <a class="dropdown-item" href="#">Loans</a>
                                <div class="dropdown-divider"></div>
                                <a class="dropdown-item" href="#">Home Mortgages</a>
                                <div class="dropdown-divider"></div>
                                <a class="dropdown-item" href="#">Small Business Assistance</a>
                                <div class="dropdown-divider"></div>
                                <a class="dropdown-item" href="#">Financial Consulting</a>
                             </div >
                        </li>
                    </ul>           
                </div>
         </nav>   
     </div>
     </form>

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
</body>
</html>


