using System.Runtime.Serialization;
using VehicleDatabaseManager.Interfaces;

namespace VehicleDatabaseManager.Models
{
	[DataContract]
	public class Client : VdBase, IClient
	{
		#region members
		[DataMember]
		public string Name { get; set; }
		
        [DataMember]
		public string CallbackUrl { get; set; }
		
        [DataMember]
		public string Password { get; set; }
		#endregion

		#region constructors
		public Client(ObjectMode mode) : base(mode)
		{
            Parent = this;
		}
		#endregion
	}
}