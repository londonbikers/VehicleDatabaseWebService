using System.Collections.Generic;
using VehicleDatabaseManager.Models;

namespace VehicleDatabaseManager.Responses
{
    public class GetVehicleTypesResponse : ResponseBase
    {
        public GetOperationResultType ResultType { get; set; }
        public List<VehicleType> Content { get; set; }

        public GetVehicleTypesResponse()
        {
            ResultType = GetOperationResultType.Success;
        }
    }
}