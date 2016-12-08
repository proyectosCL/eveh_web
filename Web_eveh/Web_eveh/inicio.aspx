<%@ Page Title="" Language="C#" MasterPageFile="~/maste_inicio.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Web_eveh.inicio"    %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container">
	<div class="card card-container">
		<div class="jumbotron">
			<h1>Iniciar Sesión!</h1>
			<div class="row">
				<div class="col-xs-1"></div>
				<div class="col-xs-1"><img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" /></div>
				<div class="col-xs-1"></div>
			</div>
			<div class="row">
				<div class="col-xs-2">Usuario:</div>
				<div class="col-xs-2">
					<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
				</div>
			</div>
			<div class="row">
				<div class="col-xs-2">Contraseña</div>
				<div class="col-xs-2">
					<asp:TextBox ID="txtConstraseña" runat="server" TextMode="Password"></asp:TextBox>
				</div>
			</div>
			<div class="row">
				<div class="col-xs-8">
					<asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-lg btn-primary btn-block btn-signin" OnClick="Button1_Click" />
				</div>
			</div>
		</div>
	</div>
	<!-- /card-container -->
</div>
<!-- /container -->
</asp:Content>
