<%@ Page Title="User Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegularHome.aspx.cs" Inherits="WebFormv2.Views.RegularHome" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .inlineBlock {
            display: inline-block;
        }
    </style>
    <style type="text/css">
        .floatLeft {
            float: left;
        }
    </style>
    <style type="text/css">
        .floatRight {
            float: right;
        }
    </style>

    <asp:Panel runat="server" ID="TableInfo" CssClass="floatRight">
        <div>
            <br />            
            <br />
            <br />
            <h2>User Dashboard</h2>

            <br />
            <div style="width: 100vh;">
                <table id="AllUserTable" style="width: 100%;"></table>
            </div>
        </div>
    </asp:Panel>

    <%--<asp:Panel runat="server" ID="ShownInfo" CssClass="inlineBlock">--%>
    <asp:Panel runat="server" ID="ShownInfo" CssClass="list-group">
        <div>
            <br />            
            <br />
            <br />
            <% string name = Session["FirstName"].ToString() + " " +
                                    Session["LastName"].ToString() + "'s Profile"; %>
            <div>
                <h2><%=name %></h2>
            </div>
            <br />
            <br />
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
            <br />
            <br />
            <asp:Button runat="server" ID="EditButton" OnClick="EditButton_Click" Text="Edit" />
            <br />
        </div>

    </asp:Panel>


</asp:Content>
