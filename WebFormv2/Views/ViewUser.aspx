<%@ Page Title="View User" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="WebFormv2.Views.ViewUser" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <asp:Panel runat="server" ID="ShownInfo" CssClass="form-group">
        <div class="list-group">
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label">UserName: </asp:Label>
                <div>
                    <asp:Label runat="server" ID="UserName" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="col-md-2 control-label">First Name: </asp:Label>
                <div>
                    <asp:Label runat="server" ID="FirstName" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="LastName" CssClass="col-md-2 control-label">Last Name: </asp:Label>
                <div>
                    <asp:Label runat="server" ID="LastName" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email: </asp:Label>
                <div>
                    <asp:Label runat="server" ID="Email" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="Adress" CssClass="col-md-2 control-label">Adress: </asp:Label>
                <div>
                    <asp:Label runat="server" ID="Adress" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="City" CssClass="col-md-2 control-label">City: </asp:Label>
                <div>
                    <asp:Label runat="server" ID="City" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="State" CssClass="col-md-2 control-label">State: </asp:Label>
                <div>
                    <asp:Label runat="server" ID="State" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="ZipCode" CssClass="col-md-2 control-label">ZipCode: </asp:Label>
                <div>
                    <asp:Label runat="server" ID="ZipCode" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="PhoneNumber" CssClass="col-md-2 control-label">PhoneNumber: </asp:Label>
                <div>
                    <asp:Label runat="server" ID="PhoneNumber" />
                </div>
            </div>
        </div>
    </asp:Panel>



    <div class="form-horizontal">
        <div class="col-sm-6">
            <%--<asp:Button runat="server" OnClick="CancelClick" Text="Cancel" CssClass="btn btn-default" />--%>
            <a class="btn btn-default" href="AdminHome.aspx">Back &raquo;</a>
        </div>
    </div>

</asp:Content>
