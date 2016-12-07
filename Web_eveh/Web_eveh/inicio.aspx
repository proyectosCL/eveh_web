<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Web_eveh.inicio"    %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
      <div class="container">
        <div class="card card-container">
            <!-- <img class="profile-img-card" src="//lh3.googleusercontent.com/-6V8xOA6M7BA/AAAAAAAAAAI/AAAAAAAAAAA/rzlHcD0KYwo/photo.jpg?sz=120" alt="" /> -->
            <img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" />
            <p id="profile-name" class="profile-name-card"></p>
            &nbsp;
                <span id="reauth-email" class="reauth-email"></span>
                <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>&nbsp;&nbsp; <asp:TextBox ID="txtConstraseña" runat="server"></asp:TextBox>
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-lg btn-primary btn-block btn-signin" OnClick="Button1_Click" />
                
            
            
        </div><!-- /card-container -->
    </div><!-- /container -->
    
</asp:Content>
