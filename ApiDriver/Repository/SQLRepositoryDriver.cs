using ApiDriver.Dto;

namespace ApiDriver.Repository
{
    public class SQLRepositoryDriver : IRepositoryDriver
    {
        public Task<DriverDto> CreateDriver(DriverDto driverDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDriver(int condId)
        {
            throw new NotImplementedException();
        }

        public Task<DriverDto> GetDriverById(int condId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DriverDto>> GetDrivers()
        {
            throw new NotImplementedException();
        }

        public Task<DriverDto> UpdateDriver(DriverDto driverDto)
        {
            throw new NotImplementedException();
        }
    }
}
