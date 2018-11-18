using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa2_IgorMilatovic
{
    public class ParkingMesto
    {
        private bool Slobodno;
        private string RegBroj;
        private string ImeParkingMesta;


        public ParkingMesto(bool setSlob, string setR, string setImeParkMesta)
        {
            SetSlobodno(setSlob);
            SetRegBroj(setR);
            SetImeParkMesta(setImeParkMesta);

        }

        public bool GetSlobodno()
        {
            return Slobodno;
            
        } 
        
        public void SetSlobodno(bool ifSlobodno)
        {
            Slobodno = ifSlobodno;

        }

        public string GetRegBroj()
        {
            return RegBroj;

        }

        public void SetRegBroj(string regBroj)
        {
            RegBroj = regBroj;
        }

        public string GetImeParkMesta()
        {
            return ImeParkingMesta;

        }

        public void SetImeParkMesta(string imeParkMesta)
        {
            ImeParkingMesta = imeParkMesta;
        }

        public override string ToString()
        {
            if (GetSlobodno())
            {   
                return "Mesto: " + GetImeParkMesta() + " je slobodno";
            }
            else
            {
                return "Mesto: " + GetImeParkMesta() + " je zauzeto, " + "registarski broj parkiranog vozila je: " + GetRegBroj();
            }
            
        }
    }
}
