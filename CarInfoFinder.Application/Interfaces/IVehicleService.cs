using CarInfoFinder.Domain.Entities;

namespace CarInfoFinder.Application.Interfaces
{
    public interface IVehicleService
    {
        Task<List<Make>> GetAllMakesAsync();
        Task<List<VehicleType>> GetVehicleTypesForMakeIdAsync(int makeId);
        Task<List<Model>> GetModelsForMakeIdYearAsync(int makeId, int year);
    }
}
