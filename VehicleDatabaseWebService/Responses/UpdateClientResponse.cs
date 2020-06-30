namespace VehicleDatabaseManager.Responses
{
    public class UpdateClientResponse : ResponseBase
    {
        public UpdateOperationResultType ResultType { get; set; }

        public UpdateClientResponse()
        {
            ResultType = UpdateOperationResultType.Success;
        }
    }
}