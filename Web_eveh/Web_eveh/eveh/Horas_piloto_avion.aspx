<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="horas_piloto_avion.aspx.cs" Inherits="Web_eveh.eveh.horas_piloto_avion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="piloto_avion" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="HORAS_VUELO" HeaderText="HORAS_VUELO" SortExpression="HORAS_VUELO" />
            <asp:BoundField DataField="DIAS_VUELO" HeaderText="DIAS_VUELO" SortExpression="DIAS_VUELO" />
            <asp:BoundField DataField="VENCIMIENTO_MEDICINA" HeaderText="VENCIMIENTO_MEDICINA" SortExpression="VENCIMIENTO_MEDICINA" />
            <asp:BoundField DataField="ULTIMO_VUELO_REALIZADO" HeaderText="ULTIMO_VUELO_REALIZADO" SortExpression="ULTIMO_VUELO_REALIZADO" />
            <asp:BoundField DataField="PERSONAS_ID" HeaderText="PERSONAS_ID" SortExpression="PERSONAS_ID" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:SqlDataSource ID="piloto_avion" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="select * from pilotos"></asp:SqlDataSource>
</asp:Content>
