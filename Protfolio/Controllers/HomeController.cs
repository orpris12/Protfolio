using Protfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Protfolio.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult sendResume()
        {
            var addr = Request["mailaddr"];
            if(addr != null)
            {
                MailMessage mail = new MailMessage("orprisPortfolio@gmail.com", "orpris12@gmail.com");
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("orprisPortfolio@gmail.com", "Kaki121191");

                mail.Subject = "Or Priesender - Resume";
                mail.Body = "Hello !" + Environment.NewLine + "This is an automatic reply to your resume request." + Environment.NewLine + "My resume is attached, Thank you for your interest.";
                var path = Server.MapPath("~/Files/Resume.docx");
                mail.Attachments.Add(new Attachment(path));
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                try
                {
                    client.Send(mail);
                }
                catch (Exception e)
                {
                    Console.Write(e.Data);
                }
            }
            return View("Index");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            var form = new ContactForm { fullName = "", content = "", email = "" };
            
            return View(form);
        }

        [HttpPost]
        public ActionResult Contact(ContactForm form)
        {
            if (ModelState.IsValid)
            {
                

                MailMessage mail = new MailMessage("orprisPortfolio@gmail.com", "orpris12@gmail.com");
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("orprisPortfolio@gmail.com", "Kaki121191");

                mail.Subject = "Potfolio Message !";
                mail.Body = "Name : " + form.fullName + Environment.NewLine + "Email : " + form.email + Environment.NewLine + "Content : " + form.content;
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                try
                {
                    client.Send(mail);
                }
                catch (Exception e)
                {
                    Console.Write(e.Data);
                }
            }


            ModelState.Clear();
            return View();
        }
    }
}