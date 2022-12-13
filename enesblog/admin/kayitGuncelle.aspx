<%@ Page Title="" Language="C#" ValidateRequest="false" Debug="true" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="kayitGuncelle.aspx.cs" Inherits="enesblog.admin.WebForm5" %>

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
            <asp:Panel ID="panelKayitGuncelle" runat="server">
                <div class="card-body">
                    <div class="form-group">
                        <label for="example">Büyük Resim</label><br />
                        <asp:FileUpload ID="fileBuyukFoto" accept="image/*" runat="server" />
                    </div>
                    <div class="form-group">
                        <label for="example">Küçük Resim</label><br />
                        <asp:FileUpload ID="fileKucukFoto" accept="image/*" runat="server" />
                    </div>

                    <div class="form-group">
                        <label for="exampl">Kategori</label><br />
                        <asp:DropDownList ID="drpKategori" runat="server">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Başık</label>
                        <asp:TextBox ID="txticerikBaslik" runat="server" CssClass="form-control" placeholder="Banner Başlık Gir"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Kısa Bilgi</label>
                        <asp:TextBox ID="txticerikKisaBilgi" TextMode="MultiLine" runat="server" CssClass="form-control" placeholder="Banner Başlık Gir" Height="150"></asp:TextBox>
                    </div>
                    <div class="form-group h-75">
                        <label for="exampleInputEmail1">İçerik</label>

                        <asp:TextBox ID="txticerik" runat="server" CssClass="form-control" TextMode="MultiLine" placeholder="Banner Kısa Metin Gir"></asp:TextBox>

                    </div>

                </div>
            </asp:Panel>
            <!-- /.card-body -->

            <div class="card-footer">

                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="btnKaydet_Click" />

            </div>

            <asp:Label ID="lblMesaj" runat="server" Text="" CssClass="form-control"></asp:Label>

        </div>

    </div>

    <script type="text/javascript" lang="javascript">
        ClassicEditor
            .create(document.querySelector('#<%=txticerik.ClientID%>'))

            .then(editor => {
                console.log(editor);
            })
            .catch(error => {
                console.error(error);
            });
    </script>
  
</asp:Content>
