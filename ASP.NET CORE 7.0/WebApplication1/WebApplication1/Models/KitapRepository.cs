using WebApplication1.Utility;

namespace WebApplication1.Models
{
    public class KitapRepository : Repository<Kitap>, IKitapRepository
    {
        private UygulamaDbContext _uygulamaDbContext;

        public KitapRepository(UygulamaDbContext context) : base(context)
        {
            _uygulamaDbContext = context;
        }

        public void Guncelle(Kitap kitap)
        {
            _uygulamaDbContext.Update(kitap);
        }

        public void Kaydet()
        {
            _uygulamaDbContext.SaveChanges();
        }
    }
}
