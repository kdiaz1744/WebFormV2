<%@ Page Title="Forgot Password" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="WebFormv2.Views.ForgotPassword" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>Enter Username to send credentials to your email account.</p>
    <div>
        <div class="col-md-10">
            <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-lg-2 control-label">User Name:</asp:Label>
        </div>
        <div>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="UserName" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ID="rfvUserName" ControlToValidate="UserName"
                    CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
        </div>

        <div class="form-horizontal">
            <div class="col-sm-6">
                <asp:Button runat="server" OnClick="SendClick" Text="Send" CssClass="btn btn-default" />
                <%--<asp:Button runat="server" OnClick="CancelClick" Text="Cancel" CssClass="btn btn-default" />--%>
                <a class="btn btn-default" href="Login.aspx">Cancel &raquo;</a>
            </div>
        </div>
    </div>




</asp:Content>



