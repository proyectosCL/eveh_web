<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="horas_piloto_avion.aspx.cs" Inherits="Web_eveh.eveh.horas_piloto_avion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
      <h1>Horas de Piloto!</h1>
      <p>
          <asp:Label ID="lblHoras" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
          
      </p>
        <p>
            &nbsp;</p>
      <p>
          
          <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/eveh/Piloto_inicio.aspx">Volver</asp:HyperLink>
      </p>
    </div>

    
    
</asp:Content>
