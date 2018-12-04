using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Garage.Lib.Entities;
using LogGuard.Lib.Entities;
using Mailer.Lib.Entities;

namespace KlassenInleiding.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            MaakAutos();
            MaakLogs();
            MaakMails();
            //lstAuto.Items.Add(txtAankoopDatum);
        }

        void StartSituatieGrid(Grid grid)
        {
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Center;
            grid.Margin = new Thickness(0);
        }

        void ToonGrid(Grid grid)
        {
            grdAuto.Visibility = Visibility.Hidden;
            grdLog.Visibility = Visibility.Hidden;
            grdMail.Visibility = Visibility.Hidden;
            grdBasis.Width = grid.Width + 20;
            grid.Visibility = Visibility.Visible;
        }

        void MaakAutos()
        {
            Auto auto1 = new Auto();
            auto1.AankoopDatum = DateTime.Today;
            auto1.Id = 1;
            auto1.Kleur = Brushes.Beige;
            auto1.NummerPlaat = "1-TWO-345";
            auto1.Snelheid = 0;

            Console.WriteLine($"Hoera, een eerst instance: {auto1.NummerPlaat} - {auto1.Snelheid} km/u.");

            Auto auto2 = new Auto
            {
                AankoopDatum = DateTime.Today,
                Id = 2,
                Kleur = Brushes.Azure,
                NummerPlaat = "1-DOS-345",
                Snelheid = -5
            };

            Console.WriteLine($"We krijgen er niet genoeg van: {auto2.NummerPlaat} - {auto2.Snelheid} km/u.");

            Auto auto3 = new Auto(3, "1-TAX-235", Brushes.Yellow, 100);

            Auto auto4 = new Auto(4, "1-TAX-235", Brushes.DeepPink);

            lstAuto.Items.Add(auto1);
            lstAuto.Items.Add(auto2);
            lstAuto.Items.Add(auto3);
            lstAuto.Items.Add(auto4);
        }

        void MaakLogs()
        {
            Log log1 = new Log();
            log1.Id = 1;
            log1.Aard = "Error";
            log1.AangemaaktOm = DateTime.Now;
            log1.Omschrijving = "Printspooler down";

            Console.WriteLine($"{log1.AangemaaktOm.ToShortDateString()}" +
                              $"{log1.AangemaaktOm.ToShortDateString()} - {log1.Aard}\t{log1.Omschrijving}");

            Log log2 = new Log
            {
                Id = 2,
                Aard = "Info",
                AangemaaktOm = DateTime.Now,
                Omschrijving = "Server opgestart"
            };

            Console.WriteLine($"{log2.AangemaaktOm.ToShortDateString()}" +
                              $"{log2.AangemaaktOm.ToShortDateString()} - {log2.Aard}\t{log2.Omschrijving}");

            Log log3 = new Log(3, "Error", "Defect aan machine");
        }

        void MaakMails()
        {
            Mail mail1 = new Mail();
            mail1.Id = 1;
            mail1.Afzender = "ict@spermalie.be";
            mail1.Bestemmeling = "stefaan.vercaemer@howest.be";
            mail1.Cc = "";
            mail1.Bcc = "";
            mail1.Onderwerp = "Test";
            mail1.HtmlBody = "Test";
            mail1.GebruikersNaam = "ict@spermalie.be";
            mail1.Paswoord = "xxxx";
            mail1.Port = 587;
            mail1.SmtpServer = "smtp.live.com";
            mail1.Datum = DateTime.Now;

            Mail mail2 = new Mail
            {
                Id = 2,
                Afzender = "ict@spermalie.be",
                Bestemmeling = "stefaan.vercaemer@howest.be",
                Cc = "",
                Bcc = "",
                Onderwerp = "Test",
                HtmlBody = "Test",
                GebruikersNaam = "ict@spermalie.be",
                Paswoord = "xxxx",
                Port = 587,
                SmtpServer = "smtp.live.com",
                Datum = DateTime.Now

            };

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StartSituatieGrid(grdAuto);
            StartSituatieGrid(grdBasis);
            StartSituatieGrid(grdLog);
            StartSituatieGrid(grdMail);
            ToonGrid(grdAuto);
        }
    }
}
