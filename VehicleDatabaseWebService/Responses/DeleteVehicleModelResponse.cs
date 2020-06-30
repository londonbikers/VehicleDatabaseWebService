namespace VehicleDatabaseManager.Responses
{
    public class DeleteVehicleModelResponse : ResponseBase
    {
        public DeleteOperationResultType ResultType { get; set; }

        public DeleteVehicleModelResponse()
        {
            ResultType = DeleteOperationResultType.Success;
        }
    }
}