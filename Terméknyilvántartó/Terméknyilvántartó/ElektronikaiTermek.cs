using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terméknyilvántartó
{
    public class ElektronikaiTermek : Termek
    {
        private int garancia;

        public int Garancia { get => garancia; set => garancia = value; }

        public ElektronikaiTermek(int azonosito, string nev, int ar, int keszlet, int garancia): base(azonosito,nev, ar, keszlet)
        {
            this.garancia = garancia;
        }

        public ElektronikaiTermek(string nev, int ar, int keszlet, int garancia): base(nev,ar,keszlet)
        {
            this.Garancia = garancia;
        }

        public ElektronikaiTermek() { }

        public override string FileToString()
        {
            return $"{Azonosito};{Nev};{Ar};{Keszlet};{Garancia}";
        }

        public override string ToString()
        {
            return Nev;
        }

    }
}
