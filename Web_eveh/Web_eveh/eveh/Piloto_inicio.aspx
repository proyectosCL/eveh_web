<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Piloto_inicio.aspx.cs" Inherits="Web_eveh.eveh.Piloto_inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
      <h1>Menu Piloto!</h1>
      <p>
          
          <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/eveh/Horas_piloto_helicoptero.aspx">Ver Horas de Vuelo de Helicoptero</asp:HyperLink>
      </p>
      <p>
          
          <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/eveh/Horas_piloto_avion.aspx">Ver Horas de Vuelo de Avion</asp:HyperLink>
      </p>
    </div>
    

</asp:Content>
