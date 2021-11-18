<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PlaceOfResidenceControl.ascx.cs" Inherits="BiuroPracy.Controls.PlaceOfResidenceControl" %>

<div class="form-group">
    <label class="control-label col-sm-2">Street:</label>
    <div class="col-sm-10">
        <asp:TextBox ID="txtStreet" class="form-control" runat="server"></asp:TextBox>
    </div>
</div>

<div class="form-group">
    <label class="control-label col-sm-2">Postal Code:</label>
    <div class="col-sm-10">
        <asp:TextBox ID="txtPostalCode" class="form-control" runat="server"></asp:TextBox>
    </div>
</div>

<div class="form-group">
    <label class="control-label col-sm-2">City:</label>
    <div class="col-sm-10">
        <asp:DropDownList ID="ddlCity" class="form-control" runat="server"></asp:DropDownList>
    </div>
</div>

<div class="form-group">
    <label class="control-label col-sm-2">Country:</label>
    <div class="col-sm-10">
        <asp:DropDownList ID="ddlCountry" class="form-control" runat="server"></asp:DropDownList>
    </div>
</div>