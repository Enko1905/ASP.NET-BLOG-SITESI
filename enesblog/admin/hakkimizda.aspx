<%@ Page Title="" Language="C#" ValidateRequest="false" Debug="true" MasterPageFile="~/admin/ana.Master" AutoEventWireup="true" CodeBehind="hakkimizda.aspx.cs" Inherits="enesblog.admin.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="content-wrapper">
            <div class="card card-light">
                <div class="card-header">
                    <h3 class="card-title">Hakkımızda</h3>
                </div>



                <asp:TextBox ID="txtHakkimizda" runat="server" TextMode="MultiLine"></asp:TextBox>

                <div class="row p-3">
                    <asp:Button ID="btnKaydet" runat="server" CssClass="btn btn-primary w-25" Text="Kaydet" OnClick="btnKaydet_Click" />
                </div>

            </div>
            <asp:Label ID="lblMesaj" runat="server" Text="" CssClass="form-control text-bold"></asp:Label>
        </div>


        <script type="text/javascript" lang="javascript">
            ClassicEditor
                .create(document.querySelector('#<%=txtHakkimizda.ClientID%>'))
                .then(editor => {
                    console.log(editor);
                })
                .catch(error => {
                    console.error(error);
                });
        </script>

    </div>


</asp:Content>
