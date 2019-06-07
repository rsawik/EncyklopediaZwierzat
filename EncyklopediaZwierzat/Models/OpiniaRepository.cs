namespace EncyklopediaZwierzat.Models
{
    public class OpiniaRepository : IOpiniaRepository
    {
        private readonly AppDbContext appDbContext;
        public OpiniaRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void DodajOpinie(Opinia opinia)
        {
            appDbContext.Opinie.Add(opinia);
            appDbContext.SaveChanges();
        }
    }
}
