using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using WAKTodoList.Models;
using System.IO;

namespace WAKToDoList.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

     
        // GET: Account/Create
        public ActionResult Register()
        {


            return View();
        }

        // POST: Account/Create
        [HttpPost]
        public ActionResult Register(UserAccount obj)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    //var bs = new byte[obj.ProfilePicture.Length];
                    //using (var fs = obj.ProfilePicture.ToString)
                    //{
                    //    var offset = 0;
                    //    do
                    //    {
                    //        offset += fs.Read(bs, offset, bs.Length - offset);


                    //    } while (offset < bs.Length);
                    //}

                    long.TryParse(obj.MobileNo.ToString(), out long mobile);
                    string subject = "Successful registration";
                    string message = "hi! " + obj.Name + "\n thank you for registering with us! \nconform your details below"
                        + "\nuser name :" + obj.Name
                        + "\naddress :" + obj.Address
                        + "\nage :" + obj.Age
                        + "\nmobile num :" + mobile 
                        +"\nqualification :" + obj.Qualification;
                    string add = obj.Address;
                    int age = obj.Age;

                    string receiver = obj.Email;

                    var senderEmail = new MailAddress("nandytest2@gmail.com", "Nandy");
                    var receiverEmail = new MailAddress(receiver, "Receiver");
                    var password = "Test@2017";
                    var sub = subject;
                    var body = message;
                    
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }



                    return RedirectToAction("EmailSent", "Account");
                }

                return View();
            }
            catch

            {
                ViewBag.Error = "Some Error";  
                return View();
            }
        }


        public ActionResult EmailSent()
            
        {
            return View();
        }
     
    }
}
