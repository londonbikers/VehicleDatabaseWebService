using VehicleDatabaseManager.Models;

namespace VehicleDatabaseManager.Responses
{
    public class GetVehicleModelResponse : ResponseBase
    {
        public GetOperationResultType ResultType { get; set; }
        public VehicleModel Content { get; set; }

        public GetVehicleModelResponse()
        {
            ResultType = GetOperationResultType.Success;
        }
    }
}