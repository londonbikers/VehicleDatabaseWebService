using System;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace VehicleDatabaseManager.Models
{
    public class ErrorHandler : IErrorHandler
    {
        #region IErrorHandler Members
        public bool HandleError(Exception error)
        {
            return false;
        }

        public void ProvideFault(Exception error, System.ServiceModel.Channels.MessageVersion version, ref System.ServiceModel.Channels.Message fault)
        {
            if (error == null)
                return;

            if (HttpContext.Current == null) //In case we run outside of IIS
                return;

            Elmah.ErrorSignal.FromCurrentContext().Raise(error);
        }
        #endregion
    }
}