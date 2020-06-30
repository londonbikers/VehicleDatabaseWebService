using System.Runtime.Serialization;
using VehicleDatabaseManager.Interfaces;

namespace VehicleDatabaseManager.Models
{
	[DataContract]
	public class VehicleModel : VdBase, IVehicleModel
	{
		#region accessors
        [DataMember]
        public ApprovalStatus ApprovalStatus { get; set; }

		[DataMember]
        public int ManufacturerId { get; set; }
		
        [DataMember]
		public string Name { get; set; }
		
        [DataMember]
		public string VariantName { get; set; }
		
        [DataMember]
		public int? EngineSizeCc { get; set; }
		
        [DataMember]
		public int? YearIntroduced { get; set; }
		
        [DataMember]
		public int? YearStopped { get; set; }

        [DataMember]
		public string WikipediaId { get; set; }
		
        [DataMember]
		public VehicleType Type { get; set; }
		#endregion

		#region constructors
		public VehicleModel(ObjectMode mode) : base(mode)
		{
		    Parent = this;
		}
		#endregion
	}
}