using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terméknyilvántartó
{
   public class Termek
    {
        protected static int plusz = 0;
        protected string nev;
        protected int keszlet;
        protected int ar;
        protected int azonosito;

        public static int Plusz { get => plusz; set => plusz = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Keszlet { get => keszlet; set => keszlet = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Azonosito { get => azonosito; set => azonosito = value; }


        public Termek(string nev, int ar, int keszlet = 0)
        {
            this.Azonosito = ++plusz;
            this.Nev = nev;
            this.Ar = ar;
            this.Keszlet = keszlet;
        }
        public Termek(int azonosito, string nev, int ar, int keszlet)
        {
            this.Azonosito = azonosito;
            this.Nev = nev;
            this.Ar = ar;
            this.Keszlet = keszlet;
        }

        public Termek() { }

        public virtual string FileToString()
        {
            return $"{Azonosito};{Nev};{Ar};{Keszlet}";
        }

        public override string ToString()
        {
            return Nev;
        }
    }
}
