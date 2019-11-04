using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication15.Models;

namespace WebApplication15.Services
{
    public interface IRepository
    {
        string SendMail(string To,string Subject,string Body);
    }
}
