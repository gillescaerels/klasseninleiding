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
        static Random random = new Random();

        public int Id { get; set; }
        public string NummerPlaat { get; set; }
        public int Snelheid { get; set; }
        public System.Windows.Media.Brush Kleur { get; set; }
        public DateTime AankoopDatum { get; set; }


        public Auto()
        {
            KiesKleur();
        }

        public Auto(int id, string taksPlaat, Brush kleur, int snelheid = 90)
        {
            Id = id;
            NummerPlaat = taksPlaat;
            Kleur = kleur;
            Snelheid = snelheid;
            AankoopDatum = DateTime.Today;
        }

        void KiesKleur()
        {
            int kleurNr;
            Brush kleur;
            kleurNr = random.Next(1, 5);
            switch (kleurNr)
            {
                case 1: kleur = Brushes.White;
                    break;
                case 2:
                    kleur = Brushes.Black;
                    break;
                case 3:
                    kleur = Brushes.Red;
                    break;
                default:
                    kleur = Brushes.Yellow;
                    break;
            }
            Kleur = kleur;
        }

    }
}
