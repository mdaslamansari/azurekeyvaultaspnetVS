<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="aslsoft._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    
    <div id="myCarousel" class="carousel slide" data-ride="carousel" data-interval="6000">
    <h1>Azure Learning</h1>
    <p class="lead" style="font-size:medium">This is just to read data from Azure SQL when the connection string is stored in Azure Vault.</p>    
</div>
<div id="UI">
    <asp:GridView ID="ProductGridView" runat="server" AllowPaging="True" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnSelectedIndexChanged="ProductGridView_SelectedIndexChanged" EnableViewState="False" OnRowEditing="ProductGridView_RowEditing">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:CommandField ShowEditButton="true" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
    </asp:GridView>    
       </div>
    <div id="Image">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Architecture.PNG" />        
    </div>    
</asp:Content>