<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RadGrid.aspx.cs" Inherits="TelerikWebFormsSandbox.RadGrid" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI, Version=2015.1.225.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <telerik:RadGrid ID="ProductionsModuleItemsMaster" ClientIDMode="AutoID" runat="server" DataSourceID="productionsModuleItemsDataSource" ClientSettings-Selecting-EnableDragToSelectRows="false"
                    AllowFilteringByColumn="True" AllowPaging="true" AllowCustomPaging="true" AllowSorting="True" AutoGenerateColumns="false" AllowMultiRowSelection="true" OnSortCommand="ProductionsModuleItemsMaster_SortCommand">
        <MasterTableView CssClass="rgTopOffset rgMasterTable" AllowFilteringByColumn="True" >
            <Columns>
                    <telerik:GridTemplateColumn HeaderText='Production Season #' ItemStyle-CssClass="sfLarge">
                    <ItemTemplate>
                        <div class="dmDescription"><%# Eval("prod_season_no") %></div>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn HeaderText='Description' ItemStyle-CssClass="sfLarge">
                    <ItemTemplate>
                        <div class="dmDescription"><%# Eval("prod_desc") %></div>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn HeaderText='First' ItemStyle-CssClass="sfLarge">
                    <ItemTemplate>
                        <div class="dmDescription"><%# Eval("first_dt", "{0:d}") %></div>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn HeaderText='Last' ItemStyle-CssClass="sfLarge">
                    <ItemTemplate>
                        <div class="dmDescription"><%# Eval("last_dt", "{0:d}") %></div>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridCheckBoxColumn UniqueName="Enabled" HeaderText="Enabled" AllowSorting="true"></telerik:GridCheckBoxColumn>
            </Columns>
        </MasterTableView>
        <PagerStyle Mode="NumericPages" />
    </telerik:RadGrid>
    
    <asp:ObjectDataSource ID="productionsModuleItemsDataSource" runat="server" DeleteMethod="Delete" EnablePaging="true" SelectCountMethod="GetTotalItemsCount"
        SelectMethod="GetItems" TypeName="TelerikWebFormsSandbox.ProductionsModuleItemsService">
    </asp:ObjectDataSource>

</asp:Content>
