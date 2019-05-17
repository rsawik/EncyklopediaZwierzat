using System.Collections.Generic;
using System.Linq;

namespace EncyklopediaZwierzat.Models
{
    public class MockZwierzeRepository : IZwierzeRepository 
    {

        private List<Zwierze> zwierzeta; //3
        public MockZwierzeRepository() //5
        {
            if(zwierzeta == null)
            {
                ZaladujZwierzeta();
            }
        }

        private void ZaladujZwierzeta() //4
        {
            zwierzeta = new List<Zwierze>
            {
                new Zwierze {Id=1,Nazwa ="Słoń", Rasa ="Szary", KrajWystepowania = "Indie", Odzywianie = "Roślinność", Srodowisko ="Ląd", Opis = "Bardzo duży przedstawiciel ssaków", SredniaDlugoscZycia = 90, CzyZnajdeGoWPolsce =true, ZdjecieUrl="/images/slon.jpg",MiniaturkaUrl ="/images/slon.jpg"},
                 new Zwierze {Id=2,Nazwa ="Rekin", Rasa ="Żarłacz", KrajWystepowania = "Ocean Atlantycki", Odzywianie = "Inne ryby", Srodowisko ="Woda", Opis = "Agresywny przedstawiciel ryb", SredniaDlugoscZycia = 50, CzyZnajdeGoWPolsce =false, ZdjecieUrl="/images/rekin.jpg",MiniaturkaUrl ="/images/rekin.jpg"},
                  new Zwierze {Id=3,Nazwa ="Żubr", Rasa ="Europejski", KrajWystepowania = "Polska, Litwa, Rosja", Odzywianie = "Roślinność", Srodowisko ="Ląd", Opis = "Artefakt Puszczy Białowieskiej", SredniaDlugoscZycia = 40, CzyZnajdeGoWPolsce =true, ZdjecieUrl="/images/zubr.jpg",MiniaturkaUrl ="/images/zubr.jpg"}
            };
        }

        public IEnumerable<Zwierze> PobierzWszystkieZwierzeta() //6
        {
            return zwierzeta;
        }

        public Zwierze PobierzZwierzeOId(int zwierzeID) //7
        {
            return zwierzeta.FirstOrDefault(z => z.Id == zwierzeID); // pierwsze zwierze dla ktorego id bedzie = przekazanemu identyfikatorowi, jesli nie ma to zwraca domyslna
        }
    }
}
