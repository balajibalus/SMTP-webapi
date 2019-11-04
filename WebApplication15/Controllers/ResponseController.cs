using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using WebApplication15.Models;
using WebApplication15.Services;

namespace WebApplication15.Controllers
{
    [Route("api/smtp")]
    [ApiController]
    public class ResponseController : Controller
    {
        private IRepository _repository;
        public ResponseController(IRepository repository)
        {
            _repository = repository;
        }
       [HttpPost("email")]
      public  string SendByMail(string To, string Subject, string Body)
        {

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("balaji.sandupatla@gmail.com");
            mm.To.Add(To);
            mm.Subject = Subject;
            mm.Body = Body;
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = true;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("balaji.sandupatla@gmail.com", "balaji@paru");
            smtp.Send(mm);
            var msg = "Mail Sent";
            return msg;
        }
    }
}
