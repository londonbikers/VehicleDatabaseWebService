namespace VehicleDatabaseManager
{
    public enum ApprovalStatus
    {
        Approved = 0,
        Suggested = 1
    }

	/// <summary>
	/// Defines how a class is instantiated.
	/// </summary>
	public enum ObjectMode
	{
		New,
		Existing
	}

    /// <summary>
    /// Defines a response to a delete operation.
    /// </summary>
    public enum DeleteOperationResultType
    {
        Success,
        FailureEntityDoesntExist,
        FailureEntityHasDependencies,
        FailureApplicationFault
    }

    /// <summary>
    /// Defines a response to a create/update operation.
    /// </summary>
    public enum UpdateOperationResultType
    {
        Success,
        FailureEntityAlreadyExists,
        FailureEntityIsInvalid,
        FailureApplicationFault
    }

    /// <summary>
    /// Defines a response to a get operation,
    /// </summary>
    public enum GetOperationResultType
    {
        Success,
        FailureEntityDoesntExist,
        FailureApplicationFault
    }
}