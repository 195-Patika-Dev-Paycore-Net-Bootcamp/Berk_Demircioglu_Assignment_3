using Core.Entities;

namespace Entities.Concrete // Concrete is the folder in which objects themselves are restored.
{
    public class Vehicle : IEntity //The Vehicle class and its properties were stated.
    {
        public virtual long Id { get; set; }
        public virtual string VehicleName { get; set; }
        public virtual string VehiclePlate { get; set; }
    }
}
