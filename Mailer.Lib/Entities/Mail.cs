using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailer.Lib.Entities
{
    public class Mail
    {
        public int Id { get; set; }
        public string Afzender { get; set; }
        public string Bestemmeling { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Onderwerp { get; set; }
        public string HtmlBody { get; set; }
        public string GebruikersNaam { get; set; }
        public string Paswoord { get; set; }
        public int Port { get; set; }
        public string SmtpServer { get; set; }
        public DateTime Datum { get; set; }
        public bool Verzonden { get; set; }

        public Mail()
        {

        }

        public Mail(string bestemmeling, string cc, string bcc, string onderwerp, string htmlBody, string paswoord)
        {
            Afzender = "stefaan.Vercaemer@howest.be";
            Bestemmeling = bestemmeling;
            Cc = cc;
            Bcc = bcc;
            Onderwerp = onderwerp;
            HtmlBody = htmlBody;
            GebruikersNaam = Afzender;
            Paswoord = paswoord;
            Port = 587;
            SmtpServer = "smtp.live.com";
            Datum = DateTime.Now;
        }

    }
}
