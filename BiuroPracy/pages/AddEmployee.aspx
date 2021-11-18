<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="BiuroPracy.pages.AddEmployee" %>
<%@ Register TagPrefix="employee" TagName="AddEmployeeControl" Src="../Controls/AddEmployeeControl.ascx" %>
<%@ Register TagPrefix="employee" TagName="PlaceOfResidenceControl" Src="../Controls/PlaceOfResidenceControl.ascx" %>

<asp:Content ID="PlaceHolder1" ContentPlaceHolderID="title" runat="server">
</asp:Content>

<asp:Content ID="PlaceHolder2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="PlaceHolder3" ContentPlaceHolderID="contentBody" runat="server">
    <h4>Dodawanie pracowników</h4>
    <div>
        <employee:AddEmployeeControl ID="ctrlAddEmployee" runat="server" />
        <employee:PlaceOfResidenceControl ID="ctrlPlaceOfResidence" runat="server" />
        <div class="form-group">
            <asp:Button ID="btnSave" style="font-size: 16px" CssClass="btn-primary btn-block" runat="server" Text="Save"/>
        </div>

        <div class="form-group">
            <asp:Button ID="btnTestNHibernate" runat="server" Text="TestNHibernate" OnClick="btnTestNHibernate_Click"/>
        </div>
    </div>
</asp:Content>
