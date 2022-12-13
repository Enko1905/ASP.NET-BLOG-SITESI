<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="tumKayitlar.aspx.cs" Inherits="enesblog.admin.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-wrapper">
        <!-- Content Header (Page header) -->

                
        <section class="content-header">
            <div class="container-fluid">
                <div class="row mb-2">
                    <div class="col-sm-6">
                        <h1>Tüm Kayıtlar</h1>
                    </div>

                </div>
            </div>
            <!-- /.container-fluid -->
        </section>

        <!-- Main content -->
        <section class="content">

            <div class="container-fluid">
                <div class="row">
                    <div class="col-12">
                        <div class="card">
                            <div class="card-header">
                                <h3 class="card-title">Kayıtlı İçerikler</h3>
                            </div>
                            <!-- /.card-header -->
                            <div class="card-body" id="tumicerikler">
                                <table id="example2" class="table table-bordered table-hover">
                                    <thead class="text-center">
                                        <tr>
                                            <th>Resimler</th>
                                            <th>İçerik Başlıkları</th>
                                            <th>Kategoriler</th>
                                            <th>Durum Aktif</th>
                                            <th>İşlemler</th>
                                            <th>Sitede Göster</th>
                                        </tr>
                                    </thead>
                                    <tbody class="text-center">

                                        <asp:Repeater ID="repeaterTumIcerikler" runat="server">
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <img style="width:250px; height:250px;" id="tumicerikler" src='../<%#Eval("fotoUrl") %>'></img></td>
                                                    <td>
                                                        <%#Eval("icerikBaslik") %>
                                                    </td>
                                                    <td><span class="badge text-light p-2 px-3" style='background-color: <%#Eval("kategoriRenk") %>'><%#Eval("kategoriAd") %></span></td>
                                                    <td>
                                                        <a href='tumKayitlar.aspx?icerkAktifId=<%#Eval("icerikId") %>&aktif=<%#Eval("icerikAktif").ToString() %>' class="btn btn-<%#Eval("icerikAktif").ToString() =="0" ? "danger":"success"%> bi <%#Eval("icerikAktif").ToString() =="0" ? " bi-toggle-off":" bi-toggle-on"%>"></a>
                                                    </td>
                                                    <td>
                                                        <a href='kayitGuncelle.aspx?gnclId=<%#Eval("icerikId") %>' class="btn btn-info bi bi-pencil-square"></a>
                                                            <a href='tumKayitlar.aspx?kayitId=<%#Eval("icerikId") %>&islem=sil' onclick="return confirm('Kategori Silinsin mi ?')" class="btn btn-info bi bi-trash3"></a>
                                                    </td>
                                                    <td>
                                                        <a href='../icerik.aspx?icId=<%#Eval("icerikId") %>' class="btn btn-info bi bi-arrow-up-right-square-fill"></a>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>

                                </table>
                            </div>
                            <!-- /.card-body -->
                        </div>
                        <!-- /.card -->


                        <!-- /.card -->
                    </div>
                    <!-- /.col -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /.container-fluid -->
        </section>
        <!-- /.content -->
    </div>


</asp:Content>
