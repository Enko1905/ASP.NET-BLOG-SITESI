<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="kullanicilar.aspx.cs" Inherits="enesblog.admin.WebForm9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <asp:Panel ID="panelYetkili" runat="server">

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
                                                <th>Kullanici Adı</th>
                                                <th>Yetki</th>
                                                <th>Aktif</th>
                                                <th>İşlemler</th>

                                            </tr>
                                        </thead>
                                        <tbody class="text-center">
                                            <asp:Repeater ID="repeaterTumKullanicilar" runat="server">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td>
                                                            <%#Eval("KullaniciAd") %>
                                                        </td>
                                                        <td>
                                                            <span class="badge text-light p-2 px-3 bg-primary"><%#Eval("kullaniciYetki").ToString()=="1" ?"Yazar":"Yonetici" %></span>
                                                        </td>

                                                        <td>
                                                            <a href='kullanicilar.aspx?kullaniciAktifId=<%#Eval("kullaniciId") %>&aktif=<%#Eval("kullaniciAktif").ToString() %>' class="btn btn-<%#Eval("kullaniciAktif").ToString() =="0" ? "danger":"success"%> bi <%#Eval("kullaniciAktif").ToString() =="0" ? " bi-toggle-off":" bi-toggle-on"%>"></a>
                                                        </td>
                                                        <td>
                                                            <a href='kullaniciGuncelle.aspx?gnclId=<%#Eval("kullaniciId") %>' class="btn btn-info bi bi-pencil-square"></a>
                                                            <a href='kullanicilar.aspx?kullaniciSilId=<%#Eval("kullaniciId") %>' onclick="return confirm('Kullanıcı Silinsin mi ?')" class="btn btn-info bi bi-trash3"></a>
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
        </asp:Panel>
        <asp:Panel ID="panelYetkisiz" runat="server">
            <h5 class="text-center mt-2 bg-danger text-light p-3">Yetki Yetersiz</h5>
        </asp:Panel>
    </div>


</asp:Content>
