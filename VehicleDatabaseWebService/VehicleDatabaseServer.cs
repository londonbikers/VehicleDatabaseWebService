using System;
using System.Linq;
using System.Collections.Generic;
using VehicleDatabaseManager.Interfaces;
using VehicleDatabaseManager.Models;

namespace VehicleDatabaseManager
{
	public class VehicleDatabaseServer
    {
        #region members
	    private List<Client> _clients;
        private List<VehicleType> _types;
	    private List<VehicleModel> _models;
        private List<VehicleManufacturer> _manufacturers;
        #endregion

        #region accessors
        private List<Client> Clients
        {
            get
            {
                if (_clients == null)
                    RetrieveClients();

                return _clients;
            }
            set
            {
                _clients = value;
            }
        }
	    private List<VehicleManufacturer> Manufacturers
	    {
	        get
	        {
                if (_manufacturers == null)
                    RetrieveVehicleManufacturers();

                return _manufacturers;
	        }
	        set
            {
                _manufacturers = value;
            }
	    }
        private List<VehicleModel> Models
        {
            get
            {
                if (_models == null)
                    RetrieveVehicleModels();

                return _models;
            }
            set
            {
                _models = value;
            }
        }
        private List<VehicleType> Types
        {
            get
            {
                if (_types == null)
                    RetrieveVehicleTypes();

                return _types;
            }
            set
            {
                _types = value;
            }
        }
        /// <summary>
        /// Retrieves the single instance of the application.
        /// </summary>
        public static VehicleDatabaseServer Instance { get; private set; }
        #endregion

        #region constructors
        static VehicleDatabaseServer()
	    {
            Instance = new VehicleDatabaseServer();
	    }
        #endregion

        #region get methods
        public List<VehicleType> GetVehicleTypes()
        {
            return Types;
        }

        public List<VehicleManufacturer> GetVehicleManufacturers()
        {
            return Manufacturers;
        }

        public VehicleManufacturer GetVehicleManufacturer(int id)
        {
            return Manufacturers.SingleOrDefault(q => q.Id == id);
        }

        public VehicleModel GetVehicleModel(int id)
        {
            return Models.SingleOrDefault(q => q.Id == id);
        }

        public List<VehicleModel> GetVehicleModelsByManufacturerId(int manufacturerId)
        {
            return Models.Where(q => q.ManufacturerId == manufacturerId).ToList();
        }

        public List<VehicleModel> GetVehicleModelsByManufacturer(VehicleManufacturer manufacturer)
        {
            return GetVehicleModelsByManufacturerId(manufacturer.Id);
        }
        #endregion

        #region create/update methods
        /// <summary>
        /// Creates a new or updates an existing VehicleType.
        /// </summary>
        public UpdateOperationResultType UpdateVehicleType(VehicleType vehicleType)
        {
            if (!vehicleType.IsValid())
                return UpdateOperationResultType.FailureEntityIsInvalid;

            using (var db = new VDDataContext())
            {
                DbType dbType;
                if (vehicleType.IsPersisted)
                {
                    dbType = db.DbTypes.Single(t => t.ID == vehicleType.Id);
                }
                else
                {
                    // duplicity check.
                    if (db.DbTypes.Count(q => q.Name.ToLower() == vehicleType.Name.ToLower().Trim()) > 0)
                        return UpdateOperationResultType.FailureEntityAlreadyExists;

                    dbType = new DbType();
                }

                dbType.Status = (int) vehicleType.ApprovalStatus;
                dbType.Name = vehicleType.Name.Trim();
                if (!vehicleType.IsPersisted)
                    db.DbTypes.InsertOnSubmit(dbType);

                db.SubmitChanges();

                if (!vehicleType.IsPersisted)
                {
                    vehicleType.Id = dbType.ID;
                    vehicleType.IsPersisted = true;
                }
            }

            // update VehicleTypes cache.
            Types = null;
            return UpdateOperationResultType.Success;
        }

        /// <summary>
        /// Creates a new or updates an existing VehicleManufacturer
        /// </summary>
        public UpdateOperationResultType UpdateVehicleManufacturer(VehicleManufacturer vehicleManufacturer)
        {
            if (!vehicleManufacturer.IsValid())
                return UpdateOperationResultType.FailureEntityIsInvalid;

            using (var db = new VDDataContext())
            {
                DbManufacturer dbManufacturer;
                if (vehicleManufacturer.IsPersisted)
                {
                    dbManufacturer = db.DbManufacturers.Single(t => t.ID == vehicleManufacturer.Id);
                }
                else
                {
                    // duplicity check.
                    if (db.DbManufacturers.Count(q => q.Name.ToLower() == vehicleManufacturer.Name.ToLower().Trim()) > 0)
                        return UpdateOperationResultType.FailureEntityAlreadyExists;

                    dbManufacturer = new DbManufacturer();
                }

                dbManufacturer.Status = (int)vehicleManufacturer.ApprovalStatus;
                dbManufacturer.Name = vehicleManufacturer.Name.Trim();
                dbManufacturer.WikipediaID = vehicleManufacturer.WikipediaId.Trim();
                if (!vehicleManufacturer.IsPersisted)
                    db.DbManufacturers.InsertOnSubmit(dbManufacturer);

                db.SubmitChanges();

                if (!vehicleManufacturer.IsPersisted)
                {
                    vehicleManufacturer.Id = dbManufacturer.ID;
                    vehicleManufacturer.IsPersisted = true;
                }
            }

            // update VehicleManufacturer cache.
            Manufacturers = null;
            return UpdateOperationResultType.Success;
        }

        /// <summary>
        /// Creates a new or updates an existing VehicleModel.
        /// </summary>
        public UpdateOperationResultType UpdateVehicleModel(VehicleModel model)
        {
            if (!model.IsValid())
                return UpdateOperationResultType.FailureEntityIsInvalid;

            var isNew = false;
            using (var db = new VDDataContext())
            {
                DbModel dbModel;
                if (model.IsPersisted)
                {
                    dbModel = db.DbModels.Single(t => t.ID == model.Id);
                }
                else
                {
                    // duplicity check.
                    if (db.DbModels.Count(q => q.Name.ToLower() == model.Name.ToLower().Trim() && q.ManufacturerID == model.ManufacturerId) > 0)
                        return UpdateOperationResultType.FailureEntityAlreadyExists;

                    dbModel = new DbModel();
                }

                dbModel.Status = (int)model.ApprovalStatus;
                dbModel.Name = model.Name.Trim();
                dbModel.ManufacturerID = model.ManufacturerId;
                dbModel.TypeID = model.Type.Id;
                dbModel.YearIntroduced = model.YearIntroduced;
                dbModel.YearStopped = model.YearStopped;
                dbModel.WikipediaID = !string.IsNullOrEmpty(model.WikipediaId) ? model.WikipediaId.Trim() : null;
                dbModel.EngineSizeCC = model.EngineSizeCc;

                if (!model.IsPersisted)
                    db.DbModels.InsertOnSubmit(dbModel);

                db.SubmitChanges();

                if (!model.IsPersisted)
                {
                    isNew = true;
                    model.Id = dbModel.ID;
                    model.IsPersisted = true;
                }
            }

            // update VehicleModel cache.
            Models = null;

            // need to clear the manufacturer model cache as well so it's reloaded.
            if (isNew)
                Manufacturers = null;

            return UpdateOperationResultType.Success;
        }

        /// <summary>
        /// Creates a new or updates an existing Client.
        /// </summary>
        public UpdateOperationResultType UpdateClient(Client client)
        {
            if (!client.IsValid())
                return UpdateOperationResultType.FailureEntityIsInvalid;

            using (var db = new VDDataContext())
            {
                DbClient dbClient;
                if (client.IsPersisted)
                {
                    dbClient = db.DbClients.Single(t => t.ID == client.Id);
                }
                else
                {
                    if (db.DbClients.Count(q => q.Name.ToLower() == client.Name.ToLower().Trim()) > 0)
                        return UpdateOperationResultType.FailureEntityAlreadyExists;

                    dbClient = new DbClient();
                }

                dbClient.Name = client.Name.Trim();
                dbClient.CallbackUrl = client.CallbackUrl;
                dbClient.Password = client.Password;
                if (!client.IsPersisted)
                    db.DbClients.InsertOnSubmit(dbClient);

                db.SubmitChanges();

                if (!client.IsPersisted)
                {
                    client.Id = dbClient.ID;
                    client.IsPersisted = true;
                }
            }

            // update Clients cache.
            Clients = null;
            return UpdateOperationResultType.Success;
        }
        #endregion

        #region delete methods - oh these could be dangerous, only for use by VDEditor.
        public DeleteOperationResultType DeleteVehicleType(int id)
        {
            using (var db = new VDDataContext())
            {
                // existence check.
                var dbType = db.DbTypes.SingleOrDefault(q => q.ID == id);
                if (dbType == null)
                    return DeleteOperationResultType.FailureEntityDoesntExist;

                // don't delete if there's models referencing this type!
                if (db.DbModels.Count(q => q.DbType.ID == id) > 0)
                    return DeleteOperationResultType.FailureEntityHasDependencies;

                db.DbTypes.DeleteOnSubmit(dbType);
                db.SubmitChanges();
                
                Types = null;
                return DeleteOperationResultType.Success;
            }
        }

        public DeleteOperationResultType DeleteVehicleManufacturer(int id)
        {
            using (var db = new VDDataContext())
            {
                var dbManufacturer = db.DbManufacturers.SingleOrDefault(q => q.ID == id);
                if (dbManufacturer == null)
                    return DeleteOperationResultType.FailureEntityDoesntExist;

                // don't delete if there's children!
                if (dbManufacturer.DbModels.Count > 0)
                    return DeleteOperationResultType.FailureEntityHasDependencies;

                db.DbManufacturers.DeleteOnSubmit(dbManufacturer);
                db.SubmitChanges();

                Manufacturers = null;
                return DeleteOperationResultType.Success;
            }
        }

        public DeleteOperationResultType DeleteVehicleModel(int id)
        {
            using (var db = new VDDataContext())
            {
                var dbModel = db.DbModels.SingleOrDefault(q => q.ID == id);
                if (dbModel == null)
                    return DeleteOperationResultType.FailureEntityDoesntExist;

                db.DbModels.DeleteOnSubmit(dbModel);
                db.SubmitChanges();

                Manufacturers = null;
                Models = null;
                return DeleteOperationResultType.Success;
            }
        }

        public DeleteOperationResultType DeleteClient(int id)
        {
            using (var db = new VDDataContext())
            {
                var dbClient = db.DbClients.SingleOrDefault(q => q.ID == id);
                if (dbClient == null)
                    return DeleteOperationResultType.FailureEntityDoesntExist;

                db.DbClients.DeleteOnSubmit(dbClient);
                db.SubmitChanges();

                Clients = null;
                return DeleteOperationResultType.Success;
            }
        }
	    #endregion

        #region private methods
        private void PopulateManufacturerVehicletypes(IVehicleManufacturer manufacturer)
        {
            if (manufacturer == null)
                throw new ArgumentNullException("manufacturer");

            if (manufacturer.Types == null)
                manufacturer.Types = new List<VehicleType>();
            else
                manufacturer.Types.Clear();

            var vehicleTypes = GetVehicleTypes();
            using (var db = new VDDataContext())
            {
                var typeIds = (from models in db.DbModels where models.ManufacturerID == manufacturer.Id orderby models.Name select models.TypeID).Distinct();
                foreach (var type in typeIds)
                {
                    var type1 = type;
                    manufacturer.Types.Add(vehicleTypes.Single(q => q.Id == type1));
                }
            }
        }

        private void RetrieveVehicleTypes()
        {
            _types = new List<VehicleType>();
            lock (_types)
                using (var db = new VDDataContext())
                    foreach (var vt in db.DbTypes.OrderBy(q => q.Name).Select(dbType => new VehicleType(ObjectMode.Existing) {Id = dbType.ID, Name = dbType.Name, ApprovalStatus = (ApprovalStatus) dbType.Status }))
                        _types.Add(vt);
        }

        /// <summary>
        /// Retrieves all of the VehicleModel objects from the database.
        /// </summary>
        /// <remarks>
        /// Loads all of the models into memory, in isolation, i.e. no direct links to dependencies.
        /// </remarks>
        private void RetrieveVehicleModels()
        {
            _models = new List<VehicleModel>();
            lock (_models)
            {
                using (var db = new VDDataContext())
                {
                    foreach (var dbModel in db.DbModels.OrderBy(q=>q.Name))
                    {
                        var model = dbModel;
                        var m = new VehicleModel(ObjectMode.Existing)
                        {
                            ApprovalStatus = (ApprovalStatus) dbModel.Status,
                            Id = dbModel.ID,
                            ManufacturerId = dbModel.ManufacturerID,
                            Name = dbModel.Name,
                            Type = Types.Single(q => q.Id == model.TypeID),
                            VariantName = dbModel.VariantName,
                            WikipediaId = dbModel.WikipediaID,
                            YearIntroduced = dbModel.YearIntroduced,
                            YearStopped = dbModel.YearStopped,
                            EngineSizeCc = dbModel.EngineSizeCC
                        };

                        _models.Add(m);
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves all of the VehicleManufacturer objects from the database.
        /// </summary>
        /// <remarks>
        /// Loads all of the manufacturers into memory, in isolation, i.e. no direct links to dependencies.
        /// </remarks>
        private void RetrieveVehicleManufacturers()
        {
            _manufacturers = new List<VehicleManufacturer>();
            lock (_manufacturers)
            {
                using (var db = new VDDataContext())
                {
                    foreach (var dbManufacturer in db.DbManufacturers.OrderBy(q => q.Name))
                    {
                        var vm = new VehicleManufacturer(ObjectMode.Existing)
                        {
                            ApprovalStatus = (ApprovalStatus)dbManufacturer.Status,
                            Id = dbManufacturer.ID,
                            Name = dbManufacturer.Name,
                            WikipediaId = dbManufacturer.WikipediaID
                        };

                        PopulateManufacturerVehicletypes(vm);
                        _manufacturers.Add(vm);
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves all of the Client objects from the database.
        /// </summary>
        /// <remarks>
        /// Loads all of the clients into memory, in isolation, i.e. no direct links to dependencies.
        /// </remarks>
        private void RetrieveClients()
        {
            _clients = new List<Client>();
            lock (_clients)
            {
                using (var db = new VDDataContext())
                {
                    foreach (var dbClient in db.DbClients.OrderBy(q=>q.Name))
                    {
                        var c = new Client(ObjectMode.Existing)
                        {
                            Id = dbClient.ID,
                            CallbackUrl = dbClient.CallbackUrl,
                            Name = dbClient.Name,
                            Password = dbClient.Password
                        };

                        _clients.Add(c);
                    }
                }
            }
        }
        #endregion
    }
}