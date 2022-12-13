<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="kullaniciGuncelle.aspx.cs" Inherits="enesblog.admin.WebForm11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        <asp:Panel ID="panelYetkili" runat="server">
            <div class="card card-light">

                <div class="card-header">
                    <h3 class="card-title">Anasayfa</h3>
                </div>

                <!-- /.card-header -->
                <!-- form start -->

                <div class="card-body">
                    <div class="form-group">
                        <label>Kullanıcı Adı</label>
                        <asp:TextBox ID="txtKadi" runat="server" CssClass="form-control" placeholder="Kullanıcı Adı"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Eski Şifre</label>
                        <asp:TextBox ID="txtEskiSifre" runat="server" CssClass="form-control" TextMode="Password" placeholder="Eski Şifre"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Yeni Şifre</label>
                        <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control" TextMode="Password" placeholder="Yeni Şifre"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label>Yeni Şifre Tekrar</label>
                        <asp:TextBox ID="txtSifreTekrar" runat="server" CssClass="form-control" TextMode="Password" placeholder="Yeni Şifre Tekrar"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampl">Kategori</label><br />
                        <asp:DropDownList ID="drpYetki" runat="server">
                            <asp:ListItem Value="1">Yönetici</asp:ListItem>
                            <asp:ListItem Value="0">Yazar</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <!-- /.card-body -->

                <div class="card-footer">

                    <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="btnKaydet_Click" />
                </div>

                <asp:Label ID="lblMesaj" runat="server" Text="" CssClass="form-control"></asp:Label>

            </div>
        </asp:Panel>
        <asp:Panel ID="panelYetkisiz" runat="server">
            <h5 class="text-center mt-2 bg-danger text-light p-3">Yetki Yetersiz</h5>
        </asp:Panel>
    </div>
</asp:Content>
