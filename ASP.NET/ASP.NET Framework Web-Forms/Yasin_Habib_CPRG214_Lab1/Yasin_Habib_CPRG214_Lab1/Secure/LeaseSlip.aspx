<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeaseSlip.aspx.cs" Inherits="Yasin_Habib_CPRG214_Lab1.Secure.LeaseSlip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br />
    <asp:Label ID="lblWelcome" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    Leased slips<br />
    <asp:GridView ID="grdLesSlp" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="247px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
    <br />
    <h3> Lease Slips </h3>
    <p> &nbsp;</p>
    <p> 
        <asp:DropDownList ID="cboDock" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboDock_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <p> 
        &nbsp;</p>
    <p> 
        Please enter the desire slip Id to lease:
        <asp:TextBox ID="txtSlipLease" runat="server"></asp:TextBox>
        <asp:Button ID="btnLease" runat="server" OnClick="btnLease_Click" Text="Lease" />
    </p>
    <p> 
        &nbsp;</p>
    <p> 
        <asp:GridView ID="grdSlip" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="138px" Width="455px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
    </p>
    <p> 
        &nbsp;</p>
</asp:Content>
