<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="enesblog.admin.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <div class="content-header">
            <div class="container-fluid">
                <div class="row mb-2">
                    <div class="col-sm-6">
                        <h2 class="m-0 font-weight-light">HIZLI ERİŞİM </h2>
                    </div>
                    <!-- /.col -->

                </div>
                <!-- /.row -->
            </div>
            <!-- /.container-fluid -->
        </div>
        <!-- /.co
    <section class="content">
        <div class="container-fluid">
          <!-- Small boxes (Stat box) -->

        <section class="content">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-3 col-md-6  col-12">
                        <!-- small box -->
                        <div class="small-box bg-primary">
                            <div class="inner">
                                <h2>Tüm Kayıtlar</h2>

                                <p>Kayıt edilen içerikler</p>
                                <a href="tumKayitlar.aspx" class="stretched-link">
                            </div>
                            <div class="icon">
                                <i class="ion ion-chevron-right"></i>
                            </div>
                            <a href="tumKayitlar.aspx" class="small-box-footer">Git <i class="fas fa-arrow-circle-right"></i></a>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6  col-12">
                        <!-- small box -->
                        <div class="small-box bg-info">
                            <div class="inner">
                                <h2>Yeni Kayıt</h2>

                                <p>Yeni kayıt işlemi gerçekleştir</p>
                                <a href="yeniKayit.aspx" class="stretched-link">
                            </div>
                            <div class="icon">
                                <i class="ion ion-plus-circled"></i>
                            </div>
                            <a href="yeniKayit.aspx" class="small-box-footer">Git <i class="fas fa-arrow-circle-right"></i></a>
                        </div>
                    </div>
                    <!-- ./col -->
                    <div class="col-lg-3 col-md-6 col-12">
                        <!-- small box -->
                        <div class="small-box bg-success">
                            <div class="inner">
                                <h2>Kategoriler</h2>

                                <p>Kategori Ekle</p>
                                <a href="kategoriler.aspx" class="stretched-link">
                            </div>
                            <div class="icon">
                                <i class="ion ion-refresh"></i>

                            </div>
                            <a href="kategoriler.aspx" class="small-box-footer">Git<i class="fas fa-arrow-circle-right"></i></a>
                        </div>
                    </div>
                    <!-- ./col -->
          
                    <!-- ./col -->

                    <div class="col-lg-3 col-md-6  col-12">
                        <!-- small box -->
                        <div class="small-box bg-gray">
                            <div class="inner">
                                <h2>Gelenler</h2>

                                <p>Gelen Epostalar</p>
                                <a href="gelenler.aspx" class="stretched-link">
                            </div>
                            <div class="icon">
                                <i class="text-white ion ion-email"></i>
                            </div>
                            <a href="gelenler.aspx" class="stretched-link small-box-footer">Git <i
                                class="fas fa-arrow-circle-right"></i></a>
                        </div>
                    </div>

                    <div class="col-lg-3 col-md-6 col-12">
                        <!-- small box -->
                        <div class="small-box bg-dark">
                            <div class="inner">
                                <h2>Site Ayarları</h2>

                                <p>İletişim Bilgileri</p>
                                <a href="siteAyarlari.aspx" class="stretched-link">
                            </div>
                            <div class="icon">
                                <i class="text-white ion ion-gear-b"></i>
                            </div>
                            <a href="siteAyarlari.aspx" class="small-box-footer">Git <i class="fas fa-arrow-circle-right"></i></a>
                        </div>
                    </div>
                    <!-- ./col -->
                    <div class="col-lg-3 col-md-6 col-12">
                        <!-- small box -->
                        <div class="small-box bg-warning">
                            <div class="inner">
                                <h2>kullanıcı Ekle</h2>

                                <p>Yeni kullanıcı oluştur</p>
                                <a href="kullaniciEkle.aspx" class="stretched-link">
                            </div>
                            <div class="icon">
                                <i class="ion ion-person-add"></i>
                            </div>
                            <a href="kullaniciEkle.aspx" class="small-box-footer">Git <i class="fas fa-arrow-circle-right"></i></a>
                        </div>
                    </div>


                </div>
                <!-- /.row -->
                <!-- Main row -->
                <div class="vstack gap-3">
                    <div class="bg-light border m-2"></div>
                </div>
                <div class="row">
                    <div class="col-md-3 col-sm-6 col-12">
                        <div class="info-box">
                            <span class="info-box-icon bg-info"><i class="ion-eye"></i></span>

                            <div class="info-box-content">
                                <span class="info-box-text">Görüntülenme Sayısı</span>
                                <span class="info-box-number">
                                    <asp:Label ID="lblGoruntulenme" runat="server" Text=""></asp:Label></span>
                            </div>
                            <!-- /.info-box-content -->
                        </div>
                        <!-- /.info-box -->
                    </div>
                    <!-- /.col -->
                    <div class="col-md-3 col-sm-6 col-12">
                        <div class="info-box">
                            <span class="info-box-icon bg-warning"><i class="text-white ion-compose"></i></span>

                            <div class="info-box-content">
                                <span class="info-box-text">İçerik Sayısı</span>
                                <span class="info-box-number">
                                    <asp:Label ID="lblIcerik" runat="server" Text=""></asp:Label>

                                </span>

                            </div>
                            <!-- /.info-box-content -->
                        </div>
                        <!-- /.info-box -->
                    </div>
                    <!-- /.col -->
                    <!-- /.col -->
                    <div class="col-md-3 col-sm-6 col-12">
                        <div class="info-box">
                            <span class="info-box-icon bg-success"><i class="ion-play"></i></span>

                            <div class="info-box-content">
                                <span class="info-box-text ">Aktif İçerikler</span>
                                <span class="info-box-number">
                                    <asp:Label ID="lblAktifIcerik" runat="server" Text=""></asp:Label>

                                </span>

                            </div>
                            <!-- /.info-box-content -->
                        </div>
                        <!-- /.info-box -->
                    </div>

                    <div class="col-md-3 col-sm-6 col-12">
                        <div class="info-box">
                            <span class="info-box-icon bg-danger"><i class="ion-pause "></i></span>

                            <div class="info-box-content">
                                <span class="info-box-text">Pasif İçerikler</span>
                                <span class="info-box-number">
                                    <asp:Label ID="lblPasifIcerikler" runat="server" Text=""></asp:Label>

                                </span>
                               
                            </div>
                            <!-- /.info-box-content -->
                        </div>
                        <!-- /.info-box -->
                    </div>
                    <!-- /.col -->
                </div>
            </div>
        </section>

    </div>




</asp:Content>
