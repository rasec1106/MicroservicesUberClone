using ApiDriver.Dto;

namespace ApiDriver.Repository
{
    public interface IRepositoryDriver
    {

        Task<IEnumerable<DriverDto>> GetDrivers();
        Task<DriverDto> GetDriverById(int condId);
        Task<DriverDto> CreateDriver(DriverDto driverDto);
        Task<DriverDto> UpdateDriver(DriverDto driverDto);
        Task<bool> DeleteDriver(int condId);

    }
}
