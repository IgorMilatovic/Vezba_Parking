using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa2_IgorMilatovic
{
    class Parking
    {
        List<ParkingMesto> ParkingMesta;

        public Parking()
        {
            ParkingMesta = new List<ParkingMesto>();
        }

        public void DodajParkingMesto(ParkingMesto mesto)
        {
            ParkingMesta.Add(mesto);
        }

        public bool DaLiJeSlobodno()
        {   
            bool provera = ParkingMesta.Any(x => x.GetSlobodno() == true);
            if (provera)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public bool UvodjenjeVozila(string registracijaVozila)
        {
            bool provera = DaLiJeSlobodno();

            if (provera)
            {
                for (var i = 0; i < ParkingMesta.Count; i++)
                {
                    if (ParkingMesta[i].GetSlobodno())
                    {
                        ParkingMesta[i].SetSlobodno(false);
                        ParkingMesta[i].SetRegBroj(registracijaVozila);
                        break;
                    }
                }

                return true;
            }
            else
            {
                Console.WriteLine("Na parkingu vise nema mesta");
                return false;
            }
            
        }

        public void IzvodjenjeVozila(string registracijaVozila)
        {   
            for (var i = 0; i < ParkingMesta.Count; i++)
            {
                if (ParkingMesta[i].GetRegBroj() == registracijaVozila)
                {   
                    ParkingMesta[i].SetSlobodno(true);
                    ParkingMesta[i].SetRegBroj("");
                }
            }
        }

        public  void IspisiStanjeCelogParkinga()
        {
            foreach (var mesto in ParkingMesta)
            {
                if (mesto.GetSlobodno())
                {
                    Console.WriteLine("Mesto " + mesto.GetImeParkMesta() + " je slobodno"); 
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Mesto " + mesto.GetImeParkMesta() + " je zauzeto");
                    Console.WriteLine("Broj registracije parkiranog vozila je: " + mesto.GetRegBroj());
                    Console.WriteLine("-----------------------------------------------");
                }
            }
        }
    }
} 
