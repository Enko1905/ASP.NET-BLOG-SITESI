<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="gelenler.aspx.cs" Inherits="enesblog.admin.WebForm8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="content-wrapper p-3">
            <div class="row row-cols-4">
                <asp:Repeater ID="repeaterGelenler" runat="server">
                    <ItemTemplate>
                        <div class="col-12 col-sm-6 col-md-4 d-flex align-items-stretch flex-column">
                            <div class="card bg-light d-flex flex-fill">
                                <div class="card-header text-muted border-bottom-0">
                                    Bildirim
                                </div>
                                <div class="card-body pt-0">
                                    <div class="row">
                                        <div class="col-7">
                                            <h2 class="lead"><b><%#Eval("gonderenAd")%></b></h2>
                                            <p class="text-muted text-sm"><b>Konu : </b><%#Eval("konu")%></p>
                                            <ul class="ml-4 mb-0 fa-ul text-muted">
                                                <li class="small"><span class="fa-li"><i class="bi bi-alarm-fill"></i></span><b>Tarih :</b> <%#Eval("tarih")%></li>
                                                <li class="small"><span class="fa-li"><i class="bi bi-envelope-fill"></i></span><b>E posta :</b> <%#Eval("gonderenEmail")%></li>
                                                <li class="small"><span class="fa-li"><i class="bi bi-pencil-fill"></i></span><b>Mesaj :</b> <%#Eval("mesaj")%></li>
                                            </ul>
                                        </div>
                                        <div class="col-5 text-center">
                                            <img src="dist/img/user.jpg" alt="user-avatar" class="img-circle img-fluid">
                                        </div>
                                    </div>
                                </div>
                                <div class="card-footer">
                                    <div class="text-right">
                                        <a href="gelenler.aspx?gonderiSil=<%#Eval("id")%>"  onclick="return confirm('Mesaj Silinsin mi ?')"  class="btn btn-sm bg-danger">
                                            <i class="bi bi-trash2-fill"></i> Sil
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
