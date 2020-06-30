namespace VehicleDatabaseManager.Responses
{
    public class DeleteClientResponse : ResponseBase
    {
        public DeleteOperationResultType ResultType { get; set; }

        public DeleteClientResponse()
        {
            ResultType = DeleteOperationResultType.Success;
        }
    }
}