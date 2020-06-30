namespace VehicleDatabaseManager.Responses
{
    public class DeleteVehicleTypeResponse : ResponseBase
    {
        public DeleteOperationResultType ResultType { get; set; }

        public DeleteVehicleTypeResponse()
        {
            ResultType = DeleteOperationResultType.Success;
        }
    }
}