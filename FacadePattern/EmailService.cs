using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class EmailService
    {
        public void SendMail(string mailTo)
        {
            Console.WriteLine("Sending an email to " + mailTo);
        }
    }
}
