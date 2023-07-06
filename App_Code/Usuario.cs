using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

/// <summary>
/// Summary description for Usuario
/// </summary>
public class Usuario : System.Web.UI.Page
{

    //variaveis globais
    public static OleDbConnection oleConexao;
    public static OleDbCommand oleCmd;
    public static OleDbDataReader oleDr;

    //construtores
    private string usuario;

    public string User
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
    private string setor;

    public string Setor
    {
        get { return setor; }
        set { setor = value; }
    }
    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    private int codigoCliente;

    public int CodigoCliente
    {
        get { return codigoCliente; }
        set { codigoCliente = value; }
    }

    public bool NovoUsuario(string Usuario, string Senha, string Nome, string Setor, string Email, int CodigoCliente)
    {
        this.usuario = Usuario;
        this.senha = Senha;
        this.nome = Nome;
        this.setor = Setor;
        this.email = Email;
        this.codigoCliente = CodigoCliente;
        return true;
    }

    public Usuario Login(string Usuario, string Senha)
    {
        oleConexao = Conexao.Conecta();
        oleConexao.Open();

        oleCmd = new OleDbCommand("SELECT * FROM Usuarios WHERE Usuario= '" + Usuario + "' AND Senha = '" + Senha + "'", oleConexao);
        oleDr = oleCmd.ExecuteReader();

        if (oleDr.Read())
        {
            Usuario usr = new Usuario();
            usr.NovoUsuario(oleDr["Usuario"].ToString(), oleDr["Senha"].ToString(), oleDr["Nome"].ToString(), oleDr["Setor"].ToString(), oleDr["Email"].ToString(), Convert.ToInt32(oleDr["CodigoCliente"]));

            oleConexao.Close();

            return usr;
        }
        else
        {
            return null;
        }
    }

    public bool alteraSenha(string SenhaAntiga, string NovaSenha, string ConfirmaNovaSenha)
    {
        if (this.senha == SenhaAntiga && NovaSenha == ConfirmaNovaSenha)
        {
            return new Conexao().executaComando("UPDATE Usuarios SET Senha='" + NovaSenha + "' WHERE Usuario='" + this.usuario + "'");
        }
        else
        {
            return false;
        }
    }
}
