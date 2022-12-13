<%@ Page Title="" Language="C#" ValidateRequest="false" Debug="true" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="enesblog.admin.WebForm2" %>

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
                    <label for="exampleInputEmail1">Banner Başlık</label>
                    <asp:TextBox ID="txtBannerBaslik" runat="server" CssClass="form-control" placeholder="Banner Başlık Gir"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleInputEmail1">Banner Kısa Metin</label>

                    <asp:TextBox ID="txtBannerMetin" runat="server" CssClass="form-control" placeholder="Banner Kısa Metin Gir"></asp:TextBox>
                </div>


                <div class="form-group">
                    <label for="exampleInputPassword1">Banner Resim Yükle</label><br />
                    <asp:FileUpload ID="fileBanner" CssClass="btn btn-primary" accept="image/*" runat="server" />
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
