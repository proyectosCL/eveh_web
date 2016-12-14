<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mantenimientos_realizados.aspx.cs" Inherits="Web_eveh.eveh.aeronaves_en_mantenimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="jumbotron">
      <h1>Mantenimientos realizados</h1>
      <p>
          
          <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/eveh/Piloto_inicio.aspx">Volver</asp:HyperLink>
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
              <Columns>
                  <asp:BoundField DataField="ID Mantenimiento" HeaderText="ID Mantenimiento" SortExpression="ID Mantenimiento" />
                  <asp:BoundField DataField="Aeronave" HeaderText="Aeronave" SortExpression="Aeronave" />
                  <asp:BoundField DataField="Plan" HeaderText="Plan" SortExpression="Plan" />
                  <asp:BoundField DataField="Estado" HeaderText="Estado" ReadOnly="True" SortExpression="Estado" />
                  <asp:BoundField DataField="Tareas realizadas" HeaderText="Tareas realizadas" ReadOnly="True" SortExpression="Tareas realizadas" />
                 
              </Columns>
              <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
              <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
              <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
              <RowStyle BackColor="White" ForeColor="#003399" />
              <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
              <SortedAscendingCellStyle BackColor="#EDF6F6" />
              <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
              <SortedDescendingCellStyle BackColor="#D6DFDF" />
              <SortedDescendingHeaderStyle BackColor="#002876" />
          </asp:GridView>
          
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
              SelectCommand="SELECT ESCUELA.DETALLES_MANTENIMIENTOS.MANTENIMIENTOS_ID AS &quot;ID Mantenimiento&quot;, 
              ESCUELA.AERONAVES.MATRICULA AS &quot;Aeronave&quot;, 
              ESCUELA.PLANES.DESCRIPCION AS &quot;Plan&quot;,
              ESCUELA.DETALLES_MANTENIMIENTOS.ESTADO AS &quot;Estado&quot;,
              ESCUELA.DETALLES_MANTENIMIENTOS.TAREAS_SELECCIONADAs AS &quot;Tareas realizadas&quot;
              FROM ESCUELA.DETALLES_MANTENIMIENTOS JOIN ESCUELA.AERONAVES
              ON ESCUELA.DETALLES_MANTENIMIENTOS.AERONAVES_ID = ESCUELA.AERONAVES.ID
              JOIN ESCUELA.PLANES
              ON ESCUELA.DETALLES_MANTENIMIENTOS.PLANES_ID = ESCUELA.PLANES.ID

"></asp:SqlDataSource>
          
      </p>
      <p>
          
          <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/eveh/Piloto_inicio.aspx">Volver</asp:HyperLink>
      </p>
    </div>
</asp:Content>
