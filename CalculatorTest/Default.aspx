<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalculatorApplication._Default" %>

<%@ Register Src="~/ViewSwitcher.ascx" TagPrefix="uc1" TagName="ViewSwitcher" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="model fade" id="mymodal" data-backdrop="false" role="dialog" style="display:none">
            <div class="model-dialog modal-dialog-centered">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Add New Record</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    <div class="modal-body">
                        <label>Start</label>
                        <asp:TextBox ID="txtstart" CssClass="form-control" TextMode="Number" placeholder="0" runat="server" />
                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtstart" ErrorMessage="Value must be a whole number" />

                        <br />

                        <label>Amount</label>
                        <asp:TextBox ID="txtamount" CssClass="form-control" TextMode="Number" placeholder="0" runat="server" />
                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtamount" ErrorMessage="Value must be a whole number" />

                    </div>
                    <div class="modal-footer">
                        <%--<button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>--%>
                        <asp:Button ID="btnadd" CssClass="btn btn-primary" Text="Add" OnClick="Modal_Add" runat="server" />
                        <asp:Button ID="btnsubtract" CssClass="btn btn-primary" Text="Subtract" OnClick="Modal_Subtract" runat="server" />
                    </div>
                </div>

            </div>

        </div>
     </div>
    <asp:Button Text="Open Modal" ID="modal" CssClass="btn btn-primary" OnClick="Modal_Click" runat="server" />



</asp:Content>