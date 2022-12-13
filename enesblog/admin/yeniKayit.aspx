<%@ Page Title="" Language="C#" ValidateRequest="false" Debug="true" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="yeniKayit.aspx.cs" Inherits="enesblog.admin.WebForm6" %>

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
            <asp:Panel ID="panelIcerikKayit" runat="server">
                <div class="card-body">

                    <div class="form-group">
                        <label>Başlık</label>
                        <asp:TextBox ID="txtBaslik" runat="server" CssClass="form-control" placeholder="Başlık Gir"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Kisa Bilgi</label>
                        <asp:TextBox ID="txtKisaBilgi" runat="server" TextMode="MultiLine" CssClass="form-control" placeholder="Kisa Bilgi"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="exampl">Kategori</label><br />

                        <asp:DropDownList ID="drpKategori" runat="server">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Büyük Resim</label><br />
                        <asp:FileUpload ID="fileBuyukResim" accept="image/*" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Küçük Resim</label><br />
                        <asp:FileUpload ID="fileKucukResim" accept="image/*" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>İçerik</label>

                        <asp:TextBox ID="txticerik" runat="server" TextMode="MultiLine" CssClass="form-control" Width="800px"></asp:TextBox>

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
