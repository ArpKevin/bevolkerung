using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevolkerung
{
    internal class Allampolgar
    {
        public Allampolgar(string sor)
        {
            var x = sor.Split(";");
            Id = int.Parse(x[0]);
            Nem = x[1];
            SzuletesiEv = int.Parse(x[2]);
            Suly = int.Parse(x[3]);
            Magassag = int.Parse(x[4]);
            Dohanyzik = new KeyValuePair<bool, string>(x[5] == "igen", x[5] == "igen" ? "igen" : "nem");
            int sorFogyasztas = int.TryParse(x[13], out int sorVal) ? sorVal : -1;
            SorFogyasztasEvente = new KeyValuePair<int, string>(
                sorFogyasztas,
                sorFogyasztas == -1 ? "NA" : sorFogyasztas.ToString()
            );

            int krumpliFogyasztas = int.TryParse(x[14], out int krumpliVal) ? krumpliVal : -1;
            KrumpliFogyasztasEvente = new KeyValuePair<int, string>(
                krumpliFogyasztas,
                krumpliFogyasztas == -1 ? "NA" : krumpliFogyasztas.ToString()
            );
            Nemzetiseg = x[6];
            Nepcsoport = x[7];
            Tartomany = x[8];
            NettoJovedelem = int.Parse(x[9]);
            IskolaiVegzettseg = x[10];
            PolitikaiNezet = x[11];
            AktivSzavazo = x[12] == "igen";
        }

        public int Id { get; set; }
        public string Nem { get; set; }
        public int SzuletesiEv { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }
        public KeyValuePair<bool, string> Dohanyzik { get; set; }
        public string Nemzetiseg { get; set; }
        public string? Nepcsoport { get; set; }
        public string Tartomany { get; set; }
        public int NettoJovedelem { get; set; }
        public string? IskolaiVegzettseg { get; set; }
        public string PolitikaiNezet { get; set; }
        public bool AktivSzavazo { get; set; }
        public KeyValuePair<int, string> SorFogyasztasEvente { get; set; }
        public KeyValuePair<int, string> KrumpliFogyasztasEvente { get; set; }
        public int HaviNettoJovedelem => (int)(NettoJovedelem / 12.0);
        public int Eletkor => DateTime.Now.Year - SzuletesiEv;


        public override string ToString()
        {
            return $"{Id} {Nem} {SzuletesiEv} {Suly} {Magassag} " +
                   $"{(Dohanyzik.Key ? Dohanyzik.Value : string.Empty)} {Nemzetiseg} " +
                   $"{(Nepcsoport ?? "nincs")} {Tartomany} {NettoJovedelem} " +
                   $"{(IskolaiVegzettseg ?? "nincs")} {PolitikaiNezet} " +
                   $"{(AktivSzavazo ? "aktív-szavazó" : string.Empty)} " +
                   $"{(SorFogyasztasEvente.Value == "NA" ? "nem-fogyaszt-sört" : SorFogyasztasEvente.Value)} " +
                   $"{(KrumpliFogyasztasEvente.Value == "NA" ? "nem-fogyaszt-krumplit" : KrumpliFogyasztasEvente.Value)}";
        }

        public string ToString(bool x){ if (x) return $"{Id}\t{Nem}\t{SzuletesiEv}\t{Suly}\t{Magassag}"; else return $"{Id}\t{Nemzetiseg}\t{Nepcsoport ?? "nincs"}\t{Tartomany}\t{NettoJovedelem}";}


    }
}