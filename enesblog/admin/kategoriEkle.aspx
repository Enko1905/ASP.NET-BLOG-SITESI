<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="kategoriEkle.aspx.cs" Inherits="enesblog.admin.WebForm13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        <div class="card card-light">

            <div class="card-header">
                <h3 class="card-title">Anasayfa</h3>
            </div>

            <!-- /.card-header -->
            <!-- form start -->

            <div class="card-body">
                <div class="form-group">
                    <label>Kategori Adı</label>
                    <asp:TextBox ID="txtKategoriAd" runat="server" CssClass="form-control" placeholder="Kategori Adı Gir"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Kategori Rengi</label>
                    <asp:TextBox ID="txtKategoriRenk" runat="server" CssClass="form-control" placeholder="Kategori Rengi Gir"></asp:TextBox>
                </div>
            </div>


            <!-- /.card-body -->

            <div class="card-footer">

                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="btnKaydet_Click"/>
            </div>

            <asp:Label ID="lblMesaj" runat="server" Text="" CssClass="form-control"></asp:Label>

        </div>

    </div>
</asp:Content>
