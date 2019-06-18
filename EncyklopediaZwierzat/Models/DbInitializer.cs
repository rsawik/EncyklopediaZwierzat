using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncyklopediaZwierzat.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Zwierzeta.Any())
            {
                context.AddRange(
                  new Zwierze { Nazwa = "Słoń", Rasa = "Szary", KrajWystepowania = "Indie", Odzywianie = "Roślinność", Srodowisko = "Ląd", Opis = "Bardzo duży przedstawiciel ssaków", SredniaDlugoscZycia = 90, CzyZnajdeGoWPolsce = true, ZdjecieUrl = "/images/slon.jpg", MiniaturkaUrl = "/images/slon.jpg" },
                  new Zwierze { Nazwa = "Rekin", Rasa = "Żarłacz", KrajWystepowania = "Ocean Atlantycki", Odzywianie = "Inne ryby", Srodowisko = "Woda", Opis = "Agresywny przedstawiciel ryb", SredniaDlugoscZycia = 50, CzyZnajdeGoWPolsce = false, ZdjecieUrl = "/images/rekin.jpg", MiniaturkaUrl = "/images/rekin.jpg" },
                  new Zwierze { Nazwa = "Żubr", Rasa = "Europejski", KrajWystepowania = "Polska, Litwa, Rosja", Odzywianie = "Roślinność", Srodowisko = "Ląd", Opis = "Artefakt Puszczy Białowieskiej", SredniaDlugoscZycia = 40, CzyZnajdeGoWPolsce = true, ZdjecieUrl = "/images/zubr.jpg", MiniaturkaUrl = "/images/zubr.jpg" },
                  new Zwierze { Nazwa = "RekinV2", Rasa = "Żarłacz", KrajWystepowania = "Ocean Atlantycki", Odzywianie = "Inne ryby", Srodowisko = "Woda", Opis = "Agresywny przedstawiciel ryb", SredniaDlugoscZycia = 50, CzyZnajdeGoWPolsce = false, ZdjecieUrl = "/images/rekin.jpg", MiniaturkaUrl = "/images/rekin.jpg" },
                  new Zwierze { Nazwa = "ŻubrV2", Rasa = "Europejski", KrajWystepowania = "Polska, Litwa, Rosja", Odzywianie = "Roślinność", Srodowisko = "Ląd", Opis = "Artefakt Puszczy Białowieskiej", SredniaDlugoscZycia = 40, CzyZnajdeGoWPolsce = true, ZdjecieUrl = "/images/zubr.jpg", MiniaturkaUrl = "/images/zubr.jpg" },
                  new Zwierze { Nazwa = "Słoń", Rasa = "Szary", KrajWystepowania = "Indie", Odzywianie = "Roślinność", Srodowisko = "Ląd", Opis = "Bardzo duży przedstawiciel ssaków", SredniaDlugoscZycia = 90, CzyZnajdeGoWPolsce = true, ZdjecieUrl = "/images/slon.jpg", MiniaturkaUrl = "/images/slon.jpg" },
                  new Zwierze { Nazwa = "Rekin", Rasa = "Żarłacz", KrajWystepowania = "Ocean Atlantycki", Odzywianie = "Inne ryby", Srodowisko = "Woda", Opis = "Agresywny przedstawiciel ryb", SredniaDlugoscZycia = 50, CzyZnajdeGoWPolsce = false, ZdjecieUrl = "/images/rekin.jpg", MiniaturkaUrl = "/images/rekin.jpg" },
                  new Zwierze { Nazwa = "Żubr", Rasa = "Europejski", KrajWystepowania = "Polska, Litwa, Rosja", Odzywianie = "Roślinność", Srodowisko = "Ląd", Opis = "Artefakt Puszczy Białowieskiej", SredniaDlugoscZycia = 40, CzyZnajdeGoWPolsce = true, ZdjecieUrl = "/images/zubr.jpg", MiniaturkaUrl = "/images/zubr.jpg" }
                  );
            }
            context.SaveChanges();
        }
    }
}
