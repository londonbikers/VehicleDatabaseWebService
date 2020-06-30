using System.Runtime.Serialization;
using VehicleDatabaseManager.Interfaces;

namespace VehicleDatabaseManager.Models
{
    /// <summary>
    /// The base class for all VDWS objects. 
    /// Inherit from this when creating new domain objects.
    /// </summary>
	[DataContract]
	public abstract class VdBase : IVdBase
	{
		#region accessors
		[DataMember]
		public int Id { get; set; }
		
        [DataMember]
		public bool IsPersisted { get; set; }
        
        public object Parent { get; set; }
		#endregion

		#region contructors
	    protected VdBase(ObjectMode mode)
	    {
			IsPersisted = (mode == ObjectMode.New) ? false : true;
		}
		#endregion

		#region public methods
		public bool IsValid()
		{
            #warning need to vix the validation!
		    return true;


		    //var results = new List<ValidationResult>();
		    //var context = new ValidationContext(Parent, null, null);
		    //var result = Validator.TryValidateObject(Parent, context, results);

		    //return result;


		    //Validator.TryValidateObject(Parent, context, results, true);
		    //#warning need to work out how to validate this!
		    //return results.Count == 0 || string.IsNullOrEmpty(results[0].ErrorMessage);


		}
		#endregion
	}
}