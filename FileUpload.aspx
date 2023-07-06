<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeFile="FileUpload.aspx.cs" Inherits="FileUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>Upload Files</h1>
    <br />
    <div>
        <br />
        <asp:FileUpload ID="FileUploadControl" runat="server" class="multi" AllowMultiple="True" />
        <asp:Label runat="server" ID="StatusLabel" Text="" ForeColor="Red" />
        <br />
        Código: (1-99)
        <br />
        <asp:TextBox ID="txtCodigo" runat="server" CssClass="Form"></asp:TextBox>
        <br />
        Descrição:
        <br /> 
        <asp:TextBox ID="txtDescricao" runat="server" CssClass="Form"></asp:TextBox>
        <br />
        <asp:Button ID="btnUpload" runat="server" Text=" Carregar Fotos " OnClick="btnUpload_Click" CssClass="Botao" />
        <br />
        <br />
        <asp:Image ID="Imagem" runat="server" ImageUrl="~\Uploads\Fotos\SemFoto.jpg" Height="331px" Width="500px" />
    </div>
</asp:Content>

