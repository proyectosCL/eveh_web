<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="aeronaves_en_mantenimiento.aspx.cs" Inherits="Web_eveh.eveh.aeronaves_en_mantenimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="jumbotron">
      <h1>Aeronaves en mantención!</h1>
      <p>
          
          <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/eveh/Piloto_inicio.aspx">Volver</asp:HyperLink>
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
              <Columns>
                  <asp:BoundField DataField="matrícula" HeaderText="matrícula" SortExpression="matrícula" />
                  <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
                  <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
                  <asp:BoundField DataField="fecha de aeronavegabilidad" HeaderText="fecha de aeronavegabilidad" ReadOnly="True" SortExpression="fecha de aeronavegabilidad" />
                  <asp:BoundField DataField="fecha de inspección anual" HeaderText="fecha de inspección anual" ReadOnly="True" SortExpression="fecha de inspección anual" />
                  <asp:BoundField DataField="horas de vuelo" HeaderText="horas de vuelo" SortExpression="horas de vuelo" />
                  <asp:BoundField DataField="dias de vuelo" HeaderText="dias de vuelo" SortExpression="dias de vuelo" />
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
          
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT ESCUELA.AERONAVES.MATRICULA AS &quot;matrícula&quot;, ESCUELA.TIPOS_AERONAVES.DESCRIPCION AS &quot;tipo&quot;, ESCUELA.AERONAVES.ESTADO AS &quot;estado&quot;, TO_CHAR(ESCUELA.AERONAVES.FECHA_AERONAVEGABILIDAD, 'DD-MM-YYYY')  AS &quot;fecha de aeronavegabilidad&quot;, TO_CHAR(ESCUELA.AERONAVES.FECHA_INSPECCION_ANUAL, 'DD-MM-YYYY') AS &quot;fecha de inspección anual&quot;, ESCUELA.AERONAVES.HORAS_VUELO AS &quot;horas de vuelo&quot;, ESCUELA.AERONAVES.DIAS_VUELO AS &quot;dias de vuelo&quot; FROM ESCUELA.AERONAVES INNER JOIN ESCUELA.TIPOS_AERONAVES ON ESCUELA.AERONAVES.TIPO_AERONAVES_ID = ESCUELA.TIPOS_AERONAVES.ID WHERE (ESCUELA.AERONAVES.ESTADO = 'M')

"></asp:SqlDataSource>
          
      </p>
      <p>
          
          <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/eveh/Piloto_inicio.aspx">Volver</asp:HyperLink>
      </p>
    </div>
</asp:Content>
