<%@ Page Title="Add User" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="WebFormv2.Views.AddUser" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <div class="form-horizontal">
        <h4>Create a new account</h4>
        <p>Please remember that a password will be automatically generated and sent to new user.</p>
        <hr />

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
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Email"
                    ForeColor="Red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
                    Display="Dynamic" ErrorMessage="Invalid email address" />
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
                <asp:TextBox runat="server" ID="ZipCode" CssClass="form-control" TextMode="Number" />
                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator1"
                    runat="server"
                    ValidationExpression="\d{5}(-\d{4})?"
                    ControlToValidate="ZipCode"
                    ErrorMessage="Input valid U.S. Zip Code!"></asp:RegularExpressionValidator>
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
            <asp:Label runat="server" AssociatedControlID="Role" CssClass="col-lg-2 control-label">Role:</asp:Label>
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
            <asp:Label runat="server" AssociatedControlID="Status" CssClass="col-lg-2 control-label">Status:</asp:Label>
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


        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="RegisterUser" OnClientClick="" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
    </div>

</asp:Content>
