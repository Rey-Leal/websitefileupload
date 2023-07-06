using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class FileUpload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Envia fotos
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUploadControl.PostedFile.ContentLength < 8388608)
        {
            try
            {
                if (FileUploadControl.HasFile)
                {
                    try
                    {
                        //Tipos de arquivos permitidos 
                        if (FileUploadControl.PostedFile.ContentType == "image/jpeg" ||
                            FileUploadControl.PostedFile.ContentType == "image/png" ||
                            FileUploadControl.PostedFile.ContentType == "image/gif" ||
                            FileUploadControl.PostedFile.ContentType == "image/bmp")
                        {
                            try
                            {
                                //Obtem o HttpFileCollection 
                                HttpFileCollection hfc = Request.Files;
                                for (int i = 0; i < hfc.Count; i++)
                                {
                                    HttpPostedFile hpf = hfc[i];
                                    if (hpf.ContentLength > 0)
                                    {
                                        //Pega o nome do arquivo 
                                        string nomeDoArquivo = Path.GetFileName(hpf.FileName);
                                        //Pega a extensão do arquivo 
                                        string extensao = Path.GetExtension(hpf.FileName);
                                        //Gera nome novo do Arquivo numericamente 
                                        //string nomeDaImagem = string.Format("{0:00000000000000}", GerarID());                                        
                                        string nomeDaImagem = txtCodigo.Text;

                                        //Caminho a onde será salvo varias imagens
                                        //hpf.SaveAs(Server.MapPath("~/Uploads/Fotos/") + nomeDaImagem + i + extensao);
                                        
                                        //Caminho a onde será salvo uma imagem
                                        hpf.SaveAs(Server.MapPath("~/Uploads/Fotos/") + nomeDaImagem + extensao);

                                        //Caminho a onde será salvo uma imagem - somente online
                                        //hpf.SaveAs(Server.MapPath(Request.PhysicalApplicationPath + "/Uploads/Fotos/") + nomeDaImagem + extensao);

                                        //Prefixo p/ img pequena 
                                        //var prefixoP = "-P";
                                        //Prefixo p/ img grande 
                                        //var prefixoG = "-G";
                                        //pega o arquivo já carregado 
                                        //string caminhoDaImagem = Server.MapPath("~/Uploads/Fotos/") + nomeDaImagem + i + extensao;
                                        //Cria copias tamanho P e G depois salva arquivo + prefixo 
                                        //TrataImagem.RedimensionaESalva(caminhoDaImagem, 70, 53, prefixoP);
                                        //TrataImagem.RedimensionaESalva(caminhoDaImagem, 500, 331, prefixoG);

                                        CarregarImagem(nomeDaImagem, extensao);
                                        TrataImagem.SalvaDiretorioImagem(txtCodigo.Text, txtDescricao.Text);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                StatusLabel.Text = "Ocorreu o seguinte erro: " + ex.Message;
                            }
                            StatusLabel.Text = "Todas imagens carregadas com sucesso!";
                        }
                        else
                        {
                            StatusLabel.Text = "É permitido carregar apenas imagens!";
                        }
                    }
                    catch (Exception ex)
                    {
                        StatusLabel.Text = "O arquivo não pôde ser carregado. O seguinte erro ocorreu: " + ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "O arquivo não pôde ser carregado. O seguinte erro ocorreu: " + ex.Message;
            }
        }
        else
        {
            StatusLabel.Text = "Não é permitido carregar mais do que 8 MB";
        }
    }

    //Gera um id de formato DDMMYYYHHMMSS
    public Int64 GerarID()
    {
        try
        {
            DateTime data = new DateTime();
            data = DateTime.Now;
            string s = data.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
            return Convert.ToInt64(s);
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    //Carrega imagem na tela
    protected void CarregarImagem(string nomeDaImagem, string extensao)
    {
        try
        {
            //String PathServidor = Server.MapPath("~/Uploads/Fotos");
            String PathServidor = Server.MapPath(Request.PhysicalApplicationPath + "/Uploads/Fotos");

            // Exibe Foto
            String strArqFoto = String.Empty;
            if (nomeDaImagem != null)
            {
                strArqFoto = Path.Combine(PathServidor, nomeDaImagem + extensao);
            }
            else
            {
                strArqFoto = Path.Combine(PathServidor, "");
            }

            // Verifica se arquivo é válido e existe
            FileInfo fi = new FileInfo(strArqFoto);

            if (fi.Exists) //&& strArqFoto.Trim().Length > 0)
            {
                Imagem.ImageUrl = "~/Uploads/Fotos/" + nomeDaImagem + extensao;
            }
            else
            {
                Imagem.ImageUrl = "~/Uploads/Fotos/SemFoto.jpg";                
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}