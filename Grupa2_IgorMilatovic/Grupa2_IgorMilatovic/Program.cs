using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa2_IgorMilatovic
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking();

            ParkingMesto pm1 = new ParkingMesto(true, "", "pm1");
            ParkingMesto pm2 = new ParkingMesto(true, "", "pm2");
            ParkingMesto pm3 = new ParkingMesto(true, "", "pm3");
            ParkingMesto pm4 = new ParkingMesto(true, "", "pm4");
            ParkingMesto pm5 = new ParkingMesto(true, "", "pm5");
            ParkingMesto pm6 = new ParkingMesto(true, "", "pm6");
            ParkingMesto pm7 = new ParkingMesto(true, "", "pm7");

            parking.DodajParkingMesto(pm1);
            parking.DodajParkingMesto(pm2);
            parking.DodajParkingMesto(pm3);
            parking.DodajParkingMesto(pm4);
            parking.DodajParkingMesto(pm5);
            parking.DodajParkingMesto(pm6);
            parking.DodajParkingMesto(pm7);

            parking.UvodjenjeVozila("BG123IV");
            parking.UvodjenjeVozila("NS234LO");
            parking.UvodjenjeVozila("KG751MM");

            string stanjePojedinogParkingMesta1 = pm1.ToString();
            Console.WriteLine(stanjePojedinogParkingMesta1);

            string stanjePojedinogParkingMesta2 = pm6.ToString();
            Console.WriteLine(stanjePojedinogParkingMesta2);

            parking.IspisiStanjeCelogParkinga();

            Console.ReadLine();
        }
    }
}
