using System.Runtime.Serialization;
using VehicleDatabaseManager.Interfaces;

namespace VehicleDatabaseManager.Models
{
	[DataContract]
	public class VehicleType : VdBase, IVehicleType
	{
		#region accessors
        [DataMember]
        public ApprovalStatus ApprovalStatus { get; set; }

		[DataMember]
		public string Name { get; set; }
		#endregion

		#region constructors
		public VehicleType(ObjectMode mode) : base(mode)
		{
		    Parent = this;
		}
		#endregion
	}
}