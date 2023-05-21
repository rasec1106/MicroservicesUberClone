using ApiTrip.DbContexts;
using ApiTrip.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTrip.Repository
{
    public class TripSqlRepository : ITripRepository
    {
        private AppDbContext dbContext;
        public TripSqlRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Trip> testFunction(int id)
        {
            var trip = await dbContext.trips.Where(t => t.tripId == id).FirstOrDefaultAsync();
            return trip;
        }
    }
}
