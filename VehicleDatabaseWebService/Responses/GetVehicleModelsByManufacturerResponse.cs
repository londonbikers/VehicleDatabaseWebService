using System.Collections.Generic;
using VehicleDatabaseManager.Models;

namespace VehicleDatabaseManager.Responses
{
    public class GetVehicleModelsByManufacturerResponse : ResponseBase
    {
        public GetOperationResultType ResultType { get; set; }
        public List<VehicleModel> Content { get; set; }

        public GetVehicleModelsByManufacturerResponse()
        {
            ResultType = GetOperationResultType.Success;
        }
    }
}