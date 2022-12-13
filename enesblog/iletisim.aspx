<%@ Page Title="" Language="C#" MasterPageFile="~/ana.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="enesblog.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-sm" style="height: 600px;">
        <h3 class="display-4">İletişim</h3>
        <div class="row w-75 g-4 ">
            <div class="col-md-12">
                <label for="inputEmail4" class="form-label">Ad-Soyad</label>
                <asp:TextBox ID="txtAdSoyad" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <div class="col-md-12">
                <label for="inputEmail4" class="form-label">Eposta</label>
                <asp:TextBox ID="txtEmail" TextMode="Email" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <div class="col-md-12">
                <label for="inputEmail4" class="form-label">Konu</label>
                 <asp:TextBox ID="txtKonu" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-12">
                <label for="exampleFormControlTextarea1" class="form-label">Mesaj</label>
                <asp:TextBox ID="txtMesaj" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>

            </div>


            <div class="col-12">
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Gönder" OnClick="Button1_Click" />
            </div>

        </div>
        <asp:Label ID="lblMesaj" CssClass="form-control" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
