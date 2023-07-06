using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Login via Sessão
        //if (Session["Logado"].Equals("MGFInformatica.com.br"))        
        //{
        //    pnLogin.Visible = false;
        //    pnLogado.Visible = true;
        //}
    }

    protected void btLogar_Click(object sender, EventArgs e)
    {

        if (txtUsuario.Text != "" & txtSenha.Text != "")
        {
            //realiza login
            if (login(txtUsuario.Text, txtSenha.Text))
            {
                pnLogin.Visible = false;
                pnLogado.Visible = true;
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "MGF", "alert('Seja Bem Vindo " + Session["Nome"].ToString() + "')", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "MGF", "alert('Usuario ou Senha Invalidos')", true);
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "MGF", "alert('Campos usuário e senha são obrigatórios!')", true);
        }
    }

    protected void lbSair_Click(object sender, EventArgs e)
    {
        if (logoff())
        {
            pnLogin.Visible = true;
            pnLogado.Visible = false;
        }
    }

    public bool login(string user, string senha)
    {
        Usuario usr = new Usuario().Login(user, senha);
        if (usr != null)
        {
            Session["Usuario"] = usr.User;
            Session["Senha"] = usr.Senha;
            Session["CodigoCliente"] = usr.CodigoCliente;
            Session["Email"] = usr.Email;
            Session["Nome"] = usr.Nome;
            Session["Setor"] = usr.Setor;
            Session["Logado"] = "MGFInformatica.com.br";
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool logoff()
    {
        Session["Usuario"] = "";
        Session["Senha"] = "";
        Session["CodigoCliente"] = "";
        Session["Email"] = "";
        Session["Nome"] = "";
        Session["Setor"] = "";
        Session["Logado"] = "";
        Response.Redirect("Default.aspx");
        return true;
    }
}
