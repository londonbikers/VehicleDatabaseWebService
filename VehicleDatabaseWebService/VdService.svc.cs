using System;
using System.ServiceModel.Activation;
using VehicleDatabaseManager.Models;
using VehicleDatabaseManager.Responses;

namespace VehicleDatabaseManager
{
    /// <summary>
    /// The VdService serves as a facade, abstracting away the underlying VehicleDatabaseServer which will fulfill the operations.
    /// This abstraction allows for the Server to be loosely-coupled, bringing benefits in unit-testing and portability.
    /// I haven't gone the whole-hog though and put it into a separate project as this is intended on being such a simple service.
    /// </summary>
    [ServiceErrorBehavior(typeof(ErrorHandler))]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class VdService : IVdService
    {
        #region accessors
        private VehicleDatabaseServer Server { get; set; }
        #endregion

        #region constructors
        public VdService()
        {
            Server = VehicleDatabaseServer.Instance;
        }
        #endregion

        public GetVehicleTypesResponse GetVehicleTypes()
        {
            var response = new GetVehicleTypesResponse();
            try
            {
                response.Content = Server.GetVehicleTypes();
            }
            catch (Exception ex)
            {
                response.ResultType = GetOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }
            
            return response;
        }

        public GetVehicleManufacturersResponse GetVehicleManufacturers()
        {
            var response = new GetVehicleManufacturersResponse();
            try
            {
                response.Content = Server.GetVehicleManufacturers();
            }
            catch (Exception ex)
            {
                response.ResultType = GetOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public GetVehicleManufacturerResponse GetVehicleManufacturer(int id)
        {
            var response = new GetVehicleManufacturerResponse();
            try
            {
                var m = Server.GetVehicleManufacturer(id);
                if (m == null)
                    response.ResultType = GetOperationResultType.FailureEntityDoesntExist;
                else
                    response.Content = m;
            }
            catch (Exception ex)
            {
                response.ResultType = GetOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public GetVehicleModelResponse GetVehicleModel(int id)
        {
            var response = new GetVehicleModelResponse();
            try
            {
                var m = Server.GetVehicleModel(id);
                if (m == null)
                    response.ResultType = GetOperationResultType.FailureEntityDoesntExist;
                else
                    response.Content = m;
            }
            catch (Exception ex)
            {
                response.ResultType = GetOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public GetVehicleModelsByManufacturerIdResponse GetVehicleModelsByManufacturerId(int id)
        {
            var response = new GetVehicleModelsByManufacturerIdResponse();
            try
            {
                var m = Server.GetVehicleModelsByManufacturerId(id);
                if (m == null)
                    response.ResultType = GetOperationResultType.FailureEntityDoesntExist;
                else
                    response.Content = m;
            }
            catch (Exception ex)
            {
                response.ResultType = GetOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public GetVehicleModelsByManufacturerResponse GetVehicleModelsByManufacturer(VehicleManufacturer manufacturer)
        {
            var response = new GetVehicleModelsByManufacturerResponse();
            try
            {
                var m = Server.GetVehicleModelsByManufacturer(manufacturer);
                if (m == null)
                    response.ResultType = GetOperationResultType.FailureEntityDoesntExist;
                else
                    response.Content = m;
            }
            catch (Exception ex)
            {
                response.ResultType = GetOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public UpdateVehicleTypeResponse UpdateVehicleType(VehicleType type)
        {
            var response = new UpdateVehicleTypeResponse();
            try
            {
                response.ResultType = Server.UpdateVehicleType(type);
            }
            catch (Exception ex)
            {
                response.ResultType = UpdateOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public UpdateVehicleManufacturerResponse UpdateVehicleManufacturer(VehicleManufacturer manufacturer)
        {
            var response = new UpdateVehicleManufacturerResponse();
            try
            {
                response.ResultType = Server.UpdateVehicleManufacturer(manufacturer);
            }
            catch (Exception ex)
            {
                response.ResultType = UpdateOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public UpdateVehicleModelResponse UpdateVehicleModel(VehicleModel model)
        {
            var response = new UpdateVehicleModelResponse();
            try
            {
                response.ResultType = Server.UpdateVehicleModel(model);
            }
            catch (Exception ex)
            {
                response.ResultType = UpdateOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public UpdateClientResponse UpdateClient(Client client)
        {
            var response = new UpdateClientResponse();
            try
            {
                response.ResultType = Server.UpdateClient(client);
            }
            catch (Exception ex)
            {
                response.ResultType = UpdateOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public DeleteVehicleTypeResponse DeleteVehicleType(int id)
        {
            var response = new DeleteVehicleTypeResponse();
            try
            {
                response.ResultType = Server.DeleteVehicleType(id);
            }
            catch (Exception ex)
            {
                response.ResultType = DeleteOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public DeleteVehicleTypeResponse DeleteVehicleManufacturer(int id)
        {
            var response = new DeleteVehicleTypeResponse();
            try
            {
                response.ResultType = Server.DeleteVehicleManufacturer(id);
            }
            catch (Exception ex)
            {
                response.ResultType = DeleteOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public DeleteVehicleModelResponse DeleteVehicleModel(int id)
        {
            var response = new DeleteVehicleModelResponse();
            try
            {
                response.ResultType = Server.DeleteVehicleModel(id);
            }
            catch (Exception ex)
            {
                response.ResultType = DeleteOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }

        public DeleteClientResponse DeleteClient(int id)
        {
            var response = new DeleteClientResponse();
            try
            {
                response.ResultType = Server.DeleteClient(id);
            }
            catch (Exception ex)
            {
                response.ResultType = DeleteOperationResultType.FailureApplicationFault;
                response.ErrorMessage = ex.Message;
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

            return response;
        }
    }
}