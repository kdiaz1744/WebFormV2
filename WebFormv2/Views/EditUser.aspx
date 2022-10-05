<%@ Page Title="Edit User" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="WebFormv2.Views.EditUser" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>


    <div class="form-horizontal">
    <h3>After editing the user, hit Save to finish, or Cancel to go back</h3>
        <hr />

<%--        <asp:FileUpload runat="server" ID="FileUpload" />
        <asp:HyperLink runat="server" ID="hyperlink">View Uploaded Image</asp:HyperLink>--%>
        <asp:Label runat="server" ID="lblMessage"></asp:Label>

        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-lg-2 control-label">User Name:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="UserName" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ID="rfvUserName" ControlToValidate="UserName"
                    CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="col-lg-2 control-label">First Name:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ID="rfvFirstName" ControlToValidate="FirstName"
                    CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="LastName" CssClass="col-lg-2 control-label">Last Name:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="LastName" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ID="rfvLastName" ControlToValidate="LastName"
                    CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Adress" CssClass="col-lg-2 control-label">Adress:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Adress" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ID="rfvAdress" ControlToValidate="Adress"
                    CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="City" CssClass="col-lg-2 control-label">City:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="City" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ID="rfvCity" ControlToValidate="City"
                    CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="State" CssClass="col-lg-2 control-label">State:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="State" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ID="rfvState" ControlToValidate="State"
                    CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ZipCode" CssClass="col-lg-2 control-label">ZipCode:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ZipCode" CssClass="form-control" TextMode="SingleLine" />
                <asp:RequiredFieldValidator runat="server" ID="rfvZipCode" ControlToValidate="ZipCode"
                    CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="PhoneNumber" CssClass="col-lg-2 control-label">PhoneNumber:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="PhoneNumber" CssClass="form-control" TextMode="Phone" />
                <asp:RequiredFieldValidator runat="server" ID="rfvPhoneNumber" ControlToValidate="PhoneNumber"
                    CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="Rolelbl" CssClass="col-lg-2 control-label">Role:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList runat="server" ID="Role" CssClass="form-control">
                    <asp:ListItem Text="Please choose user type" Value="" />
                    <asp:ListItem Text="Admin" Value="1" />
                    <asp:ListItem Text="Regular" Value="2" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ID="rfvRole" ControlToValidate="Role"
                    CssClass="text-danger" ErrorMessage="Please Choose." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" ID="Statuslbl" CssClass="col-lg-2 control-label">Status:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList runat="server" ID="Status" CssClass="form-control">
                    <asp:ListItem Text="Please choose user type" Value="" />
                    <asp:ListItem Text="Active" Value="1" />
                    <asp:ListItem Text="Inactive" Value="2" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ID="rfvStatus" ControlToValidate="Status"
                    CssClass="text-danger" ErrorMessage="Please Choose." />
            </div>
        </div>


        <div class="form-horizontal">
            <div class="col-sm-6">
                <asp:Button runat="server" OnClick="SaveClick" Text="Save" CssClass="btn btn-default" />
                <%--<asp:Button runat="server" OnClick="CancelClick" Text="Cancel" CssClass="btn btn-default" />--%>
                <a class="btn btn-default" href="AdminHome.aspx">Cancel &raquo;</a>

                <asp:Button runat="server" ID="DeleteButton" OnClick="DeleteClick" OnClientClick="return confirm('Are you sure?')"
                    ForeColor="Red" Text="Delete" CssClass="btn btn-default" />
            </div>
        </div>
    </div>

</asp:Content>
