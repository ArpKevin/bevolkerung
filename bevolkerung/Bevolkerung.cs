using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevolkerung
{
    internal class bevolkerung
    {
        public bevolkerung(string sor)
        {
            var x = sor.Split(";");
            Id = int.Parse(x[0]);
            Nem = x[1];
            SzuletesiEv = int.Parse(x[2]);
            Suly = int.Parse(x[3]);
            Magassag = int.Parse(x[4]);
            Dohanyzik = x[5] == "igen";
            Nemzetiseg = x[6];
            Nepcsoport = x[7];
            Tartomany = x[8];
            NettoJovedelem = int.Parse(x[9]);
            IskolaiVegzettseg = x[10];
            PolitikaiNezet = x[11];
            AktivSzavazo = x[12] == "igen";
            SorFogyasztasEvente = int.Parse(x[13]);
            KrumpliFogyasztasEvente = int.Parse(x[14]);
        }

        public int Id { get; set; }
        public string Nem { get; set; }
        public int SzuletesiEv { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }
        public bool Dohanyzik { get; set; }
        public string Nemzetiseg { get; set; }
        public string? Nepcsoport { get; set; }
        public string Tartomany { get; set; }
        public int NettoJovedelem { get; set; }
        public string? IskolaiVegzettseg { get; set; }
        public string PolitikaiNezet { get; set; }
        public bool AktivSzavazo { get; set; }
        public int? SorFogyasztasEvente { get; set; }
        public int? KrumpliFogyasztasEvente { get; set; }
    }
}

