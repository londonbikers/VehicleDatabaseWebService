using System.Collections.Generic;
using VehicleDatabaseManager.Models;

namespace VehicleDatabaseManager.Responses
{
    public class GetVehicleManufacturersResponse : ResponseBase
    {
        public GetOperationResultType ResultType { get; set; }
        public List<VehicleManufacturer> Content { get; set; }

        public GetVehicleManufacturersResponse()
        {
            ResultType = GetOperationResultType.Success;
        }
    }
}