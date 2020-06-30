using System.ServiceModel;
using VehicleDatabaseManager.Models;
using VehicleDatabaseManager.Responses;

namespace VehicleDatabaseManager
{
    [ServiceContract]
    public interface IVdService
    {
        [OperationContract]
        GetVehicleTypesResponse GetVehicleTypes();

        [OperationContract]
        GetVehicleManufacturersResponse GetVehicleManufacturers();

        [OperationContract]
        GetVehicleManufacturerResponse GetVehicleManufacturer(int id);

        [OperationContract]
        GetVehicleModelResponse GetVehicleModel(int id);

        [OperationContract]
        GetVehicleModelsByManufacturerIdResponse GetVehicleModelsByManufacturerId(int id);

        [OperationContract]
        GetVehicleModelsByManufacturerResponse GetVehicleModelsByManufacturer(VehicleManufacturer manufacturer);

        [OperationContract]
        UpdateVehicleTypeResponse UpdateVehicleType(VehicleType type);

        [OperationContract]
        UpdateVehicleManufacturerResponse UpdateVehicleManufacturer(VehicleManufacturer manufacturer);

        [OperationContract]
        UpdateVehicleModelResponse UpdateVehicleModel(VehicleModel model);

        [OperationContract]
        UpdateClientResponse UpdateClient(Client client);

        [OperationContract]
        DeleteVehicleTypeResponse DeleteVehicleType(int id);
        
        [OperationContract]
        DeleteVehicleTypeResponse DeleteVehicleManufacturer(int id);
        
        [OperationContract]
        DeleteVehicleModelResponse DeleteVehicleModel(int id);

        [OperationContract]
        DeleteClientResponse DeleteClient(int id);
    }
}