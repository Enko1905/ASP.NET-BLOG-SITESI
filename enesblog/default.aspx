<%@ Page Title="" Language="C#" MasterPageFile="~/ana.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="enesblog.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section>
        <div class="container-fluid">
            <asp:Repeater ID="RepeaterBanner" runat="server">
                <ItemTemplate>
                    <div class="position-relative overflow-hidden  text-center bg-light" style='background-image: url(<%# Eval("bannerResim") %>) !important' id="bannerimage">
                        <div class="col-md-5 p-lg-5 mx-auto my-5 text-light">
                            <h1 class="display-4 fw-normal"><%#Eval("bannerBaslik")%></h1>
                            <p class="lead fw-normal"><%#Eval("bannerMetin")%> </p>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

            <div class="row ">
                <div class="col-12 text-center text-dark shadow-sm p-3 mb-4 mt-1 bg-body rounded">
                    <h5>Gönderiler</h5>
                </div>
            </div>

            <asp:Repeater ID="Repeatericerikler" runat="server">
                <ItemTemplate>
                    <div class="row text-start" id="anaicerik">
                        <div class="card mb-3 border-0  ">
                            <div class="row row-cols-md-2 g-0  p-3">
                                <div class="col-md-4  mt-4">
                                    <img src='<%#Eval("fotoUrl") %>' class="img-fluid rounded" alt='<%#Eval("fotoUrl") %>'>
                                </div>
                                <div class="col-md-4 ">
                                    <div class="card-body">

                                        <h5 class="card-title">
                                            <h5><%#Eval("icerikBaslik") %></h5>
                                            <span class="badge" style='background-color:<%#Eval("kategoriRenk") %>'><%#Eval("kategoriAd") %></span>
                                        <p class="card-text"><%#Eval("icerikKisaBilgi") %></p>
                                        <a href="/icerikler-<%#enesblog.TrKarakter.TurKarakter(Eval("icerikBaslik").ToString())%>?icId=<%#Eval("icerikId")%>" class="btn btn-primary stretched-link w-25">ileri</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </ItemTemplate>
            </asp:Repeater>
      
        </div>
    </section>

</asp:Content>
