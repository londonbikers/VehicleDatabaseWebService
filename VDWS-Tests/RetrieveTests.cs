using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleDatabaseManager;
using VehicleDatabaseManager.Models;

namespace VDWS_Tests
{
    [TestClass]
    public class RetrieveTests
    {
        #region accessors
        private VehicleDatabaseServer Service { get; set; }
        #endregion

        #region constructors
        public RetrieveTests()
        {
            Service = VehicleDatabaseServer.Instance;
        }
        #endregion

        [TestMethod]
        public void GetVehicleTypesSuccessTest()
        {
            var results = Service.GetVehicleTypes();
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetVehicleManufacturersSuccessTest()
        {
            var results = Service.GetVehicleManufacturers();
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetVehicleManufacturerSuccessTest()
        {
            var manufacturers = Service.GetVehicleManufacturers();
            Assert.IsNotNull(manufacturers);
            Assert.IsTrue(manufacturers.Count > 0);

            // get a random manufacturer from the list.
            var r = new Random(DateTime.Now.Millisecond);
            var pos = r.Next(0, manufacturers.Count);
            var m = manufacturers[pos];
            Assert.IsNotNull(m);
            var id = m.Id;
            Assert.IsTrue(id > 0);

            // attempt to retrieve manufacturer for real now we have an id of one.
            var result = Service.GetVehicleManufacturer(id);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsValid());
        }

        [TestMethod]
        public void CreateVehicleTypeSuccessTest()
        {
            var vt = new VehicleType(ObjectMode.New);
            Assert.IsTrue(vt.IsValid());
        }
    }
}
