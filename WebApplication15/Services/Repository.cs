using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication15.Models;
using System.Net;
using System.Net.Mail;

namespace WebApplication15.Services
{
    public class Repository : IRepository
    {
        private SDbContext _sDbContext;
        public Repository(SDbContext sDbContext)
        {
            _sDbContext = sDbContext;
        }

        public string SendMail(string To, string Subject, string Body)
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
