namespace VehicleDatabaseManager.Responses
{
    public class UpdateVehicleTypeResponse : ResponseBase
    {
        public UpdateOperationResultType ResultType { get; set; }

        public UpdateVehicleTypeResponse()
        {
            ResultType = UpdateOperationResultType.Success;
        }
    }
}