using ApiTrip.Models;

namespace ApiTrip.Repository
{
    public interface ITripRepository
    {
        public Task<Trip> testFunction(int id);
    }
}
