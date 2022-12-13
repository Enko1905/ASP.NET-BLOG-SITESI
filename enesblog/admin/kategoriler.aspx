<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="kategoriler.aspx.cs" Inherits="enesblog.admin.WebForm12" %>
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
                                                <th>Kategori</th>
                                                <th>Kategori Renk</th>
                                                <th>İşlemler</th>

                                            </tr>
                                        </thead>
                                        <tbody class="text-center">
                                            <asp:Repeater ID="repeaterKategoriler" runat="server">
                                                <ItemTemplate>
                                                    <tr>

                                                        <td><span class="badge text-light p-2 px-3" style='background-color: <%#Eval("kategoriRenk") %>'><%#Eval("kategoriAd") %></span></td>
                                                        <td>
                                                          <span class="badge text-light p-2 px-3" style='background-color: <%#Eval("kategoriRenk") %>'><%#Eval("kategoriRenk") %></span>
                                                        </td>
                                                        <td>
                                                            <a href='kategoriler.aspx?kategoriSilId=<%#Eval("kategoriId") %>' onclick="return confirm('Kategori Silinsin mi ?')" class="btn btn-info bi bi-trash3"></a>
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
