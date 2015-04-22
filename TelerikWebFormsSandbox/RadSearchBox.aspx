<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RadSearchBox.aspx.cs" Inherits="TelerikWebFormsSandbox.RadSearchBox" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI, Version=2015.1.225.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Rad Search Box</h2>
        <telerik:RadSearchBox ID="RadSearchBox1" runat="server" OnSearch="RadSearchBox1_Search"
                              EmptyMessage="Search Products" Width="300">
            <DropDownSettings Height="150" Width="250"/>
            <WebServiceSettings Path="RadSearchBox" Method="GetResults"/>
        </telerik:RadSearchBox>
        <p>
            <asp:Label runat="server" ID="Label1"/>
        </p>
    </div>
</asp:Content>