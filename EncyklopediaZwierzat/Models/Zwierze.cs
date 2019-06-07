namespace EncyklopediaZwierzat.Models
{
    public class Zwierze //1
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Rasa { get; set; }
        public string Srodowisko { get; set; }
        public string KrajWystepowania { get; set; }
        public string Odzywianie { get; set; }
        public string Opis { get; set; }
        public double SredniaDlugoscZycia { get; set; }
        public string ZdjecieUrl { get; set; }
        public string MiniaturkaUrl { get; set; }
        public bool CzyZnajdeGoWPolsce { get; set; }
        public bool CZyJestGatunkiemChronionym { get; set; }

    }
}
