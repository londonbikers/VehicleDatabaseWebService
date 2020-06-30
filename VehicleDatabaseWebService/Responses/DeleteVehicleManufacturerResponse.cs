namespace VehicleDatabaseManager.Responses
{
    public class DeleteVehicleManufacturerResponse : ResponseBase
    {
        public DeleteOperationResultType ResultType { get; set; }

        public DeleteVehicleManufacturerResponse()
        {
            ResultType = DeleteOperationResultType.Success;
        }
    }
}