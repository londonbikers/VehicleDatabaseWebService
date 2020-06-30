using System.Collections.Generic;
using System.Runtime.Serialization;
using VehicleDatabaseManager.Interfaces;

namespace VehicleDatabaseManager.Models
{
	[DataContract]
	public class VehicleManufacturer : VdBase, IVehicleManufacturer
	{
		#region accessors
        [DataMember]
        public ApprovalStatus ApprovalStatus { get; set; }

		[DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public string WikipediaId { get; set; }
	    
        [DataMember]
	    public List<int> Models { get; set; }
	    
        /// <summary>
	    /// A list of VehicleTypes that this Make produces, i.e. whether or not they make cars, motorcycles, etc.
	    /// </summary>
        [DataMember]
        public List<VehicleType> Types { get; set; }
		#endregion

		#region constructors
		public VehicleManufacturer(ObjectMode mode) : base(mode)
		{
            Parent = this;
		}
		#endregion
	}
}