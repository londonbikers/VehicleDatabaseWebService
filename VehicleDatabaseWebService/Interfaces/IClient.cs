using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace VehicleDatabaseManager.Interfaces
{
    public interface IClient : IVdBase
    {
        [DataMember]
        [Required]
        string Name { get; set; }

        [DataMember]
        string CallbackUrl { get; set; }

        [DataMember]
        [Required]
        string Password { get; set; }
    }
}