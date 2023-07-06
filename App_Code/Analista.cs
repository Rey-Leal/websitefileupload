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
/// Summary description for Analista
/// </summary>
public class Analista
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
    private string celular;

    public string Celular
    {
        get { return celular; }
        set { celular = value; }
    }
    private string endereco;

    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }
    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

	public bool novoAnalista(string Usuario, string Senha, string Nome, string Celular, string Endereco, string Email)
	{
        this.usuario = Usuario;
        this.senha = Senha;
        this.nome = Nome;
        this.celular = Celular;
        this.endereco = Endereco;
        this.email = Email;
        return true;
	}
    public bool Atualiza()
    {
        return true;
    }
    public bool Salva()
    {
        return true;
    }
}
