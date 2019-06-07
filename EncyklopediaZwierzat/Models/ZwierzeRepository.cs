using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncyklopediaZwierzat.Models
{
    public class ZwierzeRepository : IZwierzeRepository //15
    {
        private readonly AppDbContext _appDbContext;// 16 deklarowanie zmiennej by mieć dostęp do AppDbCOntext

        public ZwierzeRepository(AppDbContext appDbContext) //17 wsytrzykiwanie contextu
        {
            _appDbContext = appDbContext;
        }

   

        public IEnumerable<Zwierze> PobierzWszystkieZwierzeta()
        {
            return _appDbContext.Zwierzeta; 
        }

        public Zwierze PobierzZwierzeOId(int zwierzeID)
        {
            return _appDbContext.Zwierzeta.FirstOrDefault(z => z.Id == zwierzeID); // pobieranie pierwszego zwierzaka który pasuje do żądanyego ID 
        }

        public void DodajZwierze(Zwierze zwierze)
        {
            _appDbContext.Zwierzeta.Add(zwierze);
            _appDbContext.SaveChanges();
        }

        public void EdytujZwierze(Zwierze zwierze)
        {
            _appDbContext.Zwierzeta.Update(zwierze);
            _appDbContext.SaveChanges();
        }

        public void UsunZwierze(Zwierze zwierze)
        {
            _appDbContext.Zwierzeta.Remove(zwierze);
            _appDbContext.SaveChanges();
        }
    }
}
