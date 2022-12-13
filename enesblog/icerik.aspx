<%@ Page Title="" Language="C#" MasterPageFile="~/ana.Master" AutoEventWireup="true" CodeBehind="icerik.aspx.cs" Inherits="enesblog.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-lg">
        <section>
            <asp:Panel ID="panelIcerikler" runat="server">
                <div class="row mt-2 p-4">
                    <div class="col bg-primary text-light text-center shadow-lg p-3 mb-5 rounded" style='background-color:<%=renkBaslik%> !important'>
                        <asp:Label ID="lblAranan" runat="server" Text="İçerikler" CssClass="fs-3"></asp:Label>
                    </div>
                </div>


                <div class="row row-cols-1  g-4 mt-2">
                    <asp:Repeater ID="Repeatericerik" runat="server">
                        <ItemTemplate>
                            <div class="col-lg-3 col-md-6 col-12">
                                <div class="card" id="katAlani">
                                    <img src='<%#Eval("fotoKucukUrl") %>' class="card-img-top" alt='<%#Eval("fotoKucukUrl") %>'>
                                    <div class="card-body">
                                        <h5 class="card-title"><%#Eval("icerikBaslik") %></h5>
                                        <p class="card-text"><%#Eval("icerikKisaBilgi") %></p>
                                        <a href="/icerikler-<%#enesblog.TrKarakter.TurKarakter(Eval("icerikBaslik").ToString())%>?icId=<%#Eval("icerikId")%>" class="btn btn-light stretched-link w-25">ileri</a>
                                    </div>
                                </div>

                            </div>

                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:Label Text="İÇERİK BULUNAMADI ! " CssClass="blockquote w-75 mx-auto alert alert-secondary" Visible="<%#Repeatericerik.Items.Count==0%>" runat="server" />
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
            </asp:Panel>

            <asp:Panel ID="panelIcerkBilgi" runat="server">
                <asp:Repeater ID="repeaterTekIcerik" runat="server">
                    <ItemTemplate>
                        <div class="row">
                            <div class="col-sm-12 col-md-8 col-xl-8">
                                <img src='<%# icerikFotoGetir((int)Eval("icerikId"))%>' class="img-fluid" />
                            </div>
                          

                        </div>

                        <div class=" row p-4">
                            <div class="col p-3 m-3 shadow-sm">
                                <h2><%#Eval("icerikBaslik") %></h2>
                            </div>
                        </div>
                        <div class="row p-4">
                            <div class="col-md-8 col-sm-12 border-bottom-2 text-start">
                                <h4 class="fs-5"><%#Eval("icerikKisabilgi") %></h4>

                                <p><%#Eval("icerikBilgi") %></p>
                            </div>
                            <div class="col-md-4 col-sm-12 ">
                                <img src='<%# kucukFotoGetir((int)Eval("icerikId"))%>' alt="icerik Resmi" class="img-fluid rounded-2" />
                            </div>

                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </asp:Panel>


        </section>
    </div>
            

</asp:Content>
