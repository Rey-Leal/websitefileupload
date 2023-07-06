<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Bem vindo!</h1>
    <br />
    Neste exemplo serão realizados testes variados de Uplad de Arquivos. 
    Tanto editor de texto CKEditor, quanto do uploader e gerenciador de imagens, filmes e mídias em geral o CKFinder... FileUpload dentre outros...
    <br /><br />
    Foto 1 = <asp:TextBox ID="txtFoto1" runat="server" CssClass="Form"></asp:TextBox><br />
    <br />
    <asp:Image ID="Imagem1" runat="server" ImageUrl="~\Uploads\Fotos\1.jpg" Height="331px" Width="500px" CssClass ="Imagem"/>
    <br />
    Foto 2 = <asp:TextBox ID="txtFoto2" runat="server" CssClass="Form"></asp:TextBox><br />
    <br />
    <asp:Image ID="Imagem2" runat="server" ImageUrl="~\Uploads\Fotos\2.jpg" Height="331px" Width="500px" CssClass ="Imagem"/>
    <br />
    Foto 3 = <asp:TextBox ID="txtFoto3" runat="server" CssClass="Form"></asp:TextBox><br />
    <br />
    <asp:Image ID="Imagem3" runat="server" ImageUrl="~\Uploads\Fotos\3.jpg" Height="331px" Width="500px" CssClass ="Imagem"/>
    <br />
    Foto 4 = <asp:TextBox ID="txtFoto4" runat="server" CssClass="Form"></asp:TextBox><br />
    <br />
    <asp:Image ID="Imagem4" runat="server" ImageUrl="~\Uploads\Fotos\4.jpg" Height="331px" Width="500px" CssClass ="Imagem"/>
</asp:Content>
