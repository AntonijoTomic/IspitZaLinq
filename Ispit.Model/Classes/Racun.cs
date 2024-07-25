namespace Ispit.Model.Classes
{
    public class Racun
    {
        

        public int BrojRacuna { get; set; }
        public int ProizvodID{ get; set; }

        public int Kolicina { get; set; }


        public Racun(int brojRacuna, int proizvodID, int kolicina)
        {
            BrojRacuna = brojRacuna;
            ProizvodID = proizvodID;
            Kolicina = kolicina;
        }
    }
}
