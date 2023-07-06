using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public class Conexao
{
    //Conexao WEB
    //public static string caminhoConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\home\mgfinformatica\Web\App_Data\MGFAtendimento.mdb;Persist Security Info=True";

    //Conexao LOCAL
    public static string caminhoConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Meus Documentos\Documents\Visual Studio 2013\Projects\WebSiteFileUpload\App_Data\MGFAtendimento.mdb";

    public static OleDbCommand oleCmd;

    public static OleDbConnection Conecta()
    {
        try
        {
            OleDbConnection conexao = new OleDbConnection(caminhoConexao);
            return conexao;
        }
        catch (OleDbException ex)
        {
            throw ex;
        }
    }

    public bool executaComando(string comando)
    {
        try
        {
            OleDbConnection oleConexao = Conexao.Conecta();
            oleConexao.Open();

            oleCmd = new OleDbCommand(comando, oleConexao);
            oleCmd.ExecuteNonQuery();

            oleConexao.Close();
            return true;
        }
        catch (OleDbException ex)
        {
            throw ex;
        }
    }
}
