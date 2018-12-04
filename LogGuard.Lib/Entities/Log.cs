using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGuard.Lib.Entities
{
    public class Log
    {
        public long Id { get; set; }
        public string Aard { get; set; }
        public DateTime AangemaaktOm { get; set; }
        public string Omschrijving { get; set; }
        public bool Verzonden { get; set; }
    }
}
