using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAync();
        }

        private async Task CheckCountriesAync()
        {
            if(!_context.Countries.Any()) 
            {
                _context.Countries.Add(new Country { Name = "Zapata" });
                _context.Countries.Add(new Country { Name = "Tlanalapa" });
                _context.Countries.Add(new Country { Name = "Bonfil" });
                _context.Countries.Add(new Country { Name = "Jaltepec" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
