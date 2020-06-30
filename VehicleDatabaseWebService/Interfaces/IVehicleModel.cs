using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using VehicleDatabaseManager.Models;

namespace VehicleDatabaseManager.Interfaces
{
    public interface IVehicleModel : IVdBase
    {
        [DataMember]
        [Required]
        ApprovalStatus ApprovalStatus { get; set; }

        [DataMember]
        [Required]
        [Range(1, int.MaxValue)]
        int ManufacturerId { get; set; }

        [DataMember]
        [Required]
        string Name { get; set; }

        [DataMember]
        string VariantName { get; set; }

        [DataMember]
        int? EngineSizeCc { get; set; }

        [DataMember]
        int? YearIntroduced { get; set; }

        [DataMember]
        int? YearStopped { get; set; }

        [DataMember]
        string WikipediaId { get; set; }

        [DataMember]
        [Required]
        VehicleType Type { get; set; }
    }
}