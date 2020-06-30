using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace VehicleDatabaseManager.Interfaces
{
    public interface IVehicleType : IVdBase
    {
        [DataMember]
        [Required]
        ApprovalStatus ApprovalStatus { get; set; }

        [DataMember]
        [Required]
        string Name { get; set; }
    }
}