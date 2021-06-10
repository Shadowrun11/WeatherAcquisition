using WeatherAcquisition.Interfaces.Base.Entities;

namespace WeatherAcquisition.DAL.Entities.Base
{
    public abstract class NameEntity : Entity, INamedEntity
    {
        public string Name { get; set; }
    }
}
