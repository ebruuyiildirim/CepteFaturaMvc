using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

namespace CepteFaturaMvc.Controllers
{

    public class EfaturaController : Controller
    {
        // GET: Efatura
        public ActionResult Ana_Sayfa()
        {
            return View();
        }

        [HttpPost]


        public JsonResult Ana_Sayfa(Models.Email model)
        {
            MailMessage mailim = new MailMessage();
            mailim.To.Add("bilgi@ceptefaturam.com");
            mailim.From = new MailAddress("bilgi@ceptefaturam.com");
            mailim.Subject = "Bize Ulaşın Sayfasından Mesajınız Var. ";
            mailim.Body = "Ad soyad:" + model.ad + " <br> Mail adresim:" + " " + model.email + " <br>Telefon Numaram:" + model.telefon + " <br>Konu:" + model.konu + " <br>Mesaj:" + model.mesaj;
            mailim.IsBodyHtml = true;



            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("bilgi@ceptefaturam.com", "0M5azs0@");
            smtp.Port = 587;
            smtp.Host = "smtp.ceptefaturam.com";
            smtp.EnableSsl = false;


            try
            {
                smtp.Send(mailim);


            }
            catch (Exception)
            {

            }

            return Json("asdasd");
        }















        public ActionResult Kampanyalar()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Kullanim_sartlari()
        {
            return View();
        }
        public ActionResult Ozellikler()
        {
            return View();
        }
        public ActionResult Destek()
        {
            return View();
        }
        public ActionResult SSS()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult EFatura_nedir()
        {
            return View();
        }
      
        public ActionResult EFaturaya_Gecis_Zorunlulugu()
        {
            return View();
        }
        
        public ActionResult Ücretsiz_EFatura_Nasil_Kullanilir()
        {
            return View();
        }
        public ActionResult Blog2()
        {
            return View();
        }
    }
}
