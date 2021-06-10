using System;
using WeatherAcquisition.DAL.Entities.Base;

namespace WeatherAcquisition.DAL.Entities
{
    public class DataValue : Entity
    {
        public DateTimeOffset Time { get; set; } = DateTimeOffset.Now;

        public string Value { get; set; }
        public DataSource Sourse { get; set; }

        public bool IsFlault { get; set; }
    }
}
