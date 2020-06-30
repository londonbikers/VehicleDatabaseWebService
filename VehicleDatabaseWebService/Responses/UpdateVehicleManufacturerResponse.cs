namespace VehicleDatabaseManager.Responses
{
    public class UpdateVehicleManufacturerResponse : ResponseBase
    {
        public UpdateOperationResultType ResultType { get; set; }

        public UpdateVehicleManufacturerResponse()
        {
            ResultType = UpdateOperationResultType.Success;
        }
    }
}