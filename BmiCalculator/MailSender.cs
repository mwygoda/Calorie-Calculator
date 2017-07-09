using System;

namespace BmiCalculator
{
    public class MailSender:IMailSender
    {
        public void SendMail(string tekst)
        {
            Console.WriteLine(tekst);
        }
    }
}