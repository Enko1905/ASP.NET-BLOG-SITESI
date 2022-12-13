<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="siteAyarlari.aspx.cs" Inherits="enesblog.admin.WebForm7" %>

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
                    <label for="exampleInputEmail1">Title</label>
                    <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control" placeholder="Title Gir"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleInputEmail1">Açıklama</label>
                    <asp:TextBox ID="txtAciklamalar" runat="server" CssClass="form-control" placeholder="Site Açıklaması"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleInputEmail1">Logo</label>
                    <asp:TextBox ID="txtLogo" runat="server" CssClass="form-control" placeholder="Logo Yazı Gir"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleInputEmail1">Site Etiketler Gir , ile ayırın</label>
                    <asp:TextBox ID="txtEtiketler" runat="server" CssClass="form-control" placeholder="Anahtar Kelimeler"></asp:TextBox>
                </div>

            </div>
            <!-- /.card-body -->

            <div class="card-footer">

                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="btnKaydet_Click" />
            </div>

            <asp:Label ID="lblMesaj" runat="server" Text="" CssClass="form-control"></asp:Label>

        </div>
    </div>
</asp:Content>
