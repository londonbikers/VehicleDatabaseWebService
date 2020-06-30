using VehicleDatabaseManager.Models;

namespace VehicleDatabaseManager.Responses
{
    public class GetVehicleManufacturerResponse : ResponseBase
    {
        public GetOperationResultType ResultType { get; set; }
        public VehicleManufacturer Content { get; set; }

        public GetVehicleManufacturerResponse()
        {
            ResultType = GetOperationResultType.Success;
        }
    }
}