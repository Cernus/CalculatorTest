<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CalculatorApplication.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="model fade" id="mymodal" data-backdrop="false" role="dialog">
            <div class="model-dialog modal-dialog-centered">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Add New Record</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    <div class="modal-body">
                        <label>Name</label>
                        <asp:TextBox ID="txtname" CssClass="form-control" placeholder="Name" runat="server" />

                        <label>Email</label>
                        <asp:TextBox ID="txtmail" CssClass="form-control" placeholder="Email" runat="server" />
                        <label>Contact</label>
                        <asp:TextBox ID="txtcontact" CssClass="form-control" placeholder="Contact" runat="server" />
                        <label>Address</label>
                        <asp:TextBox ID="txtaddress" CssClass="form-control" placeholder="Address" runat="server" />
                        <label>Status</label>
                        <asp:DropDownList CssClass="form-control" runat="server">
                            <asp:ListItem Value=""> Selected Status</asp:ListItem>
                            <asp:ListItem Text="ActiveInactive" />
                            <asp:ListItem Text="text2" />
                        </asp:DropDownList>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                        <asp:Button ID="btnsave" CssClass="btn btn-primary" Text="Save" runat="server" />
                    </div>
                </div>

            </div>

        </div>
     </div>
    <asp:Button Text="Open Modal" ID="modal" CssClass="btn btn-primary" OnClick="modal_Click" runat="server" />



</asp:Content>
