using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Administrador
/// </summary>
public class Administrador
{
    private string usuario;

    public string Usuario
    {
        get { return usuario; }
        set { usuario = value; }
    }
    private string senha;

    public string Senha
    {
        get { return senha; }
        set { senha = value; }
    }
    private string nome;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public bool novoAdministrador(string Usuario, string Senha, string Nome, string Email)
    {
        this.usuario = Usuario;
        this.senha = Senha;
        this.nome = Nome;
        this.email = Email;
        return true;
    }
}
