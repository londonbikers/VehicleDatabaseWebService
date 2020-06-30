using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace VehicleDatabaseManager.Interfaces
{
    public interface IVdBase
    {
        [DataMember]
        [Required]
        [Range(0, int.MaxValue)]
        int Id { get; set; }

        [DataMember]
        bool IsPersisted { get; set; }

        /// <summary>
        /// The object this base derives from.
        /// </summary>
        [Required]
        object Parent { get; set; }

        bool IsValid();
    }
}