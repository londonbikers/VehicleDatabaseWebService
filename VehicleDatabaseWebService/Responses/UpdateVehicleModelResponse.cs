namespace VehicleDatabaseManager.Responses
{
    public class UpdateVehicleModelResponse : ResponseBase
    {
        public UpdateOperationResultType ResultType { get; set; }

        public UpdateVehicleModelResponse()
        {
            ResultType = UpdateOperationResultType.Success;
        }
    }
}