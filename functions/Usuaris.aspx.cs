using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.IO;



public partial class functions_IdentificaCliente : System.Web.UI.Page
{

    //FapCL.CInterface iface = new FapCL.CInterface();

    protected void Page_Load(object sender, EventArgs e)
    {
       
	    Response.Write("helloooooo");
		/*
        string tarea = Request.Form["Tarea"];

        if (tarea == "EnviarClau")
            Response.Write(EnviarClau());

        if (tarea == "ValidarUsuari")
            Response.Write(ValidarUsuari());
		*/
    }


/*
    protected string ValidarUsuari()
    {
        try
        {


            string Usuario = Request.Form["usuario"];
            string Clave = Request.Form["clave"];

            if (Usuario.Trim() != "" && Clave.Trim() != "")
            {
                CPersona m_CPersona = (CPersona)iface.recoge_Persona_PorUsuario(Usuario.Trim(), Clave.ToUpper().Trim());

                if (m_CPersona != null)                    
                    return "ok";
                else
                    return "Nok";
            }
            else
                return "Nok";

            return "Nok";
        }
        catch (Exception ex)
        {
            return "Nok";

        }
    }

    //Botón Validar
    protected void bt_Siguiente_Click(object sender, EventArgs e)
    {
        try
        {
            ValidarUsuari();
                                       
        }
        catch (Exception ex)
        { }
    }
    

    protected string EnviarClau()
    {
        try
        {
            string texto = "";
            string Email = Request.Form["Email"];

           

                if (Email.Trim() != "")
                {
                    CPersona m_CPersona = (CPersona) iface.recoge_Persona_PorUsuario(Email.Trim(), "");

                    if (m_CPersona != null)
                    {                        
                        #region Enviar Mail
                            
                            //Envia los e-mails de la inscripción al usuario
  
                            try
                            {
                                MailAddress from = new MailAddress("administrador@camfic.org", "Usuaris CAMFiC");
                                MailMessage msg = new MailMessage();
                                msg.IsBodyHtml = true;

                                SmtpClient client = new SmtpClient("213.27.212.76");
                                client.UseDefaultCredentials = false;
                                client.Credentials = new System.Net.NetworkCredential("alex@camfic.org", "Afebrero81");

                                StreamReader reader = new StreamReader(Request.PhysicalApplicationPath + "TemplateMailsInternos.htm");
                                string Cuerpo = reader.ReadToEnd();
                                reader.Close();

                                msg.To.Add(new MailAddress(Email.Trim()));
                                msg.From = new MailAddress("administrador@camfic.org", "Usuaris");


                                string Texto = "";

                                Texto += "<b>Aquestes són les teves dades com a usuari de la CAMFiC.</b>";
                                Texto += "<br><br>Usuari: <b>" + m_CPersona.m_sUsuario.Trim() + "</b>";
                                Texto += "<br>Contrasenya: <b>" + m_CPersona.m_sClave.Trim() + "</b>";

                                Texto += "<br><br>Per a qualsevol dubte, pots posar-te en contacte amb la CAMFiC a través de la nostra web <a href=\"http://www.camfic.cat/CAMFiC/Seccions/ServeiSoci/Forms/Contacta.aspx\" target=\"_Blank\" style=\"Color:#3b85f5\" >www.camfic.cat</a>.";                                

                                Texto += "<br><br>Atentament,";
                                Texto += "<br>CAMFiC";
                                Texto += "<br>Telèfon: 93-3011777";
                                Texto += "<br><a hre='http://www.camfic.cat'>www.camfic.cat</a>";

                                Texto += "</div>";

                                msg.Body = Cuerpo.Replace("mensaje", Texto);
                                msg.Body = msg.Body.Replace("titulo", "Benvolgut/da " + m_CPersona.m_sNombre.Trim().ToUpper() + " " + m_CPersona.m_sApellido_1.Trim().ToUpper() + ",");
                                msg.Subject = "Dades usuari CAMFiC";

                                try
                                {
                                    client.Send(msg);
                                    return "ok";
                                }
                                catch (Exception ex)
                                {
                                    msg.From = from;
                                    client.Send(msg);
                                    return "ok";
                                }
                            }
                            catch (Exception ex)
                            {
                                return "";
                            }

    

                        #endregion
                    }
                }

            return texto;
        }
        catch (Exception ex)
        {
            return "";
        }
    }
	*/
}
