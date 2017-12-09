<%@ Page Title="Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>商品資訊</h2>
    <h3>請輸入商品名稱、重量、長、寬、高.</h3>
    <hr />
    <div class="col-md-12">
        <div class="form-horizontal">
            <div class="form-group">
                <label for="<%: txtProductName.ClientID %>" class="col-md-3 control-label">商品名稱</label>
                <div class="col-md-9">
                    <asp:TextBox ID="txtProductName" name="txtProductName" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="請輸入商品名稱"
                        ControlToValidate="txtProductName"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="<%: txtProductWeight.ClientID %>" class="col-md-3 control-label">重量</label>
                <div class="col-md-9">
                    <asp:TextBox ID="txtProductWeight" name="txtProductWeight" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="請輸入商品重量"
                        ControlToValidate="txtProductWeight"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="<%: txtProductLength.ClientID %>" class="col-md-3 control-label">長</label>
                <div class="col-md-9">
                    <asp:TextBox ID="txtProductLength" name="txtProductLength" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="請輸入商品長度"
                        ControlToValidate="txtProductLength"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="<%: txtProductWidth.ClientID %>" class="col-md-3 control-label">寬</label>
                <div class="col-md-9">
                    <asp:TextBox ID="txtProductWidth" name="txtProductWidth" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="請輸入商品寬度"
                        ControlToValidate="txtProductWidth"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="<%: txtProductHeight.ClientID %>" class="col-md-3 control-label">寬</label>
                <div class="col-md-9">
                    <asp:TextBox ID="txtProductHeight" name="txtProductHeight" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="請輸入商品高度"
                        ControlToValidate="txtProductHeight"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="<%: drpCompany.ClientID %>" class="col-md-3 control-label">物流商</label>
                <div class="col-md-9">
                    <asp:DropDownList ID="drpCompany" name="drpCompany" runat="server" CssClass="form-control">
                        <asp:ListItem>請選擇</asp:ListItem>
                        <asp:ListItem Value="1">黑貓</asp:ListItem>
                        <asp:ListItem Value="2">新竹貨運</asp:ListItem>
                        <asp:ListItem Value="3">郵局</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="drpCompany"
                        InitialValue="請選擇" runat="server" ErrorMessage="請選擇物流商"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="col-md-offset-3">
                <asp:Button ID="btnCalculate" runat="server" Text="計算運費"
                    CssClass="btn btn-primary"
                    OnClick="btnCalculate_Click" />
            </div>
        </div>
    </div>
    <hr />
    <div class="panel panel-default">
        <div class="panel-body">
            <h3 class="text-info">結果</h3>
            <div class="form-group">
                物流商：<asp:Label ID="lblCompany" runat="server"></asp:Label>
            </div>
            <div class="form-group">
                運費：<asp:Label ID="lblCharge" runat="server"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
