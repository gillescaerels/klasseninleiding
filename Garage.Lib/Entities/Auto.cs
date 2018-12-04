using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
//using System.Windows.Media;

namespace Garage.Lib.Entities
{
    public class Auto
    {
        public int Id { get; set; }
        public string NummerPlaat { get; set; }
        public int Snelheid { get; set; }
        public System.Windows.Media.Brush Kleur { get; set; }
        public DateTime AankoopDatum { get; set; }


        public Auto()
        {

        }

        public Auto(int id, string taksPlaat, Brush kleur, int snelheid = 90)
        {
            Id = id;
            NummerPlaat = taksPlaat;
            Kleur = kleur;
            Snelheid = snelheid;
            AankoopDatum = DateTime.Today;
        }

    }
}
