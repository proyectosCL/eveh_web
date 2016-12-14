<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Piloto_inicio.aspx.cs" Inherits="Web_eveh.eveh.Piloto_inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
      <h1>Menu Piloto!</h1>
      <p>
          
          <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/eveh/aeronaves_en_mantenimiento.aspx">Ver Aeronaves en Mantención</asp:HyperLink>
      </p>
      <p>
          
          <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/eveh/Horas_piloto_avion.aspx">Ver Mis Horas de Vuelo</asp:HyperLink>
      </p>
        <p>
          
          <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/eveh/Mantenimientos_realizados.aspx">Ver Mantenimientos realizados</asp:HyperLink>
      </p>
    </div>
    

</asp:Content>
