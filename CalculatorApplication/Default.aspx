<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalculatorApplication._Default" %>

<%@ Register Src="~/ViewSwitcher.ascx" TagPrefix="uc1" TagName="ViewSwitcher" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">

        <h1>Simple Calculator</h1>

        <div class="model fade" id="mymodal" data-backdrop="false" role="dialog" style="display: none">
            <div class="modal-dialog modal-dialog-centered">
                <div id="modalDiv" class="modal-content" runat="server" style="background: white">
                    <div class="modal-header">
                        <h4 class="modal-title">Simple Calculator</h4>
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

                        <br />
                        <label>Result</label>
                        <asp:TextBox ID="txtResult" CssClass="form-control" TextMode="Number" placeholder="0" runat="server" ReadOnly="true" />
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnadd" CssClass="btn btn-primary" Text="Add" OnClick="Modal_Add" runat="server" />
                        <asp:Button ID="btnsubtract" CssClass="btn btn-primary" Text="Subtract" OnClick="Modal_Subtract" runat="server" />
                        <asp:Button ID="btnclear" CssClass="btn btn-danger" Text="CLEAR" OnClick="Modal_Clear" CausesValidation="False" UseSubmitBehavior="False" runat="server" />
                    </div>
                </div>
            </div>
        </div>

        <br />
        <asp:Button Text="Open Modal" ID="modal" CssClass="btn btn-primary" OnClick="Modal_Clear" CausesValidation="False" UseSubmitBehavior="False" runat="server" />

        <br />
        <div class="pickr-container">
            <h2 style="color: white">Click to change colour</h2>
            <div class="color-picker"></div>
        </div>

    </div>

    <%--Color Picker Script--%>
    <script src="https://cdn.jsdelivr.net/npm/@simonwep/pickr/dist/pickr.min.js"></script>
    <script src="Scripts/main.js"></script>
</asp:Content>
