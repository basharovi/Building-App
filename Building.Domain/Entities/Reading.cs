using System;

namespace Building.Domain.Entities
{
    public class Reading
    {
        public int BuildingId { get; set; }
        public int DataFieldId { get; set; }
        public int ObjectId { get; set; }
        public decimal Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
