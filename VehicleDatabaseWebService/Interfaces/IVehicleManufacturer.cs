using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using VehicleDatabaseManager.Models;

namespace VehicleDatabaseManager.Interfaces
{
    public interface IVehicleManufacturer : IVdBase
    {
        [DataMember]
        [Required]
        ApprovalStatus ApprovalStatus { get; set; }

        [DataMember]
        [Required]
        string Name { get; set; }

        [DataMember]
        string WikipediaId { get; set; }

        [DataMember]
        List<int> Models { get; set; }

        /// <summary>
        /// A list of VehicleTypes that this Make produces, i.e. whether or not they make cars, motorcycles, etc.
        /// </summary>
        [DataMember]
        [Required]
        List<VehicleType> Types { get; set; }
    }
}