<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="enesblog.admin.giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title></title>
    <link href="../bootstrap/css/bootstrap.min.css" rel="stylesheet" />


</head>
<body class="text-center">
    <form id="form1" runat="server">

        <div class="container-sm">
            <div class="row justify-content-center mt-5">
                <div class="col-xl-3 col-sm-6 col-md-6 mt-5">
                    <main class="form-signin w-100 m-auto">

                        <img class="mb-4" src="dist/img/setting.png" alt="" width="80" height="80" />
                        <h1 class="h3 mb-3 fw-normal">Giriş Yap</h1>

                        <div class="form-floating">
                            <asp:TextBox ID="txtKullaniciAdi" CssClass="form-control" placeholder="Kullanıcı Adı" runat="server"></asp:TextBox>
                            <label for="floatingInput">Kullanıcı Adı</label>
                        </div>
                        <div class="form-floating">
                            <asp:TextBox ID="txtSifre" TextMode="Password" CssClass="form-control" placeholder="Kullanıcı Adı" runat="server"></asp:TextBox>
                            <label for="floatingPassword">Şifre</label>
                        </div>


                   
                        <asp:Button ID="btnGiris" runat="server" Text="Giriş Yap" CssClass="w-100 btn btn-lg btn-primary" OnClick="btnGiris_Click" />
                        <asp:Label ID="lblMesaj" CssClass="form-control" runat="server"></asp:Label>
                        <p class="mt-5 mb-3 text-muted">ADMİN GİRİŞ</p>
                        

                    </main>

                </div>
            </div>
        </div>
    </form>
    <script src="../bootstrap/js/bootstrap.bundle.min.js"></script>
</body>
</html>
